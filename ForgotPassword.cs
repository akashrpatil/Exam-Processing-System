using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class ForgotPassword : Form
    {
        string OTPCode;
        public static string to;
        string username = string.Empty;
        string password = string.Empty;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        private void buttonSendOTP_Click(object sender, EventArgs e)
        {

            //read email from textbox and check in database    
            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
           
                using (MySqlCommand cmd = new MySqlCommand("SELECT username,password FROM seating_arrange.table WHERE `emailaddress` = @emailaddress ", db.getConnection()))
                {

                    cmd.Parameters.Add("@emailaddress", MySqlDbType.VarChar).Value = textBoxTextEmailOTP.Text.Trim();

                    db.openConnection();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            username  = sdr["username"].ToString();
                            password = sdr["password"].ToString();
                        }
                    }
                    db.closeConnection();
                }
        if(!string.IsNullOrEmpty(password))
            {            
            string from, pass, messageBody;
                Random random = new Random();
                OTPCode = (random.Next(999999)).ToString();

                MailMessage message = new MailMessage();
                to = (textBoxTextEmailOTP.Text).ToString();
                from = "examprocessingsystem@gmail.com";
                pass = "ExamSeating123";
                messageBody = " We heard that you lost your Login password. " + " " +
                              "Sorry about that but don’t worry You can use the following " + " " +
                              "reset code forgot your password." +

                             "Thanks,Your friends at Admin Team" + "Your OTP Code is :" + OTPCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Forgot Password Code";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);


                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Send Succesfully...!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("This email address does not match our record..");
            }
        }
 
        private void buttonVerifyOTP_Click(object sender, EventArgs e)
        {

            if (OTPCode == (textBoxVerifyCode.Text).ToString())
            {
                to = textBoxTextEmailOTP.Text;
                ChangePassword cp = new ChangePassword((textBoxTextEmailOTP.Text).ToString());
                this.Hide();
                cp.Show();
            }
            else
            {
                MessageBox.Show("wrong verification code...!!!");
            }
        }

    }

    }

