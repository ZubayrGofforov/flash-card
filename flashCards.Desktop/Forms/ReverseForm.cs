using flashCards.Desktop.Common;
using flashCards.Desktop.Interfaces.Repositories;
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
    public partial class ReverseForm : Form
    {
        public ReverseForm()
        {
            InitializeComponent();
        }

        private void backBttn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int count = 0;
        private void ReverseForm_Load(object sender, EventArgs e)
        {
            IWordRepository wordRepository = new WordRepository();
            var result = wordRepository.GetAllByWordIdAsync(IdentitySingelton.GetInstance().TitleId, 0, 30);
            
            
        }
    }
}
