DROP TABLE Products;
GO

-- Now recreate it
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

-- Re-insert data
INSERT INTO Products (ProductID, ProductName, Category, Price)
VALUES
(1, 'Laptop', 'Electronics', 75000),
(2, 'Smartphone', 'Electronics', 45000),
(3, 'TV', 'Electronics', 45000),
(4, 'Blender', 'Home Appliances', 3000),
(5, 'Toaster', 'Home Appliances', 3000),
(6, 'Microwave', 'Home Appliances', 7000),
(7, 'Notebook', 'Stationery', 50),
(8, 'Pen', 'Stationery', 10),
(9, 'Marker', 'Stationery', 20),
(10, 'Printer', 'Electronics', 12000);
