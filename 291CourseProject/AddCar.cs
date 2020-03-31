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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
            Populate_Car_Type();
            Populate_Branch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is CarAddDelete)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(branch.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a branch");
            }
            else if (string.IsNullOrEmpty(carType.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a car type");
            }
            else
            {
                sqlInsert();
            }
        }

        private void Car_Added()
        {
            System.Windows.Forms.MessageBox.Show("A new car has been added.");

            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is CarAddDelete)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void Populate_Car_Type()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //select statement, get car ids
            SqlCommand command = new SqlCommand("Select * from [Car_Type]", cnn);
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                //populate combobox
                carType.Items.Add(sqlReader["Type_ID"].ToString());
            }
            sqlReader.Close();
            cnn.Close();
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

        private void sqlInsert()
        {
            //connect to sql server
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            int Car_ID = getCarID(cnn);

            cnn.Open();


            string carInsert = "INSERT INTO dbo.Car(Car_ID,Type_ID,Branch_ID,Passengers) VALUES(@Car_ID,@Type_ID,@Branch_ID,@Passengers)";
            //insert values
            SqlCommand carInsertcmd = new SqlCommand(carInsert, cnn);
            carInsertcmd.Parameters.AddWithValue("@Car_ID", Car_ID);
            carInsertcmd.Parameters.AddWithValue("@Type_ID", carType.GetItemText(carType.SelectedItem));
            carInsertcmd.Parameters.AddWithValue("@Branch_ID", branch.GetItemText(branch.SelectedItem));
            carInsertcmd.Parameters.AddWithValue("@Passengers", numOfPassengers.Value.ToString());

            SqlCommand command = new SqlCommand("Update IDTracker Set Car_ID = Car_ID + 1", cnn);
            //try inserts
            try
            {
                carInsertcmd.ExecuteNonQuery();
                command.ExecuteNonQuery();
                Car_Added();

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error, please try again");
            }
            cnn.Close();
        }

        private int getCarID(SqlConnection cnn)
        {
            //Method to get current rental id
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * from IDTracker", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            int[] Car_ID = { 0 };
            while (rdr.Read())
            {
                Car_ID[0] = (int)rdr["Car_ID"];
            }
            rdr.Close();
            cnn.Close();
            return Car_ID[0];
        }
    }
}
