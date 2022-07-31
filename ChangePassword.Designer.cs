namespace WindowsFormsApplication1
{
    partial class ChangePassword
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
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelConfirmPasswd = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.ForeColor = System.Drawing.Color.Black;
            this.buttonChangePassword.Location = new System.Drawing.Point(373, 189);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(169, 37);
            this.buttonChangePassword.TabIndex = 7;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Location = new System.Drawing.Point(219, 142);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(323, 22);
            this.textBoxConfirmPass.TabIndex = 5;
            this.textBoxConfirmPass.UseSystemPasswordChar = true;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(219, 84);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(323, 22);
            this.textBoxNewPass.TabIndex = 6;
            this.textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // labelConfirmPasswd
            // 
            this.labelConfirmPasswd.AutoSize = true;
            this.labelConfirmPasswd.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPasswd.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPasswd.Location = new System.Drawing.Point(11, 142);
            this.labelConfirmPasswd.Name = "labelConfirmPasswd";
            this.labelConfirmPasswd.Size = new System.Drawing.Size(202, 23);
            this.labelConfirmPasswd.TabIndex = 3;
            this.labelConfirmPasswd.Text = "Confirm Password:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelNewPassword.Location = new System.Drawing.Point(51, 81);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(162, 23);
            this.labelNewPassword.TabIndex = 4;
            this.labelNewPassword.Text = "New Password:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(586, 283);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.labelConfirmPasswd);
            this.Controls.Add(this.labelNewPassword);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelConfirmPasswd;
        private System.Windows.Forms.Label labelNewPassword;
    }
}