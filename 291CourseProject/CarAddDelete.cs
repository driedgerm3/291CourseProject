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
    public partial class CarAddDelete : Form
    {
        public CarAddDelete()
        {
            InitializeComponent();
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
    }
}
