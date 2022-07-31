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
    public partial class SelectTeacher : Form
    {
        int TeacherID;
        public SelectTeacher()
        {
            InitializeComponent();

        }
        //add headercheckbox
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(20, 20);

            //add checkbox to datagrid
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }
        //now add header checkbox click event
        private void HeaderCheckBoxClick(CheckBox HCheckbox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckbox.Checked;
                dataGridView1.RefreshEdit();

                //totalCheckBOxes = HChecked.Checked ? TotalCheckBoxes : 0;
                IsHeaderCheckBoxClicked = false;
            }
        }
        //now adding mouse click event 
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void buttonSaveTeacher_Click_1(object sender, EventArgs e)
        {
            string tname = "", dept = "";
            DB db1 = new DB();
            db1.openConnection();

            MySqlCommand cmd1 = new MySqlCommand("DELETE FROM seating_arrange.select_teacher ", db1.getConnection());
            cmd1.ExecuteNonQuery();


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value) == true)
                {
                    TeacherID = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    //    tid = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    tname = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    dept = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    //  MessageBox.Show(TeacherID + "Name : " + tname + "Department: " + dept + " ");

                    // msg += "Name : " + tname + "Department: " + dept + " ";

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO seating_arrange.select_teacher VALUES ('" + Convert.ToInt32(TeacherID) + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "')", db1.getConnection());
                    cmd.ExecuteNonQuery();
                }

            }           
            db1.closeConnection();
            MessageBox.Show("Teacher Selected");
        }

        private void buttonLoadPrevious_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //open connec
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM seating_arrange.teacher_info", db.getConnection());

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void buttonLoadSaved_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //open connec
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM seating_arrange.select_teacher", db.getConnection());

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }
        private void SelectTeacher_Load_1(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }
    }
}