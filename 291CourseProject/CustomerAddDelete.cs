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
    public partial class CustomerAddDelete : Form
    {
        List<Person> personList = new List<Person>();
        public CustomerAddDelete()
        {
            InitializeComponent();
            Checked_List_Box_Populate();
        }

        private void ad_customers_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddCustomer();

            form.Show();
            this.Hide();
        }

        private void Checked_List_Box_Populate()
        {

            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get edmonton cars
            SqlCommand command = new SqlCommand("Select * from [Customer]", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                Person person = new Person((int)sqlReader["Customer_ID"], sqlReader["First_Name"].ToString(), sqlReader["Last_Name"].ToString());
                checkedListBox1.Items.Add(person);
                personList.Add(person);
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
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
                        string deleteString = "DELETE FROM dbo.Customer where Customer_ID = " + personList[i].getID();
                        SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                        try
                        {
                            deleteCommand.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show(personList[i].getName() + " has been deleted");
                        }
                        catch
                        {
                            System.Windows.Forms.MessageBox.Show("Error, please try again");
                        }
                        cnn.Close();

                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select customers to delete");
            }
        }
    }
}
