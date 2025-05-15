# ASafariM Node.js Terminal

A web-based terminal emulator built with Node.js, Express, Socket.IO and xterm.js, with secure authentication and role-based access control.

![Terminal Screenshot](screenshot.png)

## Features

- Real-time terminal emulation in browser
- Secure authentication with JWT tokens
- Role-based access control (Admin + SuperAdmin required)
- Custom color scheme and prompt styling
- Responsive design that adapts to window size
- Support for common terminal commands

## Installation

1. Clone the repository
2. Install dependencies:

```bash
pnpm install
```

3. Configure environment variables in `.env`:
```bash
PORT=3001
JWT_SECRET=your_jwt_secret
API_URL=https://asafarim.com/api
```

4. Start the server:

```bash
pnpm start
```

5. Open browser to <http://localhost:3001>

## Project Structure

```
asafarim-cli/
├── public/            # Static files
│   └── index.html     # Terminal web interface
├── server.js          # Node.js server
├── package.json       # Project configuration
├── .env              # Environment variables
└── README.md         # Documentation
```

## Dependencies

### Runtime

- express: Web server framework
- socket.io: Real-time communication
- jsonwebtoken: JWT authentication
- cookie-parser: Cookie handling
- node-fetch: HTTP client
- xterm-headless: Terminal emulation

### Development

- dotenv: Environment variables
- nan: Native abstractions

### Client-side

- xterm.js: Terminal emulator in browser
- socket.io-client: Real-time communication

## Scripts

- `pnpm start`: Start the server
- `pnpm restart`: Reinstall dependencies and restart
- `pnpm clean`: Remove dependencies
- `pnpm reinstall`: Clean install of dependencies
- `pnpm build:prod`: Production build
- `pnpm build:dev`: Development build

## Configuration

The server can be configured via environment variables:

- `PORT`: Server port (default: 3001)
- `JWT_SECRET`: Secret for JWT token verification
- `API_URL`: URL of the main API server

## Usage

1. Log in at https://asafarim.com
2. Ensure you have Admin and SuperAdmin privileges
3. Navigate to https://asafarim.com/cli
4. The terminal supports:
   - Basic shell commands
   - Command history (up/down arrows)
   - Tab completion
   - Window resizing

## Security

- JWT token authentication required
- Admin and SuperAdmin roles required
- Session validation against main API
- Secure WebSocket connections

## Troubleshooting

If you can't access the terminal:

1. Ensure you're logged in at asafarim.com
2. Verify you have Admin and SuperAdmin privileges
3. Check browser console for authentication errors
4. Try the "Try Again" button to re-authenticate

## Deployment

### Prerequisites

- Node.js 18+ installed
- PM2 for process management
- Nginx as reverse proxy
- Domain configured (asafarim.com)

### Steps

1. Build for production:

```bash
pnpm build:prod
```

2. Start with PM2:

```bash
pm2 start server.js --name "asafarim-cli"
```

3. Configure Nginx:

```nginx
server {
    listen 443 ssl;
    server_name asafarim.com;

    ssl_certificate /etc/letsencrypt/live/asafarim.com/fullchain.pem;
    ssl_certificate_key /etc/letsencrypt/live/asafarim.com/privkey.pem;

    location /cli {
        proxy_pass http://localhost:3001;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection 'upgrade';
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
    }
}
```

4. Restart Nginx:

```bash
sudo systemctl restart nginx
```

## License

[MIT](LICENSE)
