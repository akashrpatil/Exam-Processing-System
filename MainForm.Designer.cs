namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.labelSeatCapa = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.textBoxNoOfBench = new System.Windows.Forms.TextBox();
            this.textBoxSeatCapacity = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.textBoxTotalCount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelNoOfBench = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNo.ForeColor = System.Drawing.Color.White;
            this.labelRoomNo.Location = new System.Drawing.Point(66, 109);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(99, 25);
            this.labelRoomNo.TabIndex = 202;
            this.labelRoomNo.Text = "Room No:";
            // 
            // labelSeatCapa
            // 
            this.labelSeatCapa.AutoSize = true;
            this.labelSeatCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatCapa.ForeColor = System.Drawing.Color.White;
            this.labelSeatCapa.Location = new System.Drawing.Point(66, 209);
            this.labelSeatCapa.Name = "labelSeatCapa";
            this.labelSeatCapa.Size = new System.Drawing.Size(141, 25);
            this.labelSeatCapa.TabIndex = 202;
            this.labelSeatCapa.Text = "Seat Capacity:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(66, 291);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(79, 25);
            this.labelStatus.TabIndex = 202;
            this.labelStatus.Text = "Status: ";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Location = new System.Drawing.Point(222, 109);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(219, 22);
            this.textBoxRoomNo.TabIndex = 1;
            this.textBoxRoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRoomNo_KeyPress);
            // 
            // textBoxNoOfBench
            // 
            this.textBoxNoOfBench.Location = new System.Drawing.Point(222, 156);
            this.textBoxNoOfBench.Name = "textBoxNoOfBench";
            this.textBoxNoOfBench.Size = new System.Drawing.Size(219, 22);
            this.textBoxNoOfBench.TabIndex = 2;
            this.textBoxNoOfBench.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoOfBench_KeyPress);
            // 
            // textBoxSeatCapacity
            // 
            this.textBoxSeatCapacity.Location = new System.Drawing.Point(222, 209);
            this.textBoxSeatCapacity.Name = "textBoxSeatCapacity";
            this.textBoxSeatCapacity.Size = new System.Drawing.Size(219, 22);
            this.textBoxSeatCapacity.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(222, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Active";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(364, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Inactive";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddRoom.FlatAppearance.BorderSize = 0;
            this.buttonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddRoom.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddRoom.Location = new System.Drawing.Point(173, 358);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(211, 50);
            this.buttonAddRoom.TabIndex = 204;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCount.ForeColor = System.Drawing.Color.White;
            this.labelTotalCount.Location = new System.Drawing.Point(66, 252);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(120, 25);
            this.labelTotalCount.TabIndex = 202;
            this.labelTotalCount.Text = "Total Count:";
            // 
            // textBoxTotalCount
            // 
            this.textBoxTotalCount.Location = new System.Drawing.Point(222, 252);
            this.textBoxTotalCount.Name = "textBoxTotalCount";
            this.textBoxTotalCount.Size = new System.Drawing.Size(219, 22);
            this.textBoxTotalCount.TabIndex = 3;
            this.textBoxTotalCount.Enter += new System.EventHandler(this.textBoxTotalCount_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(596, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 461);
            this.dataGridView1.TabIndex = 205;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 22);
            this.dateTimePicker1.TabIndex = 207;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(972, 535);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 32);
            this.buttonUpdate.TabIndex = 208;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(1066, 535);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 32);
            this.buttonDelete.TabIndex = 208;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 212;
            // 
            // labelNoOfBench
            // 
            this.labelNoOfBench.AutoSize = true;
            this.labelNoOfBench.BackColor = System.Drawing.Color.Transparent;
            this.labelNoOfBench.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfBench.ForeColor = System.Drawing.Color.Transparent;
            this.labelNoOfBench.Location = new System.Drawing.Point(66, 156);
            this.labelNoOfBench.Name = "labelNoOfBench";
            this.labelNoOfBench.Size = new System.Drawing.Size(125, 25);
            this.labelNoOfBench.TabIndex = 202;
            this.labelNoOfBench.Text = "No of Bench:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 40);
            this.label1.TabIndex = 211;
            this.label1.Text = "Please add room details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 778);
            this.groupBox1.TabIndex = 213;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1246, 600);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBoxTotalCount);
            this.Controls.Add(this.textBoxSeatCapacity);
            this.Controls.Add(this.textBoxNoOfBench);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTotalCount);
            this.Controls.Add(this.labelSeatCapa);
            this.Controls.Add(this.labelNoOfBench);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.Label labelSeatCapa;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.TextBox textBoxNoOfBench;
        private System.Windows.Forms.TextBox textBoxSeatCapacity;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.TextBox textBoxTotalCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private seating_arrangeDataSet seating_arrangeDataSet;
        private System.Windows.Forms.BindingSource classroomBindingSource;
        private seating_arrangeDataSetTableAdapters.classroomTableAdapter classroomTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelNoOfBench;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}