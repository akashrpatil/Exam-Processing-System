using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
   
    public partial class ChangePassword : Form
    {
        string username = ForgotPassword.to;
        string email1;
        public ChangePassword(string email)
        {
            InitializeComponent();
            email1 = email;

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if(textBoxNewPass.Text==textBoxConfirmPass.Text)
            {
                DB db1 = new DB();
                db1.openConnection();
                string queryText = "UPDATE seating_arrange.table SET password = '" +textBoxConfirmPass.Text + "' WHERE emailaddress = '" + email1 + "';";
                MySqlCommand cmd = new MySqlCommand(queryText, db1.getConnection());                       
                cmd.ExecuteNonQuery();
                MessageBox.Show("password reset successfully...!!!");                
                this.Hide();
                Login_Form lgform = new Login_Form();
                lgform.Show();
                db1.closeConnection();               
            }
            else
            {
                MessageBox.Show("password do not match try again...!!!");
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
