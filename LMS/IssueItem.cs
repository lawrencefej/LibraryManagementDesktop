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
        private string cartTitle;

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
            var data = access.SearchUsers(search);
            userDataGrid.DataSource = data;
            //memberID = user.UserID;
        }

        private void DisplayBooks(string search)
        {
            SqlConnections access = new SqlConnections();
            search = itemSearchTxt.text;
            var data = access.SearchBooks(search);
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
        private void BindItemLabels()
        {
            ItemID = Convert.ToInt32(itemDataGrid.CurrentRow.Cells[0].Value);
            itemidOutputLbl.Text = itemDataGrid.CurrentRow.Cells[0].Value.ToString();
            cartTitle = titleoutputLbl.Text = itemDataGrid.CurrentRow.Cells[1].Value.ToString();
            titleoutputLbl.Text = itemDataGrid.CurrentRow.Cells[1].Value.ToString();
            yearOutputLbl.Text = itemDataGrid.CurrentRow.Cells[2].Value.ToString();
            authorOutputLbl.Text = itemDataGrid.CurrentRow.Cells[3].Value.ToString();

        }

        private void itemFilterCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (itemFilterCb.SelectedIndex)
            {
                case 0:
                    DisplayBooks(itemSearchTxt.text);
                    directorLbl.Text = "Author";
                    break;
                case 1:
                    DisplayMedia(itemSearchTxt.text);
                    directorLbl.Text = "Director";
                    isbnOutputLbl.Text = "N/A";
                    break;
                default:
                    MessageBox.Show("Please select an item");
                    break;
            }
        }

        private void itemDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BindItemLabels();
        }

        private void userSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            DisplayUser(userSearchTxt.text);
        }

        private void itemSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            switch (itemFilterCb.SelectedIndex)
            {
                case 0:
                    DisplayBooks(itemSearchTxt.text);
                    break;
                case 1:
                    DisplayMedia(itemSearchTxt.text);
                    break;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //if (cartListBox.Items.Count < 3)
            //{
            //    cartListBox.Items.Add(ItemID.ToString() + " " + cartTitle);
            //}
            //else
            //{
            //    MessageBox.Show("You can only checkout a maximum of 3 items");
            //}
            if (memberID == 0)
            {
                MessageBox.Show("Please select a user");
            }
            else if (ItemID == 0)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                Issuebook();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            cartListBox.Items.Remove(cartListBox.SelectedItem);
        }

        private void Issuebook()
        {
            UserModel user = new UserModel();
            user.UserID = memberID;
            CheckoutModel checkout = new CheckoutModel();
            checkout.ItemID = ItemID;
            SqlConnections access = new SqlConnections();
            access.Checkout(checkout, user);
        }
    }
}
