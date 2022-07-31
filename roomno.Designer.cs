namespace WindowsFormsApplication1
{
    partial class roomno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seating_arrangeDataSet = new WindowsFormsApplication1.seating_arrangeDataSet();
            this.classinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_infoTableAdapter = new WindowsFormsApplication1.seating_arrangeDataSetTableAdapters.class_infoTableAdapter();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonpdf = new System.Windows.Forms.Button();
            this.buttonViewRoom = new System.Windows.Forms.Button();
            this.labelteacher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seating_arrangeDataSet
            // 
            this.seating_arrangeDataSet.DataSetName = "seating_arrangeDataSet";
            this.seating_arrangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classinfoBindingSource
            // 
            this.classinfoBindingSource.DataMember = "class_info";
            this.classinfoBindingSource.DataSource = this.seating_arrangeDataSet;
            // 
            // class_infoTableAdapter
            // 
            this.class_infoTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Turquoise;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(203, 54);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(768, 552);
            this.bunifuCustomDataGrid1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelteacher);
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Controls.Add(this.buttonpdf);
            this.groupBox1.Controls.Add(this.buttonViewRoom);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1239, 766);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonpdf
            // 
            this.buttonpdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpdf.Location = new System.Drawing.Point(836, 621);
            this.buttonpdf.Name = "buttonpdf";
            this.buttonpdf.Size = new System.Drawing.Size(135, 44);
            this.buttonpdf.TabIndex = 5;
            this.buttonpdf.Text = "PDF";
            this.buttonpdf.UseVisualStyleBackColor = false;
            this.buttonpdf.Click += new System.EventHandler(this.buttonpdf_Click);
            // 
            // buttonViewRoom
            // 
            this.buttonViewRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonViewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewRoom.Location = new System.Drawing.Point(634, 621);
            this.buttonViewRoom.Name = "buttonViewRoom";
            this.buttonViewRoom.Size = new System.Drawing.Size(151, 44);
            this.buttonViewRoom.TabIndex = 4;
            this.buttonViewRoom.Text = "VIEW ROOMS";
            this.buttonViewRoom.UseVisualStyleBackColor = false;
            this.buttonViewRoom.Click += new System.EventHandler(this.buttonViewRoom_Click);
            // 
            // labelteacher
            // 
            this.labelteacher.AutoSize = true;
            this.labelteacher.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteacher.ForeColor = System.Drawing.Color.White;
            this.labelteacher.Location = new System.Drawing.Point(464, -4);
            this.labelteacher.Name = "labelteacher";
            this.labelteacher.Size = new System.Drawing.Size(321, 40);
            this.labelteacher.TabIndex = 23;
            this.labelteacher.Text = "View Room Details";
            // 
            // roomno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1232, 690);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "roomno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "roomno";
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private seating_arrangeDataSet seating_arrangeDataSet;
        private System.Windows.Forms.BindingSource classinfoBindingSource;
        private seating_arrangeDataSetTableAdapters.class_infoTableAdapter class_infoTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonViewRoom;
        private System.Windows.Forms.Button buttonpdf;
        private System.Windows.Forms.Label labelteacher;
    }
}