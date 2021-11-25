<a href="#">
    <img src="https://i.imgur.com/f6Xdb0s.png" alt="CommandAPI" title="CommandAPI" align="right" height="60" />
</a>

# CommandAPI
![TechStack](https://img.shields.io/badge/C%23-ASP.NET%20Core%20API-yellowgreen)
![TechStack](https://img.shields.io/badge/C%23-Entity%20Framework%20Core-red)
![TechStack](https://img.shields.io/badge/SQL-MSSQL-green)

Basic API tutorial from Les Jackson's book [The Complete ASP.NET Core 3 API Tutorial](https://www.springerprofessional.de/en/introduction/18420678?fulltextView=true). 

The project is built slightly differently from what is described in the book. 

**Tools used:**

* IDE: Visual Studio
* Database: MSSQL
* ORM: Entity Framework Core

## Arhitchture - MVC
![Arhitchture](https://i.imgur.com/DuRMVRg.png)

### Functionality
The project support CRUD requests at the following routes:

| **Request Type** | **URI**  | **Request Body** | **Functionality** |
| --- | --- |--- | --- |
| **HTTPGET**  | `http://localhost:5000/api/commands`|none|Get all commands from the database.|
| **HTTPGET**  | `http://localhost:5000/api/commands/{id}}` |none|Get a command with Id=1.|
| **HTTPPOST**  | `http://localhost:5000/api/commands`  |`{"howTo": "Create and EF migration","platform": "Entity Framework Package Menager Console","commandLine": "add-migration <name of migration>"}`|Create new command.|
| **HTTPUT**  | `http://localhost:5000/api/commands/{id}`|`{"howTo": "Run a .NET Core App","platform": ".NET Core CLI","commandLine": "dotnet run"}`|Fully update command with the given Id.|
| **HTTPPATCH**  | `http://localhost:5000/api/commands/{id}`|`[{"op": "replace","path": "/howto","value": "Run a .NET Core 3.1 App"}]`|Update part of a single resource (by Id)|
| **HTTPDELETE**  | `http://localhost:5000/api/commands/{id}`|none| Delete a single resource (by Id)|

### Installation
- Download the project
- Double click `CommandAPISolution.sln`
- Set the connection string in `appsettings.json` to your local database
- Run the project with CTR+F5
- The database will be automatically seeded with test data 