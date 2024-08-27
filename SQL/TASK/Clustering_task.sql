--Indexing - Cluster and non-cluster indexing 
/*
CREATE TABLE PersonalInfo (
    ID INT PRIMARY KEY,
    Fullname VARCHAR(100),
    Salary VARCHAR(50)
);

INSERT INTO PersonalInfo (ID, Fullname, Salary)
VALUES
    (1, 'sree ', '50000'),
    (2, ' vishnu', '60000'),
    (3, 'stephin', '55000'),
    (4, 'tony', '65000');

*/

-- sp_helpindex PersonalInfo;

--CREATE CLUSTERED INDEX IX_PersonalInfo_Salary ON PersonalInfo(Salary DESC);

--select * from PersonalInfo;




      -- merge concept

	  /*
CREATE TABLE TargetProduct (
    ProductID INT PRIMARY KEY,
    Price DECIMAL(10, 2),
    Name VARCHAR(100)
);

CREATE TABLE SourceProduct (
    ProductID INT PRIMARY KEY,
    Price DECIMAL(10, 2),
    Name VARCHAR(100)
);

INSERT INTO TargetProduct (ProductID, Price, Name)
VALUES
    (1, 300, 'table'),
    (2, 340, ' chair'),
    (3, 320, 'bag');

INSERT INTO SourceProduct (ProductID, Price, Name)
VALUES
    (2, 400, 'chair'),  
    (3, 320, 'bag'),  
    (4, 100, 'book'); 

*/

/*
select * from SourceProduct
select * from TargetProduct



MERGE TargetProduct AS t
USING SourceProduct AS s
ON t.ProductID = s.ProductID
WHEN MATCHED THEN UPDATE 
 SET t.Price =s.Price ,  t.ProductName =s.ProductName

WHEN NOT MATCHED BY TARGET THEN
INSERT VALUES (s.ProductID , s.Price , s.ProductName);

*/