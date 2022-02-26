﻿using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.HidePassword = new System.Windows.Forms.Button();
            this.LoginButton1 = new System.Windows.Forms.Button();
            this.LoggingInLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DontHaveAnAccountLabel = new System.Windows.Forms.LinkLabel();
            this.RefreshFormButton = new System.Windows.Forms.Button();
            this.LoginSettingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginButton = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old London", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(115, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Fantasy4You";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(153, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "to continue please put in your credentials";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(277, 158);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(152, 23);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old London", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(172, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Old London", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(172, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(277, 208);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(152, 23);
            this.PasswordTextbox.TabIndex = 8;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // ShowPassword
            // 
            this.ShowPassword.BackColor = System.Drawing.Color.Tan;
            this.ShowPassword.FlatAppearance.BorderSize = 0;
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPassword.Location = new System.Drawing.Point(435, 208);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(29, 23);
            this.ShowPassword.TabIndex = 9;
            this.ShowPassword.Text = "X";
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.BackColor = System.Drawing.Color.Tan;
            this.HidePassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HidePassword.FlatAppearance.BorderSize = 0;
            this.HidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HidePassword.Location = new System.Drawing.Point(435, 208);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(29, 23);
            this.HidePassword.TabIndex = 10;
            this.HidePassword.Text = "X";
            this.HidePassword.UseVisualStyleBackColor = false;
            this.HidePassword.Visible = false;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // LoginButton1
            // 
            this.LoginButton1.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton1.Location = new System.Drawing.Point(226, 277);
            this.LoginButton1.Name = "LoginButton1";
            this.LoginButton1.Size = new System.Drawing.Size(221, 47);
            this.LoginButton1.TabIndex = 11;
            this.LoginButton1.Text = "Login";
            this.LoginButton1.UseVisualStyleBackColor = false;
            // 
            // LoggingInLabel
            // 
            this.LoggingInLabel.AutoSize = true;
            this.LoggingInLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoggingInLabel.Location = new System.Drawing.Point(304, 336);
            this.LoggingInLabel.Name = "LoggingInLabel";
            this.LoggingInLabel.Size = new System.Drawing.Size(76, 15);
            this.LoggingInLabel.TabIndex = 12;
            this.LoggingInLabel.Text = "Please Wait...";
            this.LoggingInLabel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.checkBox1.Location = new System.Drawing.Point(212, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DontHaveAnAccountLabel
            // 
            this.DontHaveAnAccountLabel.AutoSize = true;
            this.DontHaveAnAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.DontHaveAnAccountLabel.ForeColor = System.Drawing.Color.Coral;
            this.DontHaveAnAccountLabel.LinkColor = System.Drawing.Color.SandyBrown;
            this.DontHaveAnAccountLabel.Location = new System.Drawing.Point(453, 309);
            this.DontHaveAnAccountLabel.Name = "DontHaveAnAccountLabel";
            this.DontHaveAnAccountLabel.Size = new System.Drawing.Size(128, 15);
            this.DontHaveAnAccountLabel.TabIndex = 14;
            this.DontHaveAnAccountLabel.TabStop = true;
            this.DontHaveAnAccountLabel.Text = "Dont have an account?";
            this.DontHaveAnAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DontHaveAnAccountLabel_LinkClicked);
            // 
            // RefreshFormButton
            // 
            this.RefreshFormButton.Location = new System.Drawing.Point(640, 356);
            this.RefreshFormButton.Name = "RefreshFormButton";
            this.RefreshFormButton.Size = new System.Drawing.Size(75, 29);
            this.RefreshFormButton.TabIndex = 15;
            this.RefreshFormButton.Text = "Refresh";
            this.RefreshFormButton.UseVisualStyleBackColor = true;
            this.RefreshFormButton.Click += new System.EventHandler(this.RefreshFormButton_Click);
            // 
            // LoginSettingsButton
            // 
            this.LoginSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginSettingsButton.Location = new System.Drawing.Point(640, 391);
            this.LoginSettingsButton.Name = "LoginSettingsButton";
            this.LoginSettingsButton.Size = new System.Drawing.Size(75, 27);
            this.LoginSettingsButton.TabIndex = 16;
            this.LoginSettingsButton.Text = "Settings";
            this.LoginSettingsButton.UseVisualStyleBackColor = true;
            this.LoginSettingsButton.Click += new System.EventHandler(this.LoginSettingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 436);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.ButtonColor = System.Drawing.Color.Tan;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(226, 277);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnHoverButtonColor = System.Drawing.Color.Tan;
            this.LoginButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.LoginButton.Size = new System.Drawing.Size(221, 56);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextColor = System.Drawing.Color.White;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FANTASY4YOU.Properties.Resources.starter1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 430);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginSettingsButton);
            this.Controls.Add(this.RefreshFormButton);
            this.Controls.Add(this.DontHaveAnAccountLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LoggingInLabel);
            this.Controls.Add(this.LoginButton1);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginButton1;
        private Label label1;
        private Label label2;
        private TextBox UsernameTextbox;
        private Label label3;
        private Label label4;
        private TextBox PasswordTextbox;
        private Button ShowPassword;
        private Button HidePassword;
        private Label LoggingInLabel;
        private CheckBox checkBox1;
        private LinkLabel DontHaveAnAccountLabel;
        private Button RefreshFormButton;
        private Button LoginSettingsButton;
        private PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC LoginButton;
    }
}