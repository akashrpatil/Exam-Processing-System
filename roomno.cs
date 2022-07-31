using System;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApplication1
{
   
    public partial class roomno : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;username=root;password=tybscit;database=seating_arrange");
        public roomno()
        {
            InitializeComponent();
        }
        int a =1;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //open connec
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM seating_arrange.classroom", db.getConnection());

            DataTable table = new DataTable();

            adapter.Fill(table);

            bunifuCustomDataGrid1.DataSource = table;
            
        }



        //code for pdf convert
        public void exporttogrid (DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgv.ColumnCount);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //header

            foreach(DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //add datarow
            foreach(DataGridViewRow row in dgv.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
      
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if(savefiledialoge.ShowDialog()==DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            exporttogrid(bunifuCustomDataGrid1, "filename");
        }

        private void buttonpdf_Click(object sender, EventArgs e)
        {
            exporttogrid(bunifuCustomDataGrid1, "filename");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherinfo teachinfo = new teacherinfo();
            teachinfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
         //   home hm = new home();
        //    hm.Show();
        }

        private void buttonViewRoom_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //open connec
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM seating_arrange.classroom", db.getConnection());

            DataTable table = new DataTable();

            adapter.Fill(table);

            bunifuCustomDataGrid1.DataSource = table;
        }

    }

}
