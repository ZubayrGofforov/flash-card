using flashCards.Desktop.Common;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
using System;
using System.Windows.Forms;

namespace flashCards.Desktop.Forms
{
    public partial class TitleCreateForm : Form
    {
        public TitleCreateForm()
        {
            InitializeComponent();
        }

        private void createBttn_Click(object sender, EventArgs e)
        {
            Title title = new Title()
            {
                WordsTitle = titleTxtBox.Text,
                Description = descriptionTxtBox.Text,
                UserId = IdentitySingelton.GetInstance().UserId
            };

            ITitleRepository titleRepository = new TitleRepository();
            var result = titleRepository.CreateAsync(title);

            if (result is null) MessageBox.Show("Did not join");
            else MessageBox.Show("Successfuly!");
        }

        private void canelBttn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
