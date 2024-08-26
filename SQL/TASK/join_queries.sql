-- create database PurchaseDB 

-- task 5   SQL JOINS
/*
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName VARCHAR(100) ,
    Email VARCHAR(100)  UNIQUE,
    City VARCHAR(50) ,
    Phone VARCHAR(15) 
);



CREATE TABLE Orders (
 OrderID INT PRIMARY KEY IDENTITY(1,1),
 CustomerID INT FOREIGN KEY REFERENCES  Customers(CustomerID),
 OrderDate DATETIME DEFAULT GETDATE(),
 Amount DECIMAL(10, 2) );
*/

/*

INSERT INTO Customers (CustomerName, Email, City, Phone)
VALUES 
('Arjun', 'arjun@gmail.com', 'Kochi', '9447000001'),
('Sree ', 'sree@gmail.com', 'Thiruvananthapuram', '9447000002'),
('Rajesh', 'rajesh.kumar@gmail.com', 'Kozhikode', '9447000003'),
('Sreelakshmi', 'sreelakshmi@gmail.com', 'Kochi', '9447000004'),
('Vijay', 'vijay@gmail.com', 'Kannur', '9447000005');


INSERT INTO Orders (CustomerID, OrderDate, Amount)
VALUES 
(1, '2024-08-01', 150.00),
(1, '2024-08-15', 200.00),
(2, '2024-08-20', 300.00),
(3, '2024-08-22', 250.00),
(4, '2024-08-25', 100.00),
(1, '2024-08-26', 350.00);


*/

-- inner join
/*
SELECT 
 c.CustomerName,
 c.Email,
 o.OrderID,
 o.OrderDate,
 o.Amount

FROM
 Customers c

INNER JOIN Orders o ON c.CustomerID = o.CustomerID;
*/

-- left join
/*
SELECT 
 c.CustomerName, 
 c.Email,
 c.City,
 o.OrderID,
 o.OrderDate,
 o.Amount

FROM 
Customers c

LEFT JOIN Orders o ON c.CustomerID = o.CustomerID;
*/

-- right join
/*
SELECT 
 c.CustomerName,
 c.Email, o.OrderID,
 o.OrderDate, 
 o.Amount

FROM 
 Customers c

RIGHT JOIN Orders o ON c.CustomerID = o.CustomerID;
*/


--FULL OUTER JOIN
/*
SELECT  
 c.CustomerName, 
 c.Email, 
 o.OrderID,
 o.OrderDate,
 o.Amount

FROM
 Customers c
FULL OUTER JOIN Orders o ON c.CustomerID = o.CustomerID;
*/



--self join
/*
SELECT 
 a.CustomerName AS CustomerA, 
 b.CustomerName AS CustomerB,
 a.City
FROM Customers a
INNER JOIN Customers b ON a.City = b.City
WHERE a.CustomerID <> b.CustomerID;
*/
