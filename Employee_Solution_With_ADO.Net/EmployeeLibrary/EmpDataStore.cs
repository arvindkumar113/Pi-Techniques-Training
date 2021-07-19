using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class EmpDataStore
    {
        //sqlconnection
        SqlConnection connection;

        //SqlDataReader
        SqlDataReader reader;

        //SqlDataAdapter
        //SqlDataAdapter adapter;

        //command
        SqlCommand command;

        public EmpDataStore(string connectionString)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        public List<Emp> GetAllEmployeeDetails()
        {
            List<Emp> empList = new List<Emp>();

            try
            {
                string sql = "select empNo, empname, hiredate, SALARY from employee";

                command = new SqlCommand(sql, connection);

                if(connection.State==ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Emp emp = new Emp();
                    emp.EmpNo = (int)reader["empNo"];
                    emp.EmpName = reader["empname"].ToString();
                    emp.Salary = Convert.ToDecimal(reader["SALARY"]);
                    //emp.Salary= reader["SALARY"] as decimal?;
                    emp.HireDate = reader["hiredate"] as DateTime?;

                    empList.Add(emp);
                    emp = null;

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return empList;
        }


        //method to get employee by employee number
        public Emp GetEmpByEmpNo(int employeenumber)
        {
            Emp emp = new Emp();
            try
            {
                string sql = "select empno, ename, hiredate, sal from emp where empno=@empNo";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("empNo", employeenumber);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    emp.EmpNo = (int) reader["empno"];
                    emp.EmpName = (string) reader["ename"];
                    emp.HireDate = (DateTime) reader["hiredate"];
                    emp.Salary = (decimal)reader["sal"];
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return emp;
        }

        //method to insert single record
        public bool InsertInEmp(Emp empObj)
        {
            try
            {
                string sql = "Insert into employee (empno, empname, hiredate, salary) values " +
                        "(@EmpNo, EmpName, @HireDate, @Salary)";

                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("EmpNo", empObj.EmpNo);
                command.Parameters.AddWithValue("EmpName", empObj.EmpName);
                command.Parameters.AddWithValue("HireDate", empObj.HireDate);
                command.Parameters.AddWithValue("Salary", empObj.Salary);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                if (count == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        //method to insert employee details using stored procedure
        public bool InsertEmployeeUsing_StoredProcedure(Emp empObj)
        {
            try
            {
                command = new SqlCommand("INSERTEMPLOYEE_SP", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("EmpNo", empObj.EmpNo);
                command.Parameters.AddWithValue("EmpName", empObj.EmpName);
                command.Parameters.AddWithValue("HireDate", empObj.HireDate);
                command.Parameters.AddWithValue("Salary", empObj.Salary);

                foreach (SqlParameter item in command.Parameters)
                {
                    if (item.Value == null)
                    {
                        item.Value = DBNull.Value;
                    }
                }

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                if (count == 0)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            
        }





    }
}
