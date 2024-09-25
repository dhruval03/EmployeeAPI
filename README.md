# Asp.Net-Core-Web-API-CRUD-Operations
Asp.Net Core Web API CRUD Operations


Points discussed :
-	Create .Net Core Web API Project
-	What is meant by CRUD Operations in an Restfull API
-	Test & Verify Web API Methods using Swagger Interface
-	Setup EF Model & Create the Database
-	API Controller with CRUD Web Methods
-	GET Web Method for Read Operation
-	Insert a Record using Post Web Method
-	Common Status Codes in Web APIs
-	Retrieve a Specific Record with Given ID
-	Update Operation using PUT Web Method
-	Various Return Types
-	Delete Operation


# Steps to Create Web API :

- Create Web API Project
- Install Packages using NuGet Package Manager Console
```
Install-Package Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.AspNetCore.Cors
```
- Define the Student Model
- Set Up the Database Context (inside Data Folder)
- Configure the Connection String - appsettings.json
- Configure the Services in Program.cs
- Create the CRUD Controller
- Create and Apply Migrations in NuGet Package Manager Console
```
add-migration initial
update-database
```
- Test the API


