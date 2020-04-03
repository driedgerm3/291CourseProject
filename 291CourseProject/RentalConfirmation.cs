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
    public partial class RentalConfirmation : Form
    {
        public RentalConfirmation(int Rental_ID, int charge, string rentalLength)
        {
            InitializeComponent();
            rental.Text = Rental_ID.ToString();
            price.Text = charge.ToString();
            recurance.Text = rentalLength;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is ModeSelector)
                {
                    oForm.Show();
                    break;
                }
                else oForm.Close();
            }
            this.Close();
        }
    }
}
