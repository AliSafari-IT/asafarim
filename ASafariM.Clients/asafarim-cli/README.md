# ASafariM Node.js Terminal

A web-based terminal emulator built with Node.js, Express, Socket.IO and xterm.js.

![Terminal Screenshot](screenshot.png)

## Features

- Real-time terminal emulation in browser
- Custom color scheme and prompt styling
- Responsive design that adapts to window size
- Support for common terminal commands
- Cross-platform (Windows/Linux/macOS)

## Installation

1. Clone the repository
2. Install dependencies:

```bash
pnpm install
```

3. Start the server:

```bash
pnpm start
```

4. Open browser to <http://localhost:3008>

## Project Structure

```
node-terminal/
├── public/            # Static files
│   └── index.html     # Terminal web interface
├── server.js          # Node.js server
├── package.json       # Project configuration
└── README.md          # This file
```

## Dependencies

### Runtime

- express: Web server framework
- socket.io: Real-time communication
- node-pty: Pseudo-terminal functionality

### Development

- dotenv: Environment variables

### Client-side

- xterm.js: Terminal emulator in browser

## Configuration

The server can be configured via environment variables:

- `PORT`: Server port (default: 3008)
- `DEFAULT_CWD`: Default working directory (default: /var/www/asafarim)

## Usage

1. Open the terminal in your browser
2. Type commands as you would in a normal terminal
3. The terminal supports:
   - Basic shell commands
   - Command history (up/down arrows)
   - Tab completion
   - Resizing

## Troubleshooting

If the prompt doesn't appear:

1. Wait a few seconds - it may take a moment to initialize
2. Press Enter to trigger a new prompt
3. Check browser console for errors

## Deployment to asafarim.com/terminal

### Prerequisites

- Node.js installed on server
- PM2 for process management
- Nginx as reverse proxy
- Domain configured (asafarim.com)

### Steps

1. Build for production:

```bash
pnpm install --production
```

2. Start the application using PM2:

```bash
pm2 start server.js --name "asafarim-terminal"
```

3. Configure Nginx reverse proxy:

```nginx
server {
    listen 80;
    server_name asafarim.com;

    location /terminal {
        proxy_pass http://localhost:3008;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection 'upgrade';
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
    }
}
```

4. Set up SSL with Let's Encrypt:

```bash
sudo certbot --nginx -d asafarim.com
```

5. Enable the Nginx config:

```bash
sudo systemctl restart nginx
```

## License

[MIT](LICENSE)
