namespace WindowsFormsApplication1
{
    partial class Class_Info
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelSeatCapa = new System.Windows.Forms.Label();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.classinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seating_arrangeDataSet = new WindowsFormsApplication1.seating_arrangeDataSet();
            this.labelCancelled = new System.Windows.Forms.Label();
            this.class_infoTableAdapter = new WindowsFormsApplication1.seating_arrangeDataSetTableAdapters.class_infoTableAdapter();
            this.button20 = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.comboBoxStream = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCancelCount = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonStep2 = new System.Windows.Forms.Button();
            this.textBoxCancelledNo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.classinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGenerate.FlatAppearance.BorderSize = 0;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(1112, 235);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(144, 46);
            this.buttonGenerate.TabIndex = 216;
            this.buttonGenerate.Text = "1. Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(749, 247);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(132, 22);
            this.textBoxFrom.TabIndex = 210;
            this.textBoxFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFrom_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 215;
            this.label2.Text = "Class:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.White;
            this.labelTo.Location = new System.Drawing.Point(947, 208);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(115, 25);
            this.labelTo.TabIndex = 212;
            this.labelTo.Text = "Seat no To:";
            // 
            // labelSeatCapa
            // 
            this.labelSeatCapa.AutoSize = true;
            this.labelSeatCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatCapa.ForeColor = System.Drawing.Color.White;
            this.labelSeatCapa.Location = new System.Drawing.Point(743, 208);
            this.labelSeatCapa.Name = "labelSeatCapa";
            this.labelSeatCapa.Size = new System.Drawing.Size(139, 25);
            this.labelSeatCapa.TabIndex = 213;
            this.labelSeatCapa.Text = "Seat No From:";
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNo.ForeColor = System.Drawing.Color.White;
            this.labelRoomNo.Location = new System.Drawing.Point(10, 83);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(81, 25);
            this.labelRoomNo.TabIndex = 214;
            this.labelRoomNo.Text = "Stream:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(940, 247);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(132, 22);
            this.textBoxTo.TabIndex = 210;
            this.textBoxTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTo_KeyPress);
            // 
            // classinfoBindingSource
            // 
            this.classinfoBindingSource.DataMember = "class_info";
            this.classinfoBindingSource.DataSource = this.seating_arrangeDataSet;
            // 
            // seating_arrangeDataSet
            // 
            this.seating_arrangeDataSet.DataSetName = "seating_arrangeDataSet";
            this.seating_arrangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCancelled
            // 
            this.labelCancelled.AutoSize = true;
            this.labelCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancelled.ForeColor = System.Drawing.Color.White;
            this.labelCancelled.Location = new System.Drawing.Point(743, 316);
            this.labelCancelled.Name = "labelCancelled";
            this.labelCancelled.Size = new System.Drawing.Size(173, 25);
            this.labelCancelled.TabIndex = 219;
            this.labelCancelled.Text = "Cancelled Roll No:";
            // 
            // class_infoTableAdapter
            // 
            this.class_infoTableAdapter.ClearBeforeFill = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(-138, 332);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // labelClose
            // 
            this.labelClose.Location = new System.Drawing.Point(0, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(100, 23);
            this.labelClose.TabIndex = 231;
            // 
            // comboBoxStream
            // 
            this.comboBoxStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStream.FormattingEnabled = true;
            this.comboBoxStream.Items.AddRange(new object[] {
            "BMM",
            "BCOM",
            "BSCIT",
            "BMS",
            "BAF"});
            this.comboBoxStream.Location = new System.Drawing.Point(97, 84);
            this.comboBoxStream.Name = "comboBoxStream";
            this.comboBoxStream.Size = new System.Drawing.Size(185, 24);
            this.comboBoxStream.TabIndex = 222;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "FY",
            "SY",
            "TY"});
            this.comboBoxClass.Location = new System.Drawing.Point(346, 84);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(185, 24);
            this.comboBoxClass.TabIndex = 223;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 219;
            this.label1.Text = "Cancelled Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 219;
            this.label3.Text = "Total:";
            // 
            // textBoxCancelCount
            // 
            this.textBoxCancelCount.Location = new System.Drawing.Point(201, 345);
            this.textBoxCancelCount.Name = "textBoxCancelCount";
            this.textBoxCancelCount.Size = new System.Drawing.Size(168, 22);
            this.textBoxCancelCount.TabIndex = 224;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(940, 430);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(168, 22);
            this.textBoxTotal.TabIndex = 224;
            this.textBoxTotal.Enter += new System.EventHandler(this.textBoxTotal_Enter);
            // 
            // buttonStep2
            // 
            this.buttonStep2.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStep2.FlatAppearance.BorderSize = 0;
            this.buttonStep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStep2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStep2.ForeColor = System.Drawing.Color.White;
            this.buttonStep2.Location = new System.Drawing.Point(765, 471);
            this.buttonStep2.Name = "buttonStep2";
            this.buttonStep2.Size = new System.Drawing.Size(211, 50);
            this.buttonStep2.TabIndex = 225;
            this.buttonStep2.Text = "2. Calculate";
            this.buttonStep2.UseVisualStyleBackColor = false;
            this.buttonStep2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCancelledNo
            // 
            this.textBoxCancelledNo.Location = new System.Drawing.Point(940, 316);
            this.textBoxCancelledNo.Multiline = true;
            this.textBoxCancelledNo.Name = "textBoxCancelledNo";
            this.textBoxCancelledNo.Size = new System.Drawing.Size(168, 36);
            this.textBoxCancelledNo.TabIndex = 226;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(697, 468);
            this.flowLayoutPanel1.TabIndex = 227;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(1016, 471);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(211, 50);
            this.buttonSave.TabIndex = 228;
            this.buttonSave.Text = "3. Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 187);
            this.dataGridView1.TabIndex = 229;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(938, 171);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 36);
            this.buttonDelete.TabIndex = 230;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPdf.Location = new System.Drawing.Point(1095, 171);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(119, 40);
            this.buttonPdf.TabIndex = 232;
            this.buttonPdf.Text = "PDF";
            this.buttonPdf.UseVisualStyleBackColor = false;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(523, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 40);
            this.label4.TabIndex = 233;
            this.label4.Text = "Add Class Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxClass);
            this.groupBox1.Controls.Add(this.textBoxCancelCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxStream);
            this.groupBox1.Controls.Add(this.labelRoomNo);
            this.groupBox1.Location = new System.Drawing.Point(739, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 537);
            this.groupBox1.TabIndex = 234;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.buttonPdf);
            this.groupBox2.Location = new System.Drawing.Point(13, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1263, 256);
            this.groupBox2.TabIndex = 235;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 537);
            this.groupBox3.TabIndex = 236;
            this.groupBox3.TabStop = false;
            // 
            // Class_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1299, 823);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxCancelledNo);
            this.Controls.Add(this.buttonStep2);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.labelCancelled);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelSeatCapa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Class_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class_Info";
            ((System.ComponentModel.ISupportInitialize)(this.classinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelSeatCapa;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelCancelled;
        private seating_arrangeDataSet seating_arrangeDataSet;
        private System.Windows.Forms.BindingSource classinfoBindingSource;
        private seating_arrangeDataSetTableAdapters.class_infoTableAdapter class_infoTableAdapter;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ComboBox comboBoxStream;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCancelCount;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonStep2;
        private System.Windows.Forms.TextBox textBoxCancelledNo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}