# ASafariM - Full Stack Clean Architecture Solution
Update: 2025-02-07

## Introduction

This repository contains the source code for an enterprise-grade full-stack application built with .NET 9 and React TypeScript, following Clean Architecture principles.

[![GitHub Repository](https://img.shields.io/badge/GitHub-Repository-brightgreen.svg)](https://github.com/AliSafari-IT/ASafariM)

A modern, enterprise-grade full-stack application built with .NET 9 and React TypeScript, following Clean Architecture principles.

## Architecture

This solution follows Clean Architecture principles, with a clear separation of concerns:

- `ASafariM.Api`: REST API endpoints and API configuration
- `ASafariM.Application`: Application business logic and use cases
- `ASafariM.Domain`: Core business logic and entities
- `ASafariM.Infrastructure`: External concerns and implementations
- `ASafariM.Presentation`: API controllers and presentation logic
- `ASafariM.Clients/asafarim-ui`: React TypeScript frontend application
- `ASafariM.Test`: Unit and integration tests

## Technology Stack

### Backend (.NET 9)
- ASP.NET Core 9.0 Web API
- Entity Framework Core with MySQL
- AutoMapper for object mapping
- JWT Authentication
- Swagger/OpenAPI documentation
- Serilog for structured logging

### Frontend (React + TypeScript)
- Vite.js as build tool
- React with TypeScript
- Fluent UI components
- Yarn package manager
- Modern development tools:
  - ESLint
  - PostCSS
  - Vitest for testing

## Prerequisites

- .NET 9.0 SDK
- Node.js (LTS version)
- Yarn package manager
- MySQL Server

## Installation

1. Clone the repository:
```bash
git clone https://github.com/AliSafari-IT/ASafariM.git
cd ASafariM
```

2. Install backend dependencies:
```bash
dotnet restore
```

3. Install frontend dependencies:
```bash
cd ASafariM.Clients/asafarim-ui
yarn install
```

## Running the Application

### Backend
```bash
cd ASafariM.Api
dotnet run
```

### Frontend
```bash
cd ASafariM.Clients/asafarim-ui
yarn start
```

For development with hot reload:
```bash
yarn dev
```

## Testing

Run backend tests:
```bash
dotnet test
```

Run frontend tests:
```bash
cd ASafariM.Clients/asafarim-ui
yarn test
```

## Project Structure

```
ASafariM/
├── ASafariM.Api/            # REST API endpoints
├── ASafariM.Application/    # Application business logic
├── ASafariM.Domain/         # Core business logic
├── ASafariM.Infrastructure/ # External concerns
├── ASafariM.Presentation/   # API Controllers
├── ASafariM.Test/          # Test projects
└── ASafariM.Clients/       # Frontend applications
    └── asafarim-ui/        # React TypeScript client
```

## Security

- JWT-based authentication
- HTTPS enforcement
- Cross-Origin Resource Sharing (CORS) configuration
- Secure password hashing
- Input validation and sanitization

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the terms of the LICENSE.txt file included in the repository.

## Acknowledgments

- Clean Architecture principles by Robert C. Martin
- Microsoft's ASP.NET Core team
- React development team
- All contributors and maintainers

## Issues and Support

If you encounter any issues or need support, please [open an issue](https://github.com/AliSafari-IT/ASafariM/issues) on GitHub.

---
Built with ❤️ using Clean Architecture principles
