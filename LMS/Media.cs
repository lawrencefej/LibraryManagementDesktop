using LMSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSLibrary.Models;

namespace LMS
{
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        private void Media_Load(object sender, EventArgs e)
        {
            yearDateTimePicker.CustomFormat = "yyyy";
            //dateTimePicker1.ShowUpDown = true;
            DisplayData(searchTxt.text);
        }

        private void DisplayData(string search)
        {
            SqlConnections access = new SqlConnections();
            search = searchTxt.text;
            var data = access.SearchMedia(search);
            bunifuCustomDataGrid1.DataSource = data;
            bunifuCustomDataGrid1.Columns[1].Visible = false;
        }

        private void searchTxt_OnTextChange(object sender, EventArgs e)
        {
            DisplayData(searchTxt.text);
        }

        private void bunifuCustomDataGrid1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        //private void AddBook()
        //{
        //    Media media = new Media();
            

        //    SqlConnections access = new SqlConnections();
        //    Model.media.Title = titleTxt.Text;
        //    media.



        //    book.Title = titletxt.Text;
        //    book.Author = authortxt.Text;
        //    book.ISBN = isbntxt.Text;
        //    book.Year = yeartxt.Text;
        //    book.Quantity = int.Parse(quantitytxt.Text);
        //    book = access.AddBook(book);
        //    DisplayData(searchtxt.text.Trim());
        //    MetroFramework.MetroMessageBox.Show(this, "Successfully added");
        //    this.Refresh();
        //}
    }
}
