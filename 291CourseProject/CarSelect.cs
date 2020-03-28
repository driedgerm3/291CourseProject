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
    public partial class CarSelect : Form
    {
        string selectedBranch;
        DateTime pickupDate;
        DateTime dropoffDate;
        TimeSpan pickupTime;
        TimeSpan dropoffTime;
        public CarSelect(string selectedBranch, DateTime pickupDate, DateTime dropoffDate, TimeSpan pickupTime, TimeSpan dropoffTime)
        {
            this.selectedBranch = selectedBranch;
            this.pickupDate = pickupDate;
            this.dropoffDate = dropoffDate;
            this.pickupTime = pickupTime;
            this.dropoffTime = dropoffTime;
            InitializeComponent();
            //sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get car ids
            SqlCommand command = new SqlCommand("Select * from [Car] where Branch_ID = " + selectedBranch, cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate combobox
                carComboBox.Items.Add(sqlReader["Car_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
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
            if (string.IsNullOrEmpty(carComboBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a car");
            }
            else
            {
                string selectedCar = this.carComboBox.GetItemText(this.carComboBox.SelectedItem);
                sqlInserts(selectedCar);
            }
        }


        private void sqlInserts(string selectedCar)
        {
            //connect to sql server
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            int Rental_ID = getRentalID(cnn);

            cnn.Open();
            //insert statment
            string rentalInsert = "INSERT INTO dbo.Rental(Rental_id,Rental_Type,Pickup_Date,Pickup_time,Return_Date,Return_Time) VALUES(@Rental_id,@Rental_Type,@Pickup_Date,@Pickup_time,@Return_Date,@Return_Time)";
            //insert values
            SqlCommand rentalInsertcmd = new SqlCommand(rentalInsert, cnn);
            rentalInsertcmd.Parameters.AddWithValue("@Rental_ID", Rental_ID);
            rentalInsertcmd.Parameters.AddWithValue("@Rental_Type", 2);
            rentalInsertcmd.Parameters.AddWithValue("@Pickup_Date", this.pickupDate);
            rentalInsertcmd.Parameters.AddWithValue("@Pickup_time", this.pickupTime);
            rentalInsertcmd.Parameters.AddWithValue("@Return_Date", this.dropoffDate);
            rentalInsertcmd.Parameters.AddWithValue("@Return_Time", this.pickupTime);

            //insert statement
            string rentedInsert = "INSERT INTO dbo.Rented(Rental_ID,Car_ID) VALUES(@Rental_ID,@Car_ID)";
            //insert values
            SqlCommand rentedInsertcmd = new SqlCommand(rentedInsert, cnn);
            rentedInsertcmd.Parameters.AddWithValue("@Rental_ID", Rental_ID);
            rentedInsertcmd.Parameters.AddWithValue("@Car_ID", selectedCar);

            //try inserts
            try
            {
                rentalInsertcmd.ExecuteNonQuery();
                rentedInsertcmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Rental has been accepted\nProgram will now close");
                Application.Exit();

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error, please try again");
            }
            cnn.Close();
        }

        private int getRentalID(SqlConnection cnn)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * from IDTracker", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            int[] Rental_ID = { 0 };
            while (rdr.Read())
            {
                Rental_ID[0] = (int)rdr["Rental_ID"];
            }
            rdr.Close();
            SqlCommand command = new SqlCommand("Update IDTracker Set Rental_ID = Rental_ID + 1", cnn);
            command.ExecuteNonQuery();
            cnn.Close();
            return Rental_ID[0];
        }
    }
}