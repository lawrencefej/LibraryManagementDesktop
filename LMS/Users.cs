using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSLibrary.DataAccess;
using LMSLibrary.Models;

namespace LMS
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void DisplayData(string search)
        {
            SqlConnections access = new SqlConnections();
            search = bunifuTextbox1.text;
            var data = access.SearchUsers(search);
            bunifuCustomDataGrid1.DataSource = data;
            bunifuCustomDataGrid1.Columns[0].Visible = false;
        }

        private void SearchUsers(object sender, EventArgs e)
        {
            // TODO fix the datagrid search
            BindingSource bs = new BindingSource();
            bs.DataSource = bunifuCustomDataGrid1.DataSource;
            bs.Filter = "[1] like '%" + bunifuTextbox1.Text + "%'";
            bunifuCustomDataGrid1.DataSource = bs;
            //var filter = string.Format("(Title like '% {0}%')", searchtxt.text);
            //bs.Filter = filter;
        }

        private void AddRowNumber(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
            //this.dataGridView1.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet1.User' table. You can move, or remove it, as needed.
            //this.userTableAdapter.Fill(this.libraryDBDataSet1.User);
            DisplayData(bunifuTextbox1.text);
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            DisplayData(bunifuTextbox1.text);
        }

        private void slideUpBtn_Click(object sender, EventArgs e)
        {
            if (inputPanel.Height == 39)
            {
                inputPanel.Visible = false;
                inputPanel.Height = 130;
                inputPanelTransition.ShowSync(inputPanel);
                //PictureAnimator.ShowSync(libraryPicture);
            }
            else
            {
                //PictureAnimator.Hide(libraryPicture);
                inputPanel.Visible = false;
                inputPanel.Height = 39;
                inputPanelTransition.ShowSync(inputPanel);
            }
        }
    }
}
