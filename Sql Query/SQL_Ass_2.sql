
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
SELECT *, ISZERO(COMM, 250)+SAL AS NET_SAL FROM EMP 

SELECT *, NETSAL 
CASE
	WHEN COMM=0 THEN NETSAL AS 250+SAL
	ELSE NETSAL AS SAL
END AS NETSAL
FROM EMP



--13
 ---- Display the name, job and bonus for all employees, 
 --assuming all managers gets a bonus of Rs. 500, 
 --clerk gets Rs. 200 
 --and all other except president get Rs. 350. 
 --The president gets 20% of his salary as bonus
 
 



--14	 Find the  job of the employees receiving commission
SELECT * FROM EMP WHERE COMM!=0 OR COMM IS NULL
SELECT * FROM EMP WHERE COMM!=0

--15	 Show the daily salary of all employees assuming a month has 30 days without any decimal
SELECT *, (SAL/30) AS dAILY_SAL FROM EMP


--16	display record of last joined employee
SELECT TOP 1 * FROM EMP ORDER BY  HIREDATE DESC


--17	list empname, hiredate, sal , comm and netsal in date, number and currency format of India
SELECT ENAME, HIREDATE, SAL, COMM, (SAL+ISNULL(COMM,0)) AS NET_SAL,CONVERT( 'HI-IN') AS 'INDIA' FROM EMP


--18	show empoyee data as per year or joing
--for each year jan to dec give sr no 1, 2, ...
--year change again start number for 1
--HINT- Partition function




select * from emp
 
--19	CASE SENSITIVE 
-- IN MS SQL SERVER HOW TO WORK ON CASE SENSITIVE DATA
SELECT * FROM EMP WHERE CAST(ENAME AS VARBINARY(40)) = CAST('smith' as varbinary(40))
--another way is to make whole database case sensative

select * from emp where ename='smith'

