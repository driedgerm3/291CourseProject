﻿using System;
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
    public partial class PickupDetails : Form
    {
        string Customer_ID;
        public PickupDetails(string userID)
        {
            this.Customer_ID = userID;
            InitializeComponent();
            pickupDate.Value = DateTime.Today;
            pickupTime.Value = DateTime.Now;
            dropoffDate.Value = DateTime.Today.AddDays(1);
            dropoffTime.Value = DateTime.UtcNow;
            branchesPopulate();
        }

        private void branchesPopulate()
        {
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get branches
            SqlCommand command = new SqlCommand("Select * from [Branch]", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate combobox
                branches.Items.Add(sqlReader["Branch_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(branches.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a pickup location");
            }
            else
            {
                //get values
                string selectedBranch = this.branches.GetItemText(this.branches.SelectedItem);
                DateTime pickupDate = this.pickupDate.Value.Date;
                TimeSpan pickupTime = this.pickupTime.Value.TimeOfDay;
                DateTime dropoffDate = this.dropoffDate.Value.Date;
                TimeSpan dropoffTime = this.dropoffTime.Value.TimeOfDay;
                
                //run next form with selected values
                var form = new CarSelect(selectedBranch, pickupDate, dropoffDate, pickupTime, dropoffTime, this.Customer_ID);

                form.Show();
                this.Hide();
            }
        }

        private void PickupDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
