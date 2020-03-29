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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new CarAddDelete();

            form.Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new EmployeeAddDelete();

            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new CustomerAddDelete();

            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new TransactionsViewProcess();

            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new GenerateReport();

            form.Show();
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
        private void Employee_FormClosing(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
