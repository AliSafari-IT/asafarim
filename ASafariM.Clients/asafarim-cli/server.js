require('dotenv').config();
const express = require('express');
const http = require('http');
const socketIO = require('socket.io');
const pty = require('node-pty');
const path = require('path');
const os = require('os');

const app = express();
const server = http.createServer(app);
const io = socketIO(server);

// Serve static files
app.use(express.static(path.join(__dirname, 'public')));

// Route for the home page
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'public', 'index.html'));
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
