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

namespace WindowsFormsApplication1
{
    public partial class teacherinformation : Form
    {
        int TeacherID;
        public teacherinformation()
        {           
            InitializeComponent();
            displayData();
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxTeacherName.Text.Equals("") || textBoxTeacherPhone.Text.Equals("") || textBoxTeacherEmail.Text.Equals(""))
                {
                    MessageBox.Show("Please provide details");
                }
                else
                {
                    DB db1 = new DB();
                    db1.openConnection();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO seating_arrange.teacher_info VALUES ('" + textBoxTeacherName.Text + "','" + comboBoxDepartment.Text + "','" + textBoxTeacherEmail.Text + "','" + textBoxTeacherPhone.Text + "','" + Convert.ToInt32(TeacherID) + "')", db1.getConnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your data has been saved...!!!");
                    db1.closeConnection();

                    displayData();
                    Clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("add correct information");
            }

        }
        public void displayData()
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adpt = new MySqlDataAdapter("Select * from seating_arrange.teacher_info", db1.getConnection());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            db1.closeConnection();
        }
        public void Clear()
        {
            textBoxTeacherName.Text = "";
            comboBoxDepartment.Text = "";
            textBoxTeacherEmail.Text = "";
            textBoxTeacherPhone.Text = "";
        }
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TeacherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            textBoxTeacherName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTeacherEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTeacherPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DB db1 = new DB();
                db1.openConnection();
                string queryText = "UPDATE seating_arrange.teacher_info SET teacher_name = '" + textBoxTeacherName.Text + "',dept = '" + comboBoxDepartment.Text + "', email = '" + textBoxTeacherEmail.Text + "', phone_no = '" + textBoxTeacherPhone.Text + "' where id = '" + Convert.ToInt32(TeacherID) + "';";
                MySqlCommand cmd = new MySqlCommand(queryText, db1.getConnection());
                cmd.Parameters.AddWithValue("teacher_name", textBoxTeacherName.Text);
                cmd.Parameters.AddWithValue("dept", comboBoxDepartment.Text);
                cmd.Parameters.AddWithValue("email", textBoxTeacherEmail.Text);
                cmd.Parameters.AddWithValue("phone_no", textBoxTeacherPhone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data has been updated...!!!");
                db1.closeConnection();
                displayData();
            }
            catch (Exception ex)
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM seating_arrange.teacher_info WHERE id='" + Convert.ToInt32(TeacherID) + "' ", db1.getConnection());

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

    }
}
