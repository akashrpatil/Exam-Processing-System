namespace WindowsFormsApplication1
{
    partial class ForgotPassword
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
            this.labelEnterEmail = new System.Windows.Forms.Label();
            this.labelVerifyCode = new System.Windows.Forms.Label();
            this.textBoxTextEmailOTP = new System.Windows.Forms.TextBox();
            this.textBoxVerifyCode = new System.Windows.Forms.TextBox();
            this.buttonSendOTP = new System.Windows.Forms.Button();
            this.buttonVerifyOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnterEmail
            // 
            this.labelEnterEmail.AutoSize = true;
            this.labelEnterEmail.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterEmail.ForeColor = System.Drawing.Color.White;
            this.labelEnterEmail.Location = new System.Drawing.Point(79, 58);
            this.labelEnterEmail.Name = "labelEnterEmail";
            this.labelEnterEmail.Size = new System.Drawing.Size(143, 23);
            this.labelEnterEmail.TabIndex = 0;
            this.labelEnterEmail.Text = "Enter Email : ";
            // 
            // labelVerifyCode
            // 
            this.labelVerifyCode.AutoSize = true;
            this.labelVerifyCode.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerifyCode.ForeColor = System.Drawing.Color.White;
            this.labelVerifyCode.Location = new System.Drawing.Point(20, 116);
            this.labelVerifyCode.Name = "labelVerifyCode";
            this.labelVerifyCode.Size = new System.Drawing.Size(193, 23);
            this.labelVerifyCode.TabIndex = 0;
            this.labelVerifyCode.Text = "Enter Verify Code:";
            // 
            // textBoxTextEmailOTP
            // 
            this.textBoxTextEmailOTP.Location = new System.Drawing.Point(228, 58);
            this.textBoxTextEmailOTP.Name = "textBoxTextEmailOTP";
            this.textBoxTextEmailOTP.Size = new System.Drawing.Size(323, 22);
            this.textBoxTextEmailOTP.TabIndex = 1;
            // 
            // textBoxVerifyCode
            // 
            this.textBoxVerifyCode.Location = new System.Drawing.Point(228, 116);
            this.textBoxVerifyCode.Name = "textBoxVerifyCode";
            this.textBoxVerifyCode.Size = new System.Drawing.Size(323, 22);
            this.textBoxVerifyCode.TabIndex = 3;
            // 
            // buttonSendOTP
            // 
            this.buttonSendOTP.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendOTP.Location = new System.Drawing.Point(577, 51);
            this.buttonSendOTP.Name = "buttonSendOTP";
            this.buttonSendOTP.Size = new System.Drawing.Size(84, 37);
            this.buttonSendOTP.TabIndex = 2;
            this.buttonSendOTP.Text = "Send OTP";
            this.buttonSendOTP.UseVisualStyleBackColor = false;
            this.buttonSendOTP.Click += new System.EventHandler(this.buttonSendOTP_Click);
            // 
            // buttonVerifyOTP
            // 
            this.buttonVerifyOTP.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonVerifyOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerifyOTP.Location = new System.Drawing.Point(577, 109);
            this.buttonVerifyOTP.Name = "buttonVerifyOTP";
            this.buttonVerifyOTP.Size = new System.Drawing.Size(84, 37);
            this.buttonVerifyOTP.TabIndex = 4;
            this.buttonVerifyOTP.Text = "Verify";
            this.buttonVerifyOTP.UseVisualStyleBackColor = false;
            this.buttonVerifyOTP.Click += new System.EventHandler(this.buttonVerifyOTP_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(716, 205);
            this.Controls.Add(this.buttonVerifyOTP);
            this.Controls.Add(this.buttonSendOTP);
            this.Controls.Add(this.textBoxVerifyCode);
            this.Controls.Add(this.textBoxTextEmailOTP);
            this.Controls.Add(this.labelVerifyCode);
            this.Controls.Add(this.labelEnterEmail);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterEmail;
        private System.Windows.Forms.Label labelVerifyCode;
        private System.Windows.Forms.TextBox textBoxTextEmailOTP;
        private System.Windows.Forms.TextBox textBoxVerifyCode;
        private System.Windows.Forms.Button buttonSendOTP;
        private System.Windows.Forms.Button buttonVerifyOTP;
    }
}