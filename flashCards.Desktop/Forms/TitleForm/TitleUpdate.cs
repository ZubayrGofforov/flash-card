using flashCards.Desktop.Common;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
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
    public partial class TitleUpdate : Form
    {
        public TitleUpdate()
        {
            InitializeComponent();
        }

        private void createBttn_Click(object sender, EventArgs e)
        {
            Title title = new Title()
            {
                WordsTitle = titleTxtBox.Text,
                Description = titleTxtBox.Text,
                UserId = IdentitySingelton.GetInstance().UserId
            };

            ITitleRepository titleRepository = new TitleRepository();
            var result = titleRepository.UpdateAsync(IdentitySingelton.GetInstance().TitleId, title);

            if (result is null) MessageBox.Show("Not updated");
            else MessageBox.Show("Updated");
        }

        private void canelBttn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(); 
            mainForm.Show();
            this.Close();
        }
    }
}
