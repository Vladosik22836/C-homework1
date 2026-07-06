--CREATE DATABASE Academy2;
--GO

--USE Academy2;
--GO

--CREATE TABLE Faculties
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(100) NOT NULL UNIQUE,
--    Dean NVARCHAR(100) NOT NULL,
--    Financing MONEY NOT NULL CHECK(Financing>=0)
--);

--CREATE TABLE Departments
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(100) NOT NULL UNIQUE,
--    Financing MONEY NOT NULL CHECK(Financing>=0),
--    FacultyId INT NOT NULL,
--    FOREIGN KEY(FacultyId) REFERENCES Faculties(Id)
--);

--CREATE TABLE Groups
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(10) NOT NULL UNIQUE,
--    Rating INT NOT NULL CHECK(Rating BETWEEN 0 AND 5),
--    [Year] INT NOT NULL CHECK([Year] BETWEEN 1 AND 5),
--    FacultyId INT NOT NULL,
--    DepartmentId INT NOT NULL,
--    FOREIGN KEY(FacultyId) REFERENCES Faculties(Id),
--    FOREIGN KEY(DepartmentId) REFERENCES Departments(Id)
--);

--CREATE TABLE Teachers
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(100) NOT NULL,
--    Surname NVARCHAR(100) NOT NULL,
--    Position NVARCHAR(50) NOT NULL,
--    EmploymentDate DATE NOT NULL,
--    Salary MONEY NOT NULL CHECK(Salary>0),
--    Premium MONEY NOT NULL DEFAULT 0
--);

--CREATE TABLE Subjects
--(
--    Id INT IDENTITY PRIMARY KEY,
--    Name NVARCHAR(100) NOT NULL UNIQUE,
--    DepartmentId INT NOT NULL,
--    FOREIGN KEY(DepartmentId) REFERENCES Departments(Id)
--);

--CREATE TABLE Curators
--(
--    TeacherId INT NOT NULL,
--    GroupId INT NOT NULL,
--    PRIMARY KEY(TeacherId,GroupId),
--    FOREIGN KEY(TeacherId) REFERENCES Teachers(Id),
--    FOREIGN KEY(GroupId) REFERENCES Groups(Id)
--);

--CREATE TABLE Lectures
--(
--    Id INT IDENTITY PRIMARY KEY,
--    TeacherId INT NOT NULL,
--    SubjectId INT NOT NULL,
--    GroupId INT NOT NULL,
--    FOREIGN KEY(TeacherId) REFERENCES Teachers(Id),
--    FOREIGN KEY(SubjectId) REFERENCES Subjects(Id),
--    FOREIGN KEY(GroupId) REFERENCES Groups(Id)
--);

--USE Academy2;
--GO

--INSERT INTO Faculties(Name, Dean, Financing)
--VALUES
--('Gryffindor','Minerva McGonagall',20000),
--('Slytherin','Horace Slughorn',25000),
--('Ravenclaw','Filius Flitwick',18000),
--('Hufflepuff','Pomona Sprout',15000),
--('Computer Science','Hermione Granger',12000);

--INSERT INTO Departments(Name, Financing, FacultyId)
--VALUES
--('Defence Against the Dark Arts',30000,1),
--('Potions',10000,2),
--('Charms',17000,3),
--('Herbology',9000,4),
--('Software Development',15000,5),
--('Theory of Databases',14000,5);

--INSERT INTO Groups(Name, Rating, [Year], FacultyId, DepartmentId)
--VALUES
--('G101',5,1,1,1),
--('S201',4,2,2,2),
--('R301',5,3,3,3),
--('H401',4,4,4,4),
--('P107',5,5,5,5),
--('CS51',5,5,5,6);

--INSERT INTO Teachers
--(Name,Surname,Position,EmploymentDate,Salary,Premium)
--VALUES
--('Albus','Dumbledore','Professor','1992-09-01',2000,500),
--('Severus','Snape','Professor','1995-09-01',1700,350),
--('Minerva','McGonagall','Professor','1991-09-01',1800,400),
--('Filius','Flitwick','Professor','1994-09-01',1600,300),
--('Pomona','Sprout','Professor','1993-09-01',1500,250),
--('Hermione','Granger','Professor','2005-09-01',1900,400),
--('Samantha','Adams','Professor','2008-01-15',1600,250);

--INSERT INTO Subjects(Name, DepartmentId)
--VALUES
--('Defence Against the Dark Arts',1),
--('Potions',2),
--('Charms',3),
--('Herbology',4),
--('Programming in Magic',5),
--('Theory of Databases',6);

--INSERT INTO Curators
--VALUES
--(1,1),
--(2,2),
--(3,3),
--(4,4),
--(6,5),
--(7,6);

--INSERT INTO Lectures(TeacherId,SubjectId,GroupId)
--VALUES
--(1,1,1),
--(2,2,2),
--(3,3,3),
--(4,3,4),
--(6,5,5),
--(7,6,6),
--(7,6,5);

--SELECT * FROM Faculties;
--SELECT * FROM Departments;
--SELECT * FROM Groups;
--SELECT * FROM Teachers;
--SELECT * FROM Subjects;
--SELECT * FROM Curators;
--SELECT * FROM Lectures;

--SELECT T.Surname, G.Name
--FROM Teachers T
--CROSS JOIN Groups G;

--SELECT DISTINCT F.Name
--FROM Faculties F
--JOIN Departments D ON F.Id = D.FacultyId
--WHERE D.Financing > F.Financing;

--SELECT T.Surname, G.Name
--FROM Curators C
--JOIN Teachers T ON C.TeacherId = T.Id
--JOIN Groups G ON C.GroupId = G.Id;

--SELECT DISTINCT T.Surname
--FROM Teachers T
--JOIN Lectures L ON T.Id = L.TeacherId
--JOIN Groups G ON G.Id = L.GroupId
--WHERE G.Name = 'P107';

--SELECT DISTINCT T.Surname, F.Name
--FROM Teachers T
--JOIN Lectures L ON T.Id = L.TeacherId
--JOIN Groups G ON L.GroupId = G.Id
--JOIN Faculties F ON G.FacultyId = F.Id;

--SELECT D.Name, G.Name
--FROM Departments D
--JOIN Groups G
--ON D.Id = G.DepartmentId;

--SELECT S.Name
--FROM Subjects S
--JOIN Lectures L ON S.Id = L.SubjectId
--JOIN Teachers T ON L.TeacherId = T.Id
--WHERE T.Name='Samantha'
--AND T.Surname='Adams';

--SELECT DISTINCT D.Name
--FROM Departments D
--JOIN Subjects S
--ON D.Id = S.DepartmentId
--WHERE S.Name='Theory of Databases';

--SELECT G.Name
--FROM Groups G
--JOIN Faculties F
--ON G.FacultyId = F.Id
--WHERE F.Name='Computer Science';

SELECT G.Name, F.Name
FROM Groups G
JOIN Faculties F
ON G.FacultyId = F.Id
WHERE G.Year = 5;