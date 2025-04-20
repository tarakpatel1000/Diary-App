# Diary App 📔

This is a simple Diary Web Application built using **ASP.NET Core MVC** and **Entity Framework Core**. It allows users to create, view, and delete personal diary entries. This project demonstrates full CRUD functionality, using a local SQL Server database.

## ✨ Features

- 📝 Create new diary entries
- 📖 View all past entries
- ❌ Delete unwanted entries
- 📅 Date-based entry creation
- 💾 Entity Framework Core for database interaction
- 🧩 Razor views for rendering

---

## 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 6/7)
- Entity Framework Core
- SQL Server (LocalDB)
- Razor Pages
- Bootstrap for styling

---

## 🧑‍💻 Getting Started

To run this project locally, follow these steps:

### 1. Clone the Repository

Install Prerequisites
Ensure you have the following installed on your machine:

- .NET SDK
- SQL Server Management Studio (SSMS)
- Microsoft SQL Server (LocalDB or Express Edition)

3. Set Up the Database
- Create the Database
- Open SQL Server Management Studio (SSMS) and connect to your local server.
- Create a new database (name it whatever you like) or use an existing database.
- Open the appsettings.json file in your project, and modify the connection string to point to your local SQL Server database:

- Example connection string in appsettings.json:

"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=YourDatabaseName;Trusted_Connection=True;MultipleActiveResultSets=true"
}

- Apply the Migrations
- Once the database is set up, open the terminal in your project directory and run the below command to apply the Entity Framework migrations:

- This will create the necessary tables and structure in your SQL Server database based on the migrations in the Migrations/ folder.

4. Running the Application
- After setting up the project and database, you can run the application.

```bash
dotnet ef database update
