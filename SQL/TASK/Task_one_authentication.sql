--use AuthenticationDB;
--TASK 1 and 2

/*
CREATE TABLE Signup (
   UserID INT PRIMARY KEY IDENTITY(1,1),
   Username VARCHAR(50) NOT NULL,
   Email VARCHAR(50) UNIQUE NOT NULL,
   User_Password VARCHAR(100) NOT NULL,
   Phone VARCHAR(20),
   Gender VARCHAR(10),
   DateOfBirth DATE,
   StreetAddress VARCHAR(255),
   City VARCHAR(100),
   Country VARCHAR(100)
);
*/





/*
INSERT INTO Signup (Username, Email, User_Password, Phone, Gender, DateOfBirth, StreetAddress, City, Country) 
VALUES 
    ('Sreehari', 'sreehari@gmail.com', HASHBYTES('SHA2_256', 'sree123'), '9562148689', 'Male', '1990-01-01', 'puthenvila', 'Kochi', 'India'),
    ('Amal', 'amal@gmail.com', HASHBYTES('SHA2_256', 'amal123'), '9562148689', 'Male', '1988-05-15', 'newhouse', 'Thrissur', 'India'),
    ('Vishnu', 'vishnu@gmail.com', HASHBYTES('SHA2_256', 'vishnu123'), '9562148689', 'Male', '1992-07-22', 'streetone', 'Calicut', 'India'),
    ('Bijo', 'bijo@gmail.com', HASHBYTES('SHA2_256', 'bijo123'), '9562148689', 'Male', '1995-11-30', 'myhouse', 'Kannur', 'India');

*/


/*


UPDATE Signup 
SET Phone = '968776423'
WHERE UserID = 4


DELETE FROM signup
WHERE UserID = 3;

*/

  

  --Login table
  /*
  CREATE TABLE login (
    LoginID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Signup(UserID),
    LoginTime DATETIME DEFAULT GETDATE()
);
 
 */


 --select * from Signup

/*
INSERT INTO login (UserID)
VALUES 
    (1), (2), (4);   
*/

--select * from login
/*
select s.Username , l.LoginTime
from Signup s
inner join login l
on s.UserID = l.UserID
*/