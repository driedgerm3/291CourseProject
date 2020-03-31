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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is CustomerAddDelete)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Email.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Please add an email");
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

        private void Customer_Added()
        {
            System.Windows.Forms.MessageBox.Show("A new customer has been added.");

            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is CustomerAddDelete)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private int getCustomerID(SqlConnection cnn)
        {
            //Method to get current customer id
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * from IDTracker", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            int[] Customer_ID = { 0 };
            while (rdr.Read())
            {
                Customer_ID[0] = (int)rdr["Customer_ID"];
            }
            rdr.Close();
            cnn.Close();
            return Customer_ID[0];
        }

        private void sqlInsert()
        {
            //connect to sql server
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            int Customer_ID = getCustomerID(cnn);

            cnn.Open();


            string customerInsert = "INSERT INTO dbo.Customer(Customer_ID,First_Name,Last_Name,Num_Of_Rentals,Membership,Email) VALUES(@Customer_ID,@First_Name,@Last_Name,@Num_Of_Rentals,@Membership,@Email)";
            //insert values
            SqlCommand customerInsertcmd = new SqlCommand(customerInsert, cnn);
            customerInsertcmd.Parameters.AddWithValue("@Customer_ID", Customer_ID);
            customerInsertcmd.Parameters.AddWithValue("@First_Name", First_Name.Text);
            customerInsertcmd.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
            customerInsertcmd.Parameters.AddWithValue("@Num_Of_Rentals", 0);
            customerInsertcmd.Parameters.AddWithValue("@Membership", 1);
            customerInsertcmd.Parameters.AddWithValue("@Email", Email.Text);


            SqlCommand command = new SqlCommand("Update IDTracker Set Customer_ID = Customer_ID + 1", cnn);
            //try inserts
            try
            {
                customerInsertcmd.ExecuteNonQuery();
                command.ExecuteNonQuery();
                Customer_Added();

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error, please try again");
            }
            cnn.Close();
        }
    }
}
