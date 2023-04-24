using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace flashCards.Desktop.Forms
{
    public partial class ShuffleForm : Form
    {
        private IList<Word> words;
        private int currentWord = 0;
        private int correctAnswer = 0;
        public ShuffleForm()
        {
            InitializeComponent();
        }

        private async void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            IWordRepository wordRepository = new WordRepository();
            var words = await wordRepository.GetAllByWordIdAsync(long.Parse(titleIdTxtBox.Text.ToString()), 0, 30);


            shuffleLabel.Text = words[currentWord].Word_;
            currentWord++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBttn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private async void GetWordCollection()
        {
            IWordRepository wordRepository = new WordRepository();
            var words = await wordRepository.GetAllByWordIdAsync(long.Parse(titleIdTxtBox.Text.ToString()), 0, 30);

            shuffleLabel.Text = words[currentWord].Word_;
            currentWord++;
        }
        private async void ShuffleForm_Load(object sender, EventArgs e)
        {

        }

        private void titleIdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
