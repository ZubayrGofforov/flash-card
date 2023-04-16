using flashCards.Desktop.Forms;
using flashCards.Desktop.Forms.WordForm;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Interfaces.Services;
using flashCards.Desktop.Repositories;
using flashCards.Desktop.Sevices;
using flashCards.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashCards.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void searchTextbox_OnTextChange(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new GetAllTitlesForm());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserViewModel userViewModel = new UserViewModel();
            usernameLabel.Text = userViewModel.Username;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new ReverseForm());
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void titleBttn_Click(object sender, EventArgs e)
        {
            openChildForm(new TitleCreateForm());
        }

        private void titleUpdateBttn_Click(object sender, EventArgs e)
        {
            openChildForm(new TitleUpdate());
        }

        private void addWordBttn_Click(object sender, EventArgs e)
        {
            openChildForm(new WordCreateForm());
        }

        private void usersettingsButtn_Click(object sender, EventArgs e)
        {
            openChildForm(new UserUpdateForm());
        }

        private void guna2GradientButton1_Click_2(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new QuizSetupForm());
        }
    }
}
