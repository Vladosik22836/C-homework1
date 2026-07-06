--CREATE DATABASE Academy;
--GO

--USE Academy;
--GO

--CREATE TABLE Faculties
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(100) NOT NULL UNIQUE,
--    Dean NVARCHAR(100) NOT NULL
--);

--CREATE TABLE Departments
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(100) NOT NULL UNIQUE,
--    Financing MONEY NOT NULL DEFAULT 0 CHECK(Financing>=0)
--);

--CREATE TABLE Groups
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(10) NOT NULL UNIQUE,
--    Rating INT NOT NULL CHECK(Rating BETWEEN 0 AND 5),
--    [Year] INT NOT NULL CHECK([Year] BETWEEN 1 AND 5)
--);

--CREATE TABLE Teachers
--(
--    Id INT IDENTITY PRIMARY KEY,

--    Name NVARCHAR(100) NOT NULL,
--    Surname NVARCHAR(100) NOT NULL,

--    Position NVARCHAR(50) NOT NULL,

--    EmploymentDate DATE NOT NULL,

--    Salary MONEY NOT NULL CHECK(Salary>0),

--    Premium MONEY NOT NULL DEFAULT 0 CHECK(Premium>=0)
--);

--INSERT INTO Faculties(Name,Dean)
--VALUES
--('Gryffindor','Minerva McGonagall'),
--('Slytherin','Horace Slughorn'),
--('Ravenclaw','Filius Flitwick'),
--('Hufflepuff','Pomona Sprout'),
--('Computer Science','Hermione Granger');

--INSERT INTO Departments(Name,Financing)
--VALUES
--('Software Development',30000),
--('Potions',10000),
--('Defence Against the Dark Arts',27000),
--('Herbology',9000),
--('Charms',18000);

--INSERT INTO Groups(Name,Rating,[Year])
--VALUES
--('GR-1',5,1),
--('SL-2',4,2),
--('RV-3',5,3),
--('HF-4',3,4),
--('CS-5',5,5);

--INSERT INTO Teachers
--(Name,Surname,Position,EmploymentDate,Salary,Premium)
--VALUES
--('Albus','Dumbledore','Professor','1992-09-01',2000,500),
--('Severus','Snape','Professor','1995-09-01',1600,350),
--('Minerva','McGonagall','Professor','1991-09-01',1800,400),
--('Rubeus','Hagrid','Assistant','1998-01-10',900,250),
--('Remus','Lupin','Assistant','1999-02-15',950,200),
--('Filius','Flitwick','Professor','2003-05-20',1400,300),
--('Pomona','Sprout','Assistant','1997-03-12',850,180);

SELECT * FROM Faculties;
SELECT * FROM Departments;
SELECT * FROM Groups;
SELECT * FROM Teachers;