using System;
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
    public partial class EPS : Form
    {
        //Fields   
        public Form activeForm;
        public EPS()
        {
            InitializeComponent();
            customizeDesing();
            lblTime.Font = new Font("Digital-1",50, FontStyle.Regular);
            labelDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timerTime.Start();
        }
        public void hidebutton()
        {
            buttonRoom.Visible = false;
            buttonClass.Visible = false;
            buttonTeacher.Visible = false;
            buttonTimetable.Visible = false;       
        }

        public void showbutton()
        {
            buttonRoom.Visible = true;
            buttonClass.Visible = true;
            buttonTeacher.Visible = true;
            buttonTimetable.Visible = true;
        }

        public void customizeDesing()
        {
            panelSubRoom.Visible = false;
            panelSubTeacher.Visible = false;
            panelSubTimetable.Visible = false;
            panelSubDashboard.Visible = false;
            panelSubClass.Visible = false;
            ///...
        }
        public void hideSubMenu()
        {
            if (panelSubDashboard.Visible == true)
                panelSubDashboard.Visible = false;
            if (panelSubRoom.Visible == true)
                panelSubRoom.Visible = false;
            if (panelSubTeacher.Visible == true)
                panelSubTeacher.Visible = false;
            if (panelSubClass.Visible == true)
                panelSubClass.Visible = false;
            if (panelSubTimetable.Visible == true)
                panelSubTimetable.Visible = false;
        }
        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //dashboard click
        public void buttonDashboard_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubDashboard);
        }
        //dashboard sub menu
        public void buttonLogin_Click_1(object sender, EventArgs e)
        {
           // this.Hide();
            OpenChildForm(new Login_Form(), sender);
        }
       public void buttonRegister_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterForm(), sender);   
        }


        //teachers click
        private void buttonTeacher_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubTeacher);
        }
        //teacher sub menu
        private void buttonTeacherInfo_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new teacherinformation(), sender);      
        }
        private void buttonSelectTeacher_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SelectTeacher(), sender);
            hideSubMenu();
        }


        //class click
        private void buttonClass_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubClass);
        }
        //class sub menu
        private void buttonClassInfo_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Class_Info(), sender);
        }
        private void buttonSelectClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new select_class(), sender);
        }




        //room click
        private void buttonRoom_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubRoom);
        }
        //room sub menu
        private void buttonAddRoom_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MainForm(), sender);
        }
        private void buttonViewRoom_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new roomno(), sender);
        }
        private void buttonSelectClassroom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new selectclassroom(), sender);
        }



        //timetable click

        private void buttonTimetable_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubTimetable);
        }
        //timetable sub menu
        private void buttonCreateTimetable_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MainLogic(), sender);
        }
        private void buttonViewTimetable_Click_1(object sender, EventArgs e)
        {      
        }


        //click contact
        private void buttonContact_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new contactus(), sender);
        }


        //sliding logic
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
        }

        private void EPS_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
