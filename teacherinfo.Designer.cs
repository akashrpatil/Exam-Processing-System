namespace WindowsFormsApplication1
{
    partial class teacherinfo
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
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.textBoxTeacherPhone = new System.Windows.Forms.TextBox();
            this.textBoxTeacherEmail = new System.Windows.Forms.TextBox();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.seating_arrangeDataSet = new WindowsFormsApplication1.seating_arrangeDataSet();
            this.seatingarrangeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelteacher = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatingarrangeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherName.ForeColor = System.Drawing.Color.Black;
            this.textBoxTeacherName.Location = new System.Drawing.Point(221, 93);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(350, 45);
            this.textBoxTeacherName.TabIndex = 10;
            // 
            // textBoxTeacherPhone
            // 
            this.textBoxTeacherPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherPhone.ForeColor = System.Drawing.Color.Black;
            this.textBoxTeacherPhone.Location = new System.Drawing.Point(813, 176);
            this.textBoxTeacherPhone.Name = "textBoxTeacherPhone";
            this.textBoxTeacherPhone.Size = new System.Drawing.Size(350, 45);
            this.textBoxTeacherPhone.TabIndex = 12;
            // 
            // textBoxTeacherEmail
            // 
            this.textBoxTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxTeacherEmail.Location = new System.Drawing.Point(221, 176);
            this.textBoxTeacherEmail.Name = "textBoxTeacherEmail";
            this.textBoxTeacherEmail.Size = new System.Drawing.Size(350, 45);
            this.textBoxTeacherEmail.TabIndex = 10;
            this.textBoxTeacherEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTeacherEmail_Validating);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAddTeacher.FlatAppearance.BorderSize = 0;
            this.buttonAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeacher.ForeColor = System.Drawing.Color.Black;
            this.buttonAddTeacher.Location = new System.Drawing.Point(524, 226);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(193, 39);
            this.buttonAddTeacher.TabIndex = 14;
            this.buttonAddTeacher.Text = "Add Teacher";
            this.buttonAddTeacher.UseVisualStyleBackColor = false;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click_1);
            // 
            // seating_arrangeDataSet
            // 
            this.seating_arrangeDataSet.DataSetName = "seating_arrangeDataSet";
            this.seating_arrangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seatingarrangeDataSetBindingSource
            // 
            this.seatingarrangeDataSetBindingSource.DataSource = this.seating_arrangeDataSet;
            this.seatingarrangeDataSetBindingSource.Position = 0;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.IntegralHeight = false;
            this.comboBoxDepartment.ItemHeight = 16;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "IT",
            "BMM",
            "BMS",
            "BAF",
            "BCOM"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(813, 111);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(350, 24);
            this.comboBoxDepartment.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(633, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(622, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Department";
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherName.ForeColor = System.Drawing.Color.White;
            this.labelTeacherName.Location = new System.Drawing.Point(6, 80);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(201, 32);
            this.labelTeacherName.TabIndex = 15;
            this.labelTeacherName.Text = "Teacher Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 347);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(805, 331);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 39);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(933, 331);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 38);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelteacher
            // 
            this.labelteacher.AutoSize = true;
            this.labelteacher.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteacher.Location = new System.Drawing.Point(438, -4);
            this.labelteacher.Name = "labelteacher";
            this.labelteacher.Size = new System.Drawing.Size(334, 40);
            this.labelteacher.TabIndex = 22;
            this.labelteacher.Text = "Add Teacher Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelteacher);
            this.groupBox1.Controls.Add(this.buttonAddTeacher);
            this.groupBox1.Controls.Add(this.labelTeacherName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 271);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Location = new System.Drawing.Point(13, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1206, 387);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // teacherinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1242, 708);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTeacherName);
            this.Controls.Add(this.textBoxTeacherPhone);
            this.Controls.Add(this.textBoxTeacherEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacherinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacherinfo";
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatingarrangeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.TextBox textBoxTeacherPhone;
        private System.Windows.Forms.TextBox textBoxTeacherEmail;
        private System.Windows.Forms.Button buttonAddTeacher;
        private seating_arrangeDataSet seating_arrangeDataSet;
        private System.Windows.Forms.BindingSource seatingarrangeDataSetBindingSource;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelteacher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}