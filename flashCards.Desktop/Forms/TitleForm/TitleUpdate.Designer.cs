namespace flashCards.Desktop.Forms
{
    partial class TitleUpdate
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
            this.canelBttn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.createBttn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.descriptionTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // canelBttn
            // 
            this.canelBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.canelBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.canelBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.canelBttn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.canelBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.canelBttn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.canelBttn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.canelBttn.ForeColor = System.Drawing.Color.White;
            this.canelBttn.Location = new System.Drawing.Point(126, 283);
            this.canelBttn.Name = "canelBttn";
            this.canelBttn.Size = new System.Drawing.Size(155, 39);
            this.canelBttn.TabIndex = 7;
            this.canelBttn.Text = "CANEL";
            this.canelBttn.Click += new System.EventHandler(this.canelBttn_Click);
            // 
            // createBttn
            // 
            this.createBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createBttn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createBttn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.createBttn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.createBttn.ForeColor = System.Drawing.Color.White;
            this.createBttn.Location = new System.Drawing.Point(308, 283);
            this.createBttn.Name = "createBttn";
            this.createBttn.Size = new System.Drawing.Size(155, 39);
            this.createBttn.TabIndex = 8;
            this.createBttn.Text = "UPDATE";
            this.createBttn.Click += new System.EventHandler(this.createBttn_Click);
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.BorderRadius = 1;
            this.descriptionTxtBox.BorderThickness = 2;
            this.descriptionTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTxtBox.DefaultText = "";
            this.descriptionTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.descriptionTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTxtBox.Location = new System.Drawing.Point(48, 158);
            this.descriptionTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.PasswordChar = '\0';
            this.descriptionTxtBox.PlaceholderText = "Description";
            this.descriptionTxtBox.SelectedText = "";
            this.descriptionTxtBox.Size = new System.Drawing.Size(485, 85);
            this.descriptionTxtBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Update Stack";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Animated = true;
            this.titleTxtBox.BorderRadius = 1;
            this.titleTxtBox.BorderThickness = 2;
            this.titleTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTxtBox.DefaultText = "";
            this.titleTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.titleTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleTxtBox.Location = new System.Drawing.Point(48, 86);
            this.titleTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.PasswordChar = '\0';
            this.titleTxtBox.PlaceholderText = "Title";
            this.titleTxtBox.SelectedText = "";
            this.titleTxtBox.Size = new System.Drawing.Size(485, 50);
            this.titleTxtBox.TabIndex = 4;
            // 
            // TitleUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 361);
            this.Controls.Add(this.canelBttn);
            this.Controls.Add(this.createBttn);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TitleUpdate";
            this.Text = "TitleUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton canelBttn;
        private Guna.UI2.WinForms.Guna2GradientButton createBttn;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTxtBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox titleTxtBox;
    }
}