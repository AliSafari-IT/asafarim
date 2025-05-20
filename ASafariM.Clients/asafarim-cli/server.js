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
  transports: ['websocket', 'polling'],
  path: '/socket.io' // Ensure this is the default path
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
    
    // Check if user has Admin role based on JWT token
    const userRole = socket.request.user?.role;
    console.log('User role from JWT:', userRole);
    
    // Check if user has Admin or SuperAdmin role
    if (!(userRole === 'Admin' || userRole === 'SuperAdmin')) {
      console.error('Access denied - User roles:', socket.request.user);
      socket.emit('error', 'Access denied. SuperAdmin or Admin privileges required.');
      socket.disconnect(true);
      return;
    }

    // Skip account status check since JWT doesn't contain these properties
    // The main API has already verified the account is active by issuing a valid token

    // ------ DIRECT COMMAND EXECUTION APPROACH ------
    // Start with a basic shell process
    const shellProcess = spawn('/bin/bash', [], {
      cwd: process.env.HOME || process.cwd(),
      env: process.env,
      shell: false,
      stdio: 'pipe'
    });
    
    // Track active script processes for interactive input
    const activeScriptProcesses = new Map();
    
    // Track the current command being built
    let currentCommand = '';
    
    // Track command history for arrow up/down navigation
    let commandHistory = [];
    let historyPosition = -1;
    
    // Track the current working directory
    let currentWorkingDirectory = process.env.HOME || '/var/www';
    
    // Function to get a formatted prompt with the current directory
    const getPrompt = () => {
      // Get the last part of the path for a cleaner prompt
      const dirName = path.basename(currentWorkingDirectory);
      return `\r\n[${dirName}]$ `;
    };

    // Send initial prompt
    setTimeout(() => {
      socket.emit('terminal-output', '\r\nWelcome to ASafariM CLI' + getPrompt());
    }, 500);

    // Send shell output to terminal
    shellProcess.stdout.on('data', (data) => {
      const output = data.toString();
      socket.emit('terminal-output', output);
    });
    
    shellProcess.stderr.on('data', (data) => {
      const output = data.toString();
      socket.emit('terminal-output', output);
    });

    // Track if an interactive script is currently running
    let interactiveScriptRunning = false;
    let interactiveScriptProcess = null;

    // Receive user input from terminal and send to shell
    socket.on('input', (data) => {
      try {
        // If we have an interactive script running, send input directly to it
        if (interactiveScriptRunning && interactiveScriptProcess) {
          // For enter key, send the current command to the script
          if (data === '\r' || data === '\n' || data === '\r\n') {
            interactiveScriptProcess.stdin.write(currentCommand + '\n');
            currentCommand = '';
            return;
          } else {
            // For other keys, add to the current command
            currentCommand += data;
            return;
          }
        }
        
        // Don't echo input - the terminal already does this
        
        // Add to command buffer or execute based on input
        if (data === '\r' || data === '\n' || data === '\r\n') {
  if (currentCommand.trim()) {
    // Create an array with numbers 1-99
    const numberCommands = Array.from({length: 99}, (_, i) => (i + 1).toString());
    const allowedCommands = ['ls', 'echo', 'cd', 'whoami', 'where', 'asm', 'asafarim', 'pnpm', 'npm', 'yarn', 'bun', 'npx', ...numberCommands];
    const trimmedCmd = currentCommand.trim();
    const cmdName = trimmedCmd.split(/\s+/)[0];
    // Disallow shell metacharacters for extra safety
    const forbiddenPattern = /[;&|`$()<>]/;
    if (!allowedCommands.includes(cmdName) || forbiddenPattern.test(trimmedCmd)) {
      socket.emit('terminal-output', '\r\nError: Only basic commands like "ls", "cd", "echo", numbers 1-99, and package managers are allowed.' + getPrompt());
      currentCommand = '';
      return;
    }
    console.log(`Executing command: ${currentCommand}`);
    // Add to command history if not a duplicate of the last command
    if (commandHistory.length === 0 || commandHistory[commandHistory.length - 1] !== currentCommand) {
      commandHistory.push(currentCommand);
    }
    // Reset history position to the end
    historyPosition = commandHistory.length;
    // Handle cd command specially to track directory changes
    if (cmdName === 'cd') {
      try {
        // Extract the target directory
        const targetDir = trimmedCmd.substring(2).trim();
        
        // Handle special cases
        if (!targetDir || targetDir === '~') {
          currentWorkingDirectory = process.env.HOME || '/var/www';
        } else if (targetDir === '-') {
          // Not implementing cd - (previous directory) for simplicity
          socket.emit('terminal-output', '\r\ncd - not supported in this terminal\r\n');
        } else {
          // Resolve the path (handle relative paths)
          const newPath = path.resolve(currentWorkingDirectory, targetDir);
          
          // Check if directory exists
          try {
            // Use a synchronous spawn to check if directory exists
            const checkDirProcess = spawn('test', ['-d', newPath], {
              stdio: 'pipe',
              shell: true
            });
            
            // Wait for the process to complete
            const exitCode = require('child_process').spawnSync('test', ['-d', newPath], {
              stdio: 'pipe',
              shell: true
            }).status;
            
            if (exitCode === 0) {
              currentWorkingDirectory = newPath;
              socket.emit('terminal-output', `\r\nChanged directory to: ${newPath}` + getPrompt());
            } else {
              socket.emit('terminal-output', `\r\ncd: ${targetDir}: No such directory` + getPrompt());
            }
          } catch (error) {
            socket.emit('terminal-output', `\r\ncd: ${error.message}` + getPrompt());
          }
        }
        currentCommand = '';
        return;
      } catch (error) {
        socket.emit('terminal-output', `\r\ncd: ${error.message}` + getPrompt());
        currentCommand = '';
        return;
      }
    }
    
    // Check if this is a script that might need interactive input
    const isInteractiveScript = currentCommand.includes('./publish.sh') || currentCommand.includes('pnpm asm') || currentCommand.includes('npm run asm') || currentCommand.includes('pnpm run asm');
    
    // Execute commands in the current working directory, with pseudo-TTY for interactive scripts
    const cmdProcess = spawn('/bin/bash', ['-c', currentCommand], {
      cwd: currentWorkingDirectory,
      stdio: 'pipe',  // Always use pipe for better control
      env: { ...process.env, TERM: 'xterm-256color' }
    });
    
    // If this is an interactive script, set up for interactive mode
    if (isInteractiveScript) {
      interactiveScriptRunning = true;
      interactiveScriptProcess = cmdProcess;
      socket.emit('terminal-output', '\r\n[Interactive mode enabled for script]\r\n');
    }
    // Capture command output
    cmdProcess.stdout.on('data', (output) => {
      socket.emit('terminal-output', '\r\n' + output.toString());
    });
    cmdProcess.stderr.on('data', (output) => {
      socket.emit('terminal-output', '\r\n' + output.toString());
    });
    // Display new prompt when command completes
    cmdProcess.on('close', () => {
      // Reset interactive script state if needed
      if (interactiveScriptRunning && interactiveScriptProcess === cmdProcess) {
        interactiveScriptRunning = false;
        interactiveScriptProcess = null;
        socket.emit('terminal-output', '\r\n[Interactive mode disabled]');
      }
      socket.emit('terminal-output', getPrompt());
    });
    // Reset command buffer
    currentCommand = '';
  } else {
    // Just a new line, add a new prompt
    socket.emit('terminal-output', getPrompt());
  }
        } else {
          // Handle backspace (ASCII 8 or 127)
          if (data === '\b' || data.charCodeAt(0) === 127) {
            // Remove the last character from the command buffer if it's not empty
            if (currentCommand.length > 0) {
              currentCommand = currentCommand.slice(0, -1);
              // Send a backspace to the terminal to move cursor back
              socket.emit('terminal-output', '\b \b');
            }
          } else {
            // Add character to command buffer
            currentCommand += data;
          }
        }
      } catch (error) {
        console.error('Error processing command:', error);
        socket.emit('terminal-output', '\r\nError processing command\r\n$ ');
        currentCommand = '';
      }
    });

    // Handle special keys like arrow up/down for command history
    socket.on('special-key', (key) => {
      try {
        switch(key) {
          case 'arrow-up':
            // Navigate backward in history
            if (historyPosition > 0) {
              historyPosition--;
              const prevCommand = commandHistory[historyPosition];
              // Send the previous command to the client
              socket.emit('history-command', prevCommand);
              // Update current command
              currentCommand = prevCommand;
            }
            break;
            
          case 'arrow-down':
            // Navigate forward in history or clear if at the end
            if (historyPosition < commandHistory.length - 1) {
              historyPosition++;
              const nextCommand = commandHistory[historyPosition];
              // Send the next command to the client
              socket.emit('history-command', nextCommand);
              // Update current command
              currentCommand = nextCommand;
            } else if (historyPosition === commandHistory.length - 1) {
              // At the end of history, clear the command
              historyPosition = commandHistory.length;
              socket.emit('history-command', '');
              currentCommand = '';
            }
            break;
        }
      } catch (error) {
        console.error('Error handling special key:', error);
      }
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
const PORT = process.env.PORT || 3001;
const scr= process.env.JWT_SECRET;

server.listen(PORT, () => {
  console.log(`Server running on port ${PORT} → http://localhost:${PORT}/ \n with secret code (${scr})`);
});
