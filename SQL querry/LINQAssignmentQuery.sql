create database LINQAssignment
go



CREATE TABLE DEPT
       (DEPTNO int not null constraint dept_deptno_pk primary key,
        DNAME VARCHAR(14),
        LOC VARCHAR(13) )	

		
INSERT INTO DEPT VALUES (10, 'ACCOUNTING', 'NEW YORK');
INSERT INTO DEPT VALUES (20, 'RESEARCH',   'DALLAS');
INSERT INTO DEPT VALUES (30, 'SALES',      'CHICAGO');
INSERT INTO DEPT VALUES (40, 'OPERATIONS', 'BOSTON');
go


CREATE TABLE EMP
       (EMPNO int NOT NULL constraint emp_empno_pk primary key,
        ENAME VARCHAR(10),
        JOB VARCHAR(9),
        MGR int,
        HIREDATE DATEtime,
        SAL NUmeric(7, 2),
        COMM Numeric(7, 2),
        DEPTNO int constraint emp_deptno_fk references dept(deptno)
		)



		INSERT INTO EMP VALUES
        (7369, 'SMITH',  'CLERK',     7902, '12/17/1980',
          800, NULL, 20)
INSERT INTO EMP VALUES
        (7499, 'ALLEN',  'SALESMAN',  7698,'02/20/1981', 1600,  300, 30)
INSERT INTO EMP VALUES
        (7521, 'WARD',   'SALESMAN',  7698, '02/22/1981', 1250,  500, 30)
INSERT INTO EMP VALUES
        (7566, 'JONES',  'MANAGER',   7839, '04/2/1981',  2975, NULL, 20)
INSERT INTO EMP VALUES
        (7654, 'MARTIN', 'SALESMAN',  7698, '09/28/1981', 1250, 1400, 30)
INSERT INTO EMP VALUES
        (7698, 'BLAKE',  'MANAGER',   7839,'05/01/1981',  2850, NULL, 30)
INSERT INTO EMP VALUES
        (7782, 'CLARK',  'MANAGER',   7839, '06/09/1981',  2450, NULL, 10)
INSERT INTO EMP VALUES
        (7788, 'SCOTT',  'ANALYST',   7566, '12/09/1982' , 3000, NULL, 20)
INSERT INTO EMP VALUES
        (7839, 'KING',   'PRESIDENT', NULL, '11/17/1981' , 5000, NULL, null)
INSERT INTO EMP VALUES
        (7844, 'TURNER', 'SALESMAN',  7698, '09/08/1981' ,  1500,    0, 30)
INSERT INTO EMP VALUES
        (7876, 'ADAMS',  'CLERK',     7788, ' 01/12/1983', 1100, NULL, 20)
INSERT INTO EMP VALUES
        (7900, 'JAMES',  'CLERK',     7698, '12/03/1981' ,   950, NULL, 30)
INSERT INTO EMP VALUES
        (7902, 'FORD',   'ANALYST',   7566, '12/03/1981' ,  3000, NULL, 20)
INSERT INTO EMP VALUES
        (7934, 'MILLER', 'CLERK',     7782, '01/23/1982' , 1300, NULL, 10)



select * from dept
select * from emp

select * from Employees
 select * from Orders
 select * from Customers
 select * from [Order Details]
 select * from Products

 select * from Products
 SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'

