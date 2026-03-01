💊 Pharmacy Management System
A desktop-based pharmacy management application built with C# (.NET) and SQL Server, designed to streamline pharmacy operations including inventory management, sales processing, customer records, and reporting.

📌 Overview
This application provides an integrated solution for small-to-medium pharmacies to manage daily operations efficiently. It supports real-time inventory tracking, sales recording, and structured data storage using relational database architecture.
The system focuses on:
- Improving operational accuracy
- Reducing manual record-keeping
- Ensuring structured and centralized data management
  
🚀 Features
🧾 Sales Management:

- Create and manage invoices
- Calculate total payment automatically
- Store transaction history

📦 Inventory Management:

- Add, update, delete medicine records
- Track stock levels
- Monitor expiration dates
- Low-stock alerts

👤 Customer Management:

- Store customer information
- Maintain purchase history

📊 Reporting: 

- Sales summary reports
- Inventory overview
- Revenue tracking

🛠 Tech Stack:

- Language: C# (.NET Framework / .NET Core)
- Database: Microsoft SQL Server
- Architecture: Layered Architecture (UI – Business Logic – Data Access)

🗄 Database Design:
The system uses a relational database model with structured tables:
- Medicines
- Customers
- Invoices
- InvoiceDetails
- Users

Key database concepts applied:

- Primary & Foreign Keys
- Relational integrity
- Normalization principles
- Transaction handling

⚙️ Installation Guide

1️⃣ Clone the repository

git clone https://github.com/yourusername/pharmacy-management-system.git

2️⃣ Setup Database

Open SQL Server Management Studio (SSMS)

Create a new database (e.g., PharmacyDB)

Run the provided SQL script in /Database folder

3️⃣ Configure Connection String

Update the connection string in:

app.config

Example:

<connectionStrings>
  <add name="PharmacyDB"
       connectionString="Data Source=YOUR_SERVER;Initial Catalog=PharmacyDB;Integrated Security=True"/>
</connectionStrings>
4️⃣ Run the Application

Open the solution in Visual Studio

Build and run

🏗 System Architecture

The application follows a structured layered design:

Presentation Layer (UI Forms)

Business Logic Layer (BLL)

Data Access Layer (DAL)

SQL Server Database

This ensures scalability, maintainability, and separation of concerns.

📈 Future Improvements

Role-based authentication system

Dashboard analytics

Data export (Excel / PDF)

Cloud database integration

Basic predictive demand forecasting

📚 Learning Outcomes

Through this project, I gained experience in:

Designing relational database systems

Building CRUD operations with C#

Connecting C# applications to SQL Server

Applying structured software architecture

Managing transactional business data

📄 License

This project is for educational and portfolio purposes.
