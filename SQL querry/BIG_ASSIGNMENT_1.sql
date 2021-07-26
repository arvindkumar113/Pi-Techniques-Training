SELECT * FROM CUSTOMERS


--1. Display the �Company Name� and �Contact Name� from Customers table
select * from Products
--11. List all the products for CategoryID 4 and UnitsInStock is more then 50
--others place the order by 30 units. Display ProductID, ProductName, UnitsInStock, 
--OrderedUnits.
select * from Products where UnitsInStock <5 and ReorderLevel in (30, 50)

--19. List 3 costliest product
select Top 3 * from Products order by UnitPrice desc
--20. List all the products whose CategoryID is 1 and SupplierID is either 10 or 12 or CategoryID is 4 
--and SupplierID is either 14 or 15.
select * from Orders where Datepart(mm, OrderDate) in (2)

--22. List year wise order count
select count(OrderID) as Counts, datepart(yyyy, OrderDate) as years from Orders group by datepart(yyyy, OrderDate)

--23. List the ShipCountry for which total order placed is more than 100
--Example
--ShipCountry OrderCount
--  USA			122
select ShipCountry, count(OrderID) as OrderCount from Orders group by ShipCountry

--24. List the data as per the order month (Jan � Dec)
select * from Orders order by datepart(mm, OrderDate) 
--25. List unique country name in ascending order where product is shipped
select * from Orders order by ShipCountry, ShippedDate
--26. List CustomerID, ShipCity, ShipCountry, ShipRegion from Ordrs table. If ShipRegion is null than 
--display message as �No Region"
select CustomerID, ShipCity, ShipCountry, ShipRegion from Orders if isnull('No Region', ShipRegion)


--7. List the detail of first order placed
select top 1 * from Orders order by OrderDate 

--28. List Customer wise, Year wise (Order date) order placed
--Example
--CustomerID Year OrderCount
--  ANATR	 1996	   1
--  BONAP	 1997	   



--29. List all the orders handled by employeeid 4 for the month of December


--31. List all the data of [Order Details] table


--32. List ProductID, UnitPrice, Qty and Total. Sort data on Total column with highest value on top


--33. In above query, 
--If Total is more than 10000 display 10% discount on Total cost
--If Total is more than 5000 display 5% discount on Total cost
--If Total is more than 3000 display 2% discount on Total cost
--else Rs. 300 as discount if total is more than 1000
--No discount for Total less than 1000


--34. List Total order placed for each OrderId
