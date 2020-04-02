using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft.Document;
using System.Data.SqlClient;

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
            CreatePdf();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
        private void Employee_FormClosing(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

        public static void CreatePdf()
        {
            // set up lists for employees, customers, cars and transactions (one list per branch)
            List<string> em1 = new List<string>();
            List<string> em2 = new List<string>();
            List<string> em3 = new List<string>();
            
            List<string> ca1 = new List<string>();
            List<string> ca2 = new List<string>();
            List<string> ca3 = new List<string>();

            List<string> cu = new List<string>();
            List<string> re = new List<string>();

            // set up sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            //*************************************************************************************************************************************************

            // build employee lists
            SqlCommand c1 = new SqlCommand("Select * from Employee where Branch_ID = 'Edmonton'", cnn);
            SqlDataReader r1 = c1.ExecuteReader();
            while (r1.Read())
            {
                em1.Add("ID: " + r1["Employee_ID"].ToString() + " Name: " + r1["First_Name"].ToString() + " " + r1["Last_Name"].ToString());
            }
            r1.Close();

            SqlCommand c2 = new SqlCommand("Select * from Employee where Branch_ID = 'Calgary'", cnn);
            SqlDataReader r2 = c2.ExecuteReader();
            while (r2.Read())
            {
                em2.Add("ID: " + r2["Employee_ID"].ToString() + " Name: " + r2["First_Name"].ToString() + " " + r2["Last_Name"].ToString());
            }
            r2.Close();

            SqlCommand c3 = new SqlCommand("Select * from Employee where Branch_ID = 'Leduc'", cnn);
            SqlDataReader r3 = c3.ExecuteReader();
            while (r3.Read())
            {
                em3.Add("ID: " + r3["Employee_ID"].ToString() + " Name: " + r3["First_Name"].ToString() + " " + r3["Last_Name"].ToString());
            }
            r3.Close();

            // build car lists
            SqlCommand c7 = new SqlCommand("Select * from Car where Branch_ID = 'Edmonton'", cnn);
            SqlDataReader r7 = c7.ExecuteReader();
            while (r7.Read())
            {
                ca1.Add("Car ID: " + r7["Car_ID"].ToString() + " Type ID: " + r7["Type_ID"].ToString() + " Passengers: " + r7["Passengers"].ToString());
            }
            r7.Close();

            SqlCommand c8 = new SqlCommand("Select * from Car where Branch_ID = 'Calgary'", cnn);
            SqlDataReader r8 = c8.ExecuteReader();
            while (r8.Read())
            {
                ca2.Add("Car ID: " + r8["Car_ID"].ToString() + " Type ID: " + r8["Type_ID"].ToString() + " Passengers: " + r8["Passengers"].ToString());
            }
            r8.Close();

            SqlCommand c9 = new SqlCommand("Select * from Car where Branch_ID = 'Leduc'", cnn);
            SqlDataReader r9 = c9.ExecuteReader();
            while (r9.Read())
            {
                ca3.Add("Car ID: " + r9["Car_ID"].ToString() + " Type ID: " + r9["Type_ID"].ToString() + " Passengers: " + r9["Passengers"].ToString());
            }
            r9.Close();

            //build customer list
            SqlCommand c4 = new SqlCommand("Select * from Customer", cnn);
            SqlDataReader r4 = c4.ExecuteReader();
            while (r4.Read())
            {
                cu.Add("ID: " + r4["Customer_ID"].ToString() + " - " + r4["First_Name"].ToString() + r4["Last_Name"].ToString());
            }
            r4.Close();

            // build rental list
            SqlCommand c10 = new SqlCommand("Select * from Rental", cnn);
            SqlDataReader r10 = c10.ExecuteReader();
            while (r10.Read())
            {
                re.Add("ID: " + r10["Rental_ID"].ToString() + " Pick-up Date: " + r10["Pickup_Date"].ToString() + " Drop-off Date: " + r10["Return_Date"].ToString());
            }
            r10.Close();

            // close sql connection
            cnn.Close();

            //*************************************************************************************************************************************************

            // set up PDF, make new section
            string pdfPath = @"testReport1.pdf";
            DocumentCore dc = new DocumentCore();

            Section section = new Section(dc);
            dc.Sections.Add(section);
            section.PageSetup.PaperType = PaperType.A4;

            CharacterFormat title = new CharacterFormat() { FontName = "Calibri", Size = 16, FontColor = SautinSoft.Document.Color.Black };
            CharacterFormat branch = new CharacterFormat() { FontName = "Calibri", Size = 12, FontColor = SautinSoft.Document.Color.Black, Bold = true };
            CharacterFormat body = new CharacterFormat() { FontName = "Calibri", Size = 12, FontColor = SautinSoft.Document.Color.Black };

            //*************************************************************************************************************************************************

            // top paragraph
            Paragraph par1 = new Paragraph(dc);
            par1.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Center;
            section.Blocks.Add(par1);

            Run text1 = new Run(dc, "CMB Rentals Report");
            text1.CharacterFormat = title;
            par1.Inlines.Add(text1);

            par1.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text2 = text1.Clone();
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            text2.Text = $"Date: {date}";
            par1.Inlines.Add(text2);

            //*************************************************************************************************************************************************

            // first branch
            Paragraph par2 = new Paragraph(dc);
            par2.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;
            section.Blocks.Add(par2);

            Run text3 = new Run(dc, "Edmonton Branch");
            text3.CharacterFormat = branch;
            par2.Inlines.Add(text3);

            par2.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text4 = new Run(dc, "Employees:");
            text4.CharacterFormat = body;
            par2.Inlines.Add(text4);

            par2.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string employee in em1)
            {
                Run text = text4.Clone();
                text.Text = employee;
                par2.Inlines.Add(text);
            }

            par2.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text11 = text4.Clone();
            text11.Text = "Cars:";
            par2.Inlines.Add(text11);

            par2.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string car in ca1)
            {
                Run text = text4.Clone();
                text.Text = car;
                par2.Inlines.Add(text);
            }

            par2.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            //*************************************************************************************************************************************************

            // second branch
            Paragraph par3 = new Paragraph(dc);
            par3.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;
            section.Blocks.Add(par3);

            Run text5 = text3.Clone();
            text5.Text = "Calgary Branch";
            par3.Inlines.Add(text5);

            par3.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text12 = text4.Clone();
            text12.Text = "Employees:";
            par3.Inlines.Add(text12);

            par3.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string employee in em2)
            {
                Run text = text4.Clone();
                text.Text = employee;
                par3.Inlines.Add(text);
            }

            par3.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text13 = text4.Clone();
            text13.Text = "Cars:";
            par3.Inlines.Add(text13);

            par3.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string car in ca2)
            {
                Run text = text4.Clone();
                text.Text = car;
                par3.Inlines.Add(text);
            }

            par3.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            //*************************************************************************************************************************************************

            // third branch
            Paragraph par4 = new Paragraph(dc);
            par4.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;
            section.Blocks.Add(par4);

            Run text7 = text3.Clone();
            text7.Text = "Leduc Branch";
            par4.Inlines.Add(text7);

            par4.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text14 = text4.Clone();
            text14.Text = "Employees:";
            par4.Inlines.Add(text14);

            par4.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string employee in em3)
            {
                Run text = text4.Clone();
                text.Text = employee;
                par4.Inlines.Add(text);
            }

            par4.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text15 = text4.Clone();
            text15.Text = "Cars:";
            par4.Inlines.Add(text15);

            par4.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string car in ca3)
            {
                Run text = text4.Clone();
                text.Text = car;
                par4.Inlines.Add(text);
            }

            par4.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            //*************************************************************************************************************************************************

            // customers
            Paragraph par5 = new Paragraph(dc);
            par5.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;
            section.Blocks.Add(par5);

            Run text16 = text3.Clone();
            text16.Text = "Customers:";
            par5.Inlines.Add(text16);

            par5.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string customer in cu)
            {
                Run text = text4.Clone();
                text.Text = customer;
                par5.Inlines.Add(text);
            }

            par5.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            //*************************************************************************************************************************************************

            // rentals
            Paragraph par6 = new Paragraph(dc);
            par6.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;
            section.Blocks.Add(par6);

            Run text17 = text3.Clone();
            text17.Text = "Rental Transactions:";
            par6.Inlines.Add(text17);

            par6.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            foreach (string rental in re)
            {
                Run text = text4.Clone();
                text.Text = rental;
                par6.Inlines.Add(text);
            }

            par6.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            //*************************************************************************************************************************************************

            // save and open
            dc.Save(pdfPath, new PdfSaveOptions());
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfPath) { UseShellExecute = true });
        }
    }
}