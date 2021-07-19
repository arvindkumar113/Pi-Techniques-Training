


-------- Sql Query practicising --------

--creating new database Practice
create database Practice
Go
--default database is master and so to go to Practice
use Practice

create table Dept
(
	DeptNo numeric(3) not null Primary key,
	Dename varchar(20) not null
)
go

create table Employee
(
	EmpNo numeric(4) not null identity(1,1) primary key,
	EmpName varchar(20) not null,
	DeptNo numeric(3) not null references Dept(DeptNo),
	Desig varchar(20) check( Desig in ('ceo', 'developer', 'manager')),
	HireDate Datetime null default getdate(),
	Salary numeric(10,2) not null,
	Mgr numeric(4) null references Employee(EmpNo)
)
go
drop table Employee

SELECT * FROM EMPLOYEE
SELECT * FROM Dept

---insert data into department

insert into Dept(Dename, DeptNo) values('ceo', 10)
insert into Dept(Dename, DeptNo) values('developer', 30)
insert into dept(Dename, DeptNo) values ('manager', 20)


Insert into Employee(EmpName, deptno, desig, salary, hiredate) values( 'Arvind', 10, 'ceo',10000000, '11/05/2021')
insert into employee values('aman', 20, 'manager','10/06/2021', 100000, 2)

insert into employee values('himanshu', 20, 'manager','10/06/2021', 100000, 2)
insert into employee values('shakib', 20, 'manager','10/06/2021', 100000, 2)
insert into employee values('shubham', 20, 'manager','10/06/2021', 100000, 2)

insert into employee values('munale', 20, 'developer','10/06/2021', 400000, 4)
insert into employee values('rakesh', 20, 'developer','10/06/2021', 400000, 5)
insert into employee values('meera', 20, 'developer','10/06/2021', 400000, 6)
insert into employee values('julie', 20, 'developer','10/06/2021', 400000, 4)
insert into employee values('bhavana', 20, 'developer','10/06/2021', 400000, 5)


select * from employee 
select * from Dept

	INSERT INTO Dept VALUES (40, 'SALES')

-- PRIYA JOINING AS DEVELOPER ON 1 JUNE 2021 AND HER SALARY IS 125000
insert into employee(empname, salary, hiredate, deptno) values('Priya', 125000, '01/06/2021', 30)

alter table employee add Gender char(1) not null default 'M'

alter table employee drop column Gender

alter table employee drop constraint DF__Employee__Gender__300424B4


drop table employee
drop table Dept


CREATE DATABASE TRAINING;

USE TRAINING

SELECT GETdATE()

CREATE TABLE DEPARTMENT
(	DEPTNO NUMERIC(3) NOT NULL PRIMARY KEY,
	DEPTNAME VARCHAR(10) NOT NULL UNIQUE
	)

	CREATE TABLE EMPLOYEE
	(	EMPNO NUMERIC(4) IDENTITY(1,1) NOT NULL PRIMARY KEY,
		EMPNAME VARCHAR(20) NOT NULL,
			DESIG VARCHAR(20) NULL CHECK(DESIG IN('CEO', 'MANAGER','DEVELOPER')),
			HIREDATE DATETIME NULL DEFAULT GETDATE(),
			MGR NUMERIC(4) NULL REFERENCES EMPLOYEE(EMPNO),
			SALARY NUMERIC(10,2) NULL CHECK (SALARY>=5000),
			DEPTNO NUMERIC(3) NOT NULL REFERENCES DEPARTMENT(DEPTNO)
		)

	SELECT * FROM EMPLOYEE
	SELECT * FROM DEPARTMENT

	SP_HELP 'DEPARTMENT'

	SP_HELP 'EMPLOYEE'


	INSERT INTO DEPARTMENT VALUES (10, 'SALES')

	INSERT INTO EMPLOYEE VALUES ('ARVIND', 'DEVELOPER',4, NULL, 30000, 10)

	UPDATE EMPLOYEE SET DESIG='DEVELOPER', SALARY =100000 WHERE EMPNO =10

	SELECT * FROM EMPLOYEE

	-- PRIYA JOINING AS DEVELOPER ON 1 JUNE 2021 AND HER SALARY IS 125000
	INSERT INTO EMPLOYEE VALUES ('PRIYA', 'DEVELOPER', 4, NULL, 125000, 10)

	SELECT * FROM EMPLOYEE

	UPDATE EMPLOYEE SET DESIG='MANAGER' HIREDATE '14/06/2021', SALARY = 150000 WHERE EMPNO=2

		SELECT * FROM EMPLOYEE


		ALTER TABLE EMPLOYEE ADD GENDER CHAR(1) NULL

		UPDATE EMPLOYEE SET GENDER='M' WHERE EMPNO=1


		ALTER TABLE EMPLOYEE DROP COLUMN GENDER 


		SELECT * FROM EMPLOYEE
		sp_help employee

		ALTER TABLE EMPLOYEE ADD GENDER CHAR(1) NOT NULL DEFAULT 'M'

		SELECT * FROM EMPLOYEE

		UPDATE EMPLOYEE SET GENDER='F' WHERE EMPNO=2

		SELECT * FROM EMPLOYEE

	DELETE FROM DEPARTMENT WHERE DEPTNO=10


SP_HELP 'EMPLOYEE'

ALTER TABLE EMPLOYEE DROP CONSTRAINT FK__EMPLOYEE__DEPTNO__2A4B4B5E

SP_HELP 'EMPLOYEE'


ALTER TABLE EMPLOYEE ADD CONSTRAINT FK__EMPLOYEE__DEPTNO FOREIGN KEY (DEPTNO)
REFERENCES DEPARTMENT(DEPTNO) ON DELETE CASCADE --ON DELETE CASCADE


ALTER TABLE EMPLOYEE DROP CONSTRAINT FK__EMPLOYEE__DEPTNO


ALTER TABLE EMPLOYEE ADD CONSTRAINT FK__EMPLOYEE__DEPTNO__2A4B4B5E FOREIGN KEY (DEPTNO)
REFERENCES DEPARTMENT(DEPTNO) ON DELETE SET NULL ON UPDATE CASCADE

SP_HELP EMPLOYEE


ALTER TABLE EMPLOYEE ADD CONSTRAINT FK__EMPLOYEE__DEPTNO FOREIGN KEY (DEPTNO)
REFERENCES DEPARTMENT(DEPTNO) ON DELETE SET NULL ON UPDATE CASCADE


-----tricky question ---

SELECT 1 + '1'
-- output is 2

SELECT 1 + '1.0'
-- output will give error since 1 is integer and 1.0 is float

SELECT 1.0 + '1.0'
--output is 2.0



---------SQL Querry starts now------

CREATE TABLE DEPT
(
	DEPTNO int not null constraint DEPT_deptno_pk1 primary key,
    DNAME VARCHAR(14) CONSTRAINT DEPT_Dname_UNQ UNIQUE,
    LOC VARCHAR(13)
)
Go


INSERT INTO DEPT VALUES (10, 'ACCOUNTING', 'NEW YORK');
INSERT INTO DEPT VALUES (20, 'RESEARCH',   'NEW YORK');
INSERT INTO DEPT VALUES (30, 'SALES',      'BOSTON');
INSERT INTO DEPT VALUES (40, 'OPERATIONS', 'BOSTON');

SELECT * FROM DEPT




CREATE TABLE EMP
(
	EMPNO int NOT NULL CONSTRAINT EMP_EMPNO_PK PRIMARY KEY,
    ENAME VARCHAR(30),
    JOB VARCHAR(9),
    MGR int CONSTRAINT EMP_MGR_SK REFERENCES EMP(EMPNO),
    HIREDATE DATETIME,
    SAL NUmeric(7, 2),
    COMM Numeric(7, 2),
    DEPTNO int CONSTRAINT EMP_DEPTNO_FK REFERENCES DEPT(DEPTNO)
)
GO


INSERT INTO EMP VALUES
        (7839, 'KING',   'PRESIDENT', NULL, '11/17/1981' , 5000, NULL, null)
INSERT INTO EMP VALUES
        (7566, 'JONES',  'MANAGER',   7839, '04/2/1981',  2975, NULL, 20)
INSERT INTO EMP VALUES
        (7698, 'BLAKE',  'MANAGER',   7839,'05/01/1985',  2975, NULL, 30)
INSERT INTO EMP VALUES
        (7782, 'CLARK',  'MANAGER',   7839, '06/09/1985',  2450, NULL, 10)
INSERT INTO EMP VALUES
        (7999, 'JOHN_MILLER', 'MANAGER',  7839, '01/01/2011' , 4000, NULL, 10)
INSERT INTO EMP VALUES
        (7788, 'SCOTT',  'ANALYST',   7566, '12/09/1982' , 3000, NULL, 20)
INSERT INTO EMP VALUES
        (7902, 'FORD',   'ANALYST',   7566, '12/03/1981' ,  3000, NULL, 20)
INSERT INTO EMP VALUES
        (7499, 'ALLEN',  'SALESMAN',  7698,'02/20/1985', 1600,  300, 30)
INSERT INTO EMP VALUES
        (7521, 'WARD',   'SALESMAN',  7698, '02/22/1981', 1250,  500, 30)
INSERT INTO EMP VALUES
        (7654, 'MARTIN', 'SALESMAN',  7698, '09/28/1991', 1250, 1400, 30)
INSERT INTO EMP VALUES
        (7844, 'TURNER', 'SALESMAN',  7698, '09/08/1985' ,  1500,    0, 30)
INSERT INTO EMP VALUES
        (7900, 'JAMES',  'CLERK',     7698, '12/03/1981' ,   950, NULL, 30)
INSERT INTO EMP VALUES
        (7369, 'SMITH',  'CLERK',     7902, '12/17/1980', 800, NULL, 20)
INSERT INTO EMP VALUES
        (7876, 'ADAMS',  'CLERK',     7788, ' 01/12/2003', 1100, NULL, 20)
INSERT INTO EMP VALUES
        (7934, 'MILLER', 'CLERK',     7782, '01/23/2003' , 1300, NULL, 10)


		SELECT * FROM EMP

		SELECT * FROM DEPT


--1	LIST ALL EMPS WHO ARE WORKING IN DEPT 20 AND EARNING MORE THEN 2500
select * from EMP WHERE DEPTNO=20 AND SAL>2500

--2	LIST ALL EMPS WHOSE JOB IS EITHER MANAGER OR CLERK OR ANALYST
SELECT * FROM EMP WHERE JOB IN ('MANAGER', 'CLERK', 'ANALYST')

--3	LIST ALL EMPS WHO ARE WORKING AS CLERK IN DPET 10 OR MANAGER FORM DEPT 30
SELECT * FROM EMP WHERE (DEPTNO=10 AND JOB='CLERK') OR (JOB='MANAGER' AND DEPTNO=30)

--4	LIST ALL EMPS WHOSE SALARY IN RANGE OF 3000 TO 5000
SELECT * FROM EMP WHERE SAL>=3000 AND SAL<=5000
SELECT * FROM EMP WHERE SAL BETWEEN 3000 AND 5000

--5	Find the employees whose commission is greater than 50 percent of his salary. 
SELECT * FROM EMP WHERE COMM > 0.5*SAL

--6	LIST ALL EMPS WHOSE COMM IS NOT NULL (means who are earning commission)
SELECT * FROM EMP WHERE COMM IS NOT NULL



--1	LIST ALL EMPS WHOSE NAME ENDS WITH N
SELECT * FROM EMP WHERE ENAME LIKE '%N'

--2	LIST ALL EMP WHOSE NAME CONTAINS I
SELECT * FROM EMP WHERE ENAME LIKE '%I%'

--3	LIST ALL EMP WHOSE NAME START WITH A OR M OR S
SELECT * FROM EMP WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%' OR ENAME LIKE 'S%'

--4	LIST ALL EMP WHOSE NAME START WITH A...M  (A,B,C,...M)
SELECT * FROM EMP WHERE ENAME LIKE '[A-M]%'

--5	LIST ALL EMP WHOSE NAME DOES NOT START WITH J OR W
SELECT * FROM EMP WHERE ENAME NOT LIKE 'J%' AND ENAME NOT LIKE 'W%'

--6	list all emp whose name contains vowel o or u or e, either at 2 position or at second last position
SELECT * FROM EMP WHERE ENAME LIKE '_O%' OR ENAME LIKE '_U%' OR ENAME LIKE '_E%' OR ENAME LIKE '%U_' OR ENAME LIKE '%O_' OR ENAME LIKE '%E_'

--7	LIST ALL EMP WHOSE NAME CONTAINS _   (ANS IS JOHN_MILLER)
SELECT * FROM EMP WHERE ENAME LIKE '%[_]%'

--8 LIST ALL EMP WOSE NAME HAS ONLY 5 CHAR
SELECT * FROM EMP WHERE LENGTH (ENAME) = 5

SELECT * FROM EMP WHERE LEN(ENAME) = 5;
----LENGTH IS NOT RECOGNISABLE IN SQL AND SO USE 'LEN'


--MULTIPLE COLUMN SORING (ORDER BY CLAUSE)

--LIST ALL EMPLOYEE AS PER THE JOB
SELECT * FROM EMP ORDER BY JOB

--LIST ALL EMPLOYEE AS PER THE SALARY HIGHEST TO LOWEST
SELECT * FROM EMP ORDER BY SAL DESC

--LIST ALL EMPLOYEE AS PER THE HIREDATE OLDEST FIRST
SELECT * FROM EMP ORDER BY HIREDATE 



--------MULTIPLE COLUMN SORING

--LIST ALL EMPLOYEE AS PER THE DEPARTMENT
SELECT * FROM EMP ORDER BY JOB

SELECT * FROM EMP ORDER BY DEPTNO

--LIST ALL EMPLOYEE NAME , JOB, SALARY, COMMISION
SELECT ENAME, JOB, SAL, COMM FROM EMP

--ADD A COLUMN AS NETSAL AS SAL+COMM
SELECT *, ISNULL(COMM, 0)+SAL AS NET_SAL FROM EMP

--SORT NETSAL AS PER H TO L
SELECT *, ISNULL(COMM, 0)+SAL AS NET_SAL FROM EMP ORDER BY NET_SAL

--SORT NETSAL AS PER H TO L WHERE NETSAL>2500
SELECT *, ISNULL(COMM, 0)+SAL AS NET_SAL FROM EMP WHERE ISNULL(COMM,0)+SAL>2500 ORDER BY NET_SAL

--FIND NET SAL EXPENDATURE OF ORGANIZATION
SELECT SUM(ISNULL(COMM,0)+SAL) FROM EMP

--DEPARTMENT WISE TOTAL SALARY
SELECT SUM(ISNULL(COMM,0)+SAL) FROM EMP GROUP BY DEPTNO

--FOR EACH DEPARTMENT COUNT NUMBER OF EMPLOYEE
SELECT DEPTNO, COUNT(EMPNO) AS EMP_COUNT FROM EMP GROUP BY DEPTNO

--FOR EACH DEPT PRINT HIGHEST ND LOWEST SALARY
SELECT DEPTNO, MAX(SAL) AS MAX_SALARY, MIN(SAL) AS MIN_SALARY FROM EMP GROUP BY DEPTNO

--LIST DEPTWISE, JOBWISE EMPCOUNT
SELECT DEPTNO, JOB, COUNT(JOB) AS JOB_COUNT FROM EMP GROUP BY DEPTNO, JOB ORDER BY DEPTNO

--DEPT WISE JOB COUNT
SELECT DEPTNO, COUNT(JOB) FROM EMP GROUP BY DEPTNO

--DEPARTMENT WISE EMPLOYEE COUNT


--LIST ALL DEPARTMENT HAVING MORE THAN 4 EMPLOYEE



-----DISTINCT
--LIST TYPES OF JOBS
SELECT DISTINCT JOB FROM EMP

--LIST TOP 3 HIGHEST PAID EMPLOYEE






------------date manipulation----------

select getdate(), dATEpart(dd, getdate()) as day

SELECT GETDATE(), DATEPART(MM, GETDATE()) AS MONTH, DATENAME(MM, GETDATE())

select Day(getdate()), Month(getdate()), Year(getdate())

--time in 12 hrs format
SELECT FORMAT(GETDATE(),'hh:mm') as Time 

--time in 24hrs format
select format(getdate(), 'HH:mm') as Time

--using convert function
SELECT CONVERT(VARCHAR(9),getdate(),108) 
SELECT cast(DATEPART(hour, GETDATE()) as varchar) + ':' + cast(DATEPART(minute, GETDATE()) as varchar)



--time in AM/PM format
SELECT  CONVERT(VARCHAR(5), GETDATE(), 108) + 
(CASE WHEN DATEPART(HOUR, GETDATE()) > 12 THEN ' PM'
    ELSE ' AM'
END) 'Hour:Minutes'
--or
SELECT  Format(GETDATE(), 'hh:mm') + 
(CASE WHEN DATEPART(HOUR, GETDATE()) > 12 THEN ' PM'
    ELSE ' AM'
END) 'Hour:Minutes'



--ADDING OR SUBSTRACTING DAY AND MONTH

SELECT GETDATE(), DATEADD(MM,6, GETDATE()), DATEADD(DD, 180, GETDATE()), DATEADD(DD,-180, GETDATE()), DATEADD(MM,-6, GETDATE())


SELECT DATEDIFF(DD,'01/01/2021', GETDATE()), DATEDIFF(MM,'01/01/2021', GETDATE())

select convert(varchar, getdate(), 4)


select convert(varchar, getdate(), 0)	

select convert(varchar, getdate(), 113)	

select convert(varchar, getdate(), 13)	

select convert(nvarchar, getdate(), 130)


--FORMAT AND CULTURE
SELECT FORMAT (getdate(), 'd', 'es-bo') as date

SELECT FORMAT (getdate(), 'd', 'HI-IN') as date

SELECT FORMAT(1233746278837, 'N', 'HI-IN') AS 'INDIA', FORMAT(1233746278837, 'N', 'EN-US') AS 'US'


--number rounding and format
select abs(-130)
select round(1256.6654,2)
select format(1256.4576, '0.00')

select ceiling(121.33)
select floor(121.99)
SELECT FORMAT(1256.22276,'0')

--CONDITIONAL CHECKING IN QUERRY

--1. select ename, comm and comm_status from emp 
-- where comm=0 then 'earning zero commision'
--else if comm >0 then 'earning commision'
--else not earning comision

select ename, comm,
case
	when comm=0 then 'earning zero commision'
	when comm is null then 'not earning commision'
	else 'earning commision'
end
as [earning commision ] from emp order by comm desc


-------OVER CLAUSE

select ROW_NUMBER() over(order by sal desc) as Rank, * from emp
-- row_number() is used to  make a row number on the any other column using over clause

------DENSE RANK AND RANK
select ROW_NUMBER() over(order by sal desc) as SNO, rank() over(order by sal desc) as Rank, DENSE_RANK() over(order by sal desc) as Dense_Rank, * from EMP

----------SQL ASSIGNMENT 2 CLAUSE AND FUNCTIONS----------------

--1. LIST empname, hiredate and the no of years completed by each employee in organization
select ename, hiredate, datediff(yy,hiredate,getdate()) as [Years Completed] from emp

--2. LIST ALL EMP WHO HAVE JOINED BEFORE 2000
select * from emp where datepart(yyyy,hiredate) < 2000


--3 LIST ALL EMP WHO HAVE COMPLETED 35 YEARS OF SERVICE ---DONE---
select * from emp where datediff(yyyy, hiredate, getdate())>35


--4 LIST ALL EMP AS PER THE MONTH OF JOINING IRRESPECITVE OF THE YEARS . EXAMPLE JAN, FEB .... DEC
select * from emp order by datepart(mm, hiredate) 


--5 LIST ALL EMP WHO HAVE JOINED IN DEC 81
select * from emp where datepart(mm, hiredate) =12 and datepart(yyyy, hiredate) =1981


--6		LIST EACH YEAR   IN WHICH ALL EMP HAVE JOINED
select *, datepart(yyyy, hiredate) as Joined_Year from emp order by datepart(yyyy, hiredate) asc


--7		For each employee display the number of days passed since the employee joined the company
select *, datediff(dd, hiredate, getdate()) as [day completed] from emp order by [day completed] desc

--8		list empname, hiredate and dayoftheweek when employee joined the organization
select ename, hiredate, datename(WEEKDAY, hiredate) as DayOfTheWeek from emp

--9		LIST THE YEAR AND TOTAL NO OF EMP JOINED IN THAT YEAR  
-- 		1981		3
-- 		1985		5
select datepart(yyyy, hiredate) as Year, count(ename) as [Employee Joined] from emp group by datepart(yyyy, hiredate)

--10	LIST FULL DETAILS OF OLDEST  EMPLOYEE
select * from emp where hiredate = (select min(hiredate) from emp)
select top 1 * from emp order by hiredate


--11 DISPLAY NAME IN PROPER FORMAT LIKE Smith, Allen, Ward
select initcap(ename) as name from emp 

select 
        upper(left(ENAME, 1))+ lower(RIGHT(ENAME, len(ename)-1) )
     from EMP



--12  All employees who are not receiving commission are 
--entitled  to Rs. 250 as an additional amount,  show the net earnings  of all employees
select *, 
case
	when comm is null then sal+250
	when comm=0 then sal+250
	else sal+comm
	end as Net_Earnings from emp


--13
 ---- Display the name, job and bonus for all employees, 
 --assuming all managers gets a bonus of Rs. 500, 
 --clerk gets Rs. 200 
 --and all other except president get Rs. 350. 
 --The president gets 20% of his salary as bonus
 select ename, job,
 case
	when job='manager' then 500
	when job='clerk' then 200
	when job='president' then sal*0.2
	else 350
end as Bonus from EMP order by Bonus desc
 
--14	 Find the  job of the employees receiving commission
select * from emp where comm is null or comm !=0 order by SAL


--15	 Show the daily salary of all employees assuming a month has 30 days without any decimal
select *,cast(sal/30 as int) as Daily_Salary from EMP

--16	display record of last joined employee
select top 1 * from emp order by hiredate desc
select * from emp where hiredate in (select Max(hiredate) from emp)


--17	list empname, hiredate, sal , comm and netsal in date, number and currency format of India
--use format unction
select ename, format(hiredate, 'dd/MM/yyyy')as HireDate, format(sal, 'N') as Salary, format(comm, 'N') as comm, format((sal+isnull(comm,0)), 'N') as Net_Sal from emp 


--18	show empoyee data as per year or joing
--for each year jan to dec give sr no 1, 2, ...
--year change again start number for 1
--HINT- Partition function
select ROW_NUMBER() over(partition by datepart(yyyy,hiredate) order by hiredate), * from emp group by datepart(yyyy, hiredate) 
 
--19	CASE SENSITIVE 
-- IN MS SQL SERVER HOW TO WORK ON CASE SENSITIVE DATA
SELECT * 
FROM EMP
WHERE   
    BINARY_CHECKSUM(ename) = BINARY_CHECKSUM('SMITH')
 ---or use collate with 
select * from emp where ENAME='SMITH' collate SQL_Latin1_General_CP1_CS_AS

--another way is to make whole database case sensative




---------------sub query ----------

CREATE TABLE CUSTOMER
(	CUSTOMERID NUMERIC(3) NOT NULL PRIMARY KEY,
	CUSTOMERNAME VARCHAR(20) NOT NULL,
	ADDRESS VARCHAR(20)
	)
	drop table CUSTOMER

	CREATE TABLE CATEGORY
	(	CATEGORYID NUMERIC(3) NOT NULL PRIMARY KEY,
		CATEGORYNAME VARCHAR(20) NOT NULL UNIQUE
	)

select * from CATEGORY
select * from PRODUCT	
	CREATE TABLE PRODUCT
	(	 PRODUCTID NUMERIC(3) NOT NULL PRIMARY KEY,
		 PRODUCTNAME VARCHAR(20) NOT NULL,
		 CATEGORYID NUMERIC(3) REFERENCES CATEGORY(CATEGORYID),
		 PRICE NUMERIC(10,2) CHECK (PRICE>50),
		 QUANTITY NUMERIC(3) CHECK (QUANTITY>0)
	)

drop table orders

	CREATE TABLE ORDERS
	(	ORDERYEAR NUMERIC(4),
		ORDERMONTH VARCHAR(20),
		ORDERID VARCHAR(20),
		ORDERDATE DATETIME DEFAULT GETDATE(),
		PRODUCTID NUMERIC(3) CONSTRAINT PRODUCT_PRODUCTID_FK REFERENCES PRODUCT(PRODUCTID),
		CUSTOMERID NUMERIC(3) CONSTRAINT CUSTOMER_CUSTOMERID_FK REFERENCES CUSTOMER(CUSTOMERID),
		ORDQRY NUMERIC(3) CHECK (ORDQRY>0),

		CONSTRAINT PK_ORDERS PRIMARY KEY (ORDERYEAR, ORDERMONTH, ORDERID)
	)


 --DEFAULT ADDRESS 'MUMBAI'
 select * from CUSTOMER
 INSERT INTO CUSTOMER VALUES(1, 'AJAY', 'MUMBAI')
 INSERT INTO CUSTOMER VALUES(2, 'CHIRAG', 'DELHI')
 INSERT INTO CUSTOMER VALUES(3, 'AMIT', 'PUNE')

 select * from CATEGORY
 INSERT INTO CATEGORY VALUES(1, 'FOOD')
 INSERT INTO CATEGORY VALUES(2, 'ELECTRONICS')
 INSERT INTO CATEGORY VALUES(3, 'STATIONARY')

select * from PRODUCT
 INSERT INTO PRODUCT VALUES(101, 'TEA', 1, 60, 100)
 INSERT INTO PRODUCT VALUES(102, 'PEN', 3, 80, 50)
 INSERT INTO PRODUCT VALUES(103, 'NOTEBOOK', 3, 125, 200)
 INSERT INTO PRODUCT VALUES(104, 'COFFEE', 1, 80, 100)
 INSERT INTO PRODUCT VALUES(105, 'TV', 2, 15000, 5)
 INSERT INTO PRODUCT VALUES(106, 'WASHINGMACHINE', 2, 12000, 3)


 INSERT INTO ORDERS (ORDERYEAR, ORDERMONTH, ORDERID, PRODUCTID, CUSTOMERID, ORDQRY) VALUES(2010, 1, 1, 101,2,10)

 select * from ORDERS
 INSERT INTO ORDERS(ORDERYEAR, ORDERMONTH, ORDERID, PRODUCTID,CUSTOMERID, ORDQRY) VALUES(2010, 1, 2, 104,1,2)
 INSERT INTO ORDERS(ORDERYEAR, ORDERMONTH, ORDERID, PRODUCTID,CUSTOMERID, ORDQRY) VALUES(2010, 2, 1, 105,2,1)
 INSERT INTO ORDERS(ORDERYEAR, ORDERMONTH, ORDERID, PRODUCTID,CUSTOMERID, ORDQRY) VALUES(2010, 2, 2, 101,1,5)
 INSERT INTO ORDERS(ORDERYEAR, ORDERMONTH, ORDERID, PRODUCTID,CUSTOMERID, ORDQRY) VALUES(2010, 2, 3, 106,2,1)
 INSERT INTO ORDERS(ORDERYEAR, ORDERMONTH, ORDERID, PRODUCTID,CUSTOMERID, ORDQRY) VALUES(2011, 1, 1, 104,1,2)


 select * from ORDERS
 SELECT * FROM CUSTOMER
 SELECT * FROM CATEGORY
 SELECT * FROM PRODUCT



 
------------------------ASSIGNMENT on SUB QUERY AND JOINS---------------------------------

--1	LIST COSTLIEST PRODUCT DETAILS
select * from product where price in (select max(price) from PRODUCT)

--2	PRINT ALL THE ORDERS PLACED BY CUSTOMER AJAY
select * from ORDERS where CUSTOMERID in (select CUSTOMERID from customer where customername ='ajay')


--3	LIST PRODUCTNAME, PRICE, QUANTITY AND CATEGORYNAME
select p.productname, p.price, p.quantity, c.categoryname from PRODUCT as p join CATEGORY as c on p.CATEGORYID=c.CATEGORYID


--4	LIST ORDERYEAR, ORDERMONTH, ORDERID, ORDERDATE, CUSTOMERNAME FOR ALL ORDERS
select o.orderyear, o.ordermonth, o.orderid, o.orderdate, c.customername from ORDERS as o join customer as c on o.CUSTOMERID=c.customerid


--5	LIST ALL THE ORDERS FOR THE CATEGORY ELECTRONICS
select * from ORDERS where PRODUCTID in (select PRODUCTID from PRODUCT where CATEGORYID in (select CATEGORYID from category where CATEGORYNAME='electronics'))


--6	LIST ALL THE ORDERS WHOSE PRICE IS GREATER THEN 1000
select * from  orders where PRODUCTID in (select PRODUCTID from PRODUCT where PRICE>1000)


--7	LIST ALL THE ORDERS FOR THE CUSTOMER CHIRAG PLACED FOR CATEGORY FOOD
select * from orders where customerid = (select customerid from customer where customername='chirag') and productid in (select productid from product where categoryid in( select categoryid from category where CATEGORYNAME='food'))



--8	LIST ORDERYEAR, ORDERMONTH, ORDERID, ORDERDATE, CUSTOMERNAME, 
--	CATEGORYNAME, PRODUCTNAME, PRICE, ORDERQTY, TOTAL(PRICE*ORDERQTY) FOR ALL ORDERS
select o.orderyear, o.ordermonth, o.orderid, o.orderdate, c.CUSTOMERNAME, d.categoryname, p.productname, p.price, o.ordqry, (p.price * o.ordqry) as Total from ORDERS as o join customer as c on o.CUSTOMERID=c.customerid join PRODUCT as p on o.PRODUCTID= p.PRODUCTID join category as d on p.CATEGORYID=d.CATEGORYID


--9	LIST TOTAL ORDERCOUNT, TOTALORDERQTY, TOTALVALUE OF ORDERS PLACE BY CUSTOMER AJAY
--	HINT: BELOW OUTPUT
--ORDERCOUNT	TOTALORDERQTY	TOTALVALUE
--    3			     9	    	  620.00
--RUNNING FINE
SELECT COUNT(O.ORDERID), SUM(O.ORDQRY), (O.ORDQRY * P.PRICE) AS [TOTAL VALUE] FROM ORDERS AS O JOIN PRODUCT AS P ON O.PRODUCTID=P.PRODUCTID WHERE CUSTOMERID IN (SELECT CUSTOMERID FROM CUSTOMER WHERE CUSTOMERNAME='AJAY') GROUP BY O.ORDQRY, P.PRICE

SELECT SUM(COUNT(O.ORDERID)), SUM(SUM(O.ORDQRY)), SUM((O.ORDQRY * P.PRICE)) AS [TOTAL VALUE] FROM ORDERS AS O JOIN PRODUCT AS P ON O.PRODUCTID=P.PRODUCTID WHERE CUSTOMERID IN (SELECT CUSTOMERID FROM CUSTOMER WHERE CUSTOMERNAME='AJAY') GROUP BY O.ORDQRY, P.PRICE


--10	LIST SUM OF  ORDERQTY  FROM ORDERS TABLE FOR CATEGORY ELECTRONICS 
--HINT
--TOTALORDERQTY
--     2
SELECT SUM(ORDQRY) AS TOTALORDERQTY FROM ORDERS WHERE PRODUCTID IN (SELECT PRODUCTID FROM PRODUCT WHERE CATEGORYID IN (SELECT CATEGORYID FROM CATEGORY WHERE CATEGORYNAME='ELECTRONICS')) GROUP BY ORDQRY


SELECT * FROM EMP

-- prind 3rd highest salary in employee table
SELECT Max(sal) AS [3RD HIGHEST SALARY] 
FROM   emp
WHERE  saL < (SELECT Max(sal) 
                 FROM   emp 
                 WHERE  saL NOT IN(SELECT Max(sal) 
                                      FROM   emp)) 



--ANOTHER SOLUTION
SELECT ename,sal from Emp e1 where 
        2 = (SELECT COUNT(DISTINCT sal)from Emp e2 where e2.sal > e1.sal) 
 SELECT * FROM EMP ORDER BY SAL DESC



 
------------------------Northwind assignments-----------------
--use database Northwind





 --select * from Products
--select * from Categories
--select * from CustomerCustomerDemo
--select * from CustomerDemographics
--select * from Customers
--select * from Employees
--select * from EmployeeTerritories
--select * from Orders
--select * from [order details]




--------------------Assignment -1   Northwind Queries-------

--Table: Customers
select * from Customers
--1. Display the “Company Name” and “Contact Name” from Customers table
SELECT [COMPANYNAME], [CONTACTNAME] FROM Customers
--2. Find the Customers who are staying wither in USA, UK, Germany, France
SELECT * FROM CUSTOMERS WHERE COUNTRY IN ('USA', 'UK', 'GERMANY', 'FRANCE')

--3. Find the Customers whose “Company Name” starts with G
SELECT * FROM CUSTOMERS WHERE COMPANYNAME LIKE 'G%'

--4. List all the Customers who are located in Paris
SELECT * FROM CUSTOMERS WHERE CITY ='PARIS'

--5. List the Customer details whose postal code start with 4
SELECT * FROM CUSTOMERS WHERE POSTALCODE LIKE '4%'

--6. List all the Customers who neither stay in Canada nor in Brazil
SELECT * FROM CUSTOMERS WHERE COUNTRY NOT IN ('CANADA', 'BRAZIL')

--7. Print total number of Customers for each country.
SELECT COUNT(CUSTOMERID) AS [TOTAL NUMBER OF CUSTOMER] FROM CUSTOMERS GROUP BY Country

--8. List Customers detail based on Country and City
SELECT * FROM CUSTOMERS ORDER BY COUNTRY, CITY

--9. List all the manager from the Customers table
SELECT * FROM CUSTOMERS WHERE CUSTOMERID IN (SELECT CUSTOMERID FROM EMPLOYEES )

--10. List all Customers details where “company name” contains aphostophy (‘)
SELECT * FROM  CUSTOMERS WHERE COMPANYNAME LIKE '%''%'




--------------------Table: Products----------
SELECT * FROM Products

--11. List all the products for CategoryID 4 and UnitsInStock is more then 50
SELECT * FROM PRODUCTS WHERE CATEGORYID=4 AND UnitsInStock>50

--12. List ProductName, UnitPrice, UnitsInStock, NetStock (i.e. UnitPrice * UnitsInStock)
SELECT PRODUCTNAME, UNITPRICE, UNITSINSTOCK, (UNITPRICE * UNITSINSTOCK) AS NETSTOCK FROM Products

--13. List Maximum and Minimum UnitPrice
SELECT MAX(UNITPRICE), MIN(UNITPRICE) FROM Products

--14. Count the number of products whose UnitPrice is more then 50
SELECT COUNT(PRODUCTID) AS [NUMBER OF PRODUCTS] FROM PRODUCTS WHERE UNITPRICE >50

--15. List product count base on CategoryID. List the data where count is more then 10
SELECT CATEGORYID, COUNT(PRODUCTID) AS [PRODUCT COUNT BASED ON CATEGORY ID] FROM PRODUCTS   GROUP BY CATEGORYID 

SELECT 
CASE
	WHEN COUNT(PRODUCTID)>10 THEN COUNT(PRODUCTID) 
END AS [PRODUCT COUNT], CATEGORYID
FROM PRODUCTS GROUP BY CATEGORYID
--16. Find all the products where UnitsInStock iS less than Reorder Level
SELECT * FROM PRODUCTS WHERE UnitsInStock < ReorderLevel

--17. List Category wise, Supplier wise product count
SELECT COUNT(PRODUCTID) AS PRODUCTCOUNT, SUPPLIERID, CATEGORYID FROM Products GROUP BY SupplierID, CategoryID ORDER BY SUPPLIERID, CategoryID

--18. All Products whose UnitsInStock is less than 5 units are entitles for placing order by 50 units for 
--others place the order by 30 units. Display ProductID, ProductName, UnitsInStock,
SELECT PRODUCTID, PRODUCTNAME,
CASE
	WHEN UNITSINSTOCK<5 THEN UNITSINSTOCK+50
	ELSE UNITSINSTOCK + 30
END AS [UNITS IN STOCK] FROM Products

SELECT * FROM Products


 
----------------OrderedUnits-------

--19. List 3 costliest product
SELECT TOP 3 * FROM PRODUCTS ORDER BY UnitPrice DESC

--20. List all the products whose CategoryID is 1 and SupplierID is either 10 or 12 or CategoryID is 4 
--and SupplierID is either 14 or 15.
SELECT  * FROM PRODUCTS WHERE (CategoryID=1 AND SupplierID IN (10,12)) OR (CategoryID=4 AND SupplierID IN (14, 15))



---------Table: Orders--------

SELECT * FROM Orders
--21. List all the orders placed in month of February
SELECT * FROM ORDERS WHERE DATEPART(MM, ORDERDATE)=2

--22. List year wise order count
SELECT COUNT(ORDERID) AS [YEAR WISE ORDER COUNT], DATEPART(YYYY, ORDERDATE) FROM ORDERS GROUP BY DATEPART(YYYY, OrderDate)

--23. List the ShipCountry for which total order placed is more than 100
--Example
--ShipCountry OrderCount
--USA 122
SELECT SHIPCOUNTRY, COUNT(ORDERID) FROM ORDERS GROUP BY ShipCountry HAVING COUNT(ORDERID)>100 

--24. List the data as per the order month (Jan – Dec)
SELECT * FROM ORDERS ORDER BY DATEPART(MM, ORDERDATE)

--25. List unique country name in ascending order where product is shipped
SELECT DISTINCT(SHIPCOUNTRY) FROM ORDERS ORDER BY ShipCountry

--26. List CustomerID, ShipCity, ShipCountry, ShipRegion from Ordrs table. If ShipRegion is null then 
--display message as “No Region”27. 
SELECT CUSTOMERID, SHIPCITY, SHIPCOUNTRY, 
CASE
	WHEN SHIPREGION IS NULL THEN 'No Region'
	ELSE SHIPREGION
END AS [SHIP REGION] FROM ORDERS  

--List the detail of first order placed
SELECT TOP 1 * FROM ORDERS

SELECT * FROM ORDERS WHERE ORDERDATE IN (SELECT MIN(ORDERDATE) FROM ORDERS)


--28. List Customer wise, Year wise (Order date) order placed
--Example
--CustomerID Year OrderCount
-- ANATR 1996 1
--BONAP 1997 8
SELECT CUSTOMERID, DATEPART(YYYY, ORDERDATE) AS YEAR, COUNT(ORDERID) AS [ORDER COUNT] FROM ORDERS GROUP BY CustomerID


--29. List all the orders handled by employeeid 4 for the month of December
SELECT * FROM ORDERS WHERE EmployeeID=4 AND DATEPART(MM, ORDERDATE) =12


--30. List employee wise , year wise, month wise ordercount
SELECT EMPLOYEEID, DATEPART(YYYY, OrderDate), DATEPART(MM, ORDERDATE), COUNT(ORDERID) FROM ORDERS GROUP BY EmployeeID



------Use Table: [Order Details]

--31. List all the data of [Order Details] table

--32. List ProductID, UnitPrice, Qty and Total. Sort data on Total column with highest value on top

--33. In above query, 
--If Total is more than 10000 display 10% discount on Total cost
--If Total is more than 5000 display 5% discount on Total cost
--If Total is more than 3000 display 2% discount on Total cost
--else Rs. 300 as discount if total is more than 1000
--No discount for Total less than 1000


--34. List Total order placed for each OrderId


--35. List minimum cost and maximum cost order value



-------------------JOIN AND SUBQUERY ASSIGNMENT------------------------


--1 LIST ALL THE PRODUCTS DETAILS WHOSE CATEGORY IS SAME AS 'TOFU'


--2 LIST ALL THE PRODUCTS DETAILS FOR THE CATEGORY 'BEVERAGES'


--3 LIST ALL THE ORDERS PLACED BY THE COMPANY NAME "ISLAND TRADING"


--4 LIST COMPANY NAME AND NO OF ORDER COUNT PLACED BY EACH COMPANY


--5 LIST ORDERID, CUSTOMER_COMAPNAYNAME FOR ALL THE ORDERS WHICH ARE HANDLE BY THE EMPLOYEES WHOSE TITLE IS "SALES MANAGER"




--6 LIST 3RD HIGHEST COSTLIEST PRODUCT


--7 FOR THE PRODUCT TABLE DISPLAY PRODUCTNAME AND CATEGORYNAME. ARRANGE AS PER THE CATEGORYNAME


--8 FOR THE ORDERS TABLE DISPLAY ORDERID CUSTOMER_COMPANYNAME AND EMPLOYEE_FULLNAME


--9 LIST ORDERID, EMPLOYEE_FULLNAME, CUSTOMER_COMPANYNAME, CATEGORYNAME, SUPPLIER_COMPANYNAME, PRODUCTNAME, ORDERDETAIS_UNIRPRICE, ORDERDETAILS_QUANTITY , NETSTOCK


--10 LIST ALL THE ORDERS (ORDERID, PRODUCTNAME) PLACED BY THE CUSTOMER IN LONDON


--11 FOR THE COSTLIEST PRODUCT DISPLAY PRODUCTNAME, UNITPRICE, CATEGORYNAME, SUPPLIER_CONTACTNAME--12 LIST ALL THE PRODUCTNAME WHOSE ORDER PLACED IN MONTH OF AUGUST


--13 LIST ORDERID, QUANTITY FOR ALL THE ORDERS. ASSIGNED RANK AS PER THE HIGHEST OT LOWEST QUANTITY. DO NOT MISS ANY NUMBER
-- WHILE ASSIGNING THE RANK


--14 List all the products for the category “Dairy Product”


--15 List all the products which is supplied by the company “Bigfoot Breweries” for the category “Beverages”


--16 Print CategoryName , Supplier Comapny name and product count for each category and supplier
--17 PRINT REGION AND TERRITORYDESCRIPTION NAME IN ASCENDING ORDER


--18 PRINT EMPLOYEES NAME, REGION NAME, CITY AND COUNTRY --(check for the error, no region relationship)


--19 FOR EACH CATEGORIES PRINT CATEGORYNAME AND SUPPLIERS NAME


--20 PRINT EMPLOYEE TITLEOFCOURTESY, EMPLOYEE FIRST + LASTNAME , EMPLOYEE TITLE, MANAGER TITLEOFCURTASY, 
--MANAGER FIRSTNAME + LASTNAME, MANAGER TITL




------------NORTHWIND DATABASE – PROGRAMMING ASSIGNMENT----------


--1. WRITE A PROCEDURE WHICH TAKES CATEGORY NAME AS A PARAMETER AND RETURN 
--ALL PRODUCTS WHICH MATCH WITH THE CATEGORY NAME. IF NAME NOT EXIST PRINT 
--MESSAGE



--2. TAKE COUNTRY NAME AS THE PARAMETER AND RETURN ALL CUSTOMERS FROM THAT 
--COUNTRY


--3. WRITE INSERT, UPDATE AND DELETE PROCEDURE FOR EMPLOYEES TABLE. IF ANY 
--STATEMENT FAIL RAISE PROPER ERROR MESSAGE
--PARAMETER : 
--EMPLOYEEID LASTNAME FIRSTNAME TITLE TITLEOFCOURTESY BIRTHDATE HIREDATE ADDRESS CITY REGION POSTALCODE COUNTRY


--4. TAKE REGIONDESCRIPTION AS A PARAMETER
--PRINT REGIONDESCRIPTION, TERRITORY DESCRIPTION, AND EMPNAME


--5. PRODUCTS TABLE
--WRITE A PROCEDURE WHICH CHECKS UNITSINSTOCK AND UNITSONORDER
--DISPLAY ALL PRODUCTS DETAILS (PRODUCTNAME, UNITPRICE, UNITSINSTOCK, 
--UNITSONORDER, DIFFERENCE ) where UNITSONORDER is more then UNITSINSTOCK


--6. ORDER DETAILS TABLE
--TAKE ORDERID AS PARAMETER
--FOR THE ORDERID PRINT PRODUCTNAME, UNITPRICE, QUANTITY, DISCOUNT, TOTAL I.E 
--UNITPRICE * QUNATITY, DISCOUNTAMOUNT, FINAL PRICE I.E. TOTAL –DISCOUNT AMOUNT
--7. WRITE A PROCEDURE WHICH INSERT IN PRODUCTTABLE
--PARAMETER FOR PROCEDURE PRODUCTNAME, UNITPRICE AND CATEGORYNAME
--CHECK IF CATEGORYNAME EXIST THEN ADD PRODUCTS WITH EXISTING CATEGORYID
--IF CATEGORYNAME DOES NOT EXIST FIRST INSERT IN CATEGORY TABLE
--READ CATEGORYID WHICH IS IDENTITY FIELD
--AND INSERT NEW INSERTED ID IN PRODUCT TABLE AS CATEGORYID



--8. ORDERS TABLE
--TAKE YEAR AS PARAMETER TO PROCEDURE
--PRINT IN EACH QUARTER HOW MANY ORDERS BOOKED,
--EXAMPLE IN Q-1 100
 
 
 
 --Q-2 150 ….
--IF YEAR NOT EXIST PRINT ERROR MESSAGE


--9. TABLE ORDERS AND ORDER DETAILS –OUT PARAMETER
--TAKE YEAR AND MONTH AS PARAMETER AND RETURN
--TOTAL REVENUE GENERATED SUM(UNITPRICE * QTY – DISCOUNT)


--10. FOR EACH EMPLOYEE PRINT EMPLOYEE FULL NAME, BIRTHDATE, HIREDATE, AGE (IN 
--YEARS) AT THE TIME OF HIRING, RETIREMENT DATE. (60 YEARS)FUNCTIONS
--1. TAKE PRODUCTNAME AS PARAMETER AND RETURN UNITPRICE
--2. TAKE PRODUCTNAME AS PARAMETER AND RETURN UNITSINSTOCK AND 
--UNINTSONORDER



--3. TAKE POSTALCODE AS PARAMETER AND RETURN CUSTOMER NAME. IF POSTAL CODE IS 
--NOT VALID DISPLAY ERROR MESSAGE



--4. TAKE COUNTRY AS PARAMETER AND RETURN CITY AND POSTALCODE FOR A CUSTOMERS

--5. TAKE EMPLOYEE FIRSTNAME AND LASTNAME AS PARAMETER AND RETURN ALL 
--CUSTOMERS COMPANY NAME, CONTACTNAME, CONTACTTILE



--6. TAKE YEAR AND EMPLOYEENAME AND DISPLAY AMOUNT OF ORDERS HANDLE BY THE 
--EMPLOYEE IN A YEAR (SUM OF QUANTITY)



--7. TAKE YEAR AND MONTH AS PARAMETER AND RETURN NO OF ORDERS SHIPPED IN THE 
--GIVEN MONTH



--8. TAKE PRODUCTNAME AS PARAMTER AND RETURN TOTLA UNITS OF ORDER PLACED FOR 
--THE PRODUCT (SUM(ORDERED QUANTITY)
--Hint: use Products and [Order Details] table



--9. TAKE ORDERID AS PARAMETER AND RETURN TOTAL UNITS OF ORDER PLACE FOR THE 
--ORDERI
