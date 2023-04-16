using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
using PagedList;
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
    public partial class GetAllTitlesForm : Form
    {
        int pageNumber = 1;
        IPagedList<Title> titles;
        public GetAllTitlesForm()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<Title>> GetAllTitleAsync(int pageNumber = 1, int pageSize = 5)
        {
            ITitleRepository titleRepository = new TitleRepository();
            var result = await titleRepository.GetAllAsync();
            return result.OrderBy(x => x.Id).ToPagedList(pageNumber, pageSize);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenerateDynamicTitleControl()
        {
            flowLayoutPanel1.Controls.Clear();

            TitleControl[] myTitleControls = new TitleControl[5];
            string[] title = new string[5] { "Essential", "Regular", "Irregular", "Adjective", "Adverb" };

            for (int i = 0; i < myTitleControls.Length; i++)
            {
                myTitleControls[i] = new TitleControl();
                myTitleControls[i].Title = title[i];

                flowLayoutPanel1.Controls.Add(myTitleControls[i]);

                myTitleControls[i].Click += new System.EventHandler(this.guna2GradientButton2_Click);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            //titleBttnGetAdd.Text = obj.Title;
            //showpanel();
        }

        //private void showpanel()
        //{
        //    guna2Panel1.Visible = true;
        //}

        //private void hidepanel()
        //{
        //    guna2Panel1.Visible = false;
        //}

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            //titleBttnGetAdd.Text = 
        }

        private async void GetAllTitlesForm_Load(object sender, EventArgs e)
        {
            titles = await GetAllTitleAsync();
            nextBttn.Enabled = titles.HasNextPage;
            backBttn.Enabled = titles.HasPreviousPage;
            dataGridViewTitles.DataSource = titles.ToList();
            resultLabel.Text = String.Format("Page{0}/{1}", pageNumber, titles.PageCount);
        }

        private async void nextBttn_Click(object sender, EventArgs e)
        {
            titles = await GetAllTitleAsync(++pageNumber);
            nextBttn.Enabled = titles.HasNextPage;
            backBttn.Enabled = titles.HasPreviousPage;
            dataGridViewTitles.DataSource = titles.ToList();
            resultLabel.Text = String.Format("Page{0}/{1}", pageNumber, titles.PageCount);
        }

        private async void backBttn_Click(object sender, EventArgs e)
        {
            titles = await GetAllTitleAsync(--pageNumber);
            backBttn.Enabled = titles.HasPreviousPage;
            nextBttn.Enabled = titles.HasNextPage;
            dataGridViewTitles.DataSource = titles.ToList();
            resultLabel.Text = String.Format("Page{0}/{1}", pageNumber, titles.PageCount);
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchBttn_Click(object sender, EventArgs e)
        {
            
        }

        private void idTitleTxtBox_TextChanged(object sender, EventArgs e)
        {
            //ITitleRepository titleRepository = new TitleRepository();
            //foreach (var user in collection)
            //{

            //}
            //dgvEmployee.Rows.Clear();
            //foreach (var user in await employeeRepository.GetAllAsync(0, 20))
            //{
            //    if (user.FullName.ToLower().Contains(txtSearch.Text.ToLower()))
            //    {
            //        dgvEmployee.Rows.Add(user.Id, user.FullName, user.age, user.role, user.salary, user.accountant_id);
            //    }
            //}
        }
    }
}
