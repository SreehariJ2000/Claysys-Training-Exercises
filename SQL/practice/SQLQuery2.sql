/*
CREATE TABLE Students (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    City VARCHAR(50),
    EnrollmentDate DATE
);

CREATE TABLE Courses (
    CourseID INT IDENTITY(1,1) PRIMARY KEY,
    CourseName VARCHAR(50),
    Instructor VARCHAR(50),
    Credits INT,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
);


-- Inserting into Students table
INSERT INTO Students (Name, Age, City, EnrollmentDate)
VALUES 
('John Doe', 20, 'Los Angeles', '2024-01-15'),
('Jane Smith', 22, 'New York', '2024-02-10'),
('Tom Brown', 19, 'Chicago', '2024-03-20'),
('Emma Wilson', 21, 'Miami', '2024-04-05'),
('Lucas Davis', 23, 'Houston', '2024-05-25');

-- Inserting into Courses table
INSERT INTO Courses (CourseName, Instructor, Credits, StudentID)
VALUES 
('Mathematics', 'Dr. A', 3, 1),
('Physics', 'Dr. B', 4, 2),
('Chemistry', 'Dr. C', 3, 3),
('Biology', 'Dr. D', 4, 1),
('Computer Science', 'Dr. E', 5, 4),
('English', 'Dr. F', 2, 5),
('History', 'Dr. G', 3, 1);


*/

--select * from Courses;
--select * from Students;

/*SELECT * FROM Students 
WHERE City = 'Los Angeles';

SELECT * FROM Students
WHERE Age > 20 OR City = 'Chicago'


SELECT * FROM Students
ORDER BY Enrollment

select s.Name , c.CourseName 
FROM  Students s 
INNER JOIN Courses c
ON s.StudentID = c.StudentID;

select count(StudentID) , CourseName
from Courses
group by CourseName;

*/


SELECT s.Name, COUNT(c.CourseID) AS CourseCount
FROM Students s
INNER JOIN Courses c ON s.StudentID = c.StudentID
GROUP BY s.Name
HAVING COUNT(c.CourseID) > 1;



