using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Documents;

namespace SampleProject1
{
    /// <summary>
    /// Interaction logic for EmployeeForm.xaml
    /// </summary>
    public partial class EmployeeForm : Window
    {
        #region Properties
        /// <summary>
        /// connection to the local database SampleProject_db
        /// </summary>
        SqlConnection _connection = new SqlConnection(@"Server=(local);Database=SampleProject_db;Trusted_Connection=Yes;");

        #endregion

        #region Constructors

        /// <summary>
        ///  Initializes a new instance of the <see cref="EmployeeForm"/> class.
        /// </summary>
        public EmployeeForm()
        {
            InitializeComponent();

            SqlCommand Command = new SqlCommand();
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                _connection.Open();
                Command.Connection = _connection;
                Command.CommandText = "select DeptId , DeptName from Department";
                Adapter.SelectCommand = Command;
                Adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    List<Department> lstDepartment = new List<Department>();

                    foreach(DataRow dr in dt.Rows)
                    {
                        Department d = new Department();
                        d.DepartmentId = (int)dr[0];
                        d.DepartmentName= dr[1].ToString();
                        lstDepartment.Add(d);

                    }
                   
                    foreach(Department dept in lstDepartment)
                    {
                        ComboBoxDepartments.Items.Add(dept);
                    }

                    ComboBoxDepartments.DisplayMemberPath = "DepartmentName";                  
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
        }

        #endregion

        #region Methods

        /// <summary>
        /// Saves employee details.
        /// </summary>
        /// <param name="sender">sender of event.</param>
        /// <param name="e"> event arguments.</param>
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {   
                string FirstName = null;
                if(TextBoxFirstName.Text!=null && TextBoxFirstName.Text.Trim() !="")
                {
                    FirstName = "'"+TextBoxFirstName.Text.ToString()+"'";
                }
                else
                {
                    FirstName ="'FirstName'";//Please note that the default first name will be "FirstName"
                }


                string MiddleName = null;
                if(TextBoxMiddleName.Text!=null && TextBoxMiddleName.Text.Trim() !="")
                {
                    MiddleName = "'"+TextBoxMiddleName.Text.ToString()+"'";
                }
                else
                {
                    MiddleName ="NULL";
                }


                string LastName = null;
                if (TextBoxLastName.Text != null && TextBoxLastName.Text.Trim() != "")
                {
                    LastName = "'" + TextBoxLastName.Text.ToString() + "'";
                }
                else
                {
                    LastName = "'LastName'";//Please note that the default last name will be "LastName"
                }


                string BirthDate = null;
                if(DatePickerBirthDate.SelectedDate!=null)
                {
                    DateTime dt = DatePickerBirthDate.SelectedDate.Value;
                    BirthDate = "'"+dt.Year + "-" + dt.Month + "-" + dt.Day+"'";
                }
                else
                {
                    BirthDate = "NULL";
                }


                string gender = "'M'";
                if ((bool)RadioButtonGenderMale.IsChecked)
                {
                    gender = "'M'";
                }
                else
                {
                    gender = "'F'";
                }


                string Address = null;
                if(TextBoxAddress.Text !=null && TextBoxAddress.Text.Trim()!="")
                {
                    Address = "'"+TextBoxAddress.Text+"'";
                }
                else
                {
                    Address = "NULL";
                }


                string ContactNumber = null;
                if(TextBoxContactNumber.Text!=null && TextBoxContactNumber.Text.Trim()!="")
                {
                    ContactNumber="'"+TextBoxContactNumber.Text+"'";
                }
                else
                {
                    ContactNumber = "NULL";
                }


                string EmailId = null;
                if(TextBoxEmailId.Text !=null && TextBoxEmailId.Text.Trim()!="")
                {
                    EmailId = "'"+TextBoxEmailId.Text+"'";
                }
                else
                {
                    EmailId = "NULL";
                }


                string JoiningDate = null;
                if (DatePickerJoiningDate.SelectedDate!= null)
                {
                    DateTime dt = DatePickerJoiningDate.SelectedDate.Value;
                    JoiningDate = "'"+dt.Year + "-" + dt.Month + "-" + dt.Day+"'";
                }
                else
                {
                    JoiningDate = "NULL";
                }


                string ConfirmationDate = null;
                if (DatePickerConfirmationDate.SelectedDate != null)
                {
                    DateTime dt = DatePickerConfirmationDate.SelectedDate.Value;
                    ConfirmationDate = "'"+dt.Year + "-" + dt.Month + "-" + dt.Day+"'";
                }
                else
                {
                    ConfirmationDate = "NULL";
                }


                string IsResigned = CheckBoxIsResigned.IsChecked==true ? "1" : "0";


                string Salary = null;
                if(TextBoxSalary.Text!=null && TextBoxSalary.Text.Trim() !="")
                {
                    Salary = TextBoxSalary.Text;
                }
                else
                {
                    Salary = "NULL";
                }


                string Designation = null;
                if(TextBoxDesignation.Text!=null && TextBoxDesignation.Text.Trim() !="")
                {
                    Designation = "'"+TextBoxDesignation.Text+"'";
                }
                else
                {
                    Designation = "NULL";
                }


                string DepatmentId = null;
                if (ComboBoxDepartments.SelectedItem != null)
                {
                    DepatmentId = ((Department)ComboBoxDepartments.SelectedItem).DepartmentId.ToString();
                }
                else
                {
                    DepatmentId = "NULL";
                }

                string strCommand= "INSERT INTO [dbo].[Employee] ([FirstName] ,[MiddleName] ,[LastName] ,[BirthDate] ,[Gender] ,[Address] ,[ContactNumber] ,[EmailId], [JoiningDate], [ConfirmationDate], [IsResigned], [Salary], [Designation], [DeptId]) VALUES ("+FirstName+","+MiddleName+","+LastName+","+BirthDate+","+gender+","+Address+","+ContactNumber+","+EmailId+","+JoiningDate+","+ConfirmationDate+","+IsResigned+","+Salary+","+Designation+","+DepatmentId+")";
                SqlCommand Command = new SqlCommand(strCommand, _connection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Employee data saved successfully.", "Save", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }


        /// <summary>
        /// Cancel save and closes the window.
        /// </summary>
        /// <param name="sender">sender of event.</param>
        /// <param name="e"> event arguments.</param>
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion
    }

    /// <summary>
    /// Department format to bind department ComboBox
    /// </summary>
    public class Department
    {
        #region Properties
        /// <summary>
        /// Gets or sets the department id.
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets department name.
        /// </summary>
        public string DepartmentName { get; set; }

        #endregion
    }
}

