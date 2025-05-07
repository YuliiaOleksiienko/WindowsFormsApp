-- Create database
CREATE DATABASE db_yrkesprov;
GO

USE db_yrkesprov;
GO

-- Table: kostnad (prices for menu items)
CREATE TABLE kostnad (
    prisid INT PRIMARY KEY IDENTITY(1,1),
    prisburger FLOAT,
    pristaco FLOAT,
    prisburitto FLOAT,
    prispotatis FLOAT,
    prispizza FLOAT,
    prispaj FLOAT,
    prisläsk FLOAT,
    priskaffe FLOAT,
    prisglass FLOAT
);

-- Table: valet (current orders)
CREATE TABLE valet (
    nummer INT PRIMARY KEY IDENTITY(1,1),
    mat NVARCHAR(30),         -- food item name
    antal INT,                -- quantity
    pris FLOAT,               -- price per unit
    summa FLOAT,              -- total for item (pris * antal)
    total FLOAT,              -- full order total
    datum DATETIME            -- order timestamp
);

-- Table: sold (confirmed/sold orders)
CREATE TABLE sold (
    nummer INT PRIMARY KEY IDENTITY(1,1),
    mat NVARCHAR(30),
    antal INT,
    pris FLOAT,
    summa FLOAT,
    total FLOAT,
    datum DATETIME
);

-- Optional: insert example prices
INSERT INTO kostnad (
    prisburger, pristaco, prisburitto, prispotatis,
    prispizza, prispaj, prisläsk, priskaffe, prisglass
)
VALUES (
    8.5, 6.3, 7.5, 3.2,
    12.6, 4.4, 2.6, 3.2, 2.7
);
