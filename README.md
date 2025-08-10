# Clean Architecture with .NET 9, EF Core 9 & Fluent API
This project demonstrates a Clean Architecture implementation using .NET 9, Entity Framework Core 9, and the Fluent API for database configuration.
It follows modern software engineering practices to ensure scalability, maintainability, and testability.

📂 Project Structure
The project is divided into four main layers as per the Clean Architecture principles:
**• Domain**
•	Contains Entities, Value Objects, and Domain Interfaces
•	Pure business logic with no external dependencies
**• Application**
•	Contains Use Cases / Services implementing application-specific logic
•	Uses Interfaces from the Domain layer
**• Infrastructure**
  •	Implements repository interfaces using EF Core 9
  •	Configures the database using Fluent API
  •	Handles persistence, migrations, and external services
**• Presentation (API/UI)**(Not implemented yet)
  •	ASP.NET Core 9 Web API for exposing endpoints
  •	Interacts with Application layer via Dependency Injection


**⚙️ Tech Stack**
•	.NET 9 (ASP.NET Core API)
•	Entity Framework Core 9
•	Fluent API (Model configuration & relationships)
•	SQL Server (Database)
•	Dependency Injection
•	Repository Pattern


**🚀 Features**
•	Clean separation of concerns with Clean Architecture.
•	Fully implemented CRUD operations.
•	Fluent API for entity configuration (relationships, keys, indexes).
•	Repository pattern with EF Core 9.
•	Unit tests for business logic.
•	Easy to extend and maintain.
