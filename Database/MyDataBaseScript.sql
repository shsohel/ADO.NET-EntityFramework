USE MASTER
Go

/*object database : MySGHrDB   ******/
If DB_ID('MySGHrDB') Is not null
DROP DATABASE MySGHrDB
GO


CREATE DATABASE MySGHrDB
GO


ALTER DATABASE MySGHrDB MODIFY FILE (Name=N'MySGHrDB',Size=10MB,MaxSize=Unlimited,FileGrowth=1024KB)
GO

ALTER DATABASE MySGHrDB MODIFY FILE (Name=N'MySGHrDB_log',Size=9MB,MaxSize=100MB,FileGrowth=10%)
GO


USE MySGHrDB
GO

CREATE SCHEMA SGHR
GO

--Use MySGHrDB
--EXEC sp_helpdb MySGHrDB
--GO

--CREATE ROLE TABLE---

CREATE TABLE SGHR.HrDesignation
(
DegID int primary key identity(10, 1),
ForDegID AS ('DEG'+Right('000'+CAST(DegID AS Varchar(15)),10)+'SG'),
DegName varchar(20) not null
)
go

Select * FROM SGHR.HrDesignation
GO

Insert into SGHR.HrDesignation values ('Admin'), ('Officer'), ('Manager'),('Accountant')
Go


--CREATE USER TABLE--

CREATE TABLE SGHR.MyUser
(
UserID int primary key identity(1,1),
DegID int foreign key references SGHR.HrDesignation(DegID) ON DELETE CASCADE,
ForUserID AS ('USER'+Right('000'+CAST(USER AS Varchar(15)),10)+'SG'),
UserName varchar(20) not null,
Email varchar (20) not null,
Password varchar(10) not null,
IsActive bit, 
)
GO

INSERT INTO SGHR.MyUser Values (10, 'shsohel', 'Sohel20@gmail.com', 'sohel@123', 1)
Go



Select * FROM SGHR.MyUser
GO


CREATE TABLE SGHR.HrProject
(
ProID int primary key identity (800,1),
ProName varchar (20) not null,
RequireSkill varchar (20) not null,
SuperVisor varchar (20) not null,
ProDesc varchar (20) not null
)
GO

Select * FROM SGHR.HrProject
GO



CREATE TABLE SGHR.Departments
(
DeptID int primary key identity(200,1),
DeptName varchar (20) not null,
DeptType varchar(20) not null,
DeptDesc varchar (30) null
)
GO


SELECT * FROM SGHR.Departments 
GO

INSERT INTO SGHR.Departments  Values ('ICT','TECHNOLOGY','ICT')
Go

CREATE TABLE SGHR.Employees
(
EmpID int primary key identity(100,1) ,
EmpFirstName varchar(20) not null,
EmpLastName varchar(20) not null,
Gender varchar(10)  null,
MaritalStatus varchar(15)  null,
CellPhone varchar(15) null CHECK ((CellPhone like '[0][1][0-9][0-9][0-9] [0-9][0-9][0-9] [0-9][0-9][0-9]' or CellPhone like '018%')),
DOB datetime not null, 
Email varchar(30) null,
BloodGroup varchar (10) null, 
Address varchar(30) NOT NULL CONSTRAINT CN_CustomerAddress  DEFAULT ('UNKNOWN'),
JoiningDate datetime not null,
TerminationDate datetime null,
EmImage varbinary (max) null,
DeptID int FOREIGN KEY REFERENCES SGHR.Departments(DeptID) ON DELETE CASCADE,
DesignationId int FOREIGN KEY REFERENCES SGHR.HrDesignation(DegID) ON DELETE CASCADE,
IsActive bit
)
Go

--INSERT INTO SGHR.Employees  Values ('Sumon','Ahmed','Male','Single','01811275653',1/1/2010,'sumon@gmail.com','A+','Ctg','1/1/2017','1/1/2018','@C:\Users\SH SOHEL\Pictures\Screenshots\pci.png',200,1,10,1)
--Go

SELECT * FROM SGHR.Employees 
GO




CREATE TABLE  SGHR.Emp_DailyAttendence
(
AttnID int primary key identity (600, 1),
EmpID int foreign key references SGHR.Employees(EmpID) ON DELETE CASCADE,
StartTime datetime default getdate(),
EndTime datetime not null CONSTRAINT CN_EmployeeDefaultDateInSystem DEFAULT (getdate()) CHECK  ((EndTime<=getdate())),
Remarks varchar(10) null
)
Go

SELECT * FROM SGHR.Emp_DailyAttendence 
GO

CREATE TABLE SGHR.EmLeaveType
(
LeaveTypeID int primary key identity,
LeaveType varchar(15) not null,
LeaveDescription nvarchar(20) null
)
Go

SELECT * FROM SGHR.EmLeaveType 
GO

CREATE TABLE  SGHR.Emp_LeaveCalculation
(
EmpLeveID int primary key identity,
LeaveTypeID int foreign key references SGHR.EmLeaveType(LeaveTypeID) ON DELETE CASCADE,
EmpID int foreign key references SGHR.Employees(EmpID) ON DELETE CASCADE,
LeaveStartDate int not null,
LeaveEndDate int not null,
NumberOfDayLeave int not null,
)
Go


SELECT * FROM SGHR.Emp_LeaveCalculation 
GO

CREATE TABLE SGHR.Salary
(
SalID int primary key identity (111,1),
EmpID int foreign key references SGHR.Employees(EmpID) ON DELETE CASCADE,
SalType varchar (20) not null,
SalAmount varchar (30) not null,
SalMonth varchar (30) not null,
SalDesc varchar (30) not null
)
GO


SELECT * FROM SGHR.Salary 
GO

CREATE TABLE SGHR.AssignEmp
(
ProAssID int,
ProID int foreign key references SGHR.HrProject(ProID) ON DELETE CASCADE,
EmpID int foreign key references SGHR.Employees(EmpID) ON DELETE CASCADE
)
GO


SELECT * FROM SGHR.AssignEmp 
GO



-------for Department Table table---
Create proc sp_AllDepartments
(
@deptid int,
@deptname varchar (20) ,
@deptype varchar(20) ,
@depdesc varchar (30),
@operation varchar (20)
)
AS 
BEGIN
	BEGIN TRY
	BEGIN TRAN 
		IF(@operation = 'INSERT')
		
			INSERT into SGHR.Departments values (@deptname,@deptype,@depdesc)
			Print 'Your data inserted Successfully'
		

	
		 IF(@operation = 'UPDATE')
		
			UPDATE SGHR.Departments set DeptName=@deptname, DeptType=@deptype, DeptDesc=@depdesc
			Where DeptID=@deptid
			Print 'Your data UPDATED Successfully'



		IF(@operation = 'DELETE')
		
			DELETE FROM SGHR.Departments
			Where DeptID=@deptid
			Print 'Your data DELETED Successfully'

			IF(@operation = 'DISPLAY')
		
			SELECT * FROM SGHR.Departments
			Print 'SEE THE YOUR DATA'
		COMMIT TRAN
	END TRY
	BEGIN Catch 
		RollBack TRAN 
		Print 'Somethong Wrong'
	END CAtch
END

--Drop Proc sp_AllDepartments
Go

-------for Employee Table table---
Create proc sp_AllCRUDEmployee
(
@empid int,
@empfirstname varchar(20),
@emplastname varchar(20),
@gender varchar(10),
@maritalstatus varchar(15) ,
@cellphone varchar(15),
@dob datetime, 
@email varchar(30),
@bloodgroup varchar (10) , 
@address varchar(30),
@joiningdate datetime ,
@terminationdate datetime ,
@emimage varbinary (max) ,
@deptid int,
@designationid int,
@isactive bit,
@operation varchar(20)
)
AS 
BEGIN
	BEGIN TRY
	BEGIN TRAN 
		IF(@operation = 'INSERT')
		
			INSERT into SGHR.Employees values 
			(@empfirstname,@emplastname,@gender,@maritalstatus,@cellphone,@dob,
			@email,@bloodgroup,@address,@joiningdate,@terminationdate,@emimage,@deptid,@designationid,@isactive)
			Print 'Your data inserted Successfully'
		

	
		 IF(@operation = 'UPDATE')
		
			UPDATE SGHR.Employees set EmpFirstName= @empfirstname, EmpLastName= @emplastname,Gender= @gender,MaritalStatus= @maritalstatus,CellPhone= @cellphone,DOB= @dob,
			Email= @email, BloodGroup= @bloodgroup, Address=@address, JoiningDate= @joiningdate,TerminationDate=@terminationdate, EmImage= @emimage, DeptID= @deptid, DesignationId= @designationid, IsActive= @isactive
			Where EmpID=@empid
			Print 'Your data UPDATED Successfully'



		IF(@operation = 'DELETE')
		
			DELETE FROM SGHR.Employees
			Where EmpID=@empid
			Print 'Your data DELETED Successfully'
		
		COMMIT TRAN
	END TRY
	BEGIN Catch 
		RollBack TRAN 
		Print 'Somethong Wrong'
	END CAtch
END
