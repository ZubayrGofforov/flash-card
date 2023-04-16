using flashCards.Desktop.Interfaces.Services;
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

namespace flashCards.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            UserViewModel userCreateViewModel = new UserViewModel();
            userCreateViewModel.FullName = fullNameTxtBox.Text;
            userCreateViewModel.Username = userNameTxtBox.Text;
            userCreateViewModel.Password = passwordTxtBox.Text;
            userCreateViewModel.BirthDate = DateTime.Parse(birthDateTxtBox.Text.ToString());

            IUserService userService = new UserService();
            var result = userService.RegisterAsync(userCreateViewModel);
            if (result != null) MessageBox.Show("Successfuly!");
            else MessageBox.Show("No added user");

            if (pnlRegspic.Visible)
            {
             
                pnlLoginpic.Visible = true;
            }
            if (pnlRegs.Visible)
            {
                loginPanel.Visible = true;
              
            }
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            pnlRegs.Visible = true;
            loginPanel.Visible = false;
            pnlLoginpic.Visible = false;
            pnlRegspic.Visible = true;
        
            //RegisterForm registerForm = new RegisterForm();
            //this.Hide();
            //registerForm.Show();
        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            IUserService userService = new UserService();
            string username = usernameLTextBox.Text;
            string password = passwordLTextBox.Text;
            var user = await userService.Loginasync(username, password);

            if (user.IsSuccessful)
            {
                MessageBox.Show("Successfuly!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(user.Message);
                usernameLTextBox.Text = "";
                passwordLTextBox.Text = "";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlRegs_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLoginpic_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
