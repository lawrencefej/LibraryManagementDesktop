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
using LMSLibrary;

namespace LMS
{
    public partial class IssueItem : Form
    {
        private List<ItemModel> items = GlobalConfig.Connection.GetItem();
        private List<MemberModel> members = GlobalConfig.Connection.GetMembers();
        private List<ItemModel> cartItems = new List<ItemModel>();
        private bool memberSelected = false;
        //private int ID;
        //ItemModel itemModel = new ItemModel();

        IMemberModel member = GlobalConfig.Member();

        public IssueItem()
        {
            InitializeComponent();

            WireupMembers();

            WireupItemListBox();

            WireupCart();
        }

        private void WireupItemListBox()
        {
            itemListBox.DataSource = items;
            itemListBox.DisplayMember = "Items";
        }

        private void WireupCart()
        {
            cartListBox.DataSource = null;

            cartListBox.DataSource = cartItems;
            cartListBox.DisplayMember = "Cart";
        }

        private void WireupMembers()
        {
            userDataGrid.DataSource = members;
        }

        private void IssueItem_Load(object sender, EventArgs e)
        {
            ReturnDateTimePicker.MinDate = DateTime.Now;
            ReturnDateTimePicker.MaxDate = DateTime.Now.AddDays(60);
            ReturnDateTimePicker.Value = DateTime.Now.AddDays(14);
        }

        private void BindMember()
        {
            //MemberModel i = (MemberModel)userDataGrid.CurrentRow.Cells[0].
            //members. .MemberID = Convert.ToInt32(userDataGrid.CurrentRow.Cells[0].Value);
            //memberLbl.Text = userDataGrid.CurrentRow.Cells[0].Value.ToString();
            //var firstName = userDataGrid.CurrentRow.Cells[1].Value.ToString();
            //var lastName = userDataGrid.CurrentRow.Cells[2].Value.ToString();
            ////member.FullName =  firstName + " " + lastName;
            //// TODO try to use string concatenation below
            ////memNameLbl.Text = firstName + " " + lastName;
            //memberLbl.Text = member.FullName;
            //memEmailLbl.Text = userDataGrid.CurrentRow.Cells[3].Value.ToString();
            //memPhoneNumberLbl.Text = userDataGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void AddToCart()
        {
            // Fix =1 duplicate error
            ItemModel i = (ItemModel)itemListBox.SelectedItem;
            titleoutputLbl.Text = i.Title;
                if (cartListBox.Items.Contains(itemListBox.SelectedItem))
                {
                    MessageBox.Show($" {i.Title} has already been added to the cart");
                }
                else
                {
                    cartItems.Add(i);
                    WireupCart();
                } 
        }

        private void CheckoutItems()
        {
            CheckoutModel c = new CheckoutModel();
            c.ExpReturnDate = ReturnDateTimePicker.Value.ToString();
            c.Items = cartItems;
            var date = DateTime.Now;
            c.CheckoutDate = DateTime.Now.ToString();
            member.MemberID = member.MemberID;
            //date.AddDays(Convert.ToDouble( ReturnDatePicker.Value));
            //c.ExpReturnDate = date.ToString();
            GlobalConfig.Connection.IssueItem(c, member);
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void userDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            member.MemberID = Convert.ToInt32(userDataGrid.CurrentRow.Cells[0].Value);
            memberLbl.Text = userDataGrid.CurrentRow.Cells[0].Value.ToString();
            var firstName = userDataGrid.CurrentRow.Cells[1].Value.ToString();
            var lastName = userDataGrid.CurrentRow.Cells[2].Value.ToString();
            //member.FullName =  firstName + " " + lastName;
            // TODO try to use string concatenation below
            //memNameLbl.Text = firstName + " " + lastName;
            memberLbl.Text = member.FullName;
            memEmailLbl.Text = userDataGrid.CurrentRow.Cells[3].Value.ToString();
            memPhoneNumberLbl.Text = userDataGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void itemFilterCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (itemFilterCb.SelectedIndex)
            {
                case 0:
                    
                    WireupItemListBox();
                    directorLbl.Text = "Author";
                    break;
                case 1:
                    //var items = items.Where(x => x.ItemTypeID == 1).ToList();
                    itemListBox.DataSource = items.Where(x => x.ItemTypeID == 1).ToList();
                    //WireupItemListBox();
                    //DisplayBooks(itemSearchTxt.text);
                    directorLbl.Text = "Author";
                    break;
                case 2:
                    itemListBox.DataSource = items.Where(x => x.ItemTypeID == 2).ToList();
                    //items = items.Where(x => x.ItemTypeID == 2).ToList();
                    //WireupItemListBox();
                    //DisplayMedia(itemSearchTxt.text);
                    directorLbl.Text = "Director";
                    isbnOutputLbl.Text = "N/A";
                    break;
                default:
                    MessageBox.Show("Please select an item");
                    break;
            }
        }

        //private void itemDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    BindItemLabels();
        //}

        private void userSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            //DisplayMember(userSearchTxt.text);
        }

        private void itemSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            itemListBox.DataSource = items.Where(x => x.Title.ToLower().Contains(itemSearchTxt.text)).ToList();
        }

        private void RemoveSelectedItem()
        {
            ItemModel i = (ItemModel)cartListBox.SelectedItem;

            if (i != null)
            {
                cartItems.Remove(i);
                WireupCart();
            }
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemModel i = (ItemModel)itemListBox.SelectedItem;
            titleoutputLbl.Text = i.Title;
            authorOutputLbl.Text = i.Author;
            yearOutputLbl.Text = i.Year;
            amountOutputLbl.Text = i.Stock.ToString();
            itemidOutputLbl.Text = i.ItemID.ToString();
            isbnOutputLbl.Text = i.ISBN;
            itemTypeOutputLbl.Text = i.ItemTypeName;
            // TODO fix the item time label
        }

        private bool CheckoutValidation()
        {
            bool validate = true;
            if (member.MemberID == 0)
            {
                validate = false;
            }

            if (cartItems.Count == 0)
            {
                validate = false;
            }
            return validate;
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            if (!CheckoutValidation())
            {
                MessageBox.Show("Please select a member & at least one item");
            }
            else
            {
                try
                {
                    CheckoutItems();
                    MessageBox.Show($"All {cartListBox.Items.Count} items have been checked out successfully");
                    cartItems.Clear();
                    WireupCart();
                    //cartListBox.Items.Clear();
                    //cartListBox.Refresh();
                    member.MemberID = 0;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            RemoveSelectedItem();
        }

        private void memberSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            userDataGrid.DataSource = members.Where(x => x.EmailAddress.ToLower().Contains(memberSearchTxt.text)).ToList();
        }
    }
}
