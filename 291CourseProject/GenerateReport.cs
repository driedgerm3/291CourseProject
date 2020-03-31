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

            // first paragraph
            dc.Content.End.Insert("\nCMB Rentals - Report", new CharacterFormat() { Size = 25, FontColor = SautinSoft.Document.Color.Black, Bold = true });
            SpecialCharacter lBr = new SpecialCharacter(dc, SpecialCharacterType.LineBreak);
            dc.Content.End.Insert(lBr.Content);
            dc.Content.End.Insert("Content chosen: _____________", new CharacterFormat() { Size = 20, FontColor = SautinSoft.Document.Color.Black });

            dc.Save(pdfPath, new PdfSaveOptions());

            // Open the result for demonstration purposes.
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfPath) { UseShellExecute = true });
        }
    }
}
