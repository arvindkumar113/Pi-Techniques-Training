using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Using_Linq_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the entity northwind
            NorthwindEntities db = new NorthwindEntities();

            //here defining about lazyloading or eager loading and default is lazy
            db.Configuration.LazyLoadingEnabled = false;

            db.Database.Log = Console.WriteLine;

            //1.  list all the products
            //IEnumerable<Product> query1 = from p in db.Products select p;
            //foreach (Product item in query1)
            //{
            //    Console.WriteLine(item.ProductID + "\t" + item.ProductName + "\t\t" + item.QuantityPerUnit + "\t\t" + item.UnitPrice + "\n");
            //}

            ////list the products where productID =5
            //Product query2 = (from p in db.Products where p.ProductID == 5 select p).SingleOrDefault();
            //Console.WriteLine(query2.ProductID + "\t" + query2.ProductName + "\t\t" + query2.QuantityPerUnit + "\t\t" +
            //    query2.UnitPrice + "\n");
            ////tostring() method is not overloaded so below will not work
            ////Console.WriteLine(query2);



            //3.  List productid, productname, unitprice, unitinstock, categoryname and descripton from product and category
            //var query3 = from p in db.Products
            //             join c in db.Categories on p.CategoryID equals c.CategoryID
            //             select new { p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock, c.CategoryName, c.Description };
            //foreach( var item in query3)
            //{
            //    Console.WriteLine(item.ProductID + "\t" + item.ProductName + "\t\t" + item.UnitPrice + "\t\t" +
            //        item.UnitsInStock +"\t\t"+item.CategoryName+"\t\t"+item.Description +"\n");
            //}



            //4.  left Join
            //var query4 = from c in db.Categories
            //             join p in db.Products
            //            on c.CategoryID equals p.CategoryID into productdata
            //             from data in productdata.DefaultIfEmpty()
            //             orderby c.CategoryName
            //             select new { c.CategoryName, data.ProductName, data.UnitPrice };
            //foreach(var item in query4)
            //{
            //    Console.WriteLine("\n " + item.CategoryName + "\t\t" + item.ProductName + "\t\t\t" + item.UnitPrice + " ");
            //}

            // 5.  lazy loading

            //var lazyloadingQuery = from category in db.Categories select category;
            //foreach (var item in lazyloadingQuery)
            //{
            //    Console.WriteLine($"\n For Category {item.CategoryName} ---- Total Producs = {item.Products.Count()} \n");
            //}

            // 6.   Eager Loading
            // make this  db.Configuration.LazyLoadingEnabled = false;
            //var eagerloadingQuery = from category in db.Categories.Include("Products") select category;

            //foreach(var item in eagerloadingQuery)
            //{
            //    Console.WriteLine($"\n For caegory {item.CategoryName} ----Total Products = {item.Products.Count()} \n");
            //}



            // DML Operation using Linq


            //add products into Product table productname=Green Tea, categoryId=1, UnitPrice =100
            //Product product = new Product()
            //{
            //    ProductName = "Green Tea",
            //    CategoryID = 1,
            //    UnitPrice = 100
            //};

            //db.Products.Add(product);
            //db.SaveChanges();


            //Product product = db.Products.SingleOrDefault(p => p.ProductID == 70);

            //if (product != null)
            //{
            //    product.UnitPrice = 100;
            //    product.UnitsInStock = 0;
            //    db.SaveChanges();
            //}

            //Product updateProduct = new Product()
            //{
            //    ProductID = 77,
            //    ProductName = "coldCoffee",
            //    UnitPrice = 100
            //};

            //db.Entry(updateProduct).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();

            //var returnData = db.GetProductCount(1);
            //Console.WriteLine("Total Product count = " + returnData.First());








            Console.ReadKey();
        }
    }
}
