SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create database SampleProject_db
GO

CREATE TABLE [dbo].[Department](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

select * from department
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
set IDENTITY_INSERT ON
GO
insert into [dbo].[Employee] values('Arvind', 'Kumar', 'Sahu', '11/05/1998', 'M', 'Bihar', '9325860577', 'aksahub088@gmail.com', '08/06/2021', '08/06/2021', '09:00:00', '17:00:00', 0, 45000, 'Developer', 1)
CREATE TABLE [dbo].[Employee](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[MiddleName] [varchar](20) NULL,
	[LastName] [varchar](20) NOT NULL,
	[BirthDate] [date] NULL,
	[Gender] [char](1) NULL,
	[Address] [varchar](300) NULL,
	[ContactNumber] [nvarchar](10) NULL,
	[EmailId] [varchar](100) NULL,
	[JoiningDate] [date] NULL,
	[ConfirmationDate] [date] NULL,
	[ExpectedInTime] [time](7) NULL,
	[ExpectedOutTime] [time](7) NULL,
	[IsResigned] [bit] NULL,
	[Salary] [decimal](18, 2) NULL,
	[Designation] [varchar](50) NULL,
	[DeptId] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DeptId])
REFERENCES [dbo].[Department] ([DeptId])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO

INSERT INTO DEPARTMENT VALUES ('HR');
INSERT INTO DEPARTMENT VALUES ('SALES');
INSERT INTO DEPARTMENT VALUES ('ACC');


  
 insert into [dbo].[Employee] values('Aman', '', 'Priyadarshi', '11/05/1998', 'M', 'Bihar', '9325860577', 'aksahub088@gmail.com', '08/06/2021', '08/06/2021', '09:00:00', '17:00:00', 0, 45000, 'Developer', 1)

 insert into [dbo].[Employee] values('Shubham', '', 'Kumar', '11/05/1998', 'M', 'Bihar', '9325860577', 'aksahub088@gmail.com', '08/06/2021', '08/06/2021', '09:00:00', '17:00:00', 0, 45000, 'Developer', 1)

 insert into [dbo].[Employee] values('Md.', 'Shakib', '', '11/05/1998', 'M', 'Bihar', '9325860577', 'aksahub088@gmail.com', '08/06/2021', '08/06/2021', '09:00:00', '17:00:00', 0, 45000, 'Developer', 1)
SELECT * FROM DEPARTMENT;
SELECT * FROM Employee;














select * from DEPARTMENT
insert into DEPARTMENT values (20, 'Development')

insert into DEPARTMENT values (30, 'Accounting')



SET IDENTITY_INSERT employee ON;

alter proc INSERTEMPLOYEE_SP (@eno int, @name varchar(20), @date Datetime, @sal numeric(10,2)) as
begin
	Insert into EMPLOYEE(EMPNO, EMPNAME, HIREDATE, SALARY, DEPTNO) values(@eno, @name, @date, @sal, 30)
end

Exec INSERTEMPLOYEE_SP 3, 'Birendra', '01/06/2021', 45000 



select * from employee



 
 select * from DEPT
 select * from EMP


 select * from Products

