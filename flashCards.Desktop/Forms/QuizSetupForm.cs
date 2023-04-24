using System;
using System.Windows.Forms;

namespace flashCards.Desktop.Forms
{
    public partial class QuizSetupForm : Form
    {
        public QuizSetupForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            ReverseForm reverseForm = new ReverseForm();
            reverseForm.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ShuffleForm shuffleForm = new ShuffleForm();
            shuffleForm.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
