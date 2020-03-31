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
            }
            sqlReader.Close();
            cnn.Close();
        }
    }
}
