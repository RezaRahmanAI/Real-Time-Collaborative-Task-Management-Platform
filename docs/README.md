# Real-Time Collaborative Task Management Platform

Single-repo monorepo layout:

TaskManagementPlatform/
├── backend/
│ ├── src/
│ │ ├── API/
│ │ ├── Application/
│ │ ├── Domain/
│ │ └── Infrastructure/
│ └── tests/
├── frontend/
│ ├── src/
│ │ ├── app/
│ │ ├── assets/
│ │ └── environments/
├── docs/
├── scripts/
├── .gitignore
├── README.md
└── docker-compose.yml (optional)

markdown
Copy code

## Tech Stack
- **Backend**: ASP.NET Core Web API, SignalR, EF Core, SQL Server
- **Frontend**: Angular + Tailwind CSS
- **Auth**: JWT + Refresh Tokens, RBAC
- **Architecture**: Clean Architecture + Repository + Unit of Work

## Getting Started
- Step 1: Repo init & structure (this)
- Step 2: Backend bootstrap (.NET solution, projects, Clean Architecture)
- Step 3: Database schema & EF Core integration
- Step 4: Frontend bootstrap (Angular, Tailwind)
- Step 5: Auth (JWT + refresh) & RBAC
- Step 6: SignalR real-time features
- Step 7: Files, comments, notifications
- Step 8: Caching, pagination, perf
- Step 9: CI/CD (optional), Docker (optional)

> Proceed step-by-step. See conversation history for instructions.