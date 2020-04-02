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
    public partial class VehicleDropoff : Form
    {
        string Customer_ID;
        public VehicleDropoff(string userID)
        {
            this.Customer_ID = userID;
            InitializeComponent();
            branchPopulate();
            carPopulate();
            if (rental.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No ongoing rentals");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            back();
        }

        private void back()
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is Customer)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(branch.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a branch");
            }
            else if (string.IsNullOrEmpty(rental.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a car");
            }
            else
            {
                string branch = this.branch.GetItemText(this.branch.SelectedItem);
                string rental = this.rental.GetItemText(this.rental.SelectedItem);
                sqlInserts(branch, rental);
            }
        }

        private void branchPopulate()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get branch ids
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

        private void carPopulate()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get car ids
            SqlCommand command = new SqlCommand("Select * from dbo.ProcessedTransactions where Customer_ID = @User_ID and Rental_ID not in (Select Rental_ID from Dropoff)", cnn);
            command.Parameters.AddWithValue("@User_ID", this.Customer_ID);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate combobox
                rental.Items.Add(sqlReader["Rental_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void sqlInserts(string branch, string rental)
        {
            //connect to sql server
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            //insert statment
            //insert statement
            string dropoffInsert = "INSERT INTO dbo.Dropoff(Branch_ID,Rental_ID) VALUES(@Branch_ID,@Rental_ID)";
            //insert values
            SqlCommand dropoffInsertcmd = new SqlCommand(dropoffInsert, cnn);
            dropoffInsertcmd.Parameters.AddWithValue("@Branch_ID", branch);
            dropoffInsertcmd.Parameters.AddWithValue("@Rental_ID", rental);

            //try inserts
            try
            {
                dropoffInsertcmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Dropoff location selected");
                back();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error, please try again");
            }
            cnn.Close();
        }
    }
}
