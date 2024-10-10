# ASafariM Fullstack Application

## Overview

ASafariM is a full-stack web application built using:

- **Frontend**: React with TypeScript and Tailwind CSS
- **Backend**: ASP.NET Core 8.0 with Clean Architecture
- **Database**: MySQL

This project follows a clean architecture pattern, keeping the business logic, data access, and web API layers separate.

The project is hosted on GitHub: [ASafariM Repository](https://github.com/AliSafari-IT/ASafariM)

## Prerequisites

Before running the application, make sure you have the following installed:

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/en/) (v16+)
- [Yarn](https://classic.yarnpkg.com/en/docs/install/)
- [MySQL](https://dev.mysql.com/downloads/mysql/)

## Folder Structure

```plaintext
E:\VS\ASafariM\
│
├── ASafariM.Server/                       # Backend (ASP.NET Core)
│   ├── src/
│   │   ├── ApplicationBusinessLogic/      # Business logic & use cases
│   │   │   ├── Abstractions/
│   │   │   │   └── IPanelRepository.cs    # Panel repository interface
│   │   ├── CoreDomainEntities/            # Domain Entities
│   │   │   └── Panels/
│   │   │       └── Panel.cs               # Panel entity class
│   │   ├── InfrastructureDataAccessLayer/ # Data access
│   │   │   ├── Persistence/
│   │   │   │   └── AppDbContext.cs        # EF Core DbContext
│   │   │   └── Repositories/
│   │   │       └── PanelRepository.cs     # Panel repository implementation
│   │   ├── WebApiService/                 # API controllers
│   │   │   └── Controllers/
│   │   │       └── PanelsController.cs    # Panels API controller
│   └── Program.cs                         # Main entry point for ASP.NET Core
│
├── asafarim.client/                       # Frontend (React + TypeScript)
│   ├── src/
│   │   ├── components/
│   │   ├── pages/
│   ├── App.tsx
│   └── index.tsx
├── .vscode/
│   ├── launch.json                        # Configuration to run backend and frontend
│   ├── tasks.json                         # Task definitions for building and running backend/frontend
└── README.md                              # Project documentation (this file)
```

## Setting up the Project

### 1. Clone the Repository

```bash
git clone https://github.com/AliSafari-IT/ASafariM
cd E:\VS\ASafariM
```

### 2. Install Frontend Dependencies

Navigate to the `asafarim.client` directory and install dependencies using Yarn:

```bash
cd asafarim.client
yarn install
```

### 3. Set up the Backend

Ensure the .NET SDK is installed and set up.

Configure your MySQL database connection in `appsettings.json` (located in `ASafariM.Server`) like this:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=asafarimDb;User=your-username;Password=your-password;"
  }
}
```

Run database migrations:

```bash
cd ASafariM.Server
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Build and Run the Backend

In the root folder (`E:\VS\ASafariM`), build the backend using:

```bash
dotnet build ASafariM.Server
```

To run the backend API:

```bash
dotnet run --project ASafariM.Server
```

### 5. Running the Frontend

To start the React frontend, run the following command from the `asafarim.client` directory:

```bash
yarn start
```

The frontend will run on `https://localhost:5173`.

### 6. Running Both Backend and Frontend Together

VS Code is configured to launch both the backend (ASP.NET Core) and frontend (React) simultaneously. Use the compound task in the `launch.json`:

1. Open the VS Code **Run and Debug** menu.
2. Select **Launch Backend and Frontend**.
3. This will start both the backend and frontend in one go.

## Key Backend Files and Components

### 1. **Panel Entity**

Location: `E:\VS\ASafariM\ASafariM.Server\src\CoreDomainEntities\Panels\Panel.cs`

The `Panel` class defines the structure for a panel in the application.

```csharp
namespace ASafariM.Server.CoreDomainEntities.Panels
{
    public class Panel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
```

### 2. **IPanelRepository Interface**

Location: `E:\VS\ASafariM\ASafariM.Server\src\ApplicationBusinessLogic\Abstractions\IPanelRepository.cs`

This interface defines the contract for the `PanelRepository` that handles data access for `Panel` entities.

```csharp
namespace ASafariM.Server.ApplicationBusinessLogic.Abstractions
{
    public interface IPanelRepository
    {
        Task<IEnumerable<Panel>> GetPanelsAsync();
        Task<Panel> GetPanelByIdAsync(int id);
        Task AddPanelAsync(Panel panel);
        Task UpdatePanelAsync(Panel panel);
        Task DeletePanelAsync(Panel panel);
    }
}
```

### 3. **AppDbContext**

Location: `E:\VS\ASafariM\ASafariM.Server\src\InfrastructureDataAccessLayer\Persistence\AppDbContext.cs`

The `AppDbContext` class is responsible for managing the database context and mapping the `Panel` entity to the database using Entity Framework Core.

```csharp
using Microsoft.EntityFrameworkCore;
using ASafariM.Server.CoreDomainEntities.Panels;

namespace ASafariM.Server.InfrastructureDataAccessLayer.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Panel> Panels { get; set; }
    }
}
```

### 4. **PanelRepository Implementation**

Location: `E:\VS\ASafariM\ASafariM.Server\src\InfrastructureDataAccessLayer\Repositories\PanelRepository.cs`

The `PanelRepository` class implements the `IPanelRepository` interface and provides concrete methods for interacting with the database.

```csharp
using ASafariM.Server.ApplicationBusinessLogic.Abstractions;
using ASafariM.Server.CoreDomainEntities.Panels;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Server.InfrastructureDataAccessLayer.Repositories
{
    public class PanelRepository : IPanelRepository
    {
        private readonly AppDbContext _context;

        public PanelRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Panel>> GetPanelsAsync()
        {
            return await _context.Panels.ToListAsync();
        }

        public async Task<Panel> GetPanelByIdAsync(int id)
        {
            return await _context.Panels.FindAsync(id);
        }

        public async Task AddPanelAsync(Panel panel)
        {
            await _context.Panels.AddAsync(panel);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePanelAsync(Panel panel)
        {
            _context.Panels.Update(panel);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePanelAsync(Panel panel)
        {
            _context.Panels.Remove(panel);
            await _context.SaveChangesAsync();
        }
    }
}
```

### 5. **PanelsController API**

Location: `E:\VS\ASafariM\ASafariM.Server\src\WebApiService\Controllers\PanelsController.cs`

The `PanelsController` provides the API endpoints to manage `Panel` entities, including adding, updating, retrieving, and deleting panels.

```csharp
using ASafariM.Server.ApplicationBusinessLogic.Abstractions;
using ASafariM.Server.CoreDomainEntities.Panels;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Server.WebApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PanelsController : ControllerBase
    {
        private readonly IPanelRepository _panelRepository;

        public PanelsController(IPanelRepository panelRepository)
        {
            _panelRepository = panelRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Panel>>> GetPanels()
        {
            var panels = await _panelRepository.GetPanelsAsync();
            return Ok(panels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Panel>> GetPanelById(int id)
        {
            var panel = await _panelRepository.GetPanelByIdAsync(id);
            if (panel ==

 null)
            {
                return NotFound();
            }

            return Ok(panel);
        }

        [HttpPost]
        public async Task<ActionResult> AddPanel(Panel panel)
        {
            await _panelRepository.AddPanelAsync(panel);
            return CreatedAtAction(nameof(GetPanelById), new { id = panel.Id }, panel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePanel(int id, Panel panel)
        {
            if (id != panel.Id)
            {
                return BadRequest();
            }

            await _panelRepository.UpdatePanelAsync(panel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePanel(int id)
        {
            var panel = await _panelRepository.GetPanelByIdAsync(id);
            if (panel == null)
            {
                return NotFound();
            }

            await _panelRepository.DeletePanelAsync(panel);

            return NoContent();
        }
    }
}
```

## Additional Notes

- **CORS Configuration**: Ensure that the backend is configured to allow CORS for the frontend running at `https://localhost:5173` in `Program.cs`.
  
```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.WithOrigins("https://localhost:5173")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
```

- **API Endpoints**: The API exposes the following endpoints:
  - **GET** `/api/panels`: Retrieves all panels.
  - **POST** `/api/panels`: Adds a new panel.
  - **PUT** `/api/panels/{id}`: Updates an existing panel.
  - **DELETE** `/api/panels/{id}`: Deletes a panel by ID.

---

This `README.md` provides instructions on setting up the project, running both the frontend and backend, and details key files like the `Panel` entity, `IPanelRepository`, `AppDbContext`, `PanelRepository`, and `PanelsController`.
