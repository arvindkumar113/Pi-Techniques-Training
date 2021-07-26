using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Documents;

namespace SampleProject3
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        #region Properties
        /// <summary>
        /// connection to the local database SampleProject_db
        /// </summary>
        SqlConnection _connection = new SqlConnection(@"Server=(local);Database=SampleProject_db;Trusted_Connection=Yes;");

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeList"/> class.
        /// </summary>
        public EmployeeList()
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            try
            {
                //get employee data from database
                GetDataFromDb(dt);

                if (dt.Rows.Count > 0)
                {
                    List<Employee> lstEmployee = new List<Employee>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Employee emp = new Employee(dr);
                        lstEmployee.Add(emp);
                    }

                    ListViewEmployees.ItemsSource = lstEmployee;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (_connection != null && _connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the data from database
        /// </summary>
        /// <param name="dt">The datatable (where data is fetched).</param>
        private void GetDataFromDb(DataTable dt)
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            _connection.Open();
            Command.Connection = _connection;
            Command.CommandText = "SELECT e.[EmpId]" +
                                        ",e.[FirstName]" +
                                        ",e.[MiddleName]" +
                                        ",e.[LastName]" +
                                        ",e.[BirthDate]" +
                                        ",e.[Gender]" +
                                        ",e.[Address]" +
                                        ",e.[ContactNumber]" +
                                        ",e.[EmailId]" +
                                        ",e.[JoiningDate]" +
                                        ",e.[ConfirmationDate]" +
                                        ",e.[ExpectedInTime]" +
                                        ",e.[ExpectedOutTime]" +
                                        ",e.[IsResigned]" +
                                        ",e.[Salary]" +
                                        ",e.[Designation]" +
                                        ",e.[DeptId]" +
                                        ", d.[DeptName] AS DeptName" +
                                        " FROM [SampleProject_db].[dbo].[Employee] e" +
                                        " LEFT JOIN Department d ON e.DeptId = d.DeptId";
            Adapter.SelectCommand = Command;
            Adapter.Fill(dt);
            _connection.Close();
        }

        #endregion
    }

    // <summary>
    /// Employee format to bind employee list.
    /// </summary>
    public class Employee
    {
        #region Properties

        /// <summary>
        /// Gets or sets employee id.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets employee first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets employee middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets employee last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets employee birth date.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets gender.
        /// </summary>
        public char? Gender { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets contact number.
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets email id.
        /// </summary>
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets joining date.
        /// </summary>
        public DateTime? JoiningDate { get; set; }

        /// <summary>
        /// Gets or sets confirmation date.
        /// </summary>
        public DateTime? ConfirmationDate { get; set; }

        /// <summary>
        /// Gets or sets the value if employee has resigned.
        /// </summary>
        public bool IsResigned { get; set; }

        /// <summary>
        /// Gets or sets salary.
        /// </summary>
        public decimal? Salary { get; set; }

        /// <summary>
        /// Gets or sets designation.
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets Department id.
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets department name.
        /// </summary>
        public string DepartmentName { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="employeeData">The data row that contains data to initialize a new instance.</param>
        public Employee(DataRow employeeData)
        {
            EmployeeId = (int)employeeData[0];
            FirstName = employeeData[1].ToString();
            MiddleName = employeeData[2].ToString();
            LastName = employeeData[3].ToString();

            string StringBirthDate = employeeData[4].ToString();
            if (StringBirthDate != "")
            {
                BirthDate = Convert.ToDateTime(StringBirthDate);
            }

            string StringGender = employeeData[5].ToString();
            if (StringGender != "")
            {
                Gender = Convert.ToChar(StringGender);
            }

            Address = employeeData[6].ToString();
            ContactNumber = employeeData[7].ToString();
            EmailId = employeeData[8].ToString();

            string StringJoiningDate = employeeData[9].ToString();
            if (StringJoiningDate != "")
            {
                JoiningDate = Convert.ToDateTime(StringJoiningDate);
            }

            string StringConfirmationDate = employeeData[10].ToString();
            if (StringConfirmationDate != "")
            {
                ConfirmationDate = Convert.ToDateTime(StringConfirmationDate);
            }

            IsResigned = employeeData[13].ToString() == "" ? false : (bool)(employeeData[13]);
            Salary = employeeData[14].ToString() == "" ? null : (decimal?)employeeData[14];
            Designation = employeeData[15].ToString();
            DepartmentId = employeeData[16].ToString() == "" ? null : (int?)employeeData[16];
            DepartmentName = employeeData[17].ToString();
        }

        #endregion
    }

}
