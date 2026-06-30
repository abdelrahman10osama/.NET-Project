# 🚀 ITI Company Management System

A professional ASP.NET Core MVC application for managing instructors, courses, departments, and trainees. The project demonstrates the implementation of MVC architecture, Entity Framework Core, Repository Pattern, Authentication, Authorization, and SQL Server.

---

## 📌 Features

- 🔐 User Authentication (Login / Register)
- 🍪 Cookie Authentication
- 👤 Role-Based Authorization (Admin / User)
- 👨‍🏫 Instructor Management (CRUD)
- 📚 Course Management (CRUD)
- 🏢 Department Management
- 🎓 Trainee Management
- ✅ Server-Side Validation
- 🗄️ Entity Framework Core
- 📂 Repository Pattern
- 🎨 Responsive UI using Bootstrap 5

---

## 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 8)
- C#
- Entity Framework Core
- SQL Server
- LINQ
- Bootstrap 5
- HTML5
- CSS3
- JavaScript

---

## 📂 Project Structure

```
WebApplication2
│
├── Controllers
├── Models
├── DTO
├── Repository
├── Views
├── wwwroot
├── Migrations
├── appsettings.json
└── Program.cs
```

---

## 🔑 Authentication

The application uses **Cookie Authentication**.

Users can:

- Register
- Login
- Logout

Protected pages require authentication using:

```csharp
[Authorize]
```

Role-based authorization is also supported:

```csharp
[Authorize(Roles = "Admin")]
```

---

## 🗄️ Database

Entity Framework Core is used with SQL Server.

Run the following commands to create the database:

```bash
Update-Database
```

or

```bash
dotnet ef database update
```

---

## ⚙️ Configuration

Update the connection string inside:

```json
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "cs": "Server=.;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

## ▶️ Running the Project

1. Clone the repository

```bash
git clone https://github.com/Abdelrahman10osama/.NET-project.git
```

2. Open the solution using Visual Studio.

3. Restore NuGet packages.

4. Update the connection string.

5. Apply migrations.

```bash
Update-Database
```

6. Run the project.

---

## 🎯 Learning Objectives

This project demonstrates:

- ASP.NET Core MVC Architecture
- Entity Framework Core
- Repository Pattern
- Dependency Injection
- Authentication & Authorization
- CRUD Operations
- Model Validation
- SQL Server Integration

---

## 👨‍💻 Author

**Abdelrahman Osama Mohamed**

- GIS Developer
- Full Stack .NET Developer

LinkedIn:
(https://www.linkedin.com/in/abdelrahman-osama-a4600424b/)

GitHub:
(https://github.com/abdelrahman10osama)

---

## ⭐ If you like this project

Give it a ⭐ on GitHub!
