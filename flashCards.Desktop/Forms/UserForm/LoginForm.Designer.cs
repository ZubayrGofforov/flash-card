namespace flashCards.Desktop.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordLTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameLTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlRegs = new System.Windows.Forms.Panel();
            this.birthDateTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.userNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlRegspic = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLoginpic = new Guna.UI2.WinForms.Guna2Panel();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnlRegs.SuspendLayout();
            this.pnlRegspic.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 2;
            this.guna2GradientButton1.BorderThickness = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Gray;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(47, 316);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(260, 46);
            this.guna2GradientButton1.TabIndex = 6;
            this.guna2GradientButton1.Text = "Login";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(122, 398);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 22);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passwordLTextBox);
            this.loginPanel.Controls.Add(this.usernameLTextBox);
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.guna2GradientButton1);
            this.loginPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.loginPanel.Location = new System.Drawing.Point(473, 23);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(364, 461);
            this.loginPanel.TabIndex = 10;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // passwordLTextBox
            // 
            this.passwordLTextBox.BorderColor = System.Drawing.Color.Black;
            this.passwordLTextBox.BorderRadius = 1;
            this.passwordLTextBox.BorderThickness = 2;
            this.passwordLTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLTextBox.DefaultText = "";
            this.passwordLTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordLTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordLTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordLTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordLTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordLTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordLTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordLTextBox.Location = new System.Drawing.Point(47, 219);
            this.passwordLTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordLTextBox.Name = "passwordLTextBox";
            this.passwordLTextBox.PasswordChar = '*';
            this.passwordLTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordLTextBox.PlaceholderText = "Password";
            this.passwordLTextBox.SelectedText = "";
            this.passwordLTextBox.Size = new System.Drawing.Size(260, 45);
            this.passwordLTextBox.TabIndex = 8;
            // 
            // usernameLTextBox
            // 
            this.usernameLTextBox.BorderColor = System.Drawing.Color.Black;
            this.usernameLTextBox.BorderRadius = 1;
            this.usernameLTextBox.BorderThickness = 2;
            this.usernameLTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameLTextBox.DefaultText = "";
            this.usernameLTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameLTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameLTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameLTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameLTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameLTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameLTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.usernameLTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameLTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameLTextBox.Location = new System.Drawing.Point(47, 143);
            this.usernameLTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameLTextBox.Name = "usernameLTextBox";
            this.usernameLTextBox.PasswordChar = '\0';
            this.usernameLTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.usernameLTextBox.PlaceholderText = "Username";
            this.usernameLTextBox.SelectedText = "";
            this.usernameLTextBox.Size = new System.Drawing.Size(260, 45);
            this.usernameLTextBox.TabIndex = 8;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2CirclePictureBox1.Image = global::flashCards.Desktop.Properties.Resources.accountIcon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(136, 34);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(85, 77);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pnlRegs
            // 
            this.pnlRegs.Controls.Add(this.birthDateTxtBox);
            this.pnlRegs.Controls.Add(this.passwordTxtBox);
            this.pnlRegs.Controls.Add(this.userNameTxtBox);
            this.pnlRegs.Controls.Add(this.fullNameTxtBox);
            this.pnlRegs.Controls.Add(this.guna2GradientButton2);
            this.pnlRegs.Location = new System.Drawing.Point(489, 23);
            this.pnlRegs.Name = "pnlRegs";
            this.pnlRegs.Size = new System.Drawing.Size(348, 458);
            this.pnlRegs.TabIndex = 11;
            this.pnlRegs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegs_Paint);
            // 
            // birthDateTxtBox
            // 
            this.birthDateTxtBox.Animated = true;
            this.birthDateTxtBox.BorderColor = System.Drawing.Color.Black;
            this.birthDateTxtBox.BorderRadius = 1;
            this.birthDateTxtBox.BorderThickness = 2;
            this.birthDateTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthDateTxtBox.DefaultText = "";
            this.birthDateTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.birthDateTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.birthDateTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthDateTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthDateTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthDateTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthDateTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.birthDateTxtBox.ForeColor = System.Drawing.Color.White;
            this.birthDateTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthDateTxtBox.Location = new System.Drawing.Point(33, 245);
            this.birthDateTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthDateTxtBox.Name = "birthDateTxtBox";
            this.birthDateTxtBox.PasswordChar = '\0';
            this.birthDateTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.birthDateTxtBox.PlaceholderText = "Birth of date";
            this.birthDateTxtBox.SelectedText = "";
            this.birthDateTxtBox.Size = new System.Drawing.Size(254, 45);
            this.birthDateTxtBox.TabIndex = 4;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Animated = true;
            this.passwordTxtBox.BorderColor = System.Drawing.Color.Black;
            this.passwordTxtBox.BorderRadius = 1;
            this.passwordTxtBox.BorderThickness = 2;
            this.passwordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtBox.DefaultText = "";
            this.passwordTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.passwordTxtBox.ForeColor = System.Drawing.Color.White;
            this.passwordTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.Location = new System.Drawing.Point(33, 177);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTxtBox.PlaceholderText = "Password";
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.Size = new System.Drawing.Size(254, 45);
            this.passwordTxtBox.TabIndex = 4;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Animated = true;
            this.userNameTxtBox.BorderColor = System.Drawing.Color.Black;
            this.userNameTxtBox.BorderRadius = 1;
            this.userNameTxtBox.BorderThickness = 2;
            this.userNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxtBox.DefaultText = "";
            this.userNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.userNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.userNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxtBox.Location = new System.Drawing.Point(33, 105);
            this.userNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.PasswordChar = '\0';
            this.userNameTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userNameTxtBox.PlaceholderText = "Username";
            this.userNameTxtBox.SelectedText = "";
            this.userNameTxtBox.Size = new System.Drawing.Size(254, 45);
            this.userNameTxtBox.TabIndex = 4;
            // 
            // fullNameTxtBox
            // 
            this.fullNameTxtBox.Animated = true;
            this.fullNameTxtBox.BorderColor = System.Drawing.Color.Black;
            this.fullNameTxtBox.BorderRadius = 1;
            this.fullNameTxtBox.BorderThickness = 2;
            this.fullNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameTxtBox.DefaultText = "";
            this.fullNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.fullNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.fullNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTxtBox.Location = new System.Drawing.Point(33, 34);
            this.fullNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullNameTxtBox.Name = "fullNameTxtBox";
            this.fullNameTxtBox.PasswordChar = '\0';
            this.fullNameTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.fullNameTxtBox.PlaceholderText = "Full Name";
            this.fullNameTxtBox.SelectedText = "";
            this.fullNameTxtBox.Size = new System.Drawing.Size(254, 45);
            this.fullNameTxtBox.TabIndex = 4;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 2;
            this.guna2GradientButton2.BorderThickness = 2;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.DimGray;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(33, 351);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(254, 44);
            this.guna2GradientButton2.TabIndex = 3;
            this.guna2GradientButton2.Text = "Register";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // pnlRegspic
            // 
            this.pnlRegspic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRegspic.BackgroundImage")));
            this.pnlRegspic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRegspic.Controls.Add(this.pnlLoginpic);
            this.pnlRegspic.Location = new System.Drawing.Point(-76, -1);
            this.pnlRegspic.Name = "pnlRegspic";
            this.pnlRegspic.Size = new System.Drawing.Size(554, 504);
            this.pnlRegspic.TabIndex = 13;
            // 
            // pnlLoginpic
            // 
            this.pnlLoginpic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLoginpic.BackgroundImage")));
            this.pnlLoginpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginpic.Location = new System.Drawing.Point(75, -1);
            this.pnlLoginpic.Name = "pnlLoginpic";
            this.pnlLoginpic.Size = new System.Drawing.Size(491, 504);
            this.pnlLoginpic.TabIndex = 12;
            this.pnlLoginpic.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLoginpic_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 500);
            this.Controls.Add(this.pnlRegspic);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.pnlRegs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnlRegs.ResumeLayout(false);
            this.pnlRegspic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel pnlRegs;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginpic;
        private Guna.UI2.WinForms.Guna2Panel pnlRegspic;
        private Guna.UI2.WinForms.Guna2TextBox birthDateTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox userNameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox fullNameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordLTextBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameLTextBox;
    }
}