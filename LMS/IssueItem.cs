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
    public partial class IssueItem : Form
    {
        private int memberID;
        private int ItemID;

        public IssueItem()
        {
            InitializeComponent();
        }

        private void IssueItem_Load(object sender, EventArgs e)
        {
            DisplayUser(userSearchTxt.text);
            DisplayBooks(itemSearchTxt.text);
            itemFilterCb.SelectedIndex = 0;
        }

        private void DisplayUser(string search)
        {
            SqlConnections access = new SqlConnections();
            //User user = new User();
            search = userSearchTxt.text;
            var data = access.GetUsers();
            userDataGrid.DataSource = data;
            //memberID = user.UserID;
        }

        private void DisplayBooks(string search)
        {
            SqlConnections access = new SqlConnections();
            search = itemSearchTxt.text;
            var data = access.GetBooks();
            itemDataGrid.DataSource = data;

        }

        private void DisplayMedia(string search)
        {
            SqlConnections access = new SqlConnections();
            search = itemSearchTxt.text;
            var data = access.SearchMedia(search);
            itemDataGrid.DataSource = data;
        }

        private void userDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            memberID = Convert.ToInt32(userDataGrid.CurrentRow.Cells[0].Value);
            memberLbl.Text = userDataGrid.CurrentRow.Cells[0].Value.ToString();
            var firstName = userDataGrid.CurrentRow.Cells[1].Value.ToString();
            var lastName = userDataGrid.CurrentRow.Cells[2].Value.ToString();
            // TODO try to use string concatenation below
            memNameLbl.Text = firstName + " " + lastName;
            memEmailLbl.Text = userDataGrid.CurrentRow.Cells[3].Value.ToString();
            memPhoneNumberLbl.Text = userDataGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void itemFilterCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (itemFilterCb.SelectedIndex)
            {
                case 0:
                    DisplayBooks(itemSearchTxt.text);
                    break;
                case 1:
                    DisplayMedia(itemSearchTxt.text);
                    break;
                default:
                    MessageBox.Show("Please select an item");
                    break;
            }
        }
    }
}
