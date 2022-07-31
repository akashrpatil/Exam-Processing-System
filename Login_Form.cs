using System.Data.SqlClient;
using System;
using System.Data.Sql;
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
    public partial class Login_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;username=root;password=tybscit;database=seating_arrange");
        public Login_Form()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
      //      labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
       //     labelClose.ForeColor = Color.White;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM seating_arrange.table WHERE `username` = @usn and `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // check if the user exists or not
            if (table.Rows.Count > 0)
            {
                this.Hide();
                //     MainForm mainform = new MainForm();
                //     //    mainform.Show();   
                EPS test1 = new EPS();
                //    test1.hidebutton();
                
                test1.showbutton();
                test1.Show();

            }

            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username to login", "Username Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "Password Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            EPS e1 = new WindowsFormsApplication1.EPS();
            e1.buttonRegister_Click_1(sender, e);
            
           // RegisterForm registerform = new RegisterForm();
           // registerform.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.Green;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }
        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            this.Hide();
            fp.Show();
        }
    }
    }


