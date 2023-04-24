using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
using System;
using System.Windows.Forms;

namespace flashCards.Desktop.Forms.WordForm
{
    public partial class WordCreateForm : Form
    {
        public WordCreateForm()
        {
            InitializeComponent();
        }

        private void WordCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Word word = new Word()
            {
                Word_ = wordTxtBox.Text,
                TranslateWord = translateTxtBox.Text,
                TitleId = long.Parse(idTxtBox.Text.ToString()),
                CreatedAt = DateTime.Now
            };

            IWordRepository wordRepository = new WordRepository();
            var result = wordRepository.CreateAsync(word);

            if (result != null) MessageBox.Show("Added word");
            else MessageBox.Show("No word added!");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IWordRepository wordRepository = new WordRepository();
            guna2DataGridView1.DataSource = wordRepository.GetAllByWordIdAsync(long.Parse(idTxtBox.ToString()), 0, 30);
        }

        private void searchBttn_Click(object sender, EventArgs e)
        {
        }
    }
}
