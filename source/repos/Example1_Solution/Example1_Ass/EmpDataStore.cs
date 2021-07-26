using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Example1_Ass;

namespace Example1_Ass_Library
{
    public class EmpDataStore
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand command=null;

        public EmpDataStore(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public List<Emp> Emp_Dept_Job(int deptno, string job)
        {

            string sql = "select empno, ename, hiredate, sal from emp where dptno=@dno and job=@empjob";

            SqlCommand Command = new SqlCommand(sql, connection);
            Command.Parameters.AddWithValue("dno", deptno);
            Command.Parameters.AddWithValue("empjob", job);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            List<Emp> empList = new List<Emp>();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.EmpNo = (int)reader["empno"];
                emp.EmpName = reader["ename"].ToString();
                emp.Salary = reader["sal"] as Decimal?;
                emp.HireDate = reader["hiredate"] as DateTime?;

                empList.Add(emp);
            }
            return empList;


        }




    }

}
