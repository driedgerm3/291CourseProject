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
    public partial class TransactionsViewProcess : Form
    {
        List<Transaction> transactionList = new List<Transaction>();
        public TransactionsViewProcess()
        {
            InitializeComponent();
            Pending_Transactions_Populate();
            Confirmed_Transactions_Populate();
            
        }

        private void vp_transactions_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (pendingTransactions.CheckedItems.Count != 0)
            {
                int i;
                for (i = 0; i <= (pendingTransactions.Items.Count - 1); i++)
                {
                    if (pendingTransactions.GetItemChecked(i))
                    {
                        //connect to sql server
                        string connetionString;
                        SqlConnection cnn;
                        connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
                        cnn = new SqlConnection(connetionString);
                        cnn.Open();
                        Transaction transaction = new Transaction();
                        foreach (Transaction element in transactionList)
                        {
                            if (element.ToString().Equals(pendingTransactions.Items[i].ToString()))
                            {
                                transaction = element;
                            }
                        }
                        string deleteString = "DELETE FROM dbo.OngoingTransactions where Rental_ID = " + pendingTransactions.Items[i].ToString();
                        SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);

                        string insertString = "INSERT INTO dbo.ProcessedTransactions(Customer_ID,Rental_ID) VALUES(@Customer_ID,@Rental_ID)";
                        SqlCommand insertCommand = new SqlCommand(insertString, cnn);
                        insertCommand.Parameters.AddWithValue("@Customer_ID", transaction.getCustomerID());
                        insertCommand.Parameters.AddWithValue("@Rental_ID", transaction.getRentalID());
                        try
                        {
                            deleteCommand.ExecuteNonQuery();
                            insertCommand.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show("Rental Number " + pendingTransactions.Items[i].ToString() + " has been confirmed");
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

        private void Pending_Transactions_Populate()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get edmonton cars
            SqlCommand command = new SqlCommand("Select * from [OngoingTransactions]", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                Transaction transaction = new Transaction((int)sqlReader["Rental_ID"], (int)sqlReader["Customer_ID"]);
                pendingTransactions.Items.Add(transaction);
                transactionList.Add(transaction);
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void Confirmed_Transactions_Populate()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get edmonton cars
            SqlCommand command = new SqlCommand("Select * from [ProcessedTransactions]", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate checked list box
                confirmedTransactions.Items.Add(sqlReader["Rental_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pendingTransactions.CheckedItems.Count != 0)
            {
                int i;
                for (i = 0; i <= (pendingTransactions.Items.Count - 1); i++)
                {
                    if (pendingTransactions.GetItemChecked(i))
                    {
                        //connect to sql server
                        string connetionString;
                        SqlConnection cnn;
                        connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
                        cnn = new SqlConnection(connetionString);
                        cnn.Open();
                        string deleteString = "DELETE FROM dbo.OngoingTransactions where Rental_ID = " + pendingTransactions.Items[i].ToString();
                        SqlCommand deleteCommand = new SqlCommand(deleteString, cnn);
                        try
                        {
                            deleteCommand.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show("Rental Number " + pendingTransactions.Items[i].ToString() + " has been deleted");
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
