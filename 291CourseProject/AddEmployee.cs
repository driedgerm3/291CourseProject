using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291CourseProject
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            Populate_Branch();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is EmployeeAddDelete)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(branch.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a branch");
            }
            else if (First_Name.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Please add a first name");
            }
            else if (Last_Name.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Please add a last name");
            }
            else
            {
                sqlInsert();
            }
        }

        private void Employee_Added()
        {
            System.Windows.Forms.MessageBox.Show("A new employee has been added.");

            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is EmployeeAddDelete)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void Populate_Branch()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get car ids
            SqlCommand command = new SqlCommand("Select * from [Branch]", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate combobox
                branch.Items.Add(sqlReader["Branch_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
        }

        private int getEmployeeID(SqlConnection cnn)
        {
            //Method to get current employee id
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * from IDTracker", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            int[] Employee_ID = { 0 };
            while (rdr.Read())
            {
                Employee_ID[0] = (int)rdr["Employee_ID"];
            }
            rdr.Close();
            cnn.Close();
            return Employee_ID[0];
        }

        private void sqlInsert()
        {
            //connect to sql server
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            int Employee_ID = getEmployeeID(cnn);

            cnn.Open();


            string employeeInsert = "INSERT INTO dbo.Employee(Employee_ID,First_Name,Last_Name,Branch_ID) VALUES(@Employee_ID,@First_Name,@Last_Name,@Branch_ID)";
            //insert values
            SqlCommand employeeInsertcmd = new SqlCommand(employeeInsert, cnn);
            employeeInsertcmd.Parameters.AddWithValue("@Employee_ID", Employee_ID);
            employeeInsertcmd.Parameters.AddWithValue("@First_Name", First_Name.Text);
            employeeInsertcmd.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
            employeeInsertcmd.Parameters.AddWithValue("@Branch_ID", branch.GetItemText(branch.SelectedItem));

            SqlCommand command = new SqlCommand("Update IDTracker Set Employee_ID = Employee_ID + 1", cnn);
            //try inserts
            try
            {
                employeeInsertcmd.ExecuteNonQuery();
                command.ExecuteNonQuery();
                Employee_Added();

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error, please try again");
            }
            cnn.Close();
        }
    }
}
