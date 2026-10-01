# Inventory Management System

ITS203 Object-Oriented Design and Programming – Assessment C
Rajit Gajurel (S2500239)

A C# Windows Forms application for a small retail shop. It keeps track of products, categories and
stock levels, records every delivery and sale, and warns the user when a product is running low.
All data is stored in a MySQL database.


## Built with

- C# Windows Forms, .NET 10 (`net10.0-windows`)
- Visual Studio Community 2026
- MySQL (MariaDB from XAMPP)
- MySql.Data NuGet package

## Setup and run

You need Visual Studio 2026 (with ".NET desktop development") and XAMPP.

1. Clone the repository:
   ```
   git clone https://github.com/rajitgajurel/InventoryManagementSystem.git
   ```
2. Start **Apache** and **MySQL** in the XAMPP Control Panel.
3. Import `Database/inventory_db.sql` in phpMyAdmin (http://localhost/phpmyadmin, Import tab) to create the database.
   Optional: import `Database/sample_data.sql` too for test data (it replaces any existing data).
4. In the `InventoryManagementSystem` project folder, copy `App.config.example` to `App.config`.
   The example uses the XAMPP defaults (user `root`, no password). Change it if yours are different.
5. Open `InventoryManagementSystem.slnx` in Visual Studio and press **F5**
   (or run `dotnet run --project InventoryManagementSystem`).


## How to use

The window opens on the Home page, which shows the low stock warning, the totals and the most
recent stock changes. Use the menu on the left to open a screen.

1. Add some categories in **Categories** first (a product needs a category).
2. Add products in **Products**. Click a row to edit or delete that product.
3. Use **Stock In / Out** when a delivery arrives or items are sold.
4. Check **Restock List**, **Stock History** and **Stock Report** to see what is happening with the stock.
