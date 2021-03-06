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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get car ids
            SqlCommand command = new SqlCommand("Select * from [Customer]", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate combobox
                users.Items.Add(sqlReader["Customer_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is ModeSelector)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(users.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a Customer ID");
            }
            else
            {
                string Customer_ID = this.users.GetItemText(this.users.SelectedItem);
                var form = new PickupDetails(Customer_ID);

                form.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(users.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a Customer ID");
            }
            else
            {
                string Customer_ID = this.users.GetItemText(this.users.SelectedItem);
                var form = new VehicleDropoff(Customer_ID);

                form.Show();
                this.Hide();
            }
        }
    }
}
