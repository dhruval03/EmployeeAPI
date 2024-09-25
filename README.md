# Employee API

## Overview

The Employee API is a simple RESTful service built with ASP.NET Core. It provides a straightforward way to manage employee records, supporting various operations such as creating, reading, updating, and deleting employee data.

## Features

- **CRUD Operations**: Create, Read, Update, and Delete employee records.
- **Search Functionality**: Easily search for employees by name.
- **Basic Authentication**: Secure access to endpoints.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK (6.0 or later)](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/dhruval03/EmployeeAPI.git
   cd EmployeeAPI
2. **Restore dependencies:**
   
   ```bash
   dotnet restore

3. **Configure the database connection:**
   ```bash
   "ConnectionStrings": {
   "DefaultConnection": "Server=your_server;Database=EmployeeDB;User Id=your_user;Password=your_password;"
    }

4. **Apply database migrations:**:
   ```bash
    dotnet ef database update

5. **Run the application:**:
   ```bash
    dotnet run

### API Endpoints
  - GET /api/employees - Get all employees
  - GET /api/employees/{id} - Get an employee by ID
  - POST /api/employees - Create a new employee
  - PUT /api/employees/{id} - Update an employee
  - DELETE /api/employees/{id} - Delete an employee

### Contact
For any inquiries, please reach out at maniyardhruval1290@gmail.com.
