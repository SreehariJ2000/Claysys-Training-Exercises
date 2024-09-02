CREATE DATABASE UserDB;
USE UserDB;

/*
CREATE TABLE Signup (
   UserID INT PRIMARY KEY IDENTITY(1,1),
   FirstName VARCHAR(50) NOT NULL,
   LastName VARCHAR(50) NOT NULL,
   Email VARCHAR(50) UNIQUE NOT NULL,
   User_Password VARCHAR(100) NOT NULL,
   Phone VARCHAR(20) UNIQUE NOT NULL 
);

*/

/*


CREATE PROCEDURE spInsertUser
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(50),
    @User_Password VARCHAR(100),
    @Phone VARCHAR(20)
AS
BEGIN
    INSERT INTO Signup (FirstName, LastName, Email, User_Password, Phone)
    VALUES (@FirstName, @LastName, @Email, @User_Password, @Phone);
END;


*/

/*
CREATE PROCEDURE spUpdateUser
    @UserID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(50),
    @User_Password VARCHAR(100),
    @Phone VARCHAR(20)
AS
BEGIN
    UPDATE Signup
    SET FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        User_Password = @User_Password,
        Phone = @Phone
    WHERE UserID = @UserID;
END;
*/

/*
CREATE PROCEDURE spDeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM Signup
    WHERE UserID = @UserID;
END;
*/



ALTER PROCEDURE spGetAllUserData
AS
BEGIN
    SELECT UserID , FirstName, LastName, Email, User_Password, Phone
	FROM Signup;
END;




/*
execute spInsertUser 
@FirstName='Sreehari', @LastName='J', @Email='hsree524@gmail.com', @User_Password ='sree123', @Phone='9562148689';

execute spGetAllUserData;
*/




CREATE PROCEDURE spSearchUsers
    @SearchTerm NVARCHAR(50)
AS
BEGIN
    SELECT UserID, FirstName, LastName, Email, Phone
    FROM Signup
    WHERE FirstName LIKE '%' + @SearchTerm + '%'
       OR LastName LIKE '%' + @SearchTerm + '%'
       OR Email LIKE '%' + @SearchTerm + '%'
       OR Phone LIKE '%' + @SearchTerm + '%'
END
