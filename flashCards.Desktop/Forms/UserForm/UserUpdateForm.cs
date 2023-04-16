using flashCards.Desktop.Common;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Repositories;
using flashCards.Desktop.ViewModels;
using System;
using System.Windows.Forms;

namespace flashCards.Desktop.Forms
{
    public partial class UserUpdateForm : Form
    {
        public UserUpdateForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            UserViewModel userViewModel = new UserViewModel()
            {
                FullName = fullNameTxtBox.Text,
                Username = userNameTxtBox.Text,
                Password = passwordTxtBox.Text,
                BirthDate = DateTime.Parse(birthDateTxtBox.Text.ToString())
            };

            var result = userRepository.UpdateAsync(IdentitySingelton.GetInstance().UserId, userViewModel);

            if (result != null) MessageBox.Show("User updated");
            else MessageBox.Show("No user updated!");
        }
    }
}
