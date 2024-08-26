USE Ecommerce;

/*
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL
);

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(50) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Stock INT,
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID)
);

CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(50) NOT NULL,
    City VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20)
);

CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE NOT NULL,
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL
);

*/


/*

-- Inserting into Categories
INSERT INTO Categories (CategoryName) VALUES 
('Electronics'),
('Furniture'),
('Clothing'),
('Books');

-- Inserting into Products
INSERT INTO Products (ProductName, Price, Stock, CategoryID) VALUES 
('Laptop', 1200, 50, 1),
('Smartphone', 800, 150, 1),
('Table', 300, 20, 2),
('Chair', 100, 100, 2),
('T-Shirt', 202, 200, 3),
('Novel', 150, 500, 4);

-- Inserting into Customers
INSERT INTO Customers (CustomerName, City, Email, PhoneNumber) VALUES 
('Anil ', 'Kochi', 'anil@gmail.com', '9847012345'),
('Lakshmi', 'Thiruvananthapuram', 'lakshmi@gmail.com', '9447054321'),
('Sree', 'Pathanamthitta', 'sree@gmail.com', '9895067890'),
('Vishnu', 'Pathanamthitta', 'vishnu@gmail.com', '9746098765');


-- Inserting into Orders
INSERT INTO Orders (OrderDate, CustomerID, ProductID, Quantity) VALUES 
('2024-08-01', 1, 1, 2), 
('2024-08-03', 2, 2, 3), 
('2024-08-05', 3, 3, 1), 
('2024-08-07', 4, 4, 5), 
('2024-08-09', 1, 6, 10), 
('2024-08-11', 2, 5, 7); 

*/

SELECT * FROM Orders
SELECT * FROM Products
SELECT * FROM Categories
SELECT * FROM Customers

/*
Query 1: Retrieve total sales for each product category, including categories where total sales exceed 2000.

SELECT  p.CategoryID , SUM(o.Quantity * p.Price)  
FROM Orders o
INNER JOIN Products p
ON o.ProductID = p.ProductID
GROUP BY p.CategoryID
HAVING SUM(o.Quantity * p.Price) > 2000

*/

/*

Find the top 3 customers who have made the highest total purchases, including their city and contact details.

SELECT TOP 3 c.CustomerID , sum( o.Quantity * p.Price )  ,  c.City , c.PhoneNumber 
FROM Customers c 
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
INNER JOIN Products p ON p.ProductID = o.ProductID
group by c.CustomerID , c.City , c.PhoneNumber
*/

/*
Query 3: Retrieve products in the 'Electronics' or 'Furniture' categories with prices between 100 and 1000,
ordered by price descending.

select p.ProductID , p.ProductName , c. CategoryName ,p.Price
FROM Products p
INNER JOIN Categories c
ON p. CategoryID = c.CategoryID
Where (c. CategoryName = 'Electronics' OR c. CategoryName = 'Furniture')  AND (p.Price between 300 and 1000)
order by   p.Price desc

*/


