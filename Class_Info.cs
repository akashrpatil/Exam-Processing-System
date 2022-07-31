using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
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
    public partial class Class_Info : Form
    {
        int TeacherID;
        public Class_Info()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adpt = new MySqlDataAdapter("Select * from seating_arrange.class_info", db1.getConnection());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TeacherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            comboBoxStream.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxClass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxFrom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxCancelledNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxCancelCount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        CheckBox[] l1 = new CheckBox[200];
        int loop;
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBoxFrom.Text.Equals("") || textBoxTo.Text.Equals(""))
            {
                MessageBox.Show("Please provide From & To Values");
            }
            else
            {
                //experiment
                int fm = Convert.ToInt32(textBoxFrom.Text);
                int to = Convert.ToInt32(textBoxTo.Text);
                loop = to - fm;
                for (int i = 0; i <= loop; i++, fm++)
                {

                    l1[i] = addCheckBox(fm);
                    //  MessageBox.Show(fm.ToString());
                    flowLayoutPanel1.Controls.Add(l1[i]);
                    //    endposition += 100;
                }
            }
        }
        CheckBox addCheckBox(int i)
        {

            CheckBox l = new CheckBox();

            l.Text = "" + i.ToString();
            l.ForeColor = Color.White;
            l.BackColor = Color.Green;
            l.Font = new System.Drawing.Font("Serif", 8, FontStyle.Bold);
            l.Width = 40;
            l.Height = 40;
            l.Checked = false;
            //  l.Location = new Point(start, end);
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding();

            return l;
        }


        private void textBoxTotal_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxFrom.Text.Equals("") || textBoxTo.Text.Equals(""))
            {
                MessageBox.Show("Please provide To & From roll no");
            }
            else
            {
                //add values to database

                int[] x = new int[100];
                int j = 0;
                for (int i = 0; i <= loop; i++)
                {
                    if (l1[i].Checked == true)
                    {
                        x[j] = Convert.ToInt32(l1[i].Text);
                        // MessageBox.Show(x[j].ToString());
                        j++;
                    }
                }

                string str = "0";
                for (int i = 0; i < j; i++)
                {
                    if (i == 0)
                        str = "";
                    str = str + x[i] + ",";

                }
                if (str.Length > 1)
                    str = str.Substring(0, str.Length - 1);
                textBoxCancelledNo.Text = str;
                textBoxCancelCount.Text = j.ToString();

                int nb = Convert.ToInt32(textBoxTo.Text);
                int cp = Convert.ToInt32(textBoxCancelCount.Text);
                int total = nb - cp;
                textBoxTotal.Text = total.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFrom.Text.Equals("") || textBoxTo.Text.Equals(""))
                {
                    MessageBox.Show("Please enter seat no details");
                }
                else
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("INSERT INTO seating_arrange.class_info(`stream`, `class`, `from`, `to`, `cancelled`, `cancel_count`, `total`, `id`) VALUES (@stream, @class, @from, @to,@cancelled,@cancel_count,@total,@id)", db.getConnection());

                    command.Parameters.Add("@stream", MySqlDbType.VarChar).Value = comboBoxStream.Text.ToString();
                    command.Parameters.Add("@class", MySqlDbType.VarChar).Value = comboBoxClass.Text.ToString();
                    command.Parameters.Add("@from", MySqlDbType.VarChar).Value = Convert.ToInt32(textBoxFrom.Text);
                    command.Parameters.Add("@to", MySqlDbType.VarChar).Value = Convert.ToInt32(textBoxTo.Text);
                    command.Parameters.Add("@total", MySqlDbType.VarChar).Value = Convert.ToInt32(textBoxTotal.Text);
                    command.Parameters.Add("@cancelled", MySqlDbType.VarChar).Value = textBoxCancelledNo.Text;
                    command.Parameters.Add("@cancel_count", MySqlDbType.VarChar).Value = Convert.ToInt32(textBoxCancelCount.Text);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToInt32(TeacherID);
                    // open the connection
                    db.openConnection();

                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Has Been Inserted", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }


                    // close the connection
                    db.closeConnection();
                    displayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please add details to continue");
            }
        }
        //some error facing
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DB db1 = new DB();
                db1.openConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM seating_arrange.class_info WHERE id='" + Convert.ToInt32(TeacherID) + "' ", db1.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Your data has been deleted...!!!");

                db1.closeConnection();
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        //code for pdf convert
        public void exporttogrid(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgv.ColumnCount);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //header

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //add datarow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }

            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
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
        private void buttonPdf_Click(object sender, EventArgs e)
        {
            exporttogrid(dataGridView1, "filename");
        }

        private void textBoxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please provide valid details", "Only Integer Values", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void textBoxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please provide valid details", "Only Integer Values", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
