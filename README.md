# Pustok Web App 🌐

PustokApp is an ASP.NET Core web application developed using C# and .NET 8.
The project demonstrates structured architecture, separation of concerns, and common enterprise patterns such as MVC (Model-View-Controller), ViewModels for data transfer, and robust web development practices.

This application provides a functional, interactive web interface for users, including account and profile management capabilities.

## 🎯 Project Goals
The main objectives of this project are:

- Practice clean architecture and MVC design patterns
- Apply Entity Framework Core in a real-world web scenario
- Understand web routing and controller logic
- Use ViewModels (like `UserProfileVm`) to securely and efficiently transfer data to views
- Build a fully functional responsive web application
- Handle user authentication, input validation, and exceptions gracefully

## 🧱 Architecture Overview
The project follows a solid web-based multi-layered architecture:

### 1️⃣ Presentation Layer (Views)
- Handles user interaction via responsive web pages
- Displays data securely using Razor syntax (`.cshtml`)
- Contains client-side validations, HTML, CSS, and JavaScript
- Ensures an intuitive and user-friendly web interface

### 2️⃣ Application & Business Layer (Controllers & Services)
- Contains business logic and request routing (e.g., `AccountController`)
- Uses ViewModels to encapsulate necessary data for the UI
- Processes user input, enforces business rules, and communicates with the data layer
- Handles authentication and user state management

### 3️⃣ Data Access Layer (Models & Database)
- Responsible for database operations
- Uses Entity Framework Core for ORM
- Contains entity models defining the database schema
- Manages secure data retrieval and persistence

This separation ensures:
- Better maintainability
- Clear application flow
- Easier testing and debugging
- Robust security boundaries

## ✨ Features

### 👤 Account & Profile Management
- Secure user registration and login
- User profile viewing and updating capabilities (`UserProfile`)
- Form validation and error handling for user inputs

### 🌐 Web Features
- Dynamic routing and scalable endpoints
- Responsive UI design
- Clean data presentation 

## 🛠️ Technologies & Tools
- C#
- .NET 8
- ASP.NET Core MVC / Razor Pages
- Entity Framework Core
- HTML / CSS / JavaScript
- Git & GitHub
   ```
   *Alternatively, you can open the solution in Visual Studio 2022 and start it from there.*
