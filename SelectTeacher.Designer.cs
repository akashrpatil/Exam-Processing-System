namespace WindowsFormsApplication1
{
    partial class SelectTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTeacher));
            this.buttonSaveTeacher = new System.Windows.Forms.Button();
            this.teachernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select_teacher = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seating_arrangeDataSet1 = new WindowsFormsApplication1.seating_arrangeDataSet1();
            this.teacher_infoTableAdapter = new WindowsFormsApplication1.seating_arrangeDataSet1TableAdapters.teacher_infoTableAdapter();
            this.labelSelectTeacher = new System.Windows.Forms.Label();
            this.buttonLoadPrevious = new System.Windows.Forms.Button();
            this.buttonLoadSaved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveTeacher
            // 
            this.buttonSaveTeacher.BackColor = System.Drawing.Color.Navy;
            this.buttonSaveTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonSaveTeacher.Location = new System.Drawing.Point(1022, 527);
            this.buttonSaveTeacher.Name = "buttonSaveTeacher";
            this.buttonSaveTeacher.Size = new System.Drawing.Size(151, 35);
            this.buttonSaveTeacher.TabIndex = 1;
            this.buttonSaveTeacher.Text = "Save";
            this.buttonSaveTeacher.UseVisualStyleBackColor = false;
            this.buttonSaveTeacher.Click += new System.EventHandler(this.buttonSaveTeacher_Click_1);
            // 
            // teachernameDataGridViewTextBoxColumn
            // 
            this.teachernameDataGridViewTextBoxColumn.Name = "teachernameDataGridViewTextBoxColumn";
            // 
            // select_teacher
            // 
            this.select_teacher.DataPropertyName = "teacher_name";
            this.select_teacher.HeaderText = "Select Teacher";
            this.select_teacher.Name = "select_teacher";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.id,
            this.teachernameDataGridViewTextBoxColumn1,
            this.deptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 477);
            this.dataGridView1.TabIndex = 2;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // teachernameDataGridViewTextBoxColumn1
            // 
            this.teachernameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teachernameDataGridViewTextBoxColumn1.DataPropertyName = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn1.HeaderText = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn1.Name = "teachernameDataGridViewTextBoxColumn1";
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "dept";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            // 
            // teacherinfoBindingSource
            // 
            this.teacherinfoBindingSource.DataMember = "teacher_info";
            this.teacherinfoBindingSource.DataSource = this.seating_arrangeDataSet1;
            // 
            // seating_arrangeDataSet1
            // 
            this.seating_arrangeDataSet1.DataSetName = "seating_arrangeDataSet1";
            this.seating_arrangeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacher_infoTableAdapter
            // 
            this.teacher_infoTableAdapter.ClearBeforeFill = true;
            // 
            // labelSelectTeacher
            // 
            this.labelSelectTeacher.AutoSize = true;
            this.labelSelectTeacher.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectTeacher.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeacher.ForeColor = System.Drawing.Color.White;
            this.labelSelectTeacher.Location = new System.Drawing.Point(555, 9);
            this.labelSelectTeacher.Name = "labelSelectTeacher";
            this.labelSelectTeacher.Size = new System.Drawing.Size(283, 30);
            this.labelSelectTeacher.TabIndex = 3;
            this.labelSelectTeacher.Text = "Mongolian Baiti, 22.2pt";
            // 
            // buttonLoadPrevious
            // 
            this.buttonLoadPrevious.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLoadPrevious.FlatAppearance.BorderSize = 0;
            this.buttonLoadPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonLoadPrevious.Location = new System.Drawing.Point(40, 527);
            this.buttonLoadPrevious.Name = "buttonLoadPrevious";
            this.buttonLoadPrevious.Size = new System.Drawing.Size(117, 35);
            this.buttonLoadPrevious.TabIndex = 4;
            this.buttonLoadPrevious.Text = "Load Previous";
            this.buttonLoadPrevious.UseVisualStyleBackColor = false;
            this.buttonLoadPrevious.Click += new System.EventHandler(this.buttonLoadPrevious_Click);
            // 
            // buttonLoadSaved
            // 
            this.buttonLoadSaved.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLoadSaved.FlatAppearance.BorderSize = 0;
            this.buttonLoadSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadSaved.ForeColor = System.Drawing.Color.White;
            this.buttonLoadSaved.Location = new System.Drawing.Point(178, 527);
            this.buttonLoadSaved.Name = "buttonLoadSaved";
            this.buttonLoadSaved.Size = new System.Drawing.Size(117, 35);
            this.buttonLoadSaved.TabIndex = 25;
            this.buttonLoadSaved.Text = "Load Saved";
            this.buttonLoadSaved.UseVisualStyleBackColor = false;
            this.buttonLoadSaved.Click += new System.EventHandler(this.buttonLoadSaved_Click);
            // 
            // SelectTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1246, 577);
            this.Controls.Add(this.buttonLoadSaved);
            this.Controls.Add(this.buttonLoadPrevious);
            this.Controls.Add(this.labelSelectTeacher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSaveTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectTeacher";
            this.Load += new System.EventHandler(this.SelectTeacher_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seating_arrangeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select_teacher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private seating_arrangeDataSet1 seating_arrangeDataSet1;
        private System.Windows.Forms.BindingSource teacherinfoBindingSource;
        private seating_arrangeDataSet1TableAdapters.teacher_infoTableAdapter teacher_infoTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelSelectTeacher;
        private System.Windows.Forms.Button buttonLoadPrevious;
        private System.Windows.Forms.Button buttonLoadSaved;
    }
}