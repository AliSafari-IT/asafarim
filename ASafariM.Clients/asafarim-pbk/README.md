# Multi-User Portfolio Builder Kit (AsafarimPbk)

This document will explain the clean architecture, multi-user support, and how portfolios are isolated, persisted, and served:


## 📄 `architecture-overview.md`

```md
# Architecture Overview: ASafariM Portfolio Builder Kit (PBK)

## Purpose

The **ASafariM Portfolio Builder Kit (PBK)** is a modular, fullstack Angular + .NET 9 clean architecture solution designed to empower authenticated users to build and manage their own portfolio pages, such as:

- **/portfolios** – Browse all user portfolios
- **/portfolios/:userId** – View specific user's portfolio
- **/portfolio/:userId/edit** – Edit portfolio
- **/portfolio/:userId/create** – Create new portfolio
- **/portfolio/:userId/delete** – Remove a portfolio

## Goals

- ✅ Showcase **Angular skills** within a large-scale enterprise monorepo
- ✅ Demonstrate **multi-framework support** inside Clean Architecture
- ✅ Offer a **modular**, reusable, and open-source-ready PBK component
- ✅ Persist user-created content in **MySQL** via .NET 9 APIs
- ✅ Respect **role-based access control** (RBAC)
- ✅ Enable **theme reusability**, JWT auth, and clean API integration

## High-Level Architecture

```
ASafariM/
├── Domain/
│   └── Entities/
│       └── Portfolio.cs          ← Portfolio Entity (per user)
│
├── Application/
│   └── Portfolios/
│       └── Commands + Queries    ← CQRS Handlers
│
├── Infrastructure/
│   └── Services/
│       └── PortfolioService.cs   ← Business Logic
│   └── Repositories/
│       └── PortfolioRepository.cs
│
├── Presentation/
│   └── Controllers/
│       └── PortfolioController.cs ← Secured API endpoints
│
├── Clients/
│   └── asafarim-pbk/             ← Angular Portfolio Frontend
│
└── AppDbContext.cs               ← Registers DbSet<Portfolio>
```


## Entity Design: Portfolio

```csharp
public class Portfolio : BaseEntity
{
    public Guid UserId { get; set; }
    public string Headline { get; set; }
    public string Biography { get; set; }
    public string ExperienceMarkdown { get; set; }
    public string PublicationsMarkdown { get; set; }
    public string FundingMarkdown { get; set; }
    public bool IsPublic { get; set; }
}
```

- `UserId` links to the owner
- Markdown fields provide structured, flexible content
- Only Admins and Owners can edit or delete

## Angular Frontend: Routes

| Route                           | Purpose                                 | Permissions                    |
|--------------------------------|-----------------------------------------|--------------------------------|
| `/portfolios`                  | Show all public portfolios              | All authenticated users        |
| `/portfolios/:userId`          | View a specific portfolio               | All roles                      |
| `/portfolio/:userId/create`    | Create a new portfolio                  | Owner only                     |
| `/portfolio/:userId/edit`      | Edit existing portfolio                 | Owner, Admin, SuperAdmin       |
| `/portfolio/:userId/delete`    | Delete existing portfolio               | Owner, Admin, SuperAdmin       |

## Role-Based Access

| Action     | Admin/SuperAdmin | Owner | Guest |
|------------|------------------|-------|-------|
| View List  | ✅                | ✅    | ❌    |
| View       | ✅                | ✅    | ❌    |
| Create     | ✅                | ✅    | ❌    |
| Edit       | ✅                | ✅    | ❌    |
| Delete     | ✅                | ✅    | ❌    |

## JWT Integration

- Uses `nameid` claim to identify the current user
- Auth data decoded and injected via Angular `authService`
- All API requests are secured with Bearer token headers

## Angular App Setup (`asafarim-pbk`)

```bash
npx @angular/cli new asafarim-pbk --standalone --routing --style=scss
cd asafarim-pbk
```

Ensure you register it inside the Nx workspace:
```bash
nx g @nrwl/angular:app asafarim-pbk --directory=Clients --routing --style=scss
```

## REST API Integration

Base endpoints:
- `GET /api/portfolios`
- `GET /api/portfolios/{userId}`
- `POST /api/portfolios`
- `PUT /api/portfolios/{userId}`
- `DELETE /api/portfolios/{userId}`

## Logging, Testing & Monitoring

- 📊 Logging with **Serilog**
- ✅ API validation with **FluentValidation**
- 🔁 Angular forms + validators for UX
- 🧪 Future: Unit tests with **Jest** and integration via **Nx runners**

## Future Plans

- 🧱 Add shared component library for portfolio sections
- 🌍 Export portfolio to PDF or markdown
- 🧑‍🤝‍🧑 Enable collaboration mode
- 🔓 Open-source the PBK as a pluggable module

## Conclusion

The `asafarim-pbk` module represents a **scalable, secure, and framework-diverse solution** built with best practices in mind. It proves the extensibility of ASafariM's Clean Architecture and offers a foundation for user-centric features in a maintainable, multi-tenant app.