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




INSERT INTO EMPLOYEE (EMPNAME, DEPTNO) VALUES ('AMIT', 10)
INSERT INTO EMPLOYEE (EMPNAME, DEPTNO) VALUES ('GITA', 20)
INSERT INTO EMPLOYEE (EMPNAME, DEPTNO) VALUES ('AJIT', 10)
INSERT INTO EMPLOYEE (EMPNAME, DEPTNO) VALUES ('ANKIT', 10)

DELETE FROM EMPLOYEE WHERE EMPNO=3

SELECT * FROM EMPLOYEE

SELECT * FROM DEPARTMENT

DELETE FROM DEPARTMENT WHERE DEPTNO=10
INSERT INTO DEPARTMENT VALUES (10, 'HR')
INSERT INTO DEPARTMENT VALUES (20, 'MANAGER')





drop table EMPLOYEE


DROP TABLE DEPARTMENT





select * from COUNTRY
select * from STATE
select * from TESTDATA