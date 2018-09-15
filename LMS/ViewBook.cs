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

namespace LMS
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private string txt = "";
        public void ViewBook_Load(object sender, EventArgs e)
        {
            DisplayData(txt);
        }

        public void Search(string search)
        {
            DisplayData(search);
            //dataGridView1.Update();
            //dataGridView1.Refresh();
        }

        private void DisplayData(string search)
        {
            SqlConnections access = new SqlConnections();
            search = searchtxt.text;
            var data = access.SearchBooks(search);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DisplayData(searchtxt.text.Trim());
        }
    }
}
