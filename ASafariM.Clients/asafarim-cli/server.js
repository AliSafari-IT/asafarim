require('dotenv').config();
const express = require('express');
const http = require('http');
const socketIO = require('socket.io');
const pty = require('node-pty');
const path = require('path');
const os = require('os');
const cookieParser = require('cookie-parser');
const jwt = require('jsonwebtoken');
const fetch = (...args) => import('node-fetch').then(({default: fetch}) => fetch(...args));

const app = express();
const server = http.createServer(app);
const io = socketIO(server);

// Middleware
app.use(cookieParser());
app.use(express.json());

// Serve static files
app.use(express.static(path.join(__dirname, 'public')));

// Authentication check endpoint
app.get('/api/auth/check', (req, res) => {
  try {
    const token = req.cookies.token;
    
    if (!token) {
      return res.json({
        isAuthenticated: false,
        isAdmin: false,
        userRoles: []
      });
    }

    // Verify JWT token
    const decoded = jwt.verify(token, process.env.JWT_SECRET);
    
    return res.json({
      isAuthenticated: true,
      isAdmin: decoded.isAdmin || false,
      userRoles: decoded.roles || []
    });
  } catch (error) {
    console.error('Auth check error:', error);
    return res.json({
      isAuthenticated: false,
      isAdmin: false,
      userRoles: []
    });
  }
});

// Route for the home page
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'public', 'index.html'));
});

// Socket authentication middleware
io.use(async (socket, next) => {
  try {
    const token = socket.handshake.auth.token;
    if (!token) {
      return next(new Error('Authentication required'));
    }

    // Verify token with asafarim.com API
    const response = await fetch('https://asafarim.com/api/roles', {
      headers: {
        'Authorization': `Bearer ${token}`
      }
    });

    if (!response.ok) {
      return next(new Error('Invalid token'));
    }

    const rolesData = await response.json();
    socket.user = { token, roles: rolesData };
    next();
  } catch (error) {
    console.error('Socket auth error:', error);
    next(new Error('Authentication failed'));
  }
});

// Socket.io connection
io.on('connection', (socket) => {
  console.log('A user connected');
  
  // Create a new terminal
  const shell = process.platform === 'win32' ? 'powershell.exe' : 'bash';
  const env = Object.assign({}, process.env);
  env.TERM = 'xterm-256color';
  
  // Force a prompt to appear by setting PS1
  env.PS1 = '\\[\\033[01;32m\\]\\u@\\h\\[\\033[00m\\]:\\[\\033[01;34m\\]\\w\\[\\033[00m\\]\\$ ';
  
  // Disable the problematic shell integration
  env.VSCODE_SHELL_INTEGRATION = '';
  
  // Additional environment variables to ensure prompt appears
  env.BASH_INTERACTIVE = '1';
  env.FORCE_PROMPT = '1';
  
  // Use specific bash arguments to ensure prompt appears
  const ptyProcess = pty.spawn('bash', ['--norc', '--noprofile', '-i'], {
    name: 'xterm-color',
    cols: 80,
    rows: 24,
    cwd: '/var/www/asafarim',  // Set default directory
    env: env
  });
  
  // Write a command to set the prompt explicitly
  setTimeout(() => {
    ptyProcess.write('export PS1="\\[\\033[01;32m\\]\\u@\\h\\[\\033[00m\\]:\\[\\033[01;34m\\]\\w\\[\\033[00m\\]\\$ "; clear\n');
  }, 500);
  
  // Handle data from the terminal
  ptyProcess.onData((data) => {
    socket.emit('terminal-output', data);
  });
  
  // Handle input from the client
  socket.on('terminal-input', (data) => {
    ptyProcess.write(data);
  });
  
  // Handle resize events
  socket.on('terminal-resize', (size) => {
    ptyProcess.resize(size.cols, size.rows);
  });
  
  // Clean up on disconnect
  socket.on('disconnect', () => {
    console.log('User disconnected');
    ptyProcess.kill();
  });
});

// Start the server
const PORT = process.env.PORT || 3008;
server.listen(PORT, () => {
  console.log(`Server running on port ${PORT} → http://localhost:${PORT}/`);
});
