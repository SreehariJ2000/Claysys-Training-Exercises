--AuthenticationDB
--TASK 6 Stored procedure signup
USE AuthenticationDB;

--add data

/*
CREATE PROCEDURE InsertData
    @Username VARCHAR(50),
    @Email VARCHAR(50),
    @Password VARCHAR(100),
    @Phone VARCHAR(20),
    @Gender VARCHAR(10),
    @DateOfBirth DATE,
    @StreetAddress VARCHAR(255),
    @City VARCHAR(100),
    @Country VARCHAR(100)

AS
BEGIN
    INSERT INTO Signup (Username, Email, User_Password, Phone, Gender, DateOfBirth, StreetAddress, City, Country)
    VALUES ( @Username,  @Email,  HASHBYTES('SHA2_256', @Password),  @Phone,  @Gender,  @DateOfBirth,  @StreetAddress, 
	         @City,  @Country );
END;

*/


-- view data
/*
CREATE PROCEDURE Get_data
     @Email VARCHAR(50)
 AS
 BEGIN
    SELECT * FROM Signup
	WHERE Email = @Email
 END;
 */  



 --update user
/*
ALTER PROCEDURE UpdateUser
    @UserID INT,
    @Username VARCHAR(50) = NULL,
    @Email VARCHAR(50) = NULL,
    @Password VARCHAR(100) = NULL, 
    @Phone VARCHAR(20) = NULL,
    @Gender VARCHAR(10) = NULL,
    @DateOfBirth DATE = NULL,
    @StreetAddress VARCHAR(255) = NULL,
    @City VARCHAR(100) = NULL,
    @Country VARCHAR(100) = NULL
AS
BEGIN
    UPDATE Signup
    SET Username = ISNULL(@Username, Username),
        Email = ISNULL(@Email, Email),
        User_Password = ISNULL( @Password , User_Password),
        Phone = ISNULL(@Phone, Phone),
        Gender = ISNULL(@Gender, Gender),
        DateOfBirth = ISNULL(@DateOfBirth, DateOfBirth),
        StreetAddress = ISNULL(@StreetAddress, StreetAddress),
        City = ISNULL(@City, City),
        Country = ISNULL(@Country, Country)
    WHERE UserID = @UserID;
END;

*/

-- delete user
/*
CREATE PROCEDURE DeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM Signup
    WHERE UserID = @UserID;
END;

*/


 /*
EXECUTE InsertData 
    @Username = 'JohnDoe',
    @Email = 'johndoe@example.com',
    @Password = 'securepassword',
    @Phone = '1234567890',
    @Gender = 'Male',
    @DateOfBirth = '1990-01-01',
    @StreetAddress = '456 Elm St',
    @City = 'CityName',
    @Country = 'CountryName';
*/

--EXECUTE Get_data @Email = 'amal@gmail.com'

-- EXECUTE UpdateUser   @UserID = 1,  @Phone = '0987654321',  @City = 'Kanjirapally';
  

--EXEC DeleteUser @UserID = 5;

--select * from Signup



