SELECT * FROM CUSTOMERS


--1. Display the “Company Name” and “Contact Name” from Customers tableSELECT CompanyName, ContactName from Customers --2. Find the Customers who are staying wither in USA, UK, Germany, France select * from Customers where City in ('USA', 'UK', 'Germany', 'France') --3. Find the Customers whose “Company Name” starts with G select * from Customers where [CompanyName] ='G%'-- 4. List all the Customers who are located in Parisselect * from Customers where Country='Paris'--5. List the Customer details whose postal code start with 4select * from Customers where PostalCode='4%'--6. List all the Customers who neither stay in Canada nor in Brazilselect * from Customers where Country not in ('canada', 'Brazil')--7. Print total number of Customers for each country.select count(CustomerID) from Customers group by Country--8. List Customers detail based on Country and Cityselect * from Customers group by Country, City--9. List all the manager from the Customers table--not possible due to insufficient table column--10. List all Customers details where “company name” contains aphostophy (‘)select * from Customers where CompanyName='%''%'--Table: Products
select * from Products
--11. List all the products for CategoryID 4 and UnitsInStock is more then 50select * from products where CategoryID = 4 and UnitsInStock > 50 --12. List ProductName, UnitPrice, UnitsInStock, NetStock (i.e. UnitPrice * UnitsInStock)select ProductName, UnitPrice, UnitsInStock, (UnitPrice * UnitsInStock) as NetStock from Products --13. List Maximum and Minimum UnitPriceselect Max(UnitPrice), Min(UnitPrice) from Products--14. Count the number of products whose UnitPrice is more then 50select Count(ProductID) from Products where UnitPrice > 50--15. List product count base on CategoryID. List the data where count is more then 10select Count(ProductID), CategoryID from Products group by CategoryID--16. Find all the products where UnitsInStock in less than Reorder Levelselect * from Products where UnitsInStock < ReorderLevel--17. List Category wise, Supplier wise product countselect CategoryID, SupplierID, count(productID) from Products group by CategoryID, SupplierID--18. All Products whose UnitsInStock is less than 5 units are entitles for placing order by 50 units for 
--others place the order by 30 units. Display ProductID, ProductName, UnitsInStock, 
--OrderedUnits.
select * from Products where UnitsInStock <5 and ReorderLevel in (30, 50)

--19. List 3 costliest product
select Top 3 * from Products order by UnitPrice desc
--20. List all the products whose CategoryID is 1 and SupplierID is either 10 or 12 or CategoryID is 4 
--and SupplierID is either 14 or 15.select * from Products where (CategoryID = 1 and supplierID in (10,12) ) or (CategoryID = 4 and SupplierID in (14,15))order by CategoryID------TABLE Orders-----select * from Orders--21. List all the orders placed in month of February
select * from Orders where Datepart(mm, OrderDate) in (2)

--22. List year wise order count
select count(OrderID) as Counts, datepart(yyyy, OrderDate) as years from Orders group by datepart(yyyy, OrderDate)

--23. List the ShipCountry for which total order placed is more than 100
--Example
--ShipCountry OrderCount
--  USA			122
select ShipCountry, count(OrderID) as OrderCount from Orders group by ShipCountry

--24. List the data as per the order month (Jan – Dec)
select * from Orders order by datepart(mm, OrderDate) 
--25. List unique country name in ascending order where product is shipped
select * from Orders order by ShipCountry, ShippedDate
--26. List CustomerID, ShipCity, ShipCountry, ShipRegion from Ordrs table. If ShipRegion is null than 
--display message as “No Region"
select CustomerID, ShipCity, ShipCountry, ShipRegion from Orders if isnull('No Region', ShipRegion)


--7. List the detail of first order placed
select top 1 * from Orders order by OrderDate 

--28. List Customer wise, Year wise (Order date) order placed
--Example
--CustomerID Year OrderCount
--  ANATR	 1996	   1
--  BONAP	 1997	   



--29. List all the orders handled by employeeid 4 for the month of December
--30. List employee wise , year wise, month wise ordercount---------------Table: [Order Details]-------

--31. List all the data of [Order Details] table


--32. List ProductID, UnitPrice, Qty and Total. Sort data on Total column with highest value on top


--33. In above query, 
--If Total is more than 10000 display 10% discount on Total cost
--If Total is more than 5000 display 5% discount on Total cost
--If Total is more than 3000 display 2% discount on Total cost
--else Rs. 300 as discount if total is more than 1000
--No discount for Total less than 1000


--34. List Total order placed for each OrderId
--35. List minimum cost and maximum cost order valu