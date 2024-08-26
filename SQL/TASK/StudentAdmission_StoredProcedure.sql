--AuthenticationDB
--TASK 7 Stored procedure Student Admission Form page

/*
CREATE TABLE StudentAdmission (
    StudentID INT IDENTITY(1,1) PRIMARY KEY, 
    Fullname VARCHAR(100),
    Email VARCHAR(100) ,
    Phone VARCHAR(15) ,
    StudentAddress VARCHAR(200) ,
    City VARCHAR(50) ,
    DOB DATE ,
    Gender VARCHAR(10) CHECK (Gender IN ('M', 'F' , 'O')), 
    Course VARCHAR(100) 
);
*/

/*

CREATE PROCEDURE ManageStudents 
          @Type VARCHAR(20),
          @StudentID INT = NULL , 
          @Fullname VARCHAR(100) = NULL,
          @Email VARCHAR(100) = NULL ,
          @Phone VARCHAR(15) = NULL ,
          @StudentAddress VARCHAR(200) = NULL ,
          @City VARCHAR(50) = NULL,
          @DOB DATE = NULL ,
          @Gender VARCHAR(10) = NULL, 
          @Course VARCHAR(100) = NULL

    AS
	BEGIN
	      IF @Type = 'INSERT'
		  BEGIN
		   INSERT INTO StudentAdmission (Fullname , Email , Phone , StudentAddress , City , DOB , Gender , Course)
		   VALUES (@Fullname , @Email , @Phone , @StudentAddress , @City , @DOB , @Gender , @Course);
		  END

		  ELSE IF @Type = 'SHOW'
		  BEGIN
		   SELECT * FROM  StudentAdmission;
		  END

		  ELSE IF @Type = 'UPDATE'
		  BEGIN
		   UPDATE StudentAdmission
                SET FullName = ISNULL(@FullName, FullName),
                    Email = ISNULL(@Email, Email),
                    Phone = ISNULL(@Phone, Phone),
                    StudentAddress = ISNULL(@StudentAddress, StudentAddress),
                    City = ISNULL(@City, City),
                    DOB = ISNULL(@DOB, DOB),
                    Gender = ISNULL(@Gender, Gender),
                    Course = ISNULL(@Course, Course)

                   
                WHERE StudentID = @StudentID;
          END

		  ELSE IF @Type = 'DELETE'
          BEGIN
              DELETE FROM StudentAdmission
              WHERE StudentID = @StudentID;
          END
	END


*/

-- insert data
/*
EXEC ManageStudents @Type = 'INSERT', 
                   @Fullname = 'sree', 
                   @Email = 'sreeh@gmail.com', 
                   @Phone = '9447088001', 
                   @StudentAddress = 'nehouse', 
                   @City = 'Kochi', 
                   @DOB = '2000-11-01', 
                   @Gender = 'M', 
                   @Course = 'MCA';
*/


-- update data
/*
EXEC ManageStudents @Type = 'UPDATE', 
                   @StudentID = 1, 
                   @Phone = '9447000002', 
                   @StudentAddress = 'newvilla';
*/

-- delete data
/*
EXEC ManageStudents @Type = 'DELETE', 
                   @StudentID = 1;
*/


-- view data
--EXEC ManageStudents @Type = 'SHOW';
                   


				