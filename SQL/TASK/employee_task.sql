-- DB used EmployeeDB
-- TASK 3 AND 4

/*
CREATE TABLE employee (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeName VARCHAR(50) ,
    Department VARCHAR(50) ,
    Salary DECIMAL(10, 2),
);

*/

/*
INSERT INTO employee (EmployeeName, Department, Salary)
VALUES 
('Sree', 'IT', 75000.00),
('Vishnu', 'HR', 68000.00),
('Rahul', 'IT', 72000.00),
('Sneha', 'Sales', 65000.00),
('AARUN', 'Finance', 80000.00),
('Vikram', 'Sales', 62000.00),
('Pooja', 'IT', 73000.00);

*/

-- second highest salary

/*
SELECT  MAX(Salary) as Second_highest
FROM employee
WHERE Salary < (SELECT MAX(Salary) FROM employee);
*/


-- List of number of employees in each department

/*
SELECT Department , COUNT(EmployeeID) AS Number_of_Employees
FROM employee
GROUP BY Department

*/

select * from employee

