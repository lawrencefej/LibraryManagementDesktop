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
    public partial class ViewItems : Form
    {
        IItemModel item = GlobalConfig.itemModel();

        //IItemSQLConnections = 
        public ViewItems()
        {
            InitializeComponent();
        }

        private void DisplayItems(string search)
        {
            search = searchTxt.text;
            var data = GlobalConfig.Connection.GetItems(search);
            itemDataGrid.DataSource = data;
            //dataGrid.Columns[9].Visible = false;
            yearTxt.Text = DateTime.Now.Year.ToString();
            BindComboBox();
        }

        private void BindComboBox()
        {
            var cb1 = GlobalConfig.Connection.GetCategory();
            var cb2 = GlobalConfig.Connection.GetItemType();
            categoryCb.DisplayMember = "CategoryName";
            categoryCb.ValueMember = "CategoryID";
            categoryCb.DataSource = cb1;
            itemTypeCb.DisplayMember = "ItemTypeName";
            itemTypeCb.ValueMember = "ItemTypeID";
            itemTypeCb.DataSource = cb2;
        }

        private void AddItem()
        {
            // TODO make location databound
            item.Title = titleTxt.Text;
            item.Author = authorTxt.Text;
            item.Description = descriptionTxt.Text;
            item.Year = yearTxt.Text;
            item.Location = locationCb.Text;
            item.ISBN = isbnTxt.Text;
            item.Quantity = Convert.ToInt32(quantityCb.Text);
            item.CategoryID = int.Parse(categoryCb.SelectedValue.ToString());
            item.ItemTypeID = int.Parse(categoryCb.SelectedValue.ToString());
            GlobalConfig.Connection.AddItem(item);
            DisplayItems(searchTxt.text);
            this.Refresh();
        }

        private void BindItem()
        {
            //TODO wire up the edit button
            titleTxt.Text = itemDataGrid.CurrentRow.Cells[2].Value.ToString();
            yearTxt.Text = itemDataGrid.CurrentRow.Cells[3].Value.ToString();
            authorTxt.Text = itemDataGrid.CurrentRow.Cells[4].Value.ToString();
            descriptionTxt.Text = itemDataGrid.CurrentRow.Cells[5].Value.ToString();
            locationCb.Text = itemDataGrid.CurrentRow.Cells[6].Value.ToString();
            isbnTxt.Text = itemDataGrid.CurrentRow.Cells[7].Value.ToString();
            quantityCb.Text = itemDataGrid.CurrentRow.Cells[8].Value.ToString();
            itemTypeCb.Text = itemDataGrid.CurrentRow.Cells[10].Value.ToString();
            categoryCb.Text = itemDataGrid.CurrentRow.Cells[11].Value.ToString();

            addBtn.Visible = false;
            editBtn.Visible = true;
            deleteBtn.Visible = true;
            resetBtn.Visible = true;
        }

        private void Clear()
        {
            titleTxt.Text = authorTxt.Text = descriptionTxt.Text = "";
            locationCb.Text = null;
            quantityCb.Text = "1";
            categoryCb.Text = null;
            itemTypeCb.Text = null;
            yearTxt.Text = DateTime.Now.Year.ToString();
            addBtn.Visible = true;
            editBtn.Visible = false;
            resetBtn.Visible = false;
            deleteBtn.Visible = false;
        }

        private void ViewItems_Load(object sender, EventArgs e)
        {
            DisplayItems(searchTxt.text);
        }

        private void itemDataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.itemDataGrid.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
            this.itemDataGrid.Rows[e.RowIndex].Cells["Edit"].Value = "Edit";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string message = categoryCb.Text;
            message += Environment.NewLine;
            message += categoryCb.SelectedValue;
            MessageBox.Show(message);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddItem();
                MessageBox.Show($"{item.Title} has been added");
                Clear();
                DisplayItems(searchTxt.text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void itemDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                BindItem();
            }
        }
    }
}
