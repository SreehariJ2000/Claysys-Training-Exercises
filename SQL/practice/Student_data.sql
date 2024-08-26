
-- Retrieve the instructors who are teaching at least 2 different courses to the same student.
/*
SELECT c.Instructor, c.StudentID, COUNT(DISTINCT c.CourseName) AS CourseCount
FROM Courses c
GROUP BY c.Instructor, c.StudentID
HAVING COUNT(DISTINCT c.CourseName) >= 2;


Find students who have enrolled in courses that have more than 3 credits but less than 5 credits. 
Only include students who have enrolled in at least 2 such courses.

select s.Name ,  COUNT( c.CourseName)  
from Students s
inner join Courses c
on s.studentID = c.studentID
where Credits > 3  and  Credits < 5
group by s.Name
HAVING  count(c.CourseName) >= 2

*/

/*
Retrieve the list of students along with the total credits of courses they are enrolled in,
only if the total credits exceed 6.


SELECT s.Name , sum(c.Credits)
FROM Students s
INNER JOIN Courses c
ON s.StudentID = c.StudentID
GROUP BY s.Name
HAVING sum(c.Credits) > 6;

*/

/*
 Retrieve the list of instructors who have taught more than one student,
 and among those students, calculate the average age.

 SELECT AVG(s.Age) , c.Instructor
FROM Students s
INNER JOIN Courses c
ON s.StudentID = c.StudentID
Group by c.Instructor
HAVING COUNT(distinct s.Name) > 1;

*/


--select * from Courses









