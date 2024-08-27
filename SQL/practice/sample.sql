CREATE DATABASE SambleDB;
USE SambleDB;
/*
CREATE TABLE Store  (
              StoreID INT PRIMARY KEY IDENTITY(1 ,1),
			  Place VARCHAR (100) NOT NULL ,
			  Started_At DATE );
   

CREATE PROCEDURE StoreOperations 
     @TYPE VARCHAR(20), @StoreID INT = null , @Place VARCHAR(20) = null , @Started_At DATE =null

	 AS
	 IF @TYPE = 'INSERT'
	 BEGIN
	   INSERT INTO Store values (@Place , @Started_At);
	END
	ELSE IF 
	 @TYPE = 'UPDATE'
	 BEGIN
	  UPDATE Store
	   SET Place = ISNULL(@Place,Place) ,
	        Started_At = ISNULL(@Started_At,Started_At)            
	  WHERE StoreID = @StoreID
	  END
	ELSE IF @TYPE = 'SELECT'
	 BEGIN
	  SELECT * FROM Store
	 END
	ELSE IF @TYPE = 'delete'
	 BEGIN
	  DELETE FROM Store
	  WHERE StoreID = @StoreID
	  END

EXECUTE StoreOperations @Type ="INSERT"  ,@Place ="kotm" , @Started_At = "2022-03-23"

EXECUTE StoreOperations @Type = 'delete' , @StoreID = 1;

select * from Store
*/