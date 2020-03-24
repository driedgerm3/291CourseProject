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
    public partial class CustomerAddDelete : Form
    {
        public CustomerAddDelete()
        {
            InitializeComponent();
        }

        private void ad_customers_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddCustomer();

            form.Show();
            this.Hide();
        }
    }
}
