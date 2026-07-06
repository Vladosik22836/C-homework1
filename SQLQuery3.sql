--USE HogwartsDB;
--GO

--CREATE TABLE Groups
--(
--    Id INT IDENTITY(1,1) PRIMARY KEY,

--    Name NVARCHAR(10) NOT NULL
--        UNIQUE
--        CHECK (Name <> ''),

--    Rating INT NOT NULL
--        CHECK (Rating BETWEEN 0 AND 5),

--    [Year] INT NOT NULL
--        CHECK ([Year] BETWEEN 1 AND 5)
--);

--INSERT INTO Groups (Name, Rating, [Year])
--VALUES
--('GR-1', 5, 1),
--('SL-2', 4, 2),
--('RV-3', 5, 3),
--('HF-4', 3, 4);

--SELECT * FROM Groups;