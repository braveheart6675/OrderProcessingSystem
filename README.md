# Order Processing System 🚀

![.NET](https://img.shields.io/badge/.NET-6.0-purple)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-6.0-blue)
![CQRS](https://img.shields.io/badge/Architecture-CQRS-orange)
![EF Core](https://img.shields.io/badge/Entity_Framework-6.0-green)
![xUnit](https://img.shields.io/badge/Testing-xUnit-success)
![MediatR](https://img.shields.io/badge/Pattern-Mediator-yellow)
![Docker](https://img.shields.io/badge/Container-Docker-blue)

A sophisticated Order Processing System built with **ASP.NET Core**, implementing **CQRS Pattern** with MediatR, Entity Framework Core, comprehensive testing strategies, and Docker containerization.

## 📋 Table of Contents
- [✨ Features](#-features)
- [🏗️ Architecture](#️-architecture)
- [🚀 Getting Started](#-getting-started)
- [🐳 Docker Deployment](#-docker-deployment)
- [📡 API Endpoints](#-api-endpoints)
- [🧪 Testing](#-testing)
- [🔧 Project Structure](#-project-structure)
- [🛠️ Development](#️-development)
- [🤝 Contributing](#-contributing)

## ✨ Features

- **🎯 CQRS Pattern** - Command and Query Responsibility Segregation with MediatR
- **✅ Comprehensive Testing** - Unit tests and integration tests with xUnit
- **🛡️ Validation Pipeline** - FluentValidation with MediatR behavior
- **🗄️ Entity Framework Core** - Data access with repositories
- **🐳 Docker Containerization** - Full container support with Docker Compose
- **📡 RESTful API** - Clean API endpoints
- **🎯 Clean Architecture** - Separation of concerns
- **🔒 Error Handling** - Global exception handling
- **📚 Swagger Documentation** - API documentation

## 🏗️ Architecture

### Design Patterns
- **CQRS** - Separate command and query models
- **Mediator** - MediatR for in-process messaging
- **Repository** - Data access abstraction
- **Pipeline Behavior** - Validation and logging

### Tech Stack
- **.NET 6.0** - Runtime
- **ASP.NET Core** - Web framework
- **Entity Framework Core** - ORM
- **MediatR** - Mediator pattern implementation
- **FluentValidation** - Validation library
- **xUnit** - Testing framework
- **SQL Server** - Database
- **Docker** - Containerization

## 🚀 Getting Started

### Prerequisites
- .NET 6.0 SDK OR Docker
- SQL Server (for local development)

### Installation

#### Option 1: Local Development
```bash
# Clone repository
git clone https://github.com/braveheart6675/OrderProcessingSystem.git
cd OrderProcessingSystem

# Database setup
dotnet ef database update

# Run application
dotnet run

Option 2: Docker (Recommended)
bash
# Run with Docker Compose
docker-compose up -d
Access Points
API: http://localhost:8080

Swagger UI: http://localhost:8080/swagger

🐳 Docker Deployment
Quick Start
bash
docker-compose up -d

Docker Services
order-api: ASP.NET Core application (port 8080)

db: SQL Server database (port 1433)

Environment Variables
ConnectionStrings__DefaultConnection - Database connection string

ASPNETCORE_ENVIRONMENT - Runtime environment

📡 API Endpoints
Commands (Write Operations)
Method	Endpoint	Description
POST	/api/orders	Create new order
PUT	/api/orders/{id}	Update order
DELETE	/api/orders/{id}	Delete order

Queries (Read Operations)
Method	Endpoint	Description
GET	/api/orders	Get all orders
GET	/api/orders/{id}	Get order by ID
GET	/api/orders/search	Search orders with filters
Example Request
json
{
  "customerId": "123e4567-e89b-12d3-a456-426614174000",
  "orderItems": [
    {
      "productId": "123e4567-e89b-12d3-a456-426614174001",
      "quantity": 2,
      "unitPrice": 29.99
    }
  ],
  "shippingAddress": "123 Main St, City, Country"
}
🧪 Testing
Run Tests
bash
# Unit tests
dotnet test --filter Category=Unit

# Integration tests  
dotnet test --filter Category=Integration

# All tests
dotnet test
Test Coverage
Unit Tests: Command handlers, query handlers, validators

Integration Tests: Database operations, API endpoints

🔧 Project Structure
OrderProcessingSystem/
├── Application/          # Application Layer
│   ├── Commands/        # Command handlers
│   ├── Queries/         # Query handlers
│   └── Behaviors/       # Pipeline behaviors
├── Domain/              # Domain Layer
│   ├── Entities/        # Domain entities
│   └── ValueObjects/    # Value objects
├── Infrastructure/      # Infrastructure Layer
│   ├── Data/            # DbContext
│   └── Repositories/    # Repository implementations
├── API/                 # Presentation Layer
│   └── Controllers/     # API controllers
├── Tests/               # Test projects
│   ├── UnitTests/       # Unit tests
│   └── IntegrationTests/# Integration tests
└── Dockerfile           # Docker configuration

🛠️ Development
Build and Run
bash
dotnet build
dotnet run
Database Management
bash
# Create migration
dotnet ef migrations add FeatureName

# Update database
dotnet ef database update

🤝 Contributing
Fork the repository

Create feature branch (git checkout -b feature/amazing-feature)

Commit changes (git commit -m 'Add amazing feature')

Push to branch (git push origin feature/amazing-feature)

Open a Pull Request

📄 License
This project is licensed under the MIT License - see the LICENSE file for details.

⭐ Star this repo if you find it helpful!

Built with ❤️ using ASP.NET Core, CQRS, and Clean Architecture
