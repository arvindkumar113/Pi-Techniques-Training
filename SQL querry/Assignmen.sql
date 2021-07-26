create Database DBAssignment
go

create table  Client_master
(
	Client_no varchar(6) check(client_no like 'C%') primary key,
	Name varchar(20) not null,
	City varchar(15),
	State varchar(15),
	Pincode numeric(6),
	Balance_due numeric(10,2)
)


create table Product_master
(
	Product_no varchar(6) check(Product_no like 'P%') primary key,
	Description varchar(50) not null,
	Profit_percent numeric(3,2) not null,
	Unit_measure varchar(10) not null,
	Qty_on_hand numeric(8) null,
	record_lvl numeric(8) not null,
	sell_price numeric(8,2) not null check(sell_price >0),
	cost_price numeric(8,2) not null check(cost_price>0)
)


create table Salesman_master
(
	salesman_no varchar(6) check(salesman_no like 'S%') primary key,
	salesman_name varchar(20) not null,
	address1 varchar(30) not null,
	address2 varchar(30),
	city varchar(20),
	pincode varchar(6),
	state varchar(20),
	sal_amt numeric(8,2) not null check(sal_amt>0),
	tgt_to_get numeric(8,2) not null check(tgt_to_get>0),
	ytd_sales numeric(6,2) not null,
	remarks varchar(60)
)
go



create table sales_order
(
	s_order_no varchar(6) check(s_order_no like 'O%') primary key,
	s_order_date date,
	client_no varchar(6) foreign key references client_master(client_no),
	dely_addr varchar(25),
	salesman_no varchar(6) foreign key references Salesman_master(salesman_no),
	dely_type char(1) default 'F' check(dely_type in('P', 'F')),
	billed_yn char(1) default 'N' check(billed_yn in ('Y', 'N')),
	dely_date date,
	order_status varchar(10) check(order_status in('In process', 'Fulfilled','BackOrder', 'Canceled'))
)
go


create table sales_order_details
(
	s_order_no varchar(6) foreign key references sales_order(s_order_no),
	product_no varchar(6)  foreign key references product_master(product_no),
	qty_ordered numeric(8),
	qty_disp numeric(8),
	product_rate numeric(10,1)
)
go
create table challan_header
(
	challan_no varchar(6) check(challan_no like 'CH%') primary key,
	s_order_no varchar(6) foreign key references sales_order(s_order_no),
	challan_date date not null,
	billed_yn char(1) default 'N' check(billed_yn in('Y', 'N')),
)
go

create table challan_details
(
	challan_no varchar(6)  foreign key references challan_header(challan_no),
	product_no varchar(6) foreign key references product_master(product_no),
	qty_disp numeric(4,2) not null,
	constraint PK_challan_details primary key(challan_no, product_no)
)
go



-------Inserting data into Client-master

select * from Client_master
sp_help client_master

insert into Client_master values('C00001', 'Ivan Bayross', 'Bombay', 'Maharashtra', 400054, 15000)

insert into Client_master values('C00002', 'Vandana Saitwal', 'Madras', 'Tamil Nadu', 780001 , 0)

insert into Client_master values('C00003', 'Pramada Jaguste', 'Bombay', 'Maharashtra', 400057, 5000)


insert into Client_master values('C00004', 'Basu Navindgi', 'Bombay', 'Maharashtra', 400056, 0)


insert into Client_master values('C00005', 'Ravi Sreedharan', 'Delhi', 'Delhi', 100001, 2000)

insert into Client_master values('C00006', 'Rukmini', 'Bombay', 'Maharashtra', 400050, 0)

sp_help Product_master

insert into Product_master values('P00001', '1.44 Floppies',5, 'Piece', 100, 20 ,525, 500)

insert into Product_master values('P03453', 'Monitors', 6 ,'Piece' ,10 ,3 ,12000, 11280)

insert into Product_master values('P06734', 'Mouse', 5 ,'Piece' ,20 ,5 ,1050, 1000)

insert into Product_master values('P07865', '1.22 Floppies',5, 'Piece', 100, 20 ,525, 500)
insert into Product_master values('P07868' ,'Keyboards', 2 ,'Piece' ,10, 3, 3150 ,3050)
insert into Product_master values('P07885', 'CD Drive', 2.5, 'Piece', 10, 3, 5250 ,5100)
insert into Product_master values('P07965', '540 HDD',4, 'Piece', 10, 3 ,8400 ,8000)
insert into Product_master values('P07975', '1.44 Drive', 5, 'Piece', 10, 3 ,1050 ,1000)
insert into Product_master values('P08865', '1.22 Drive', 5 ,'Piece', 2, 3 ,1050 ,1000)

-----inserting data into the salesman_master table
sp_help salesman_master

insert into Salesman_master values('S00001', 'Kiran', 'A/14', 'Worli', 'Bombay', '400002', 'MAH',3000,100, 50, 'Good')insert into Salesman_master values('S00002', 'Manish' ,'65', 'Nariman','Bombay',400001,'MAH',3000 ,200 ,100, 'Good')

insert into Salesman_master values('S00003', 'Ravi' ,'P-7', 'Bandra','Bombay',400032,'MAH',3000 ,200 ,100, 'Good')insert into Salesman_master values('S00004', 'Ashish' ,'A-5', 'Juhu','Bombay',400044,'MAH',3500 ,200 ,150, 'Good')----inserting Data for sales_order table :sp_help sales_orderSET ansi_warnings OFF
GOinsert into sales_order(s_order_no, s_order_date, client_no, dely_type, billed_yn, salesman_no, dely_date,order_status) values('O19001', '1996-01-12', 'C00001', 'F', 'N', 'S00001', '1996-01-20', 'in process')insert into sales_order(s_order_no, s_order_date, client_no, dely_type, billed_yn, salesman_no, dely_date,order_status) values('O19002', '1996-01-25', 'C00002', 'P', 'N', 'S00002', '1996-01-27', 'Canceled')insert into sales_order(s_order_no, s_order_date, client_no, dely_type, billed_yn, salesman_no, dely_date,order_status) values('O46865', '1996-02-18', 'C00003', 'F', 'Y', 'S00003', '1996-02-20', 'Fulfilled')insert into sales_order(s_order_no, s_order_date, client_no, dely_type, billed_yn, salesman_no, dely_date,order_status) values('O19003', '1996-03-03', 'C00001', 'F', 'Y', 'S00001', '1996-04-07', 'Fulfilled')insert into sales_order(s_order_no, s_order_date, client_no, dely_type, billed_yn, salesman_no, dely_date,order_status) values('O46866', '1996-05-20', 'C00004', 'P', 'N', 'S00002', '1996-05-22', 'Canceled')insert into sales_order(s_order_no, s_order_date, client_no, dely_type, billed_yn, salesman_no, dely_date,order_status) values('O10008', '1996-05-24', 'C00005', 'F', 'N', 'S00004', '1996-05-26', 'In process')--Inserting Data for sales_order_details tablesp_help sales_order_detailsinsert into sales_order_details values('O19001', 'P00001', 4, 4, 525)insert into sales_order_details values('O19001', 'P07965', 2, 1, 8400)insert into sales_order_details values('O19001', 'P07885', 2, 1, 5250)insert into sales_order_details values('O19002', 'P00001', 10, 0, 525)insert into sales_order_details values('O46865', 'P07868', 3, 3 ,3150)insert into sales_order_details values('O46865', 'P07885', 3, 1, 5250)insert into sales_order_details values('O46865', 'P00001', 10, 10, 525)insert into sales_order_details values('O46865', 'P03453', 4, 4, 1050)insert into sales_order_details values('O19003', 'P03453', 2, 2, 1050)insert into sales_order_details values('O19003', 'P06734', 1, 1 ,12000)insert into sales_order_details values('O46866','P07965', 1, 0 ,8400)insert into sales_order_details values('O46866', 'P07975', 1, 0 ,105)insert into sales_order_details values('O10008', 'P00001', 10, 5, 525)insert into sales_order_details values('O10008', 'P07975', 5, 3, 1050)---inserting Data for challan_header table:sp_help challan_headerinsert into challan_header values('CH9001', 'O19001', '1995-12-12', 'Y')insert into challan_header values('CH6865', 'O46865', '1995-11-12', 'Y')insert into challan_header values('CH3965', 'O10008', '1995-10-12', 'Y')-- inserting Data for challan_details table:sp_help challan_detailsinsert into challan_details values('CH9001', 'P00001', 4)insert into challan_details values('CH9001', 'P07965', 1)insert into challan_details values('CH9001', 'P07885', 1)insert into challan_details values('CH6865', 'P07868', 3)insert into challan_details values('CH6865', 'P03453', 4)insert into challan_details values('CH6865', 'P00001', 10)insert into challan_details values('CH3965', 'P00001', 5)insert into challan_details values('CH3965', 'P07975', 2)select * from challan_details--- --------------SELF REVIEW SQL CONSTRUCTS FOR PRACTICE--------------
--1. Single table retrieval--1) Find out the names of all the clients.
select name from Client_master

--2) Print the entire client_master table.
select * from Client_master

--3) Retrieve the list of names and the cities of all the clients
select name, city from Client_master

--4) List the various products available from the product_master table.
select * from Product_master

--5) Find the names of all clients having ‘a’ as the second letter in their 
--table.
select name from Client_master where name like '_a%'

--6) Find the names of all clients who stay in a city whose second letter is 
--‘a’
select name, city from Client_master where city like '_a%'

--7) Find out the clients who stay in a city ‘Bombay’ or city ‘Delhi’ or city 
--‘Madras’.
select * from Client_master where city in ('Bombay', 'Delhi', 'Madras')

--8) List all the clients who are located in Bombay.
select * from Client_master where city in ('Bombay')

--9) Print the list of clients whose bal_due are greater than value 10000
select * from Client_master where Balance_due>10000

--10) Print the information from sales_order table of orders placed 
--in the month of January.
select * from sales_order where DATEPART(mm, s_order_date) =1

--11) Display the order information for client_no ‘C00001’ and 
--‘C00002’select * from sales_order where client_no in ('C00001', 'C00002')--12) Find the products with description as ‘1.44 Drive’ and ‘1.22 
--Drive’
select * from Product_master where Description ='1.44 Drive'

--13) Find the products whose selling price is greater than 2000 and 
--less than or equal to 5000
select * from Product_master where sell_price between 2001 and 5000
--since sql takes inclusive boundary so instead of 2000 we pass 2001

--14) Find the products whose selling price is more than 1500 and 
--also find the new selling price as original selling price * 15
select *, sell_price*15 as ['New Selling Price'] from Product_master where sell_price >1500

--15) Rename the new column in the above query as new_price
select *, sell_price*15 as ['New Price'] from Product_master where sell_price >1500

--16) Find the products whose cost price is less than 1500
select * from Product_master where cost_price<1500

--17) List the products in sorted order of their description.
select * from Product_master order by Description 

--18) Calculate the square root the price of each product.
select * , sqrt(sell_price) as ['Sqrt sell Price'], sqrt(cost_price) as ['sqrt Cost Price'] from Product_master

--19) Divide the cost of product ‘540 HDD’ by difference between its 
--price and 100
select * , (cost_price/(cost_price-100)) as ['New Cost Price'] from product_master where Description ='540 HDD'

--20) List the names, city and state of clients not in the state of 
--Maharashtra
select name, city, state from Client_master where state not in ('Maharashtra')

--21) List the product_no, description, sell_price of products whose 
--description begin with letter ‘M’
select product_no, description, sell_price from Product_master where Description like 'M%'--22) List all the orders that were canceled in the month of Mayselect * from sales_order where order_status='Canceled' and datepart(mm,s_order_date) =5-------------------2. Set Functions and Concatenation :----------------------


--23) Count the total numbers of orders.
select count(s_order_no) as ['Total no of orders'] from sales_order

--24) Calculate the average price of all the products.
select avg(sell_price) as ['Avg Sell Price'] from Product_master

--25) Calculate the minimum price of products.
select min(sell_price) as ['Minimum price'] from Product_master

--26) Determine the maximum and minimum product prices. 
--Rename the title as max_price and min_price respectively.
select max(sell_price) as ['Max_Price'] , min(sell_price) as ['Min_Price'] from Product_master

--27) Count the numeric of products having price greater than or 
--equal to 1500.
select count(product_no) as ['No of Products having sell price more than 1500'] from Product_master where sell_price >=1500

--28) Find all the products whose qty_on_hand is less than reorder 
--level.
select * from Product_master where Qty_on_hand<record_lvl
select * from Product_master
--29) Print the information of client_master, product_master, 
--sales_order table in the following formate for all the records
--{cust_name} has placed order {order_no} on {s_order_date}.
select concat(name, ' has placed order ', s_order_no, ' on ', sales_order.s_order_date) as Label from Client_master join sales_order on Client_master.Client_no = sales_order.client_no

--select concat(name, ' is from ', city) as label from Client_master



-------------------3. Having and Group by:---------------------
--30) Print the description and total qty sold for each productselect Description, sum(qty_ordered) from Product_master join sales_order_details on product_master.Product_no = sales_order_details.product_no group by sales_order_details.product_no, Product_master.Description

--31) Find the value of each product sold.
select Description, sum(qty_disp*product_rate) as ['Value'] from Product_master pm join sales_order_details as sod on pm.Product_no = sod.product_no
group by sod.product_no, pm.Description

--32) Calculate the average qty sold for each client that has a 
--maximum order value of 15000.00
select c.client_no, c.name, avg(s.qty_ordered) as [Avg Sales], max(s.qty_ordered*s.product_rate) as [Max Sale] from Client_master as c, sales_order_details as s, sales_order as so where c.Client_no=so.client_no and s.s_order_no=so.s_order_no group by c.Client_no, c.Name having max(s.qty_ordered*s.product_rate)>15000


--33) Find out the total sales amount receivable for the month of 
--jan. it will be the sum total of all the billed orders for the month.
select so.s_order_no, so.s_order_date, sum(sod.product_rate*sod.qty_ordered) as [Receiveable Amt] from sales_order as so, sales_order_details as sod where so.s_order_no=sod.s_order_no and so.billed_yn='Y' and datepart(mm, s_order_date)=1 group by so.s_order_no, so.s_order_date


--34) Print the information of product_master, order_detail table in 
--the following format for all the records
--{Description} worth Rs. {Total sales for the product} was sold.
select concat(pm.description, ' worth RS. ', sum(sod.qty_ordered*sod.product_rate), ' was sold. ') as Label from Product_master as pm, sales_order_details as sod where pm.Product_no=sod.product_no group by pm.description


--35) Print the information of product_master, order_detail table in 
--the following format for all the records
--{Description} worth Rs. {Total sales for the product} was produced in 
--the month of {s_order_date} in month formate.
select concat(pm.Description, ' worth Rs. ', sum(sod.qty_disp*sod.product_rate), ' was produced in the month of ', datename(mm, so.s_order_date)) as lable from Product_master as pm, sales_order as so, sales_order_details as sod where pm.Product_no=sod.product_no and so.s_order_no=sod.s_order_no
group by pm.Description, so.s_order_date

--------------------------4. Joins and Correlation :------------

--36) Find out the products which has been sold to ‘Ivan Bayross’
select * from Product_master where Product_no in (select Product_no from sales_order_details where s_order_no in (select s_order_no from sales_order where client_no in (select client_no from Client_master where name='Ivan Bayross') ) )


--37) Find out the products and their quantities that will have to 
--deliver in the current month.
select sod.product_no, pm.description, sum(qty_ordered) as [Quantity ordered] from Product_master as pm, sales_order_details as sod, sales_order as so where sod.product_no = pm.Product_no and sod.s_order_no=so.s_order_no and format(so.s_order_date, 'yyyy-mm') =format(so.dely_date, 'yyyy-mm') group by sod.product_no, pm.Description

--38) Find the product_no and description of moving products.
--select product_no from Product_master, 

select distinct pm.Description, pm.product_no from Product_master as pm, sales_order_details as sod where  sod.product_no=pm.Product_no


--39) Find the names of clients who have purchased ‘CD Drive’
select * from Client_master where Client_no in (select Client_no from sales_order where s_order_no in (select s_order_no from sales_order_details where product_no in(select product_no from Product_master where Description='CD Drive')) )

--40) List the product_no and s_order_no of customers having 
--qty_ordered less than 5 from the order details table for the product 
--‘1.44 floppies’
select pm.product_no, sod.s_order_no from Product_master as pm, sales_order_details as sod where 
pm.Product_no=sod.product_no and sod.qty_ordered<5 and pm.Description='1.44 floppies'

--41) Find the products and their quantities for the orders placed by 
--‘Vandana Saitwal’ and ‘Ivan Bayross’
select cm.name, pm.description, sod.product_no, sum(qty_ordered) as [ordered] from Client_master as cm, Product_master as pm, sales_order_details as sod, sales_order as so where cm.Client_no=so.client_no
 and so.s_order_no=sod.s_order_no and sod.product_no=pm.Product_no and cm.name in('Saitwal', 'Ivan Bayross') group by sod.product_no, pm.Description, cm.Name

--42) Find the products and their quantities for the orders placed by 
--client_no ‘C00001’ and ‘C00002’
select sod.product_no, so.client_no, pm.description, sum(qty_ordered) as [Quantity ordered] from Product_master as pm, Client_master as cm, sales_order as so, sales_order_details as sod where cm.Client_no=so.client_no and pm.Product_no=sod.product_no and so.s_order_no=sod.s_order_no and cm.Client_no in('C00001', 'C00002') group by so.Client_no, sod.Product_no, pm.Description 

----------------------------5. Nested Queries :-------------


--43) Find the product_no and description of non-moving products.
select description, product_no from Product_master where Product_no not in ( select Product_no from sales_order_details )

--44) Find the customer name, address1, address2, city and pin code 
--for the client who has placed order no ‘O19001’
--how can be address1 and address2 be found from customer where it resides in salesman table
--select name, address1, address2, city, pin_code from Client_master

select name, city, pincode from Client_master where Client_no in(select Client_no from sales_order where s_order_no='O19001')

--select * from Client_master


--45) Find the client names who have placed orders before the 
--month of May, 1996select name from Client_master where Client_no in(select Client_no from sales_order where s_order_date<'1996-05-01')--46) Find out if product ‘1.44 Drive’ is ordered by client and print 
--the client_no, name to whom it is was sold.
select client_no, name from Client_master where Client_no in(select Client_no from sales_order where s_order_no in (select s_order_no from sales_order_details where product_no in (select product_no from Product_master where Description='1.44 Drive')))

--47) Find the names of clients who have placed orders worth Rs. 
--10000 or more.
select name from Client_master where Client_no in(select Client_no from sales_order where s_order_no in(select s_order_no from sales_order_details where (product_rate*qty_ordered)>10000  ) )


--------------------6. Queries using Date:------------


--48) Display the order numeric and day on which clients placed 
--their order.
select s_order_no, datename(dd, s_order_date) from sales_order
select s_order_no, datename(DW, s_order_date) as Day from sales_order


--49) Display the month (in alphabets) and date when the order 
--must deliver.
select datename(mm, dely_date) as Month, dely_date from sales_order

--50) Display the s_order_date in the format. E.g. 12-February-1996 
select concat(datepart(dd, s_order_date), '-',datename(mm,s_order_date),'-',datepart(yyyy,s_order_date)) as lable from sales_order

--51) Find the date, 15 days after today’s date.
select dateadd(dd,15, getdate())

--52) Find the numeric of days elapsed between today’s date and 
--the delivery date of the orders placed by the clients.
select datediff(dd, s_order_date, getdate()) as [day elapsed] from sales_order


---------------------7. Misc (Rank, Case)-----------------



--53. In sales ordered detail table as per the quantity ordered highest to 
--lowest assign the rank. Don’t miss any numeric
select *, Dense_RANK() over (order by qty_ordered desc)  from sales_order_details 

--54.Display product master record along with record no
select ROW_NUMBER() over (order by product_no ) as [Record No], * from Product_master

--55.For sales ordered detail table assign row numeric for each 
--s_order_no. 
select ROW_NUMBER() over(order by s_order_no) as [S No.], * from sales_order

--56.Print s_order_no, qty ordered, qty disp, and difference. Also display 
--message if difference is 0 print all qty dispatched , if difference is <=5 
--few qty left to dispatched, else display difference is high
select s_order_no, qty_ordered, qty_disp, 
case 
	when (qty_ordered-qty_disp)=0 then 'All qty dispatched'
	when (qty_ordered-qty_disp)<=5 then 'Few qty left to dispatched'
	else 'difference is high'
end as [Difference] from sales_order_details


--57. List salesman master detail along with rank as per the sal_amt
select rank() over (order by sal_amt desc) as [Rank], * from Salesman_master



--------------------------8. Table Updations:---------------


--58) Change the s_order_date of client_no ‘C00001’ to 24/07/96.
update sales_order set s_order_date='24-jul-96' where client_no='C00001';


--59) Change the selling price of ‘1.44 Floppy Drive’ to Rs. 1150.00
update Product_master set sell_price=1150.00 where Description='1.44 Floppy Drive'
--nothing happend as there is no product with given description 

--60) Delete the records with order numeric ‘O19001’ from the 
--order table.
delete from sales_order where s_order_no='O19001' 
--FK__sales_ord__s_ord__403A8C7D reference eror


--61) Delete all the records having delivery date before 10th July’96
delete from sales_order where s_order_date<'10-07-1996'

--62) Change the city of client_no ‘C00005’ to ’Bombay’.
update Client_master set city='Bombay' where Client_no='C0005'

--63) Change the delivery date of order numeric ‘O10008” to 
--16/08/96update sales_order set dely_date='16-aug-1996' where client_no='C10008'--64) Change the bal_due of client_no ‘C00001’ to 1000
update Client_master set Balance_due=1000 where Client_no='C00001'

--65) Change the cost price of ‘1.22 Floppy Drive’ to Rs. 950.00.
update Product_master set cost_price=950.00 where Description='1.22 Floppy Drive'



-----------------------9. Views----------------------


--66.Create a read only view which will display Client name, city and 
--balance due
create view view1 as
select name, city, balance_due from Client_master;

select * from view1

--67.Create a read only view which will display salesman name, city, sales 
---amount, target to get
create view view2 as
select salesman_name, city, sal_amt, tgt_to_get from Salesman_master

select * from view2

--68.Create a view which display client name, salesman name 
--s_oreder_no and order status
create view view3 as
select cm.Name, sm.salesman_name, so.s_order_no, so.order_status from Client_master as cm, sales_order as so, Salesman_master as sm where cm.Client_no=so.client_no and so.salesman_no=sm.salesman_no 

select * from view3

--69.From the sales order details table display product wise quantity 
--ordered
create view view4 as
select pm.Description, sod.qty_ordered from Product_master as pm, sales_order_details as sod where sod.product_no=pm.Product_no

select * from view4

--70.Create view which display all billed challan detail
create view view5 as
select ch.challan_no, ch.s_order_no, ch.challan_date, cd.product_no, cd.qty_disp from challan_details as cd, challan_header as ch where cd.challan_no=ch.challan_no and ch.billed_yn='Y'

select * from view5


-----------------10.Stored Procedure (for all the procedure handle required error)--------------


--71.Write a procedure which takes client name and display a client record 
--from client master table.
create proc GetClientByName @name varchar(20)
as
	select * from Client_master where name=@name

exec GetClientByName @name='rukmini'

--72.Take city name as parameter and display all client name and the balance 
--due and at the end total balance due from the city (total of 
--balance_due)
create proc GetClientNameAndDueBalance @city varchar(10) as
select name, balance_due, sum(balance_due) as [Net Due] from Client_master where city=@city group by Balance_due


--73.Write a procedure which takes product description as a parameter and 
--display the details
create proc GetProductDetailsByDescription @description varchar(50) as
select * from Product_master where Description=@description

Exec GetProductDetailsByDescription @description='1.44 Floppies'

--74.Write a procedure which will take quantify on hand as parameter and 
--display all products greater than the value
create proc GetPrductDetailsGraterThanGivenHand @qtyonhand numeric(8) as
select * from Product_master where Qty_on_hand>@qtyonhand

exec GetPrductDetailsGraterThanGivenHand @qtyonhand=10

--75.Write a procedure which will display details for all “Floppies” product
create or alter proc GetAllFloppiesDetails as
select * from Product_master where Description like '%Floppies%'

exec GetAllFloppiesDetails

--76.Write a procedure which takes client name and display S_order_date, 
--Order Status.
create proc GetOrderDateAndStaus @name varchar(20) AS
select cm.name, so.s_order_date, so.order_status from Client_master as cm, sales_order as so
where so.client_no= cm.Client_no and cm.name=@name 

exec GetOrderDateAndStaus @name='Rukmini'

--77. Write a procedure which print salesman name, whose Ytd sales > 100
create proc GetSalesmanNameHavingYtd100 as
select salesman_name from Salesman_master where ytd_sales>100

exec GetSalesmanNameHavingYtd100

--78. Take a two S_order_date parameters and display all sales detail 
--between two dates.
create  proc GetDetailsOfProductBetweenTwoDates @date1 date, @date2 date as
select * from sales_order where s_order_date between @date1 and @date2  

exec GetDetailsOfProductBetweenTwoDates @date1='25-jan-1996', @date2='24-may-1996'


--79. Take bill_y/n as a parameter and list all order details like S_order_no, 
--S_order_date, salesman name, order statuscreate proc GetOrderDetailsByBill_yn @bill_y_n char(1) asselect so.s_order_no, so.s_order_date, sm.salesman_name, so.order_status from sales_order as so, Salesman_master as sm where so.salesman_no=sm.salesman_no and so.billed_yn=@bill_y_nexec GetOrderDetailsByBill_yn @bill_y_n ='Y'--80. Takes S_order_no as a parameter and display product description and 
--salesman name
create proc GetProductDescriptionAndSalesmanName @order_no varchar(6) as
select pm.Description, sm.salesman_name from Product_master as pm, sales_order as so, Salesman_master as sm, sales_order_details as sod where pm.Product_no=sod.product_no and sm.salesman_no=so.salesman_no and so.s_order_no=sod.s_order_no and so.s_order_no=@order_no

exec GetProductDescriptionAndSalesmanName @order_no='O10008'

--81. Take client name as parameter and display S_order_no, S_order_date, 
--salesman name, order status, product description, qty ordered, product 
--rate and total (qty ordered * product rate)
create proc GetOrderDetailsByClientName @name varchar(20) as
select so.s_order_no, so.s_order_date, sm.salesman_name, so.order_status, pm.Description, sod.qty_ordered, sod.product_rate, (sod.qty_ordered*sod.product_rate) as [total] from Client_master as cm, sales_order as so, sales_order_details as sod, Salesman_master as sm, Product_master as pm where cm.Client_no=so.client_no and pm.Product_no=sod.product_no and sm.salesman_no=so.salesman_no and so.s_order_no=sod.s_order_no and cm.Name=@name

exec GetOrderDetailsByClientName @name='Ivan Bayross'


--82. List order details (order no, client name, salesman name, product 
--description) where qty ordered is >= 10 
create proc GetDetailsQty_orderedGraterThan10 as
select so.s_order_no, sm.salesman_name, pm.Description from Client_master as cm, sales_order as so, sales_order_details as sod, Salesman_master as sm, Product_master as pm where cm.Client_no=so.client_no and pm.Product_no=sod.product_no and sm.salesman_no=so.salesman_no and so.s_order_no=sod.s_order_no and sod.qty_ordered>=10

exec GetDetailsQty_orderedGraterThan10

--83.Take challan no and print details (order no, challan date, client name, 
--salesman name, order date, order status)
alter proc GetChallanDetailsByChallanNo @challan_number varchar(6) as
select so.s_order_no, ch.challan_date, cm.Name, sm.salesman_name, so.s_order_date, so.order_status from Client_master as cm, Product_master as pm, Salesman_master as sm, sales_order as so, sales_order_details as sod, challan_header as ch, challan_details as cd where cm.Client_no=so.client_no and pm.Product_no=sod.product_no and sm.salesman_no=so.salesman_no and so.s_order_no=sod.s_order_no and ch.s_order_no=so.s_order_no and ch.challan_no=cd.challan_no and ch.challan_no=@challan_number

exec GetChallanDetailsByChallanNo @challan_number = 'CH3965'

--84.Take challan date month as a parameter and display challan detail like 
--s_order_no, s_order_date, bill y/n, delay_date, order status
create proc GetChallanDetailsByDate @date date as
select ch.s_order_no, so.s_order_date, so.billed_yn, so.dely_date, so.order_status from sales_order as so, sales_order_details as sod, challan_details as cd, challan_header as ch where so.s_order_no=sod.s_order_no and so.s_order_no=ch.s_order_no and ch.challan_no=cd.challan_no and ch.challan_date=@date

exec GetChallanDetailsByDate @date = '24-may-1996'

--85.Take product no as parameter and print all the orders for the products 
--like s_order_no, client name, salesman name
create proc GetOrderDetailsByProductNo @prod_no varchar(6) as
select so.s_order_no, cm.Name, sm.salesman_name from Client_master as cm, sales_order as so, sales_order_details as sod, Salesman_master as sm, Product_master as pm where cm.Client_no=so.client_no and pm.Product_no=sod.product_no and sm.salesman_no=so.salesman_no and so.s_order_no=sod.s_order_no and pm.Product_no=@prod_no

exec GetOrderDetailsByProductNo @prod_no = 'P00001'

--86.Write a procedure which print order no and order date for the salesman 
--kiran
create proc GetOrderDetailsOfSalesmanKiran as
select so.s_order_no, so.s_order_date from Salesman_master as sm, sales_order as so, sales_order_details as sod where sm.salesman_no=so.salesman_no and so.s_order_no=sod.s_order_no and sm.salesman_name='Kiran'

exec GetOrderDetailsOfSalesmanKiran

--87. Write a procedure which takes order no as parameter and return in out 
--parameter total qty ordered and total qty dispatched for the order 
--(table sales_order)
alter proc GetTotalOrderedAndDispatchedByOrderNo @order_number varchar(6), @qty_ordered numeric(8) output, @qty_dispatched numeric(8) out as
select @qty_ordered=qty_ordered, @qty_dispatched=qty_disp from sales_order_details where s_order_no=@order_number


declare @order_number varchar(6), @qty_ordered numeric(8), @qty_dispatched numeric(8)

exec GetTotalOrderedAndDispatchedByOrderNo @order_number='O10008', @qty_ordered=@qty_ordered output, @qty_dispatched=@qty_dispatched output

select @qty_ordered as [total ordered], @qty_dispatched as [dispatched]


--88. Write a procedure which display product description cost price, sales 
--price and profit amount (cost price – sales price).
create proc GetProductProfit as
select Description, cost_price, sell_price, (sell_price-cost_price) as [Profit] from Product_master as pm


exec GetProductProfit

--89.Display all the product detail where reorder level is below 5
create proc GetAllProductHavingReorderLessThan5 as
select * from Product_master where record_lvl<5

exec GetAllProductHavingReorderLessThan5

--90. Take sales order no check if qty dispatched is less than qty ordered 
--than display product description , qty ordered, qty dispatched and the 
--difference else print the message all qty dispatched. 
create proc proc1 @order_number varchar(6) as
select pm.description, sod.qty_ordered, sod.qty_disp,
case
	when sod.qty_ordered-sod.qty_disp>0 then sod.qty_ordered-sod.qty_disp
	when sod.qty_ordered-sod.qty_disp=0 then 'all dispatched'
end as [Status of delivery] from Product_master as pm, sales_order_details as sod

exec proc1 @order_number='O10008'

-------------------------11. Functions---------------


--91. Take the city name and return total no of customer count in the city
alter function GetClientCount(@cityname varchar(20))
returns int as
Begin 
	declare @ret int;
	select @ret=count(client_no) from Client_master where city=@cityname
	if(@ret is null)
		set @ret=0;
	return @ret;
end


select dbo.GetClientCount('Bombay')
	

--92. Take salesman name and return total order count 
create function GetOrderCountBySalesman(@salesmanname varchar(20))
returns int as
Begin
	declare @ret1 int;
	select @ret1=count(s_order_no) from sales_order where salesman_no in(select salesman_no from Salesman_master where salesman_name=@salesmanname)
	if(@ret1 is null)
		set @ret1=0
	return @ret1;
end

select dbo.GetOrderCountBySalesman('Kiran')

--93. Write a function which takes salesman name and return target to 
--get.
create function GetTargetToGetBySalesman (@name as varchar(20))
returns numeric(6,2) as
Begin 
	declare @ret3 numeric(6,2);
	select @ret3=tgt_to_get from Salesman_master where salesman_name=@name
	if(@ret3 is null)
		set @ret3=0.00;
	return @ret3;
end

select dbo.GetTargetToGetBySalesman('Kiran')

--94.Write a function which will return total target to get by all the 
--salesmancreate function GetAllTgtToGet() returns numeric(6,2) asBegin	declare @ret4 numeric(6,2);	select @ret4=sum(tgt_to_get) from Salesman_master	if(@ret4 is null)		set @ret4=0.00;	return @ret4;endselect dbo.GetAllTgtToGet()--95. Take order status as a parameter and return total order count for 
--the order status
create function GetTotalOrderCountByOrderStatus(@order_status varchar(20))
returns int as
Begin 
	declare @ret5 int;
	select @ret5= count(s_order_no) from sales_order where order_status=@order_status
	if( @ret5 is null)
		set @ret5=0
	return @ret5
end

select dbo.GetTotalOrderCountByOrderStatus('In Process')

--96. Take year and month as a parameter to a function and return order 
--count
create function GetOrderCountByYearAndMonth(@dat date)
returns int as
Begin
	declare @ret6 int;
	select @ret6=count(s_order_no) from sales_order where (datepart(yyyy, s_order_date)=datepart(yyyy, @dat)) and (datepart(mm, s_order_date)=datepart(mm,@dat))
	if(@ret6 is null)
		set @ret6=0;
	return @ret6;
end

select dbo.GetOrderCountByYearAndMonth('24-may-1996')


--97.Take s_order_no as a parameter to a function and return total bill 
--amount 
create function GetTotalBill(@order_number varchar(6))
returns numeric(10,2) as
Begin 
	declare @ret7 numeric(10,2);
	select @ret7=sum(qty_ordered*product_rate) from sales_order_details where s_order_no=@order_number
	if(@ret7 is null)
		set @ret7=0;
	return @ret7;
end

select dbo.GetTotalBill('O10008')


--98. Return total salesman count in the city Mumbai
create function GetTotalSalesmanCountInMumbai()
returns int as
Begin
	declare @ret8 int;
	select @ret8=count(salesman_no) from Salesman_master where city='Mumbai'
	if(@ret8 is null)
		set @ret8=0;
	return @ret8;
end


select dbo.GetTotalSalesmanCountInMumbai()

--99.Take state name and return total client in the state
create function GetClientCountFromState(@state_name varchar(20))
returns int as
Begin
	declare @ret9 int;
	select @ret9=count(Client_no) from Client_master where State=@state_name
	if(@ret9 is null)
		set @ret9=0;
	return @ret9;
end

select dbo.GetClientCountFromState('Maharashtra')

--100. Take city name as parameter and return total amount of balance 
--due for the citycreate function GetTotalDueBalanceInCity(@city_name varchar(20))returns numeric(10,2) asBegin	declare @ret10 numeric(10,2);	select @ret10=sum(Balance_due) from Client_master where City=@city_name;	if(@ret10 is null)		set @ret10=0;	return @ret10;endselect dbo.GetTotalDueBalanceInCity('Bombay')