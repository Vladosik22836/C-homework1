--USE HogwartsDB;
--GO

--CREATE TABLE Teachers
--(
--    Id INT IDENTITY(1,1) PRIMARY KEY,

--    EmploymentDate DATE NOT NULL
--        CHECK (EmploymentDate >= '1990-01-01'),

--    Name NVARCHAR(MAX) NOT NULL
--        CHECK (Name <> ''),

--    Premium MONEY NOT NULL
--        DEFAULT 0
--        CHECK (Premium >= 0),

--    Salary MONEY NOT NULL
--        CHECK (Salary > 0),

--    Surname NVARCHAR(MAX) NOT NULL
--        CHECK (Surname <> '')
--);

--INSERT INTO Teachers
--(Name, Surname, EmploymentDate, Salary, Premium)
--VALUES
--('Albus', 'Dumbledore', '1992-09-01', 150000, 50000),
--('Severus', 'Snape', '1993-09-01', 120000, 30000),
--('Minerva', 'McGonagall', '1991-09-01', 130000, 40000),
--('Filius', 'Flitwick', '1994-09-01', 100000, 20000),
--('Pomona', 'Sprout', '1995-09-01', 95000, 15000);

SELECT * FROM Teachers;