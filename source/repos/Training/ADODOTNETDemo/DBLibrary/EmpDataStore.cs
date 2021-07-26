using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;




namespace DBLibrary
{
    public class EmpDataStore
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataReader reader = null;

        public EmpDataStore(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
        }


        public Emp GetEmps(int empNo)
        {
            try
            {
                string sql = "select empno, ename, hiredate, sal from emp where empno=@empNo";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("empNo", empNo);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                Emp emp = null;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    emp.EmpNo = (int)reader["empno"];
                    emp.EmpName = reader["ename"].ToString();
                    emp.Salary = reader["sal"] as Decimal?;
                    emp.HireDate = reader["hiredate"] as DateTime?;

                }


                return emp;
            }
            catch(SqlException)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        //create a method to insert into table emp
        //take all input from user
        public int InsertInEmp(Emp empobj)
        {
            try
            {
                string sql = "Insert into employee (empno, empname, hiredate, sal) values " +
                    "(@EmpNo, EmpName, @HireDate, @Salary)";

                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("EmpNo", empobj.EmpNo);
                command.Parameters.AddWithValue("EmpName", empobj.EmpName);
                command.Parameters.AddWithValue("HireDate", empobj.HireDate);
                command.Parameters.AddWithValue("Salary", empobj.Salary);

                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                return count;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }


        public int InsertEmp_SP(Emp emp)
        {

            try
            {
                command = new SqlCommand("InsertEmp_SP", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("EmpNo", emp.EmpNo);
                command.Parameters.AddWithValue("EmpName", emp.EmpName);
                command.Parameters.AddWithValue("HireDate", emp.HireDate);
                command.Parameters.AddWithValue("Salary", emp.Salary);


                foreach (SqlParameter item in command.Parameters)
                {
                    if (item.Value == null)
                    {
                        item.Value = DBNull.Value;
                    }
                }

                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                return count;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }



        public List<Emp> GetEmpsDetails()
        {
            List<Emp> empList = new List<Emp>();
            try
            {
                string sql = "select empno, empname, hiredate, salary from employee";
                command = new SqlCommand(sql, connection);

                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Emp emp = new Emp();
                    emp.EmpNo = (int)reader["empno"];
                    emp.EmpName = reader["ename"].ToString();
                    emp.Salary = reader["sal"] as Decimal?;
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return empList;
        }


    }
}
