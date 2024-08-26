--create database NormalformDB

--Task 8

      -- 1NF
/*
CREATE TABLE Employees (
    EMP_ID INT PRIMARY KEY,
    Fullname VARCHAR(100),
    Place VARCHAR(50)
);

CREATE TABLE EmployeePhones (
    Phone_ID INT PRIMARY KEY IDENTITY(1,1), 
    EMP_ID INT FOREIGN KEY REFERENCES Employees(EMP_ID),
    Phone VARCHAR(15)
    
);

INSERT INTO Employees (EMP_ID, Fullname, Place)
VALUES 
    (1, 'Amit Sharma', 'Delhi'),
    (2, 'Rajesh Kumar', 'Mumbai'),
    (3, 'Priya Singh', 'Chennai'),
    (4, 'Sunita Menon', 'Bangalore'),
    (5, 'Vijay Patel', 'Ahmedabad');

INSERT INTO EmployeePhones (EMP_ID, Phone)
VALUES 
    (1, '9876543210'),
    (1, '9123456789'),
    (2, '8765432109'),
    (3, '9988776655'),
    (4, '8899776655'),
    (5, '7890654321'),
    (5, '7012345678');

select * from EmployeePhones
*/



--2NF
-- StudentID	StudentName	CourseID	CourseName	Instructor
/*
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50) NOT NULL
);


CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50) NOT NULL,
    Instructor VARCHAR(50) NOT NULL
);


CREATE TABLE Enrollments (
    StudentID INT,
    CourseID INT,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);


INSERT INTO Students (StudentID, StudentName)
VALUES 
(1, 'sree'),
(2, 'vishnu');


INSERT INTO Courses (CourseID, CourseName, Instructor)
VALUES 
(101, 'Math', 'Mr. Smith'),
(102, 'English', 'Mr. Arun');


INSERT INTO Enrollments (StudentID, CourseID)
VALUES 
(1, 101),
(1, 102),
(2, 101);
*/




-- 3NF

--EMP_ID	EMP_NAME	EMP_ZIP	EMP_STATE	EMP_CITY  

/*
CREATE TABLE employee_zip (
    emp_zip VARCHAR(10) PRIMARY KEY,
    emp_state VARCHAR(50),
    emp_city VARCHAR(50)
);

CREATE TABLE employee (
    emp_id INT PRIMARY KEY,
    emp_name VARCHAR(50),
    emp_zip VARCHAR(10) FOREIGN KEY REFERENCES employee_zip(emp_zip)
);

INSERT INTO employee_zip (emp_zip, emp_state, emp_city) VALUES
('695014', 'kerala', 'trivandrum'),
('678001', 'kerala', 'palakkad'),
('682001', 'kerala', 'ernakulam'),
('683104', 'kerala', 'kottayam'),
('673001', 'kerala', 'kozhikode');


INSERT INTO employee (emp_id, emp_name, emp_zip) VALUES
(1, 'arjun', '695014'),
(2, 'manju', '678001'),
(3, 'deepak', '682001'),
(4, 'aishwarya', '683104'),
(5, 'vivek', '673001');


*/


