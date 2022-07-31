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
using Microsoft.Win32;
namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        int TeacherID;
        string status = "Active";    
        public MainForm()
        {
            InitializeComponent();
            displayData();
      
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
             //   label1.ForeColor = ThemeColor.SecondaryColor;
            //    labelNoOfBench.ForeColor = ThemeColor.PrimaryColor;
            }
        }
        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            try
             {

                if (textBoxRoomNo.Text.Equals("") || textBoxNoOfBench.Text.Equals("") || textBoxSeatCapacity.Text.Equals(""))
                {
                    MessageBox.Show("Please enter details");
                }

                else
                {
                    DB db1 = new DB();
                    db1.openConnection();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO seating_arrange.classroom VALUES ('" + this.dateTimePicker1.Text + "','" + Convert.ToInt32(textBoxRoomNo.Text) + "','" + Convert.ToInt32(textBoxNoOfBench.Text) + "','" + Convert.ToInt32(textBoxSeatCapacity.Text) + "','" + Convert.ToInt32(textBoxTotalCount.Text) + "','" + status + "','" + Convert.ToInt32(TeacherID) + "')", db1.getConnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your data has been saved...!!!");
                    db1.closeConnection();
                    displayData();
                    Clear();
                }
          }catch(Exception ex)
           {
               MessageBox.Show("something went wrong");
            }
           
        }
        //validation for room no
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                status = "Active";
            }
            else if (radioButton2.Checked)
            {
                status = "Inactive";
            }
        }
        private void textBoxTotalCount_Enter(object sender, EventArgs e)
        {
            try
            {


                int nb = Convert.ToInt32(textBoxNoOfBench.Text);
                int cp = Convert.ToInt32(textBoxSeatCapacity.Text);
                int total = nb * cp;
                textBoxTotalCount.Text = total.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("");
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        public void displayData()
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adpt = new MySqlDataAdapter("Select * from seating_arrange.classroom", db1.getConnection());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            db1.closeConnection();
        }
        public void Clear()
        {
            textBoxRoomNo.Text = "";
            textBoxNoOfBench.Text = "";
            textBoxSeatCapacity.Text = "";
            textBoxTotalCount.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TeacherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            textBoxRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxNoOfBench.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSeatCapacity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxTotalCount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }  

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DB db1 = new DB();
                db1.openConnection();
                string queryText = "UPDATE seating_arrange.classroom SET room_no = '" + Convert.ToInt32(textBoxRoomNo.Text) + "',no_of_benches = '" + Convert.ToInt32(textBoxNoOfBench.Text) + "', capacity = '" + Convert.ToInt32(textBoxSeatCapacity.Text) + "' where id = '"+ Convert.ToInt32(TeacherID) + "';";
                MySqlCommand cmd = new MySqlCommand(queryText, db1.getConnection());
                cmd.Parameters.AddWithValue("room_no", textBoxRoomNo.Text);
                cmd.Parameters.AddWithValue("no_of_benches", textBoxNoOfBench.Text);
                cmd.Parameters.AddWithValue("capacity", textBoxSeatCapacity.Text);
                cmd.Parameters.AddWithValue("total_count", textBoxTotalCount.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmd.CommandText);
                MessageBox.Show("Your data has been updated...!!!");
                db1.closeConnection();
                displayData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DB db1 = new DB();
                db1.openConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM seating_arrange.classroom WHERE id='" + Convert.ToInt32(TeacherID) + "' ", db1.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Your data has been deleted...!!!");
                
                db1.closeConnection();
                displayData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
/*
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strfilename;

            openFileDialog1.Filter = "Excel Office | *.xls; *.xlsx";
            openFileDialog1.ShowDialog();

            strfilename = openFileDialog1.FileName;

            if (strfilename != string.Empty)
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(strfilename);
                xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];
                xlRange = xlWorkSheet.UsedRange;
                int i = 0;              
                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    DB db1 = new DB();
                    db1.openConnection();
                   
          //          MySqlCommand cmd = new MySqlCommand("INSERT INTO seating_arrange.classroom VALUES ('" + xlRange.Cells[0].Text + "','" + xlRange.Cells[1].Text + "','" + xlRange.Cells[2].Text + "','" + xlRange.Cells[3].Text + "','" + xlRange.Cells[4].Text + "','" + xlRange.Cells[5].Text + "','" + xlRange.Cells[6].Text + "')", db1.getConnection());
          //          cmd.ExecuteNonQuery();
                    MessageBox.Show("Excel Sheet is Uploaded...!!!");
                    db1.closeConnection();
                    displayData();
                    Clear();
                    //            dataGridView1.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text);
                    //MessageBox.Show(xlRange.Cells[1, 1].Value2.);
               //     MessageBox.Show(xlRange.Cells[xlRow, 1].Text,xlRange.Cells[xlRow, 2].Text);
                }
                xlWorkBook.Close();
                xlApp.Quit();
            }
        }
*/
        private void textBoxRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
                MessageBox.Show("Please provide valid details for room no", "Only Integer Values", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void textBoxNoOfBench_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please provide valid details for Benches", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
    }
