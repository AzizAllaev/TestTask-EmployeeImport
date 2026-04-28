# ASP.NET Core Employee CSV file processing System
This project gets CSV file with specific set of headers, demonstrate it
to user, and save to DB. That means that you can not put any CSV, it 
should have specified headers and data.

# Main Tech Stack
- C# / .NET 8 
- ASP.NET
- Entity Framework
- SQL Server


# Solution explorer
#  <img width="425" height="391" alt="Screenshot 2026-04-27 102404" src="https://github.com/user-attachments/assets/c198c6ee-5262-47c8-8287-ae1c48d4c02c" />
## Migrations
This folder includes all database migrations.

## Models
This folder includes entitys.

## Services 
This folder includes services, for example DataImportService that proccess filea and take data from him.

## How to Run
1. **Configure Connection String**: Open `Program.cs` and update the `AddDbContext` service and `AppDbContext` class, with your SQL Server path.
2. **Apply Migrations**: Open terminal in the project folder and run:
   ```bash
   dotnet ef database update



# How to use it?
When you will run project u will see home page with file importer.
<img width="1040" height="141" alt="Screenshot 2026-04-28 145542" src="https://github.com/user-attachments/assets/badeb097-f4f4-40f7-b772-588be079a9b8" />
Here u can see highlighted buttons, after pressing left one you 
will open file explorer. After you need to choose CSV file with correct 
headers(example: [dataset.xlsx](https://github.com/user-attachments/files/27160161/dataset.xlsx)) and press `Execute import`.

