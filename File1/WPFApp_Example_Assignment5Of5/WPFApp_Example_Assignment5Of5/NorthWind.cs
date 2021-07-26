using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp_Example_Assignment5Of5
{
    public static class NorthWind
    {

        public static DataSet CreateDataRelation()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database=Northwind; integrated security=true;");

                if(sqlConnection.State==ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlDataAdapter sqlCategoryDa = new SqlDataAdapter("select CategoryID,CategoryName FROM Categories", sqlConnection);

                SqlDataAdapter sqlProductDa = new SqlDataAdapter("select CategoryID,ProductID,ProductName,UnitPrice FROM Products", sqlConnection);

                DataSet dataSet = new DataSet();
                sqlCategoryDa.Fill(dataSet, "Categories");
                sqlProductDa.Fill(dataSet, "Products");

                DataRelation Dr = new DataRelation("DataRelationShip",
                    dataSet.Tables["Categories"].Columns["CategoryID"],
                    dataSet.Tables["Products"].Columns["CategoryID"],
                    true
                    );
                Dr.Nested = true;

                dataSet.Relations.Add(Dr);

                return dataSet;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }

    }
}
