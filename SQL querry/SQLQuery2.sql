CREATE TABLE DEPT
       (DEPTNO int not null constraint DEPT_deptno_pk1 primary key,
        DNAME VARCHAR(14) CONSTRAINT DEPT_Dname_UNQ UNIQUE,
        LOC VARCHAR(13) )



INSERT INTO DEPT VALUES (10, 'ACCOUNTING', 'NEW YORK');
INSERT INTO DEPT VALUES (20, 'RESEARCH',   'NEW YORK');
INSERT INTO DEPT VALUES (30, 'SALES',      'BOSTON');
INSERT INTO DEPT VALUES (40, 'OPERATIONS', 'BOSTON');

SELECT * FROM DEPT


CREATE TABLE EMP
       (EMPNO int NOT NULL CONSTRAINT EMP_EMPNO_PK PRIMARY KEY,
        ENAME VARCHAR(30),
        JOB VARCHAR(9),
        MGR int CONSTRAINT EMP_MGR_SK REFERENCES EMP(EMPNO),
        HIREDATE DATETIME,
        SAL NUmeric(7, 2),
        COMM Numeric(7, 2),
        DEPTNO int CONSTRAINT EMP_DEPTNO_FK REFERENCES DEPT(DEPTNO))



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


		SELECT EMPNO , ENAME AS [EMP NAME], JOB, SAL AS SALARY FROM EMP

		SELECT * FROM EMP WHERE DEPTNO=30


--1	LIST ALL EMPS WHO ARE WORKING IN DEPT 20 AND EARNING MORE THEN 2500

SELECT ENAME FROM EMP WHERE DEPTNO=30 AND SAL>2500

--2	LIST ALL EMPS WHOSE JOB IS EITHER MANAGER OR CLERK OR ANALYST

SELECT ENAME FROM EMP WHERE JOB = 'MANAGER' OR JOB='CLERK' OR JOB='ANALYST'

--3	LIST ALL EMPS WHO ARE WORKING AS CLERK IN DPET 10 OR MANAGER FORM DEPT 30

SELECT ENAME FROM EMP WHERE (JOB='CLERK' AND DEPTNO=10) OR (JOB='MANAGER' AND DEPTNO=30)

--4	LIST ALL EMPS WHOSE SALARY IN RANGE OF 3000 TO 5000

SELECT * FROM EMP WHERE SAL>=3000 AND SAL<=5000

select * from emp where SAL between 3000 and  5000
--(between operator in inclusive in boundry.)

--5	Find the employees whose commission is greater than 50 percent of his salary. 

SELECT ENAME FROM EMP WHERE COMM>0.5*SAL


--6	LIST ALL EMPS WHOSE COMM IS NOT NULL (means who are earning commission)
SELECT ENAME FROM EMP WHERE COMM<>NULL -- WILL NOT WORK BECAUSE ANY OPERATOE DO NOT WORK WITH NULL

SELECT ENAME FROM EMP WHERE COMM!=NULL


SELECT * FROM EMP

--1	LIST ALL EMPS WHOSE NAME ENDS WITH N
SELECT ENAME FROM EMP WHERE ENAME LIKE '%N'

--2	LIST ALL EMP WHOSE NAME CONTAINS I
SELECT ENAME FROM EMP WHERE ENAME LIKE '%I%'

--3	LIST ALL EMP WHOSE NAME START WITH A OR M OR S
SELECT ENAME FROM EMP WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%' OR ENAME LIKE 'S%'

--4	LIST ALL EMP WHOSE NAME START WITH A...M  (A,B,C,...M)

SELECT EName FROM EMP WHERE ENAME LIKE '[A-M]%'
-- in MySQL => SELECT ENAME FROM EMP WHERE ENAME like '^[A-E].*$'


--5	LIST ALL EMP WHOSE NAME DOES NOT START WITH J OR W
SELECT ENAME FROM EMP WHERE ENAME NOT LIKE 'J%' OR ENAME NOT LIKE 'W%'

--6	list all emp whose name contains vowel o or u or e, either at 2 position or at second last position
SELECT ENAME FROM EMP WHERE ENAME LIKE '__O%' OR ENAME LIKE '__U%' OR ENAME LIKE '%O_' OR ENAME LIKE '%U_'

--7	LIST ALL EMP WHOSE NAME CONTAINS _   (ANS IS JOHN_MILLER)
SELECT ENAME FROM EMP WHERE ENAME LIKE '%[_]%'

SELECT ENAME FROM EMP WHERE ENAME LIKE '%\_%' ESCAPE \   
 --IN ORACLE

--LIST ALL EMPLOYEE AS PER THE JOB
SELECT * FROM EMP ORDER BY JOB

--LIST ALL EMPLOYEE AS PER THE SALARY HIGHEST TO LOWEST
SELECT * FROM EMP ORDER BY SAL DESC

--LIST ALL EMPLOYEE AS PER THE HIREDATE OLDEST FIRST
SELECT * FROM EMP ORDER BY HIREDATE 



--MULTIPLE COLUMN SORING


--LIST ALL EMPLOYEE AS PER THE DEPARTMENT
SELECT * FROM EMP ORDER BY DEPTNO, SAL DESC 

SELECT * FROM EMP ORDER BY DEPTNO, SAL DESC, COMM DESC


--LIST ALL EMPLOYEE NAME , JOB, SALARY, COMMISION
SELECT * FROM EMP ORDER BY ENAME, JOB, SAL DESC, COMM DESC


--ADD A COLUMN AS NETSAL AS SAL+COMM

SELECT ENAME, SAL, COMM, (SAL+ISNULL(COMM, 0) )AS NETSAL FROM EMP



--SORT NETSAL AS PER H TO L
SELECT ENAME, SAL, COMM, (SAL+ISNULL(COMM, 0)) AS NETSAL FROM EMP ORDER BY NETSAL


--SORT NETSAL AS PER H TO L WHERE NETSAL>2500

SELECT ENAME, SAL, COMM, (SAL+ISNULL(COMM, 0)) AS NETSAL FROM EMP WHERE (SAL+COMM)>2500 ORDER BY NETSAL 

--FIND NET SAL EXPENDATURE OF ORGANIZATION
SELECT SUM(SAL), MAX(SAL) AS MAXSAL, MIN(SAL) AS MINSAL, AVG(SAL) AS MINSAL, COUNT(COMM) AS TOTALCOUNT, COUNT(*) AS [*] FROM EMP

--DEPARTMENT WISE TOTAL SALARY
SELECT DEPTNO, SUM(SAL) FROM EMP GROUP BY DEPTNO



--FOR EACH DEPARTMENT COUNT NUMBER OF EMPLOYEE
SELECT JOB, SUM(EMPNO) FROM EMP GROUP  BY JOB

--FOR EACH DEPT PRINT HIGHEST ND LOWEST SALARY
SELECT DEPTNO, MAX(SAL) AS MAXSAL, MIN(SAL) AS MINSAL FROM EMP GROUP BY DEPTNO

--LIST DEPTWISE, JOBWISE EMPCOUNT
SELECT DEPTNO, JOB, COUNT(JOB) AS JOBCOUNT FROM EMP GROUP BY DEPTNO, JOB ORDER BY DEPTNO, JOB

--DEPT WISE JOB COUNT
SELECT DEPTNO, COUNT(JOB) AS JOBCOUNT FROM EMP GROUP BY DEPTNO ORDER BY JOBCOUNT

--DEPARTMENT WISE EMPLOYEE COUNT
SELECT DEPTNO, COUNT(EMPNO) FROM EMP GROUP BY DEPTNO

--LIST ALL DEPARTMENT HAVING MORE THAN 4 EMPLOYEE
SELECT DEPTNO, COUNT(EMPNO) FROM EMP  GROUP BY DEPTNO HAVING COUNT(EMPNO)>4  

--DISTINCT
--LIST TYPES OF JOBS
SELECT DISTINCT JOB FROM EMP

--LIST TOP 3 HIGHEST PAID EMPLOYEE

SELECT TOP 3 * FROM EMP ORDER BY SAL


SELECT * FROM EMP





--date manipulation

select getdate(), dATEpart(dd, getdate()) as day

SELECT GETDATE(), DATEPART(MM, GETDATE()) AS MONTH, DATENAME(MM, GETDATE())

SELECT GETDATE(), DATEPART(YY, GETDATE()) AS DATEYEAR

SELECT GETDATE(), DATEPART(YYYY, GETDATE()) AS YEAR

SELECT DAY(GETDATE()), MONTH(GETDATE()), YEAR(GETDATE()) 

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
select format(1256.4576,1, '0.00')

select ceiling(121.33)
select floor(121.99)
SELECT FORMAT(1256.22276, 0,'0')



--CONDITIONAL CHECKING IN QUERRY
SELECT ENAME, COMM,
CASE 
	WHEN COMM=0 THEN 'EARNING ZERO COMMISION'
	WHEN COMM IS NULL THEN 'NOT EARNING COMMISION'
	ELSE 'EARNING COMMISION'
END AS MSG
FROM EMP ORDER BY COMM DESC

--OVER CLAUSE
SELECT ROW_NUMBER() OVER (ORDER BY SAL DESC) AS SNO, * FROM EMP

--DENSE RANK AND RANK
SELECT ROW_NUMBER() OVER (ORDER BY SAL DESC) AS SNO,
RANK() OVER (ORDER BY SAL DESC) AS RANK, DENSE_RANK() OVER (ORDER BY SAL DESC) AS DRANK, * FROM EMP














-----SQL ASSIGNMENT 2 CLAUSE AND FUNCTIONS
SELECT * FROM EMP

--LIST empname, hiredate and the no of years completed by each employee in organization
SELECT ENAME, HIREDATE, datediff(year, hiredate, getdate()) as years FROM EMP

--LIST ALL EMP WHO HAVE JOINED BEFORE 2000
SELECT ENAME, HIREDATE FROM EMP WHERE DATEPART(YEAR, HIREDATE)<2000


--3		LIST ALL EMP WHO HAVE COMPLETED 35 YEARS OF SERVICE ---DONE---
SELECT ENAME, HIREDATE, datediff(year, hiredate, getdate()) as years FROM EMP WHERE DATEDIFF(YEAR, HIREDATE,GETDATE())>35

--4		LIST ALL EMP AS PER THE MONTH OF JOINING IRRESPECITVE OF THE YEARS . EXAMPLE JAN, FEB .... DEC
SELECT ENAME, HIREDATE, DATEPART(MONTH,HIREDATE) AS MONTHS FROM EMP ORDER BY MONTHS

--5		LIST ALL EMP WHO HAVE JOINED IN DEC 81
SELECT ENAME, HIREDATE, DATEPART(MONTH, HIREDATE) AS MONTHS, DATEPART(YEAR, HIREDATE) FROM EMP 
WHERE DATEPART(MONTH, HIREDATE)=12 AND DATEPART(YEAR, HIREDATE)=1981

--6		LIST EACH YEAR   IN WHICH ALL EMP HAVE JOINED
SELECT ENAME, HIREDATE, DATEPART(YEAR, HIREDATE) AS JOINED_YEAR FROM EMP 

--7		For each employee display the number of days passed since the employee joined the company
SELECT ENAME, HIREDATE, DATEDIFF(DAY, HIREDATE, GETDATE()) AS DAY_COMPLETED FROM EMP

--8		list empname, hiredate and dayoftheweek when employee joined the organization
SELECT ENAME, HIREDATE, DATENAME(DW, HIREDATE ) AS DAY_OF_JOINING FROM EMP 

--9		LIST THE YEAR AND TOTAL NO OF EMP JOINED IN THAT YEAR  
-- 1981		3
-- 1985		5
SELECT DATEPART(YEAR, HIREDATE) AS YEARS , COUNT(ENAME) FROM EMP GROUP BY DATEPART(YEAR, HIREDATE)

--10	LIST FULL DETAILS OF OLDEST  EMPLOYEE
SELECT TOP 1 * FROM EMP


--16	display record of last joined employee
SELECT TOP 1 * FROM EMP ORDER BY HIREDATE DESC



--11 DISPLAY NAME IN PROPER FORMAT LIKE Smith, Allen, Ward
select * from emp


--12  All employees who are not receiving commission are 
--entitled  to Rs. 250 as an additional amount,  show the net earnings  of all employees
SELECT *, ISNULL(COMM, 250)+SAL AS NET_SAL FROM EMP

SELECT *,
CASE
	WHEN COMM=0 THEN  250+SAL 
	ELSE  SAL
END AS NETSAL
FROM EMP



--13
 ---- Display the name, job and bonus for all employees, 
 --assuming all managers gets a bonus of Rs. 500, 
 --clerk gets Rs. 200 
 --and all other except president get Rs. 350. 
 --The president gets 20% of his salary as bonus
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
SELECT * FROM EMP WHERE COMM!=0 OR COMM IS NULL
SELECT * FROM EMP WHERE COMM!=0

--15	 Show the daily salary of all employees assuming a month has 30 days without any decimal
SELECT *, (SAL/30) AS dAILY_SAL FROM EMP


--16	display record of last joined employee
SELECT TOP 1 * FROM EMP ORDER BY  HIREDATE DESC


--17	list empname, hiredate, sal , comm and netsal in date, number and currency format of India
SELECT ENAME, HIREDATE, SAL, COMM, (SAL+ISNULL(COMM,0)) AS NET_SAL FROM EMP
--use format unction

--18	show empoyee data as per year or joing
--for each year jan to dec give sr no 1, 2, ...
--year change again start number for 1
--HINT- Partition function




select * from emp
 
--19	CASE SENSITIVE 
-- IN MS SQL SERVER HOW TO WORK ON CASE SENSITIVE DATA
SELECT * FROM EMP WHERE CAST(ENAME AS VARBINARY(40)) = CAST('smith' as varbinary(40))
--another way is to make whole database case sensative

select * from emp where ename='king' collate  SQL_Latin1_General_CP1_CS_AS



	













----------------ADVANCED QUERRY--------------

-- LIST ALL EMPLOYEE OF DEPARTMENT IN WHICH MARTIN IS WORKING
SELECT * FROM EMP WHERE DEPTNO=(SELECT DEPTNO FROM EMP WHERE ENAME='MARTIN')
--GOOD PRACTICE SAYS TO USE 'IN' INSTEAD OF '='

SELECT * FROM EMP WHERE DEPTNO IN(SELECT DEPTNO FROM DEPT WHERE LOC='NEW YORK')


--1		list all emp whose designation is same as BLAKE
SELECT * FROM EMP WHERE JOB IN (SELECT JOB FROM EMP WHERE ENAME='BLAKE')

--2		list all emp who are earning more then the average salary of the organization
SELECT ENAME FROM EMP WHERE SAL>(SELECT AVG(SAL) FROM EMP)


--3		list full detail (all column of emp table) of highest paid employee (without using Top n)
SELECT * FROM EMP WHERE SAL = (SELECT MAX(SAL) FROM EMP)



--4		list all emp whose sal is more then Allen and working
--in same deparment with Scott and 
--hireed in same year of Jones

SELECT ENAME FROM EMP WHERE SAL>(SELECT SAL FROM EMP WHERE ENAME='ALLEN') AND
DEPTNO=(SELECT DEPTNO FROM EMP WHERE ENAME='SCOTT') AND DATEPART(YYYY, HIREDATE)=(SELECT DATEPART(YYYY, 
HIREDATE) FROM EMP WHERE ENAME='JONES')

--5		list all emp whose manager is king
SELECT eNAME FROM EMP WHERE 
MGR IN ( SELECT MGR FROM EMP WHERE ENAME='KING')

--6		LIST ALL EMP WHOSE MANAGER'S MANGER IS KING
SELECT ENAME FROM EMP WHERE EMPNO IN ( SELECT EMPNO FROM  EMP WHERE EMPNO IN ( SELECT EMPNO WHERE ENAME='KING'))


--7		list all emp who are working in research department
SELECT ENAME FROM EMP WHERE DEPTNO IN ( SELECT DEPTNO FROM DEPT WHERE DNAME='RESEARCH')


--8		list all emp who are working in NEW YORK
SELECT * FROM EMP WHERE DEPTNO IN (SELECT DEPTNO FROM DEPT WHERE LOC='NEW YORK')

--9		print department name where all emps are earning commission
SELECT DNAME FROM DEPT WHERE DePTNO IN ( SELECT DEPTNO FROM EMP WHERE  COMM!=0)

--10		LIST ALL EMP WHO ARE WORKING IN BOSTON AND EARNING MORE THEN THE AVERAGE OF DEPT LOCATED IN BOSTON
SELECT ENAME FROM EMP WHERE DEPTNO IN (SELECT DEPTNO FROM DEPT WHERE LOC='BOSTON') 
AND SAL>( SELECT AVG(SAL) FROM EMP WHERE DEPTNO IN (SELECT DEPTNO FROM DEPT WHERE LOC='BOSTON')


SELECT * FROM EMP
SELECT * FROM DEPT







---------------------JOIN------------

-- EMPNAME, 
SELECT E.ENAME, E.JOB, E.SAL, D.DNAME, D.LOC FROM EMP AS E INNER JOIN DEPT AS D ON E.DEPTNO=D.DEPTNO

--LEFT JOIN

SELECT E.ENAME, E.JOB, E.SAL, D.DNAME, D.DEPTNO FROM EMP AS E LEFT JOIN DEPT AS D ON E.DEPTNO=D.DEPTNO



-- PRINT DEPARTMENT NAME AND EMPLOYEE COUNT FOR EACH DEPT 
SELECT D.DNAME AS 'DEPARTMENT NAME', COUNT(EMPNO) AS 'NO OF EMPLOYEE' FROM DEPT AS D LEFT JOIN EMP ON EMP.DEPTNO=D.DEPTNO 
GROUP BY D.DNAME


--LIST PRODUCT NAME, PRICE AND CATEGORY NAME
SELECT P.PRODUCTNAME, P.PRICE, C.CATEGORYNAME FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATEGORYID=C.CATEGORYID

--LIST EMPNAME, JOB, SAL, DEPARTMENT NAME LOCATION OF LOWEST PAID EMPLOYEE
SELECT E.ENAME, E.JOB, E.SAL, D.DNAME, D.LOC FROM EMP AS E JOIN DEPT AS D ON E.DEPTNO=E.DEPTNO 
WHERE SAL=(SELECT MIN(SAL) FROM EMP)



SELECT department_name AS 'Department Name', 
COUNT(*) AS 'No of Employees' 
FROM departments 
INNER JOIN employees 
ON employees.department_id = departments.department_id 
GROUP BY departments.department_id, department_name 
ORDER BY department_name;



------SELF JOIN-----------

SELECT E.ENAME AS 'NAME', E.JOB, E.SAL, M.ENAME AS MGRNAME FROM EMP AS E JOIN EMP AS M ON E.MGR=M.EMPNO ORDER BY M.ENAME

SELECT E.ENAME AS 'NAME', E.JOB, E.SAL, M.ENAME AS MGRNAME FROM EMP AS E LEFT JOIN EMP AS M ON E.MGR=M.EMPNO ORDER BY M.ENAME

-- LIST EMPLOYEE NAME EMPLOYEE JOB, SALARY DEPARTMENT NAME LOCATION FOR ALL EMPLOYEE

SELECT E.ENAME, E.JOB, E.SAL, D.DNAME , D.LOC, M.ENAME AS MGRNAME FROM
 EMP AS E LEFT JOIN DEPT AS D ON E.DEPTNO=D.DEPTNO LEFT JOIN EMP AS M ON E.MGR=M.EMPNO


 --
-- SELECT P.PROGRAMM, O.OS FROM PROGRAMM AS P LEFT JOIN PROGRAMM AS O ON P.PROGRAMID= O.OS

SELECT * FROM EMP
SELECT * FROM DEPT


--------------VIEW--------
CREATE VIEW  EMPVIEW AS SELECT * FROM EMP


--CREATE A VIEW WHICH DISPLAYS DEPARTMENT NAME AND TOTAL SALARY FOR EACH DEPT
CREATE VIEW QUE1 AS SELECT D.DNAME FROM DEPT AS D  

--CREATE A VIEW WHICH DISPLAYS EMPNO, ENAME, JOB, SAL, DEPARTMENT NAME
CREATE VIEW QUE2 AS SELECT E.EMPNO, E.ENAME, E.SAL, D.DNAME FROM EMP AS E LEFT JOIN DEPT AS D ON E.DEPTNO=D.DEPTNO 
GROUP BY D.DNAME

--CREATE A VIEW WHICH DISPLAYS AS PER DATA AS PER THE SALARY HIGHEST TO LOWEST
CREATE VIEW QUE3 AS SELECT * FROM EMP ORDER BY SAL









SELECT * FROM EMP
SELECT * FROM DEPT


------------------------------SUB QUERY AND JOINS FOR ASSIGNMENT TABLES---------------------------------

--1	LIST COSTLIEST PRODUCT DETAILS


--2	PRINT ALL THE ORDERS PLACED BY CUSTOMER AJAY

--3	LIST PRODUCTNAME, PRICE, QUANTITY AND CATEGORYNAME

--4	LIST ORDERYEAR, ORDERMONTH, ORDERID, ORDERDATE, CUSTOMERNAME FOR ALL ORDERS

--5	LIST ALL THE ORDERS FOR THE CATEGORY ELECTRONICS

--6	LIST ALL THE ORDERS WHOSE PRICE IS GREATER THEN 1000

--7	LIST ALL THE ORDERS FOR THE CUSTOMER CHIRAG PLACED FOR CATEGORY FOOD


--8	LIST ORDERYEAR, ORDERMONTH, ORDERID, ORDERDATE, CUSTOMERNAME, 
--	CATEGORYNAME, PRODUCTNAME, PRICE, ORDERQTY, TOTAL(PRICE*ORDERQTY) FOR ALL ORDERS


--9	LIST TOTAL ORDERCOUNT, TOTALORDERQTY, TOTALVALUE OF ORDERS PLACE BY CUSTOMER AJAY

--	HINT: BELOW OUTPUT
ORDERCOUNT	TOTALORDERQTY	TOTALVALUE
3			9				620.00



--10	LIST SUM OF  ORDERQTY  FROM ORDERS TABLE FOR CATEGORY ELECTRONICS 

--HINT
TOTALORDERQTY
2



-- prind 3rd highest salary in employee table
SELECT Max(sal) FROM   emp WHERE  saL < (SELECT Max(sal) 
FROM   emp WHERE  saL NOT IN(SELECT Max(sal) FROM   emp)) 
--IN MYSQL
--SELECT * FROM EMP ORDER BY SAL DESC LIMIT 1 OFFSET 2
--IN 

select * from( select ename, sal, dense_rank() over(order by sal desc)r from Emp) where r=&n;

SELECT ename,sal from Emp e1 where 
        2 = (SELECT COUNT(DISTINCT sal)from Emp e2 where e2.sal > e1.sal) 
    

SELECT SAL FROM EMP OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY

SELECT TOP  3 * FROM EMP ORDER BY SAL DESC














/*EXEC sp_rename 'state.countryid1', 'COUNTRYID', 'COLUMN';    COMMAND TO CHANGE COLUMN NAME */



SELECT * FROM Products
select * from Categories





create table USERDATA
(
	USERNAME VARCHAR(20) PRIMARY KEY,
	PASSWORD VARCHAR(20) NOT NULL
)

INSERT INTO USERDATA VALUES ('ADMIN', 123)
INSERT INTO USERDATA VALUES ('USER1', 123)
INSERT INTO USERDATA VALUES ('USER2', 123)

select * from emp



