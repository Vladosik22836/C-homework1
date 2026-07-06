--USE HogwartsDB;
--GO

--CREATE TABLE Departments
--(
--    Id INT IDENTITY(1,1) PRIMARY KEY,

--    Financing MONEY NOT NULL
--        DEFAULT 0
--        CHECK (Financing >= 0),

--    Name NVARCHAR(100) NOT NULL
--        UNIQUE
--        CHECK (Name <> '')
--);

--INSERT INTO Departments (Name, Financing)
--VALUES
--('Potions', 150000),
--('Defence Against the Dark Arts', 250000),
--('Herbology', 100000);

SELECT * FROM Departments;