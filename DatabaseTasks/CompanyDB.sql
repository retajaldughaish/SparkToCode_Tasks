-- ===========================================
-- Company Database
-- ===========================================

-- Database Creation
CREATE DATABASE CompanyDB;
Go

USE CompanyDB;
Go

-- ===========================================
-- Create Tables
-- ===========================================

CREATE TABLE Department 
(
	Dnumber INT PRIMARY KEY,
	Dname VARCHAR(50) NOT NULL UNIQUE,
	Mgr_ssn CHAR(9) NULL,
	Mgr_start_date DATE
);
GO

CREATE TABLE Employee
(
	Ssn CHAR(9) PRIMARY KEY,
	Fname VARCHAR(20) NOT NULL,
	Minit CHAR(1),
	Lname VARCHAR(20) NOT NULL,
	Bdate DATE,
	Address VARCHAR(100),
	Sex CHAR(1) CHECK (Sex IN ('M','F')),
	Salary DECIMAL(10,2) CHECK (Salary > 0),
	Super_ssn CHAR(9),
	Dno INT NOT NULL
);
GO

CREATE TABLE Dept_Locations
(
	Dnumber INT NOT NULL,
	Dlocation VARCHAR(50) NOT NULL,

	PRIMARY KEY (Dnumber, Dlocation)
);
GO

CREATE TABLE Project
(
	Pnumber INT PRIMARY KEY,
	Pname VARCHAR(50) NOT NULL UNIQUE,
	Plocation VARCHAR(50) NOT NULL,
	Dnum INT NOT NULL
);
GO

CREATE TABLE Works_On
(
	Essn CHAR(9) NOT NULL,
	Pno INT NOT NULL,
	Hours DECIMAL(4,1) DEFAULT 0 CHECK (Hours >= 0),

	PRIMARY KEY (Essn, Pno)
);
GO

CREATE TABLE Dependent
(
	Essn CHAR(9) NOT NULL,
	Dependent_name VARCHAR(50) NOT NULL,
	Sex CHAR(1) CHECK (Sex IN ('M','F')),
	Bdate DATE,
	Relationship VARCHAR(30),

	PRIMARY KEY (Essn, Dependent_name)
);
GO

-- ===========================================
-- Foreign Key Constraints
-- ===========================================

-- Employee belongs to a Department
ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Department
FOREIGN KEY (Dno)
REFERENCES Department(Dnumber);

-- Employee supervises Employee (recursive relationship)
ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Supervisor
FOREIGN KEY (Super_ssn)
REFERENCES Employee(Ssn);

-- Department manager 
ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY (Mgr_ssn)
REFERENCES Employee(Ssn);

-- Department Locations
ALTER TABLE Dept_Locations
ADD CONSTRAINT FK_DeptLocations_Department
FOREIGN KEY (Dnumber)
REFERENCES Department(Dnumber);

-- Project belongs to Department
ALTER TABLE Project
ADD CONSTRAINT FK_Project_Department
FOREIGN KEY (Dnum)
REFERENCES Department(Dnumber);

-- Works_On references Employee
ALTER TABLE Works_On
ADD CONSTRAINT FK_WorksOn_Employee
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn);

-- Works_On references Project
ALTER TABLE Works_On
ADD CONSTRAINT FK_WorksOn_Project
FOREIGN KEY (Pno)
REFERENCES Project(Pnumber);

-- Dependent belongs to Employee
ALTER TABLE Dependent
ADD CONSTRAINT FK_Dependent_Employee
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn);
GO

-- ===========================================
-- CRUD Operations
-- ===========================================

-- INSERT STATEMENTS

-- 1. Insert Departments
INSERT INTO Department (Dnumber, Dname, Mgr_ssn, Mgr_start_date)
VALUES
(1, 'HR', NULL, '2024-01-01'),
(2, 'IT', NULL, '2024-01-01');
GO

-- 2. Insert Employees
INSERT INTO Employee
(Ssn, Fname, Minit, Lname, Bdate, Address, Sex, Salary, Super_ssn, Dno)
VALUES
('111111111', 'Ahmed', 'A', 'Ali', '1985-05-10', 'Muscat', 'M', 3500.00, NULL, 1),
('222222222', 'Sara', 'M', 'Salim', '1992-07-15', 'Muscat', 'F', 2500.00, '111111111', 1),
('333333333', 'Omar', 'K', 'Hassan', '1990-03-20', 'Sohar', 'M', 3000.00, '111111111', 2);
GO

-- 3. Assign Managers to Departments
UPDATE Department
SET Mgr_ssn = '111111111'
WHERE Dnumber = 1;

UPDATE Department
SET Mgr_ssn = '333333333'
WHERE Dnumber = 2;
GO

-- 4. Insert Department Locations
INSERT INTO Dept_Locations (Dnumber, Dlocation)
VALUES
(1, 'Muscat'),
(2, 'Sohar');
GO

-- 5. Insert Projects
INSERT INTO Project (Pnumber, Pname, Plocation, Dnum)
VALUES
(101, 'Payroll System', 'Muscat', 1),
(102, 'Website Upgrade', 'Sohar', 2);
GO

-- 6. Insert Works_On Records
INSERT INTO Works_On (Essn, Pno, Hours)
VALUES
('111111111', 101, 20.5),
('222222222', 101, 35.0),
('333333333', 102, 40.0);
GO

-- 7. Insert Dependent
INSERT INTO Dependent
(Essn, Dependent_name, Sex, Bdate, Relationship)
VALUES
('111111111', 'Mariam', 'F', '2015-04-12', 'Daughter');
GO

-- UPDATE STATEMENTS

-- 1. Give Ahmed a Salary raise
UPDATE Employee
SET Salary = 4000.00
WHERE Ssn = '111111111';

-- 2. Reassign Omar to the HR department
UPDATE Employee
SET Dno = 1
WHERE Ssn = '333333333';

-- 3. Change the location of a project
UPDATE Project
SET Plocation = 'Nizwa'
WHERE Pnumber = 102;

-- 4. Update hours worked on a project
UPDATE Works_On
SET Hours = 38.5
WHERE Essn = '222222222'
AND Pno = 101;

-- 5. Correct the dependent relationship
UPDATE Dependent
SET Relationship = 'Child'
WHERE Essn = '111111111'
AND Dependent_name = 'Mariam';
GO

-- DELETE STATEMENTS

-- 1. Delete the dependent first
DELETE FROM Dependent
WHERE Essn = '111111111'
AND Dependent_name = 'Mariam';

-- 2. Delete the Works_On record
DELETE FROM Works_On
WHERE Essn = '333333333'
AND Pno	= 102;
GO