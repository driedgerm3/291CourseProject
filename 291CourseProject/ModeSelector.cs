﻿using System;
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
    public partial class ModeSelector : Form
    {
        public ModeSelector()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Employee();

            form.Show();
            this.Hide();
        }

        private void ModeSelector_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Customer();

            form.Show();
            this.Hide();
        }
    }
}
