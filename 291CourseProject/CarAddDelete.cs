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
    public partial class CarAddDelete : Form
    {
        List<string> edmontonList = new List<string>();
        List<string> calgaryList = new List<string>();
        List<string> leducList = new List<string>();
        public CarAddDelete()
        {
            InitializeComponent();
            Checked_List_Box_Populate_Edmonton();
            Checked_List_Box_Populate_Calgary();
            Checked_List_Box_Populate_Leduc();
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

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddCar();

            form.Show();
            this.Hide();
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
            SqlCommand command = new SqlCommand("Select * from [Car] where Branch_ID = '1'", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                checkedListBox1.Items.Add(sqlReader["Car_ID"].ToString());
                edmontonList.Add(sqlReader["Car_ID"].ToString());
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
            SqlCommand command = new SqlCommand("Select * from [Car] where Branch_ID = '2'", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                checkedListBox2.Items.Add(sqlReader["Car_ID"].ToString());
                calgaryList.Add(sqlReader["Car_ID"].ToString());
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
            SqlCommand command = new SqlCommand("Select * from [Car] where Branch_ID = '3'", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                checkedListBox3.Items.Add(sqlReader["Car_ID"].ToString());
                leducList.Add(sqlReader["Car_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
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
                    string deleteString = "DELETE FROM dbo.Car where Car_ID = " + edmontonList[i];
                    SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(edmontonList[i] + " has been deleted");
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
                    string deleteString = "DELETE FROM dbo.Car where Car_ID = " + calgaryList[i];
                    SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(calgaryList[i] + " has been deleted");
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
                    string deleteString = "DELETE FROM dbo.Car where Car_ID = " + leducList[i];
                    SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(leducList[i] + " has been deleted");
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
