using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SautinSoft.Document;

namespace _291CourseProject
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
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

        private void GenerateReport_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {    
            CreatePdf();
        }
        public static void CreatePdf()
        {
            // set up lists for employees, customers, cars and transactions (one list per branch)
            List<string> em1 = new List<string>();
            List<string> em2 = new List<string>();
            List<string> em3 = new List<string>();

            List<string> cu1 = new List<string>();
            List<string> cu2 = new List<string>();
            List<string> cu3 = new List<string>();

            List<string> ca1 = new List<string>();
            List<string> ca2 = new List<string>();
            List<string> ca3 = new List<string>();

            List<string> re = new List<string>();

            // set up sql connection
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            //*************************************************************************************************************************************************

            // build employee lists
            SqlCommand c1 = new SqlCommand("Select * from Employee where Branch_ID = '1'", cnn);
            SqlDataReader r1 = c1.ExecuteReader();
            while (r1.Read())
            {
                em1.Add("ID: " + r1["Employee_ID"].ToString() + " Name: " + r1["First_Name"].ToString() + " " + r1["Last_Name"].ToString());
            }
            r1.Close();

            SqlCommand c2 = new SqlCommand("Select * from Employee where Branch_ID = '2'", cnn);
            SqlDataReader r2 = c2.ExecuteReader();
            while (r2.Read())
            {
                em2.Add("ID: " + r2["Employee_ID"].ToString() + " Name: " + r2["First_Name"].ToString() + " " + r2["Last_Name"].ToString());
            }
            r2.Close();

            SqlCommand c3 = new SqlCommand("Select * from Employee where Branch_ID = '3'", cnn);
            SqlDataReader r3 = c3.ExecuteReader();
            while (r3.Read())
            {
                em3.Add("ID: " + r3["Employee_ID"].ToString() + " Name: " + r3["First_Name"].ToString() + " " + r3["Last_Name"].ToString());
            }
            r3.Close();

            // build customer lists
            SqlCommand c4 = new SqlCommand("Select * from Customer where Branch_ID = '1'", cnn);
            SqlDataReader r4 = c4.ExecuteReader();
            while (r4.Read())
            {
                cu1.Add("ID: " + r4["Customer_ID"].ToString() + " - " + r4["First_Name"].ToString() + r4["Last_Name"].ToString());
            }
            r4.Close();

            SqlCommand c5 = new SqlCommand("Select * from Customer where Branch_ID = '2'", cnn);
            SqlDataReader r5 = c5.ExecuteReader();
            while (r5.Read())
            {
                cu2.Add("ID: " + r5["Customer_ID"].ToString() + " - " + r5["First_Name"].ToString() + r5["Last_Name"].ToString());
            }
            r5.Close();

            SqlCommand c6 = new SqlCommand("Select * from Customer where Branch_ID = '3'", cnn);
            SqlDataReader r6 = c6.ExecuteReader();
            while (r6.Read())
            {
                cu3.Add("ID: " + r6["Customer_ID"].ToString() + " - " + r6["First_Name"].ToString() + r6["Last_Name"].ToString());
            }
            r6.Close();

            // build car lists
            SqlCommand c7 = new SqlCommand("Select * from Cars where Branch_ID = '1'", cnn);
            SqlDataReader r7 = c7.ExecuteReader();
            while (r7.Read())
            {
                ca1.Add("Car ID: " + r7["Car_ID"].ToString() + " Type ID: " + r7["Type_ID"].ToString() + " Passengers: " + r7["Passengers"].ToString());
            }
            r7.Close();

            SqlCommand c8 = new SqlCommand("Select * from Cars where Branch_ID = '2'", cnn);
            SqlDataReader r8 = c8.ExecuteReader();
            while (r8.Read())
            {
                ca2.Add("Car ID: " + r8["Car_ID"].ToString() + " Type ID: " + r8["Type_ID"].ToString() + " Passengers: " + r8["Passengers"].ToString());
            }
            r8.Close();

            SqlCommand c9 = new SqlCommand("Select * from Cars where Branch_ID = '3'", cnn);
            SqlDataReader r9 = c9.ExecuteReader();
            while (r9.Read())
            {
                ca3.Add("Car ID: " + r9["Car_ID"].ToString() + " Type ID: " + r9["Type_ID"].ToString() + " Passengers: " + r9["Passengers"].ToString());
            }
            r9.Close();

            // build rental list
            SqlCommand c10 = new SqlCommand("Select * from Rental", cnn);
            SqlDataReader r10 = c10.ExecuteReader();
            while (r10.Read())
            {
                re.Add("ID: " + r10["Rental_ID"].ToString() + " Pick-up Date: " + r10["Pickup_Date"].ToString() + " Drop-off Date: " + r10["Dropoff_Date"].ToString());
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
                Run text = text3.Clone();
                text.Text = employee;
                par2.Inlines.Add(text);
            }

            //*************************************************************************************************************************************************

            // second branch
            Paragraph par3 = new Paragraph(dc);
            par3.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;
            section.Blocks.Add(par3);

            Run text5 = text3.Clone();
            text5.Text = "Calgary Branch";
            par3.Inlines.Add(text5);

            par3.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text6 = text4.Clone();
            text6.Text = "insert data here...";
            par3.Inlines.Add(text6);

            //*************************************************************************************************************************************************

            // third branch
            Paragraph par4 = new Paragraph(dc);
            par4.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;
            section.Blocks.Add(par4);

            Run text7 = text3.Clone();
            text7.Text = "Leduc Branch";
            par4.Inlines.Add(text7);

            par4.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

            Run text8 = text4.Clone();
            text8.Text = "insert data here...";
            par4.Inlines.Add(text8);

            //*************************************************************************************************************************************************

            // save and open
            dc.Save(pdfPath, new PdfSaveOptions());
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfPath) { UseShellExecute = true });
        }
    }
}
