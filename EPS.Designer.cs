namespace WindowsFormsApplication1
{
    partial class EPS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPS));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonContact = new System.Windows.Forms.Button();
            this.panelSubTimetable = new System.Windows.Forms.Panel();
            this.buttonCreateTimetable = new System.Windows.Forms.Button();
            this.buttonTimetable = new System.Windows.Forms.Button();
            this.panelSubTeacher = new System.Windows.Forms.Panel();
            this.buttonSelectTeacher = new System.Windows.Forms.Button();
            this.buttonTeacherInfo = new System.Windows.Forms.Button();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.panelSubClass = new System.Windows.Forms.Panel();
            this.buttonSelectClass = new System.Windows.Forms.Button();
            this.buttonClassInfo = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.panelSubRoom = new System.Windows.Forms.Panel();
            this.buttonSelectClassroom = new System.Windows.Forms.Button();
            this.buttonViewRoom = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.panelSubDashboard = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelSubTimetable.SuspendLayout();
            this.panelSubTeacher.SuspendLayout();
            this.panelSubClass.SuspendLayout();
            this.panelSubRoom.SuspendLayout();
            this.panelSubDashboard.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.buttonContact);
            this.panelSideMenu.Controls.Add(this.panelSubTimetable);
            this.panelSideMenu.Controls.Add(this.buttonTimetable);
            this.panelSideMenu.Controls.Add(this.panelSubTeacher);
            this.panelSideMenu.Controls.Add(this.buttonTeacher);
            this.panelSideMenu.Controls.Add(this.panelSubClass);
            this.panelSideMenu.Controls.Add(this.buttonClass);
            this.panelSideMenu.Controls.Add(this.panelSubRoom);
            this.panelSideMenu.Controls.Add(this.buttonRoom);
            this.panelSideMenu.Controls.Add(this.panelSubDashboard);
            this.panelSideMenu.Controls.Add(this.buttonDashboard);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 802);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonContact
            // 
            this.buttonContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonContact.FlatAppearance.BorderSize = 0;
            this.buttonContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonContact.Image = ((System.Drawing.Image)(resources.GetObject("buttonContact.Image")));
            this.buttonContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContact.Location = new System.Drawing.Point(0, 714);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonContact.Size = new System.Drawing.Size(250, 45);
            this.buttonContact.TabIndex = 26;
            this.buttonContact.Text = "            Contact";
            this.buttonContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContact.UseVisualStyleBackColor = true;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click_1);
            // 
            // panelSubTimetable
            // 
            this.panelSubTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubTimetable.Controls.Add(this.buttonCreateTimetable);
            this.panelSubTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubTimetable.Location = new System.Drawing.Point(0, 669);
            this.panelSubTimetable.Name = "panelSubTimetable";
            this.panelSubTimetable.Size = new System.Drawing.Size(250, 45);
            this.panelSubTimetable.TabIndex = 25;
            // 
            // buttonCreateTimetable
            // 
            this.buttonCreateTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateTimetable.FlatAppearance.BorderSize = 0;
            this.buttonCreateTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTimetable.ForeColor = System.Drawing.Color.LightGray;
            this.buttonCreateTimetable.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateTimetable.Name = "buttonCreateTimetable";
            this.buttonCreateTimetable.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCreateTimetable.Size = new System.Drawing.Size(250, 40);
            this.buttonCreateTimetable.TabIndex = 14;
            this.buttonCreateTimetable.Text = "Create Timetable";
            this.buttonCreateTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateTimetable.UseVisualStyleBackColor = true;
            this.buttonCreateTimetable.Click += new System.EventHandler(this.buttonCreateTimetable_Click_1);
            // 
            // buttonTimetable
            // 
            this.buttonTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimetable.FlatAppearance.BorderSize = 0;
            this.buttonTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimetable.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTimetable.Image = ((System.Drawing.Image)(resources.GetObject("buttonTimetable.Image")));
            this.buttonTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimetable.Location = new System.Drawing.Point(0, 624);
            this.buttonTimetable.Name = "buttonTimetable";
            this.buttonTimetable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTimetable.Size = new System.Drawing.Size(250, 45);
            this.buttonTimetable.TabIndex = 24;
            this.buttonTimetable.Text = "            Timetable";
            this.buttonTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimetable.UseVisualStyleBackColor = true;
            this.buttonTimetable.Visible = false;
            this.buttonTimetable.Click += new System.EventHandler(this.buttonTimetable_Click_1);
            // 
            // panelSubTeacher
            // 
            this.panelSubTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubTeacher.Controls.Add(this.buttonSelectTeacher);
            this.panelSubTeacher.Controls.Add(this.buttonTeacherInfo);
            this.panelSubTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubTeacher.Location = new System.Drawing.Point(0, 544);
            this.panelSubTeacher.Name = "panelSubTeacher";
            this.panelSubTeacher.Size = new System.Drawing.Size(250, 80);
            this.panelSubTeacher.TabIndex = 23;
            // 
            // buttonSelectTeacher
            // 
            this.buttonSelectTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectTeacher.FlatAppearance.BorderSize = 0;
            this.buttonSelectTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectTeacher.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSelectTeacher.Location = new System.Drawing.Point(0, 40);
            this.buttonSelectTeacher.Name = "buttonSelectTeacher";
            this.buttonSelectTeacher.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSelectTeacher.Size = new System.Drawing.Size(250, 40);
            this.buttonSelectTeacher.TabIndex = 9;
            this.buttonSelectTeacher.Text = "Select Teacher";
            this.buttonSelectTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectTeacher.UseVisualStyleBackColor = true;
            this.buttonSelectTeacher.Click += new System.EventHandler(this.buttonSelectTeacher_Click_1);
            // 
            // buttonTeacherInfo
            // 
            this.buttonTeacherInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTeacherInfo.FlatAppearance.BorderSize = 0;
            this.buttonTeacherInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeacherInfo.ForeColor = System.Drawing.Color.LightGray;
            this.buttonTeacherInfo.Location = new System.Drawing.Point(0, 0);
            this.buttonTeacherInfo.Name = "buttonTeacherInfo";
            this.buttonTeacherInfo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTeacherInfo.Size = new System.Drawing.Size(250, 40);
            this.buttonTeacherInfo.TabIndex = 8;
            this.buttonTeacherInfo.Text = "Teacher Info";
            this.buttonTeacherInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeacherInfo.UseVisualStyleBackColor = true;
            this.buttonTeacherInfo.Click += new System.EventHandler(this.buttonTeacherInfo_Click_1);
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTeacher.FlatAppearance.BorderSize = 0;
            this.buttonTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeacher.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTeacher.Image = ((System.Drawing.Image)(resources.GetObject("buttonTeacher.Image")));
            this.buttonTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeacher.Location = new System.Drawing.Point(0, 499);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTeacher.Size = new System.Drawing.Size(250, 45);
            this.buttonTeacher.TabIndex = 22;
            this.buttonTeacher.Text = "           Teacher";
            this.buttonTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeacher.UseVisualStyleBackColor = true;
            this.buttonTeacher.Visible = false;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click_1);
            // 
            // panelSubClass
            // 
            this.panelSubClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubClass.Controls.Add(this.buttonSelectClass);
            this.panelSubClass.Controls.Add(this.buttonClassInfo);
            this.panelSubClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubClass.Location = new System.Drawing.Point(0, 415);
            this.panelSubClass.Name = "panelSubClass";
            this.panelSubClass.Size = new System.Drawing.Size(250, 84);
            this.panelSubClass.TabIndex = 21;
            // 
            // buttonSelectClass
            // 
            this.buttonSelectClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectClass.FlatAppearance.BorderSize = 0;
            this.buttonSelectClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectClass.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSelectClass.Location = new System.Drawing.Point(0, 40);
            this.buttonSelectClass.Name = "buttonSelectClass";
            this.buttonSelectClass.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSelectClass.Size = new System.Drawing.Size(250, 35);
            this.buttonSelectClass.TabIndex = 13;
            this.buttonSelectClass.Text = "Select Class";
            this.buttonSelectClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectClass.UseVisualStyleBackColor = true;
            this.buttonSelectClass.Click += new System.EventHandler(this.buttonSelectClass_Click);
            // 
            // buttonClassInfo
            // 
            this.buttonClassInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClassInfo.FlatAppearance.BorderSize = 0;
            this.buttonClassInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassInfo.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClassInfo.Location = new System.Drawing.Point(0, 0);
            this.buttonClassInfo.Name = "buttonClassInfo";
            this.buttonClassInfo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonClassInfo.Size = new System.Drawing.Size(250, 40);
            this.buttonClassInfo.TabIndex = 11;
            this.buttonClassInfo.Text = "Class Info";
            this.buttonClassInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClassInfo.UseVisualStyleBackColor = true;
            this.buttonClassInfo.Click += new System.EventHandler(this.buttonClassInfo_Click_1);
            // 
            // buttonClass
            // 
            this.buttonClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClass.FlatAppearance.BorderSize = 0;
            this.buttonClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClass.Image = ((System.Drawing.Image)(resources.GetObject("buttonClass.Image")));
            this.buttonClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClass.Location = new System.Drawing.Point(0, 370);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonClass.Size = new System.Drawing.Size(250, 45);
            this.buttonClass.TabIndex = 20;
            this.buttonClass.Text = "            Class";
            this.buttonClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClass.UseVisualStyleBackColor = true;
            this.buttonClass.Visible = false;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click_1);
            // 
            // panelSubRoom
            // 
            this.panelSubRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubRoom.Controls.Add(this.buttonSelectClassroom);
            this.panelSubRoom.Controls.Add(this.buttonViewRoom);
            this.panelSubRoom.Controls.Add(this.buttonAddRoom);
            this.panelSubRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubRoom.Location = new System.Drawing.Point(0, 255);
            this.panelSubRoom.Name = "panelSubRoom";
            this.panelSubRoom.Size = new System.Drawing.Size(250, 115);
            this.panelSubRoom.TabIndex = 19;
            // 
            // buttonSelectClassroom
            // 
            this.buttonSelectClassroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectClassroom.FlatAppearance.BorderSize = 0;
            this.buttonSelectClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectClassroom.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSelectClassroom.Location = new System.Drawing.Point(0, 80);
            this.buttonSelectClassroom.Name = "buttonSelectClassroom";
            this.buttonSelectClassroom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSelectClassroom.Size = new System.Drawing.Size(250, 40);
            this.buttonSelectClassroom.TabIndex = 13;
            this.buttonSelectClassroom.Text = "Select Classroom";
            this.buttonSelectClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectClassroom.UseVisualStyleBackColor = true;
            this.buttonSelectClassroom.Click += new System.EventHandler(this.buttonSelectClassroom_Click);
            // 
            // buttonViewRoom
            // 
            this.buttonViewRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonViewRoom.FlatAppearance.BorderSize = 0;
            this.buttonViewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewRoom.ForeColor = System.Drawing.Color.LightGray;
            this.buttonViewRoom.Location = new System.Drawing.Point(0, 40);
            this.buttonViewRoom.Name = "buttonViewRoom";
            this.buttonViewRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonViewRoom.Size = new System.Drawing.Size(250, 40);
            this.buttonViewRoom.TabIndex = 3;
            this.buttonViewRoom.Text = "View Room";
            this.buttonViewRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewRoom.UseVisualStyleBackColor = true;
            this.buttonViewRoom.Click += new System.EventHandler(this.buttonViewRoom_Click_1);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddRoom.FlatAppearance.BorderSize = 0;
            this.buttonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRoom.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddRoom.Location = new System.Drawing.Point(0, 0);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAddRoom.Size = new System.Drawing.Size(250, 40);
            this.buttonAddRoom.TabIndex = 2;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click_1);
            // 
            // buttonRoom
            // 
            this.buttonRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoom.Image")));
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(0, 210);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRoom.Size = new System.Drawing.Size(250, 45);
            this.buttonRoom.TabIndex = 18;
            this.buttonRoom.Text = "             Room";
            this.buttonRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Visible = false;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click_1);
            // 
            // panelSubDashboard
            // 
            this.panelSubDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubDashboard.Controls.Add(this.buttonRegister);
            this.panelSubDashboard.Controls.Add(this.buttonLogin);
            this.panelSubDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubDashboard.Location = new System.Drawing.Point(0, 130);
            this.panelSubDashboard.Name = "panelSubDashboard";
            this.panelSubDashboard.Size = new System.Drawing.Size(250, 80);
            this.panelSubDashboard.TabIndex = 17;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.LightGray;
            this.buttonRegister.Location = new System.Drawing.Point(0, 40);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRegister.Size = new System.Drawing.Size(250, 40);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "         Register";
            this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLogin.Location = new System.Drawing.Point(0, 0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLogin.Size = new System.Drawing.Size(250, 40);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "          Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 85);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(250, 45);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "          Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(81, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 61);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.tableLayoutPanel1);
            this.panelChildForm.Controls.Add(this.lblTime);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(947, 802);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.71266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.28734F));
            this.tableLayoutPanel1.Controls.Add(this.labelDay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDate, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(353, 546);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 65);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelDay
            // 
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(3, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(231, 65);
            this.labelDay.TabIndex = 5;
            this.labelDay.Text = "Day";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(240, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(460, 65);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(241, 422);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(944, 84);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // EPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1197, 802);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EPS System";
            this.Load += new System.EventHandler(this.EPS_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubTimetable.ResumeLayout(false);
            this.panelSubTeacher.ResumeLayout(false);
            this.panelSubClass.ResumeLayout(false);
            this.panelSubRoom.ResumeLayout(false);
            this.panelSubDashboard.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonContact;
        private System.Windows.Forms.Panel panelSubTimetable;
        private System.Windows.Forms.Button buttonCreateTimetable;
        private System.Windows.Forms.Button buttonTimetable;
        private System.Windows.Forms.Panel panelSubTeacher;
        private System.Windows.Forms.Button buttonSelectTeacher;
        private System.Windows.Forms.Button buttonTeacherInfo;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Panel panelSubClass;
        private System.Windows.Forms.Button buttonSelectClass;
        private System.Windows.Forms.Button buttonClassInfo;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Panel panelSubRoom;
        private System.Windows.Forms.Button buttonSelectClassroom;
        private System.Windows.Forms.Button buttonViewRoom;
        private System.Windows.Forms.Button buttonAddRoom;
        public System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Panel panelSubDashboard;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}