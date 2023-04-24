using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
using PagedList;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashCards.Desktop.Forms
{
    public partial class WordAllForm : Form
    {
        private int pageNumber = 1;
        IPagedList<Word> words;
        public WordAllForm()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<Word>> GetAllWordAsync(int pageNumber = 1, int pageSize = 5)
        {
            IWordRepository wordRepository = new WordRepository();
            var result = await wordRepository.GetAllAsync();
            return result.OrderBy(x => x.Id).ToPagedList(pageNumber, pageSize);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void WordAllForm_Load(object sender, EventArgs e)
        {
            words = await GetAllWordAsync();
            nextBttn.Enabled = words.HasNextPage;
            backBttn.Enabled = words.HasPreviousPage;
            dataGridView.DataSource = words.ToList();
            resultLabel.Text = String.Format("Page{0}/{1}", pageNumber, words.PageCount);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private async void nextBttn_Click(object sender, EventArgs e)
        {
            words = await GetAllWordAsync(++pageNumber);
            nextBttn.Enabled = words.HasNextPage;
            backBttn.Enabled = words.HasPreviousPage;
            dataGridView.DataSource = words.ToList();
            resultLabel.Text = String.Format("Page{0}/{1}", pageNumber, words.PageCount);
        }

        private async void backBttn_Click(object sender, EventArgs e)
        {
            words = await GetAllWordAsync(--pageNumber);
            backBttn.Enabled = words.HasPreviousPage;
            nextBttn.Enabled = words.HasNextPage;
            dataGridView.DataSource = words.ToList();
            resultLabel.Text = String.Format("Page{0}/{1}", pageNumber, words.PageCount);
        }
    }
}
