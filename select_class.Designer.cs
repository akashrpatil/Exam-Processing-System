namespace WindowsFormsApplication1
{
    partial class select_class
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.streamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seating_arrangeDataSet4 = new WindowsFormsApplication1.seating_arrangeDataSet4();
            this.class_infoTableAdapter = new WindowsFormsApplication1.seating_arrangeDataSet4TableAdapters.class_infoTableAdapter();
            this.buttonLoadPrevious = new System.Windows.Forms.Button();
            this.buttonLoadAll = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.streamDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.cancelledDataGridViewTextBoxColumn,
            this.cancelcountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.id});
            this.dataGridView1.DataSource = this.classinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(175, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            // 
            // streamDataGridViewTextBoxColumn
            // 
            this.streamDataGridViewTextBoxColumn.DataPropertyName = "stream";
            this.streamDataGridViewTextBoxColumn.HeaderText = "stream";
            this.streamDataGridViewTextBoxColumn.Name = "streamDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "from";
            this.fromDataGridViewTextBoxColumn.HeaderText = "from";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "to";
            this.toDataGridViewTextBoxColumn.HeaderText = "to";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            // 
            // cancelledDataGridViewTextBoxColumn
            // 
            this.cancelledDataGridViewTextBoxColumn.DataPropertyName = "cancelled";
            this.cancelledDataGridViewTextBoxColumn.HeaderText = "cancelled";
            this.cancelledDataGridViewTextBoxColumn.Name = "cancelledDataGridViewTextBoxColumn";
            // 
            // cancelcountDataGridViewTextBoxColumn
            // 
            this.cancelcountDataGridViewTextBoxColumn.DataPropertyName = "cancel_count";
            this.cancelcountDataGridViewTextBoxColumn.HeaderText = "cancel_count";
            this.cancelcountDataGridViewTextBoxColumn.Name = "cancelcountDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // classinfoBindingSource
            // 
            this.classinfoBindingSource.DataMember = "class_info";
            this.classinfoBindingSource.DataSource = this.seating_arrangeDataSet4;
            // 
            // seating_arrangeDataSet4
            // 
            this.seating_arrangeDataSet4.DataSetName = "seating_arrangeDataSet4";
            this.seating_arrangeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // class_infoTableAdapter
            // 
            this.class_infoTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLoadPrevious
            // 
            this.buttonLoadPrevious.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonLoadPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPrevious.Location = new System.Drawing.Point(318, 523);
            this.buttonLoadPrevious.Name = "buttonLoadPrevious";
            this.buttonLoadPrevious.Size = new System.Drawing.Size(140, 40);
            this.buttonLoadPrevious.TabIndex = 1;
            this.buttonLoadPrevious.Text = "Load All";
            this.buttonLoadPrevious.UseVisualStyleBackColor = false;
            this.buttonLoadPrevious.Click += new System.EventHandler(this.buttonLoadPrevious_Click);
            // 
            // buttonLoadAll
            // 
            this.buttonLoadAll.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadAll.Location = new System.Drawing.Point(162, 523);
            this.buttonLoadAll.Name = "buttonLoadAll";
            this.buttonLoadAll.Size = new System.Drawing.Size(140, 40);
            this.buttonLoadAll.TabIndex = 1;
            this.buttonLoadAll.Text = "Load Previous";
            this.buttonLoadAll.UseVisualStyleBackColor = false;
            this.buttonLoadAll.Click += new System.EventHandler(this.buttonLoadAll_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(967, 532);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(140, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(581, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Class";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonLoadAll);
            this.groupBox1.Controls.Add(this.buttonLoadPrevious);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1377, 582);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // select_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1354, 616);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "select_class";
            this.Text = "select_class";
            this.Load += new System.EventHandler(this.select_class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private seating_arrangeDataSet4 seating_arrangeDataSet4;
        private System.Windows.Forms.BindingSource classinfoBindingSource;
        private seating_arrangeDataSet4TableAdapters.class_infoTableAdapter class_infoTableAdapter;
        private System.Windows.Forms.Button buttonLoadPrevious;
        private System.Windows.Forms.Button buttonLoadAll;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn streamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}