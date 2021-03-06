CREATE TABLE TESTDATA
(
	TESTNO NUMERIC(1,0) IDENTITY(1,1) NOT NULL PRIMARY KEY
	)

	SET IDENTITY_INSERT TESTDATA ON

	SET IDENTITY_INSERT TESTDATA OFF

	DROP TABLE TESTDATA

	INSERT INTO TESTDATA DEFAULT VALUES

	CREATE TABLE dbo.TestIdentity
	(
		RowId INT IDENTITY(1, 1)
	)

	insert into dbo.TestIdentity default values

	select * from dbo.TestIdentity

	SELECT 1 + '1'
SELECT 1 + '1.0'
SELECT 1.0 + '1.0'


	SELECT * FROM TESTDATA 

		INSERT INTO TESTDATA VALUES(1)

CREATE TABLE COUNTRY
(	COUNTRYID VARCHAR(3) NOT NULL PRIMARY KEY,
	COUNTRYNAME VARCHAR(20) UNIQUE,
	CAPITAL VARCHAR(20),
	FLAG VARBINARY(MAX)
	)

CREATE TABLE STATE
(	STATEID VARCHAR(3) ,
	STATENAME VARCHAR(20),
	STATECAPITAL VARCHAR(20),
	COUNTRYID1 VARCHAR(3) FOREIGN KEY REFERENCES COUNTRY(COUNTRYID) ON DELETE SET NULL ON UPDATE CASCADE 
	)



	INSERT INTO COUNTRY VALUES ('AA', 'INDIA', 'DELHI',123) 
	INSERT INTO STATE VALUES ('AB', 'BIHAR', 'PATNA', 'AA')
	INSERT INTO COUNTRY VALUES('AB','AMERICA', 'WDC',121)
	INSERT INTO STATE VALUES('ABC', 'MEXIC', 'XXXX','AB')
	INSERT INTO STATE VALUES ('AB', 'MAHARASHTRA', 'MUMBAI', 'AA')


SELECT * FROM COUNTRY
SELECT * FROM STATE


drop table customer


CREATE TABLE CUSTOMER
(	CUSTOMERID NUMERIC(3) NOT NULL PRIMARY KEY,
	CUSTOMERNAME VARCHAR(20) NOT NULL,
	CUSTADDRESS VARCHAR(20)
	)
	select * from CUSTOMER
--	drop table category


	CREATE TABLE CATEGORY
	(	CATEGORYID NUMERIC(3) NOT NULL PRIMARY KEY,
		CATEGORYNAME VARCHAR(20) NOT NULL UNIQUE
	)

--drop table product
	
	CREATE TABLE PRODUCT
	(	 PRODUCTID NUMERIC(3) NOT NULL PRIMARY KEY,
		 PRODUCTNAME VARCHAR(20) NOT NULL,
		 CATEGORYID NUMERIC(3) REFERENCES CATEGORY(CATEGORYID),
		 PRICE NUMERIC(10,2) CHECK (PRICE>50),
		 QUANTITY NUMERIC(3) CHECK (QUANTITY>0)
	)

--drop table orders

	CREATE TABLE ORDERS
	(	ORDERYEAR NUMERIC(3),
		ORDERMONTH VARCHAR(20),
		ORDERID VARCHAR(20),
		ORDERDATE DATETIME DEFAULT GETDATE(),
		PRODUCTID NUMERIC(3) CONSTRAINT PRODUCT_PRODUCTID_FK REFERENCES PRODUCT(PRODUCTID),
		CUSTOMERID NUMERIC(3) CONSTRAINT CUSTOMER_CUSTOMERID_FK REFERENCES CUSTOMER(CUSTOMERID),
		ORDQRY NUMERIC(3) CHECK (ORDQRY>0),

		CONSTRAINT PK_ORDERS PRIMARY KEY (ORDERYEAR, ORDERMONTH, ORDERID)
	)


ALTER TABLE CUSTOMER ADD ADDRESS VARCHAR(10) CHECK(ADDRESS= 'DELHI' OR ADDRESS='MUMBAI' OR ADDRESS='PUNE')
 --DEFAULT ADDRESS 'MUMBAI'

 INSERT INTO CUSTOMER VALUES(1, 'AJAY', 'MUMBAI')
 INSERT INTO CUSTOMER VALUES(2, 'CHIRAG', 'DELHI')
 INSERT INTO CUSTOMER VALUES(3, 'AMIT', 'PUNE')

 INSERT INTO CATEGORY VALUES(1, 'FOOD')
 INSERT INTO CATEGORY VALUES(2, 'ELECTRONICS')
 INSERT INTO CATEGORY VALUES(3, 'STATIONARY')


 INSERT INTO PRODUCT VALUES(101, 'TEA', 1, 60, 100)
 INSERT INTO PRODUCT VALUES(102, 'PEN', 3, 80, 50)
 INSERT INTO PRODUCT VALUES(103, 'NOTEBOOK', 3, 125, 200)
 INSERT INTO PRODUCT VALUES(104, 'COFFEE', 1, 80, 100)
 INSERT INTO PRODUCT VALUES(105, 'TV', 2, 15000, 5)
 INSERT INTO PRODUCT VALUES(106, 'WASHINGMACHINE', 2, 12000, 3)


 INSERT INTO ORDERS (ORDERYEAR, ORDERMONTH, ORDERID, PRODUCTID, CUSTOMERID, ORDQRY) VALUES(2010, 1, 1, 101,2,10)

 INSERT INTO ORDERS VALUES(2010, 1, 2,, 104,1,2)
 INSERT INTO ORDERS VALUES(2010, 2, 1,NULL, 105,2,1)
 INSERT INTO ORDERS VALUES(2010, 2, 2,NULL, 101,1,5)
 INSERT INTO ORDERS VALUES(2010, 2, 3,NULL, 106,2,1)
 INSERT INTO ORDERS VALUES(2011, 1, 1,NULL, 104,1,2)


 sp_help orders
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



-- prind 3rd highest salary in employee table
SELECT Max(sal) 
FROM   emp
WHERE  saL < (SELECT Max(sal) 
                 FROM   emp 
                 WHERE  saL NOT IN(SELECT Max(sal) 
                                      FROM   emp)) 



--ANOTHER SOLUTION
SELECT ename,sal from Emp e1 where 
        2 = (SELECT COUNT(DISTINCT sal)from Emp e2 where e2.sal > e1.sal) 
  
SELECT * FROM EMP

