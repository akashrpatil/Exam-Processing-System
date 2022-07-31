using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class select_class : Form
    {
        int TeacherID;
        int frm;
        int to;
        //    int can;
        int cnt;
        int tot;
        public select_class()
        {
            InitializeComponent();
        }
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
        private void select_class_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }

        private void buttonLoadPrevious_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //open connec
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM seating_arrange.class_info", db.getConnection());

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void buttonLoadAll_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //open connec
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM seating_arrange.select_class", db.getConnection());

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string stream = "", cls = "", can = " ";

            DB db1 = new DB();
            db1.openConnection();

            MySqlCommand cmd1 = new MySqlCommand("DELETE FROM seating_arrange.select_class", db1.getConnection());
            cmd1.ExecuteNonQuery();


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value) == true)
                {
                    stream = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    cls = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    frm = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    to = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    can = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    cnt = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    tot = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    TeacherID = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value.ToString());
                    //   MessageBox.Show("stream: " + stream + "class: " +cls+ " "+ "from: " + frm + " "+ "to: " + to + " " + "can: " + can + " " + "cnt: " + cnt + " " + "tot: " + tot + " " + "id: " + id + " ");

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO seating_arrange.select_class VALUES ('" + stream + "','" + cls + "','" + frm + "','" + to + "','" + can + "','" + cnt + "','" + tot + "','" + TeacherID + "')", db1.getConnection());
                    cmd.ExecuteNonQuery();

                }
            }
            db1.closeConnection();
            MessageBox.Show("class Selected");
        }
    }
}
