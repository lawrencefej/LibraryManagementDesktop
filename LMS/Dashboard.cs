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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook();
            viewBook.MdiParent = this;
            if (viewBook.Visible )
            {
                viewBook.Close();
                viewBook.ShowDialog();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ViewBook form = ViewBook.GetInstance();
            form.MdiParent = this;
            if (!form.Visible)
            {
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }

        private void closeAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
