# Yrkesprov – Food Ordering Application

This is my first C# Windows Forms application developed as part of my final exam project (*yrkesprov*). The application simulates a fast-food ordering system where users can select items like burgers, fries, and drinks, and receive a detailed receipt with calculated totals.

## Features

- **Order Management**: View and manage current meal orders from the database.
- **Add & Confirm Orders**: Add new orders and confirm them — confirmed orders are moved to the sold table.
- **Delete Orders**: Easily remove selected meals from the order list.
- **Total Calculation**: Automatically calculates the total price of all selected meals.
- **Receipt Printing**: Generate and preview printable receipts.
- **Clear Order Table**: Automatically clears the order table after printing or confirming.
- **Data Persistence**: All order data is stored in a SQL Server database using ADO.NET.


## Technologies Used

- C# (.NET Framework)
- Windows Forms
- Microsoft SQL Server
- Git & GitHub

## Screenshots

![Main Form](https://github.com/user-attachments/assets/b7b7220e-6f6c-4a8b-bea0-2c7462fd303b)

![Menu Form](https://github.com/user-attachments/assets/96a4adbf-e64f-47da-9e18-8ccc2a3226bc)

![Order Form](https://github.com/user-attachments/assets/9b249be0-a445-4ff1-8f33-ed118818bb96)

![Order Form Completions](https://github.com/user-attachments/assets/ca45c84f-3826-40a9-a792-8ffb543b7a01)

![Receipt Output](https://github.com/user-attachments/assets/d09fd3f6-327a-4e76-bb9c-6d7085047dbd)


## Getting Started

**Clone the repository:**

```bash
git clone https://github.com/YuliiaOleksiienko/Yrkesprov.git
```

Then follow these steps:

1. Open the project
   - Open `Yrkesprov.sln` in Visual Studio

2. Set up the database
   - Open SQL Server Management Studio
   - Run `setup.sql` to create the required tables
   - Make sure the connection string matches your SQL Server and `db_yrkesprov`

3. Run the application
   - Press `F5` in Visual Studio to build and start the project











