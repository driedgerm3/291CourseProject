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
    public partial class EmployeeAddDelete : Form
    {
        List<Person> edmontonList = new List<Person>();
        List<Person> calgaryList = new List<Person>();
        List<Person> leducList = new List<Person>();
        public EmployeeAddDelete()
        {
            InitializeComponent();
            Checked_List_Box_Populate_Edmonton();
            Checked_List_Box_Populate_Leduc();
            Checked_List_Box_Populate_Calgary();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is Employee)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new AddEmployee();

            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0 && checkedListBox2.CheckedItems.Count == 0 && checkedListBox3.CheckedItems.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Select an employee to delete");
            }
            else
            {
                edmontonDelete();
                calgaryDelete();
                leducDelete();
            }
        }

        private void EmployeeAddDelete_Load(object sender, EventArgs e)
        {

        }

        private void Checked_List_Box_Populate_Edmonton()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get edmonton cars
            SqlCommand command = new SqlCommand("Select * from [Employee] where Branch_ID = '1'", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                Person person = new Person((int)sqlReader["Employee_ID"], sqlReader["First_Name"].ToString(), sqlReader["Last_Name"].ToString());
                checkedListBox1.Items.Add(person);
                edmontonList.Add(person);
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void Checked_List_Box_Populate_Calgary()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get edmonton cars
            SqlCommand command = new SqlCommand("Select * from [Employee] where Branch_ID = '2'", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                Person person = new Person((int)sqlReader["Employee_ID"], sqlReader["First_Name"].ToString(), sqlReader["Last_Name"].ToString());
                checkedListBox2.Items.Add(person);
                calgaryList.Add(person);
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void Checked_List_Box_Populate_Leduc()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get edmonton cars
            SqlCommand command = new SqlCommand("Select * from [Employee] where Branch_ID = '3'", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                Person person = new Person((int)sqlReader["Employee_ID"], sqlReader["First_Name"].ToString(), sqlReader["Last_Name"].ToString());
                checkedListBox3.Items.Add(person);
                leducList.Add(person);
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void edmontonDelete()
        {
            int i;
            for (i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    //connect to sql server
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    string deleteString = "DELETE FROM dbo.Employee where Employee_ID = " + edmontonList[i].getID();
                    SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(edmontonList[i].getName() + " has been deleted");
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Error, please try again");
                    }
                    cnn.Close();

                }
            }
        }

        private void calgaryDelete()
        {
            int i;
            for (i = 0; i <= (checkedListBox2.Items.Count - 1); i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    //connect to sql server
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    string deleteString = "DELETE FROM dbo.Employee where Employee_ID = " + calgaryList[i].getID();
                    SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(calgaryList[i].getName() + " has been deleted");
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Error, please try again");
                    }
                    cnn.Close();

                }
            }
        }

        private void leducDelete()
        {
            int i;
            for (i = 0; i <= (checkedListBox3.Items.Count - 1); i++)
            {
                if (checkedListBox3.GetItemChecked(i))
                {
                    //connect to sql server
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    string deleteString = "DELETE FROM dbo.Employee where Employee_ID = " + leducList[i].getID();
                    SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(leducList[i].getName() + " has been deleted");
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Error, please try again");
                    }
                    cnn.Close();

                }
            }
        }
    }
}
