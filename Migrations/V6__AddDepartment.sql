CREATE TABLE Department (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Budget DECIMAL(18,2) NOT NULL,
    StartDate DATETIME NOT NULL,
    DepartmentHeadId INT NULL,
    CONSTRAINT FK_Department_Instructor FOREIGN KEY (DepartmentHeadId) REFERENCES Instructor(Id)
);
