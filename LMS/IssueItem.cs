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
        private List<ItemModel> cartItems = new List<ItemModel>();
        private int ID;

        

        //IItemModel items = GlobalConfig.Connection.GetItems();
        ItemModel itemModel = new ItemModel();

        IMemberModel member = GlobalConfig.Member();
        // private List<IItemModel> items = GlobalConfig.Connection.GetItems(hello);
        //private List<ItemModel> CartItems = new List<ItemModel>();
        

        //private List<IItemModel> CartItems = new List<IItemModel>();
        //private int memberID;
        //private int ItemID;
        //private string cartTitle;

        public IssueItem()
        {
            InitializeComponent();

            //CreateSampleData();

            WireupBoxes();
        }

        

        private void IssueItem_Load(object sender, EventArgs e)
        {
            items = GlobalConfig.Connection.GetItems(itemSearchTxt.text);
            DisplayMember(userSearchTxt.text);
            //DisplayItems(itemSearchTxt.text);
            //itemFilterCb.SelectedIndex = 0;
        }

        private void WireupBoxes()
        {
            itemListBox.DataSource = items;
            itemListBox.DisplayMember = "Items";

            cartListBox.DataSource = null;

            cartListBox.DataSource = cartItems;
            cartListBox.DisplayMember = "Cart";
        }

        //private void DisplayItems(string search)
        //{
        //    search = itemSearchTxt.text;
        //    var data = GlobalConfig.Connection.GetItems(search);
        //    itemListBox.DataSource = data;
        //    itemListBox.DisplayMember = "FullName";
        //}

        private void DisplayMember(string search)
        {
            search = userSearchTxt.text;
            var data = GlobalConfig.Connection.GetMembers(search);
            userDataGrid.DataSource = data;
        }

        private void AddToCart()
        {
            
            ItemModel i = (ItemModel)itemListBox.SelectedItem;
            titleoutputLbl.Text = i.Title;
            if (cartListBox.Items.Contains(itemListBox.SelectedItem))
            {
                MessageBox.Show("Duplicare");
            }
            else
            {
                cartItems.Add(i);
            }

            WireupBoxes();
            cartListBox.Refresh();
        }

        

        private void CreateSampleData()
        {
            //CartItems.Add(new ItemModel { Title = "TestTiltle", Year = "2018"});
            //CartItems.Add(new ItemModel { Title = "TestTiltle2", Year = "2019" });
            //itemModel.Title = "Crackin the coding interview";
            //itemModel.Year = "2019";
            //CartItems.Add(itemModel);
        }

        //private void WireUpCart()
        //{
            
        //    //cartListBox.DataSource = null;
        //    cartListBox.DataSource = cartItems;
        //    cartListBox.DisplayMember = "FullName";
        //    //cartListBox.Refresh();
        //}

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            
            AddToCart();

        }

        //private void DisplayBooks(string search)
        //{
        //    SqlConnections access = new SqlConnections();
        //    search = itemSearchTxt.text;
        //    var data = access.SearchBooks(search);
        //    itemDataGrid.DataSource = data;
        //}

        //private void DisplayMedia(string search)
        //{
        //    SqlConnections access = new SqlConnections();
        //    search = itemSearchTxt.text;
        //    var data = access.SearchMedia(search);
        //    itemDataGrid.DataSource = data;
        //}

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
        private void BindItemLabels()
        {

            //ItemID = Convert.ToInt32(itemDataGrid.CurrentRow.Cells[0].Value);
            //itemModel.ItemID = Convert.ToInt32(itemDataGrid.CurrentRow.Cells[0].Value);
            //itemidOutputLbl.Text = itemDataGrid.CurrentRow.Cells[0].Value.ToString();
            //itemModel.Title = itemDataGrid.CurrentRow.Cells[1].Value.ToString();
            //cartTitle = titleoutputLbl.Text = itemDataGrid.CurrentRow.Cells[1].Value.ToString();
            //titleoutputLbl.Text = itemDataGrid.CurrentRow.Cells[1].Value.ToString();
            //authorOutputLbl.Text = itemDataGrid.CurrentRow.Cells[2].Value.ToString();
            //yearOutputLbl.Text = itemDataGrid.CurrentRow.Cells[3].Value.ToString();
            //itemModel.Year = itemDataGrid.CurrentRow.Cells[3].Value.ToString();
            //isbnOutputLbl.Text = itemDataGrid.CurrentRow.Cells[4].Value.ToString();
            //amountOutputLbl.Text = itemDataGrid.CurrentRow.Cells[9].Value.ToString();

            //ItemModel p = new ItemModel();

            //CartItems.Add(p);
        }

        private void itemFilterCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (itemFilterCb.SelectedIndex)
            //{
            //    case 0:
            //        DisplayBooks(itemSearchTxt.text);
            //        directorLbl.Text = "Author";
            //        break;
            //    case 1:
            //        DisplayMedia(itemSearchTxt.text);
            //        directorLbl.Text = "Director";
            //        isbnOutputLbl.Text = "N/A";
            //        break;
            //    default:
            //        MessageBox.Show("Please select an item");
            //        break;
            //}
        }

        private void itemDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BindItemLabels();
        }

        private void userSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            DisplayMember(userSearchTxt.text);
        }

        private void itemSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            //switch (itemFilterCb.SelectedIndex)
            //{
            //    case 0:
            //        DisplayBooks(itemSearchTxt.text);
            //        break;
            //    case 1:
            //        DisplayMedia(itemSearchTxt.text);
            //        break;
            //}
        }

        

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ItemModel i = (ItemModel)itemListBox.SelectedItem;
            
            cartItems.Remove(i);
            WireupBoxes();
            //cartItems.Items.Remove(cartListBox.SelectedItem);
        }

        private void Issuebook()
        {
            //UserModel user = new UserModel();
            //user.UserID = memberID;
            //CheckoutModel checkout = new CheckoutModel();
            ////checkout.ItemID = ItemID;
            //SqlConnections access = new SqlConnections();
            //access.Checkout(checkout, user);
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
            itemTypeLbl.Text = i.ItemTypeName;
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            //ItemModel i = (ItemModel)itemListBox.SelectedItem;
            CheckoutModel c = new CheckoutModel();


            //c.itemModel.ItemID = i.ItemID;


            c.Items = cartItems;
            c.CheckoutDate = DateTime.Now.ToString();
            member.MemberID = member.MemberID;

            GlobalConfig.Connection.IssueItem(c, member);
        }
    }
}
