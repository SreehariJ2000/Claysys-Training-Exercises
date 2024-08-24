/* CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Grade VARCHAR(2),
    TotalMarks INT,
    City VARCHAR(50),
    EnrollmentDate DATE
);

*/

/*

INSERT INTO Student (StudentID, Name, Age, Grade, TotalMarks, City, EnrollmentDate)
VALUES (1, 'Sree', 19, 'B', 400 , 'kollam', '2024-08-02'),
       (2, 'Amal', 19, 'c', 400 , 'konni', '2024-05-02'),
	   (3, 'vishnu', 18, 'B', 300 , 'trivandrum', '2024-08-23'),
	   (4, 'ajin', 19, 'A', 350 , 'wayanad', '2024-04-02'),
	   (5, 'vimal', 20, 'c', 100 , 'kollam', '2024-08-02');


*/

-- SELECT * FROM Student;

--SELECT DISTINCT City FROM Student;

--SELECT * FROM Student WHERE Age > 18;

--SELECT * FROM Student ORDER BY TotalMarks   DESC;

--SELECT * FROM Student WHERE (Age > 18 AND Grade = 'A') ;

--UPDATE Student SET TotalMarks = 480 WHERE StudentID = 1;

--DELETE FROM Student WHERE StudentID = 3;
--SELECT * FROM Student

--SELECT TOP 3 * FROM Student ORDER BY TotalMarks ;

-- SELECT MIN(TotalMarks)  FROM Student;

--SELECT COUNT(*) AS TotalStudents  FROM Student;

--SELECT * FROM Student WHERE Name LIKE 's%';









