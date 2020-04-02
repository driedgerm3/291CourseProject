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
            //sql connection
            //string connetionString;
            //SqlConnection cnn;
            //connetionString = @"Data Source=(local);Initial Catalog=291_Project;Integrated Security=True";
            //cnn = new SqlConnection(connetionString);
            //cnn.Open();
            //select statement, get edmonton cars
            //SqlCommand command = new SqlCommand("Select * from [Employee] where Branch_ID = '2'", cnn); 
            
            CreatePdf();
        }
        public static void CreatePdf()
        {
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

            Run text4 = new Run(dc, "insert data here...");
            text4.CharacterFormat = body;
            par2.Inlines.Add(text4);

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
