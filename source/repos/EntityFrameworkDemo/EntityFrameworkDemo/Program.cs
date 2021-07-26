using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //NorthwindEntities db = new NorthwindEntities();
            //db.Configuration.LazyLoadingEnabled = false;
            //db.Database.Log = Console.WriteLine;



            //IEnumerable<Product> query1 = from p in db.Products select p;

            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item.ProductId + "\t" + item.ProductName + "\t" + item.QuantityPerUnit + "\t" + item.UnitPrice + "t");
            //}

            //list recore for productId =5
            //Product query2 = (from p in db.Products where p.ProductID == 5 select p).SingleOrDefault();
            //Console.WriteLine(query2.ProductID + "\t" + query2.ProductName + "\t" + query2.UnitPrice + "\n");

            //Console.WriteLine(query2);

            //Join Querry
            //var joinquery1 = from p in db.Products
            //                 join c in db.Categories on p.CategoryID equals c.CategoryID
            //                 select new { p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock,
            //                     c.CategoryName, c.Description };

            //left join querry
            //var leftjoinquery = from c in db.Categories
            //                    join p in db.Products
            //                    on c.CategoryID equals p.CategoryID
            //                    into productdata
            //                    from data in productdata.DefaultIfEmpty()
            //                    orderby c.CategoryName
            //                    select new { c.CategoryName, data.ProductName, data.UnitPrice };


            //var lazyloadingquery = from category in db.Categories select category;

            //foreach(var item in lazyloadingquery)
            //{
            //    Console.WriteLine($"For category {item.CategoryName} ----total product = {item.Products.Count()} \n");
            //}

            //var eagerloading = from category in db.Categories.Include("Products") select category;
            //foreach(var item in eagerloading)
            //{
            //    Console.WriteLine($" For category {item.CategoryName} ---total products are 
            //{item.Products.Count()} \n");
            //}

            //dml-- -using Linq
             //Product product = new Product()
             //{
             //    ProductName = "greantea",
             //    CategoryID = 1,
             //    UnitPrice = 100
             //};
            //db.Products.Add(newProduct);

            //db.SaveChanges();

            //Product product = db.Products.SingleOrDefault(p => p.ProductID == 70);

            //if(product !=null)
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



            //foreach(var item in joinquery1)
            //{
            //    Console.WriteLine(item.ProductID+"\t"+item.ProductName+"\t"+ item.UnitPrice+"\t"+item.UnitsInStock+"\t"
            //        +item.CategoryName+"\t"+item.Description+"\n");
            //}

            Console.ReadLine();
        }
    }
}
