---
title: Building a Portfolio Builder Kit with Angular & .NET 9
description: Learn how I integrated Angular into my .NET 9 Clean Architecture app to create a standalone portfolio builder.
author: alisafari
tags: [Angular, .NET, Clean Architecture, Fullstack]
---

---
title: Architecture Overview for Multi-User Portfolios
description: Explore how ASafariM supports modular multi-user portfolio creation using Angular and .NET 9 in a Clean Architecture.
tags: [Angular, .NET, Portfolio, Clean Architecture, Multi-User, API, Open Source]
---

# Architecture Overview for Multi-User Portfolios

This document describes the architecture and design of a **multi-user portfolio builder** implemented using:

- **Backend**: ASP.NET Core 9 (Web API)
- **Frontend**: Angular (Portfolio Builder Kit aka `asafarim-pbk`)
- **Architecture**: Clean Architecture with Domain-Driven Design (DDD)

## Goals

- Allow authenticated users to create, edit, and publish personal portfolios.
- Ensure each portfolio is scoped to a specific user.
- Enable public browsing of portfolios with role-based restrictions.
- Showcase multi-framework interoperability in a Clean Architecture.
- Prepare the portfolio module for future open-source release.

## Domain Entity: `Portfolio`

```csharp
public class Portfolio : BaseEntity
{
    public Guid OwnerId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string AboutMarkdown { get; set; } = string.Empty;
    public string ExperienceMarkdown { get; set; } = string.Empty;
    public string PublicationsMarkdown { get; set; } = string.Empty;
    public string FundingMarkdown { get; set; } = string.Empty;
    public VisibilityEnum Visibility { get; set; } = VisibilityEnum.Public;

    public User Owner { get; set; } = null!;
}
```

## API Endpoints

| Method | Route                                | Description                          |
|--------|---------------------------------------|--------------------------------------|
| GET    | `/api/portfolios`                    | List all portfolios (non-guest only) |
| GET    | `/api/portfolios/user/{userId}`      | View a user's portfolio              |
| POST   | `/api/portfolios`                    | Create new portfolio (self)          |
| PUT    | `/api/portfolios/{userId}`           | Update portfolio (admin or owner)    |
| DELETE | `/api/portfolios/{userId}`           | Delete portfolio (admin or owner)    |

## Angular Frontend Routes

| Path                          | Component              | Access              |
|-------------------------------|------------------------|----------------------|
| `/portfolios`                | `PortfolioListComponent` | All except guests    |
| `/portfolios/:userId`        | `PortfolioViewComponent` | Public               |
| `/portfolio/:userId/create`  | `PortfolioCreateComponent` | Authenticated user  |
| `/portfolio/:userId/edit`    | `PortfolioEditComponent` | Admin / Owner only   |
| `/portfolio/:userId/delete`  | `PortfolioDeleteComponent` | Admin / Owner only  |

## Permissions Model

- **All Authenticated Users** (except `Guest`): can **view** the portfolio list.
- **Only Admin/SuperAdmin or Portfolio Owner**: can **edit or delete** a portfolio.
- JWT tokens are used to identify roles and enforce access via guards/interceptors in Angular.

## Angular App: `asafarim-pbk`

The Angular app is fully modular:

```bash
ASafariM.Clients/
├── asafarim-ui/        # React client
└── asafarim-pbk/       # Angular Portfolio Builder Kit
```

It uses Angular routing, `HttpClient`, and shared auth utilities to consume the .NET API.

## Markdown Content Support

Each section of a portfolio (Experience, Publications, Funding, etc.) is authored using **Markdown**, allowing rich formatting with simple syntax.

## Final Thoughts

This architecture is designed for scalability, maintainability, and openness. By isolating the portfolio feature as its own Angular app, the system ensures:

- Clean separation of concerns
- Easy deployment under a sub-route (`/portfolio`)
- Great demo of polyglot frontend strategy

Stay tuned as this module evolves into a standalone, open-source-ready Portfolio Builder Kit.



```