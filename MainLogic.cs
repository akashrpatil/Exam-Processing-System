using System;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApplication1
{

    public partial class MainLogic : Form
    {
        ReportDataSource rs = new ReportDataSource();
        public MainLogic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] fyroll = new string[1000, 2];
            int[] room = new int[50];
            int[] capacity = new int[50];
            int[] tot = new int[50];

            //delcare 2nd table column arrary 
            string[] stream = new string[50];
            string[] clas = new string[50];
            int[] startroll = new int[50];
            int[] endroll = new int[50];
            string[] cancel = new string[50];


            DB db = new DB();
            DB db1 = new DB();

            //open connec
            db.openConnection();

            //  MySqlDataAdapter adapter = new MySqlDataAdapter("select * from classroom;", db.getConnection());

            MySqlCommand cmd = new MySqlCommand("select cancelled from class_info;", db.getConnection());

            MySqlDataReader red;
            red = cmd.ExecuteReader();
            int t1 = 0;
            while (red.Read())
            {
                cancel[t1] = Convert.ToString(red["cancelled"]);
         //   MessageBox.Show(cancel[t1].ToString() + " ");
                t1++;

            }
            red.Close();


            //open connec
            db.openConnection();

            //  MySqlDataAdapter adapter = new MySqlDataAdapter("select * from classroom;", db.getConnection());

            MySqlCommand cmd1 = new MySqlCommand("select * from select_classroom;", db.getConnection());

            MySqlDataReader reader;
            reader = cmd1.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                room[i] = Convert.ToInt32(reader["room_no"]);
                capacity[i] = Convert.ToInt32(reader["no_of_benches"]);
                // MessageBox.Show(room[i].ToString() + " " + noofbenches[i].ToString() + " ");
                i++;

            }
            reader.Close();

            db1.openConnection();
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM select_class;", db1.getConnection());
            reader = cmd2.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                stream[i] = Convert.ToString(reader["stream"]);
                clas[i] = Convert.ToString(reader["class"]);
                startroll[i] = Convert.ToInt32(reader["from"]);
                endroll[i] = Convert.ToInt32(reader["to"]);
                cancel[i] = Convert.ToString(reader["cancelled"]);
             //   MessageBox.Show(stream[i].ToString() + " " + clas[i].ToString() + " " + startroll[i].ToString() + " " + endroll[i].ToString() + " " + cancel[i].ToString() + " ");
                i++;
            }

            int max = 0;
            int x = 0;
            i = 0;
            for (int ix = 0; ix < 3; ix++)
            {
                for (int j = startroll[x]; j <= endroll[x]; j++)
                {
                    fyroll[i, 0] = j.ToString();
                    fyroll[i, 1] = stream[ix] + " " + clas[ix].ToString();
                    i++;

                }
                //      MessageBox.Show(i.ToString());
                x++;

            }
            max = i;
         //   string[] cancellist = cancel.Split('');
            int r = 0, cl = 0, rl = 0, can = 0, cp = 0, c = 0, t = 1;
            string s = "";
            c = capacity[cp];
            for (i = 0; i < max - 1; i++, t++)//room number times 
            {
                s = fyroll[i, 1];
                c--;
                if ((c == 0) || !(s == fyroll[i + 1, 1]))
                {
                    // MessageBox.Show(r.ToString() + "B " + room[r].ToString());
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = room[r];
                    dataGridView1.Rows[n].Cells[1].Value = stream[cl] + " " + clas[cl];
                    dataGridView1.Rows[n].Cells[2].Value = fyroll[rl, 0];
                    dataGridView1.Rows[n].Cells[3].Value = fyroll[i, 0];
                    dataGridView1.Rows[n].Cells[5].Value = t;
                    dataGridView1.Rows[n].Cells[4].Value = cancel[cl];

                    t = 0;
                    rl = i + 1;
                    if (c == 0)
                    {
                        cp++;
                        r++;
                        c = capacity[cp];
                    }
                    if (!(s == fyroll[i + 1, 1]))
                    {
                        cl++;
                    }

                }
            }
        }


        private void buttonPrintReport_Click(object sender, EventArgs e)
        {
            List<Report> lst = new List<Report>();
            lst.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               // MessageBox.Show(dataGridView1.Rows[i].Cells[5].Value.ToString());
                Report rprt = new Report
                {
                    Room = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                    cls = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    From = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()),
                    To = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()),
                    Cancelled =(dataGridView1.Rows[i].Cells[4].Value.ToString()),
                    Total = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()),
                   
                };
                lst.Add(rprt);

            }
            rs.Name = "DataSet1";
            rs.Value = lst;


            Form2 frm = new Form2();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report2.rdlc";

            frm.ShowDialog();
        }
    }
    public class Report
    {
        public int Room { get; set; }

        public string cls { get; set; }

        public int From { get; set; }

        public int To { get; set; }

        public string Cancelled { get; set; }

        public int Total { get; set; }
    }
}
