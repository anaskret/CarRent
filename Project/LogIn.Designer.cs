﻿namespace Project
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.cbShowHide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(31, 45);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(219, 23);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(31, 116);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(218, 27);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.Location = new System.Drawing.Point(31, 22);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(47, 20);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(31, 93);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 20);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.Location = new System.Drawing.Point(92, 189);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(102, 42);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // cbShowHide
            // 
            this.cbShowHide.AutoSize = true;
            this.cbShowHide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbShowHide.Location = new System.Drawing.Point(31, 149);
            this.cbShowHide.Name = "cbShowHide";
            this.cbShowHide.Size = new System.Drawing.Size(112, 19);
            this.cbShowHide.TabIndex = 5;
            this.cbShowHide.Text = "Show Password";
            this.cbShowHide.UseVisualStyleBackColor = true;
            this.cbShowHide.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LogIn
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.cbShowHide);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.CheckBox cbShowHide;
    }
}
