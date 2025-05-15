require('dotenv').config();
const express = require('express');
const http = require('http');
const socketIO = require('socket.io');
process.env.TERM = 'xterm-256color';  // Set terminal type
const jwt = require('jsonwebtoken');
const { spawn } = require('child_process');
const os = require('os');
const path = require('path');
const cookieParser = require('cookie-parser');
const fetch = (...args) => import('node-fetch').then(({default: fetch}) => fetch(...args));

const app = express();
const server = http.createServer(app);
const io = socketIO(server, {
  cors: {
    origin: ['https://asafarim.com', 'http://localhost:3001'],
    methods: ['GET', 'POST'],
    credentials: true
  },
  allowEIO3: true,
  transports: ['websocket', 'polling']
});

// Middleware
app.use((req, res, next) => {
  res.header('Access-Control-Allow-Origin', req.headers.origin || 'https://asafarim.com');
  res.header('Access-Control-Allow-Credentials', 'true');
  res.header('Access-Control-Allow-Headers', 'Origin, X-Requested-With, Content-Type, Accept, Authorization');
  res.header('Access-Control-Allow-Methods', 'GET, POST, OPTIONS');
  if (req.method === 'OPTIONS') {
    return res.status(200).end();
  }
  next();
});

app.use(express.json());
app.use(express.urlencoded({ extended: true }));
app.use(cookieParser());

// Authentication middleware
const authenticateUser = (req, res, next) => {
  try {
    // Get token from Authorization header or cookie
    const authHeader = req.headers.authorization;
    const token = authHeader ? authHeader.split(' ')[1] : req.cookies.token;

    if (!token) {
      return res.status(401).json({ message: 'No token provided' });
    }

    // Verify token
    const decoded = jwt.verify(token, process.env.JWT_SECRET);
    req.user = decoded;
    next();
  } catch (error) {
    console.error('Auth error:', error);
    return res.status(401).json({ message: 'Invalid token' });
  }
};

// Serve static files
app.use(express.static(path.join(__dirname, 'public')));

// Protect all routes except auth and health endpoints
app.use((req, res, next) => {
  if (req.path.startsWith('/api/auth/') || req.path === '/health') {
    return next();
  }
  authenticateUser(req, res, next);
});


// Authentication check endpoint
app.get('/api/auth/check', async (req, res) => {
  try {
    const token = req.cookies.token;
    
    if (!token) {
      return res.json({
        isAuthenticated: false,
        isAdmin: false,
        userRoles: [],
        user: null
      });
    }

    // Verify JWT token
    const decoded = jwt.verify(token, process.env.JWT_SECRET);
    
    // Get user details from main API
    try {
      // Parse the token to get the claims
      const tokenParts = token.split('.');
      const payload = JSON.parse(Buffer.from(tokenParts[1], 'base64').toString());
      
      const response = await fetch('https://asafarim.com/api/auth/current-user', {
        headers: {
          'Authorization': `Bearer ${token}`,
          'Content-Type': 'application/json'
        }
      });

      if (response.ok) {
        const userData = await response.json();
        return res.json({
          isAuthenticated: true,
          isAdmin: userData.isAdmin || false,
          userRoles: decoded.roles || [],
          user: userData
        });
      }
    } catch (apiError) {
      console.error('API error:', apiError);
    }
    
    // Fallback to token data if API call fails
    return res.json({
      isAuthenticated: true,
      isAdmin: decoded.isAdmin || false,
      userRoles: decoded.roles || [],
      user: {
        id: decoded.nameid || decoded.sub,
        userName: decoded.unique_name,
        email: decoded.email
      }
    });
  } catch (error) {
    console.error('Auth check error:', error);
    return res.json({
      isAuthenticated: false,
      isAdmin: false,
      userRoles: [],
      user: null
    });
  }
});

// Login endpoint
app.post('/api/auth/login', async (req, res) => {
  try {
    const { email, password } = req.body;
    
    // Forward login request to main API
    const response = await fetch('https://asafarim.com/api/auth/login', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json'
      },
      credentials: 'include',
      body: JSON.stringify({ email, password })
    });

    const data = await response.json();
    
    if (response.ok) {
      // Set JWT token as cookie
      res.cookie('token', data.token, {
        httpOnly: true,
        secure: process.env.NODE_ENV === 'production',
        sameSite: 'strict',
        maxAge: 24 * 60 * 60 * 1000 // 24 hours
      });

      return res.json({
        success: true,
        user: data.authenticatedUser
      });
    }

    return res.status(response.status).json(data);
  } catch (error) {
    console.error('Login error:', error);
    return res.status(500).json({
      message: 'An error occurred during login'
    });
  }
});

// Logout endpoint
app.post('/api/auth/logout', (req, res) => {
  res.clearCookie('token');
  return res.json({ success: true });
});

// Health check endpoint
app.get('/health', (req, res) => {
  res.json({ 
    status: 'ok',
    authenticated: true,
    message: 'CLI service is running'
  });
});

// Route for the home page
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'public', 'index.html'));
});

// Set up Socket.IO with authentication
// Debug logging for all socket events
io.engine.on('connection_error', (err) => {
  console.error('Transport connection error:', err);
});

io.engine.on('close', (reason) => {
  console.log('Transport closed:', reason);
});

io.on('connect_error', (error) => {
  console.error('Socket connection error:', error);
  console.error('Error details:', error.data);
});

io.use(async (socket, next) => {
  try {
    const token = socket.handshake.auth.token || socket.handshake.headers.authorization?.split(' ')[1];
    if (!token) {
      console.error('No token provided');
      return next(new Error('Authentication required'));
    }

    // First try to verify the token locally
    try {
      const decoded = jwt.verify(token, process.env.JWT_SECRET);
      if (!decoded) {
        console.error('Invalid token');
        return next(new Error('Invalid token'));
      }
    } catch (jwtError) {
      console.error('JWT verification failed:', jwtError);
      return next(new Error('Invalid token'));
    }

    // Verify token locally first
    try {
      const decoded = jwt.verify(token, process.env.JWT_SECRET);
      if (!decoded) {
        console.error('Invalid token');
        return next(new Error('Invalid token'));
      }

      // Get user info from ASafariM API
      const response = await fetch('https://asafarim.com/api/auth/validate-token', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}`
        },
        body: JSON.stringify({ token })
      });

      if (!response.ok) {
        console.error('API verification failed:', response.status);
        // Use local token verification as fallback
        socket.request.user = decoded;
        return next();
      }

      const user = await response.json();
      socket.request.user = user;
      return next();
    } catch (apiError) {
      console.error('API request error:', apiError);
      // On API error, just use local JWT verification
      const decoded = jwt.verify(token, process.env.JWT_SECRET);
      if (decoded) {
        socket.request.user = decoded;
        return next();
      }
      return next(new Error('Authentication failed'));
    }
  } catch (error) {
    console.error('Socket auth error:', error);
    next(new Error('Invalid token'));
  }
});

// Socket.io connection handling
io.on('connection', (socket) => {
  try {
    console.log('A user connected');
    console.log('Auth token:', socket.handshake.auth.token);

    // Permission checks (as you already have)
    if (!socket.request.user?.isAdmin || !socket.request.user?.isSuperAdmin) {
      console.error('Access denied - User roles:', socket.request.user);
      socket.emit('error', 'Access denied. SuperAdmin and Admin privileges required.');
      socket.disconnect(true);
      return;
    }

    if (socket.request.user.isBlocked || socket.request.user.isDeleted || !socket.request.user.isActive) {
      console.error('Account not active - User status:', socket.request.user);
      socket.emit('error', 'Account is not active');
      socket.disconnect(true);
      return;
    }

    // ------ FIXED SHELL SPAWN LOGIC ------
    const defaultShell = os.platform() === 'win32' ? 'cmd.exe' : 'bash';
    const shellProcess = spawn(defaultShell, [], {
      cwd: process.env.HOME || process.cwd(),
      env: process.env,
      shell: true,
      stdio: 'pipe'
    });

    // Send shell output to terminal
    shellProcess.stdout.on('data', (data) => {
      socket.emit('terminal-output', data.toString());
    });
    shellProcess.stderr.on('data', (data) => {
      socket.emit('terminal-output', data.toString());
    });

    // Receive user input from terminal and send to shell
    socket.on('input', (data) => {
      shellProcess.stdin.write(data);
    });

    // Handle terminal resize if implemented
    socket.on('terminal-resize', (dimensions) => {
      // No need to resize if not using a pseudo-terminal package
    });

    // Clean up on disconnect
    socket.on('disconnect', () => {
      shellProcess.kill();
    });

    shellProcess.on('close', (code) => {
      socket.emit('terminal-output', `\r\nShell exited with code ${code}\r\n`);
      socket.disconnect(true);
    });

    socket.emit('terminal-ready');
  } catch (error) {
    console.error('Socket connection error:', error);
    socket.disconnect(true);
  }
});

// Start the server
const PORT = process.env.PORT || 3002;
const scr= process.env.JWT_SECRET;

server.listen(PORT, () => {
  console.log(`Server running on port ${PORT} → http://localhost:${PORT}/ \n with secret code (${scr})`);
});
