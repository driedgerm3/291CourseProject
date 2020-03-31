using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
