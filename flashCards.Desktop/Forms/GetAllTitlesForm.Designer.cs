namespace flashCards.Desktop.Forms
{
    partial class GetAllTitlesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewTitles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nextBttn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.backBttn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.idTitleTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchBttn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitles)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewTitles);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(773, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewTitles
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridViewTitles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTitles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTitles.ColumnHeadersHeight = 29;
            this.dataGridViewTitles.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTitles.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTitles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewTitles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTitles.Name = "dataGridViewTitles";
            this.dataGridViewTitles.ReadOnly = true;
            this.dataGridViewTitles.RowHeadersVisible = false;
            this.dataGridViewTitles.RowHeadersWidth = 51;
            this.dataGridViewTitles.RowTemplate.Height = 24;
            this.dataGridViewTitles.Size = new System.Drawing.Size(770, 423);
            this.dataGridViewTitles.TabIndex = 0;
            this.dataGridViewTitles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTitles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewTitles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewTitles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewTitles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewTitles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTitles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewTitles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewTitles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTitles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTitles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTitles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTitles.ThemeStyle.HeaderStyle.Height = 29;
            this.dataGridViewTitles.ThemeStyle.ReadOnly = true;
            this.dataGridViewTitles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTitles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTitles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTitles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewTitles.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewTitles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewTitles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // nextBttn
            // 
            this.nextBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextBttn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextBttn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.nextBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.nextBttn.ForeColor = System.Drawing.Color.White;
            this.nextBttn.Location = new System.Drawing.Point(629, 450);
            this.nextBttn.Name = "nextBttn";
            this.nextBttn.Size = new System.Drawing.Size(75, 45);
            this.nextBttn.TabIndex = 2;
            this.nextBttn.Text = ">";
            this.nextBttn.Click += new System.EventHandler(this.nextBttn_Click);
            // 
            // backBttn
            // 
            this.backBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBttn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBttn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.backBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.backBttn.ForeColor = System.Drawing.Color.White;
            this.backBttn.Location = new System.Drawing.Point(433, 450);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(77, 45);
            this.backBttn.TabIndex = 3;
            this.backBttn.Text = "<";
            this.backBttn.Click += new System.EventHandler(this.backBttn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(541, 466);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(58, 22);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "label1";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // idTitleTxtBox
            // 
            this.idTitleTxtBox.BorderRadius = 1;
            this.idTitleTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTitleTxtBox.DefaultText = "";
            this.idTitleTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTitleTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTitleTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTitleTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTitleTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.idTitleTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTitleTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTitleTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTitleTxtBox.Location = new System.Drawing.Point(51, 450);
            this.idTitleTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTitleTxtBox.Name = "idTitleTxtBox";
            this.idTitleTxtBox.PasswordChar = '\0';
            this.idTitleTxtBox.PlaceholderText = "Enter title id";
            this.idTitleTxtBox.SelectedText = "";
            this.idTitleTxtBox.Size = new System.Drawing.Size(155, 45);
            this.idTitleTxtBox.TabIndex = 5;
            this.idTitleTxtBox.TextChanged += new System.EventHandler(this.idTitleTxtBox_TextChanged);
            // 
            // searchBttn
            // 
            this.searchBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBttn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBttn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.searchBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.searchBttn.ForeColor = System.Drawing.Color.White;
            this.searchBttn.Location = new System.Drawing.Point(242, 450);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(117, 45);
            this.searchBttn.TabIndex = 6;
            this.searchBttn.Text = "SEARCH";
            this.searchBttn.Click += new System.EventHandler(this.searchBttn_Click);
            // 
            // GetAllTitlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.searchBttn);
            this.Controls.Add(this.idTitleTxtBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(this.nextBttn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetAllTitlesForm";
            this.Text = "TitleCreateForm";
            this.Load += new System.EventHandler(this.GetAllTitlesForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewTitles;
        private Guna.UI2.WinForms.Guna2GradientButton nextBttn;
        private Guna.UI2.WinForms.Guna2GradientButton backBttn;
        private System.Windows.Forms.Label resultLabel;
        private Guna.UI2.WinForms.Guna2TextBox idTitleTxtBox;
        private Guna.UI2.WinForms.Guna2GradientButton searchBttn;
    }
}