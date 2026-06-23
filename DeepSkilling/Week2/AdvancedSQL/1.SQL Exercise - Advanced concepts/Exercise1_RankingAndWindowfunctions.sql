CREATE DATABASE IF NOT EXISTS CognizantSQL;
USE CognizantSQL;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);

INSERT INTO Employees VALUES
(1,'Prathap','IT',50000),
(2,'Jhansi','IT',60000),
(3,'Mike','HR',45000),
(4,'Emily','HR',55000),
(5,'David','Finance',70000);

SELECT
    EmployeeID,
    EmployeeName,
    Department,
    Salary,
    RANK() OVER (ORDER BY Salary DESC) AS SalaryRank,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseRank,
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNum
FROM Employees;