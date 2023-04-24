using flashCards.Desktop.Common;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace flashCards.Desktop
{
    public partial class TitleControl : UserControl
    {
        private IList<Title> titles;
        private int index = 0;
        private string _title;
        public TitleControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; titleBttn.Text = value; }
        }
        private async void GetTitleCollection()
        {
            ITitleRepository titleRepository = new TitleRepository();
            titles = await titleRepository.GetAllAsync(0, 20);
            titleBttn.Text = titles[index].WordsTitle;
            index++;
        }
        private void titleBttn_Click(object sender, EventArgs e)
        {
            IWordRepository wordRepository = new WordRepository();
            var result = wordRepository.GetAllByWordIdAsync(IdentitySingelton.GetInstance().TitleId, 0, 30);
            MessageBox.Show($"{result}");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
