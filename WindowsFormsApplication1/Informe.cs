using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autolavado
{
    public partial class Informe : Form
    {
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        public Informe()
        {
            InitializeComponent();
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPropietario M = new MenuPropietario();
            M.Visible = true;
            this.Visible = false;
        }

        private void BntGene_Click(object sender, EventArgs e)
        {
            string filename;
            Document reporte = new Document();
            SaveFileDialog GuardarPDF = new SaveFileDialog();
            GuardarPDF.InitialDirectory = @"C:";
            GuardarPDF.Title = "Guardar Reporte";
            GuardarPDF.DefaultExt = "pdf";
            GuardarPDF.Filter = "Documento Portable (*.pdf)|*.pdf";
            GuardarPDF.FilterIndex = 1;
            GuardarPDF.RestoreDirectory = true;
            if (GuardarPDF.ShowDialog() == DialogResult.OK)
            {
                filename = GuardarPDF.FileName;
                PdfWriter.GetInstance(reporte, new FileStream(filename, FileMode.Create));
                reporte.Open();

                //ADDING TITLE
                Paragraph para = new Paragraph("Autolavado Tuzo Express", FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
                para.Alignment = Element.ALIGN_CENTER;

                para.SpacingAfter = 10f;
                reporte.Add(para);
            

                //IMAGE
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance("D:\\Users\\almej\\Documents\\GitHub\\Autolavado2\\Logo.jpg");

                jpg.ScaleToFit(120f, 120f);
                jpg.Alignment = Element.ALIGN_MIDDLE;
                jpg.SpacingBefore = 10f;

                reporte.Add(jpg);

                PdfPTable consulta = new PdfPTable(DataInforme.Columns.Count);
                int h;
                int i;
                int k;
                for (h = 0; h < DataInforme.Columns.Count; h++)
                {
                    consulta.AddCell(new Phrase(DataInforme.Columns[h].HeaderText));
                }
                consulta.HeaderRows = 1;
                for (i = 0; i < DataInforme.Rows.Count; i++)
                {
                    for (k = 0; k < DataInforme.Columns.Count; k++)
                    {
                        if (DataInforme[k, i].Value != null)
                        {
                            consulta.AddCell(new Phrase(DataInforme[k, i].Value.ToString()));
                        }
                    }
                }
                consulta.SpacingBefore = 10f;
                reporte.Add(consulta);
                reporte.Close();
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Informe = new Microsoft.Office.Interop.Excel.Application();
            Informe.Application.Workbooks.Add(true);
            int Cont = 0;
            foreach (DataGridViewColumn Col in DataInforme.Columns) {
                Cont++;
                Informe.Cells[1,Cont]= Col.Name;
            }
            int Contf = 0;
            foreach(DataGridViewRow Row in DataInforme.Rows)
            {
                Contf++;
                Cont = 0;
                foreach(DataGridViewColumn Colm in DataInforme.Columns)
                {
                    Cont++;
                    Informe.Cells[Contf + 1, Cont] = Row.Cells[Colm.Name].Value;
                }
            }
            Informe.Visible = true;
        }

        private void Informe_Load(object sender, EventArgs e)
        {
            DataInforme.DataSource = TU.MostrarTickets();
        }
    }
}
