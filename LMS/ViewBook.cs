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
using MetroFramework;

namespace LMS
{
    public partial class ViewBook : Form
    {
        //int pw;
        //bool hidden;
        public ViewBook()
        {
            InitializeComponent();
            //pw = inputPanel.Width;
            //hidden = false;
        }

        private void HidePanel()
        {
            //if (hidden)
            //{
            //    inputPanel.Width = inputPanel.Width + 300;
            //    hidden = false;
            //    this.Refresh();
            //}
            //else
            //{
            //    inputPanel.Width = inputPanel.Width - 300;
            //    hidden = true;
            //    this.Refresh();
            //}
            if (inputPanel.Visible == false)
            {
                inputPanel.Visible = true;
            }
            else
            {
                inputPanel.Visible = false;
            }
        }

        /// <summary>
        /// Used to the instance of the class.
        /// </summary>
        private static ViewBook _instance;

        /// <summary>
        /// Creates an instace of the class if one does not already exist.
        /// </summary>
        /// <returns>Instance of the class</returns>
        public static ViewBook GetInstance()
        {
            if (_instance == null) _instance = new ViewBook();
            return _instance;
        }
        /// <summary>
        /// Method that loads the data into the datagrid once the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ViewBook_Load(object sender, EventArgs e)
        {
            DisplayData(searchtxt.text);
        }
        /// <summary>
        /// Accesses the database, returns a list of books and displays it on the datagrid.
        /// </summary>
        /// <param name="search"></param>
        private void DisplayData(string search)
        {
            SqlConnections access = new SqlConnections();
            search = searchtxt.text;
            var data = access.SearchBooks(search);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
        }
        /// <summary>
        /// Calls the DisplayData method to and passes the search string to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchbtn_Click(object sender, EventArgs e)
        {
            DisplayData(searchtxt.text.Trim());
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            HidePanel();
        }

        //private void AddBook()
        //{
        //    // Todo Add book input validation.    
        //    SqlConnections access = new SqlConnections();
        //    Book book = new Book();

        //    book.Title = titletxt.Text;
        //    book.Author = authortxt.Text;
        //    book.ISBN = isbntxt.Text;
        //    book.Year = yeartxt.Text;
        //    book.Quantity = int.Parse(quantitytxt.Text);
        //    try
        //    {
        //        access.AddBook(book);
        //        MetroFramework.MetroMessageBox.Show(this, "Successfully added");
        //    }
        //    catch (System.Data.SqlClient.SqlException)
        //    {

        //        MessageBox.Show($"This ISBN {book.ISBN.ToString()} has already been added");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // Todo Add book input validation.    
            SqlConnections access = new SqlConnections();
            Book book = new Book();

            book.Title = titletxt.Text;
            book.Author = authortxt.Text;
            book.ISBN = isbntxt.Text;
            book.Year = yeartxt.Text;
            book.Quantity = int.Parse(quantitytxt.Text);
            

            try
            {
                book = access.AddBook(book);
                DisplayData(searchtxt.text.Trim());
                MetroFramework.MetroMessageBox.Show(this, "Successfully added");
                titletxt.Text = authortxt.Text = isbntxt.Text = yeartxt.Text = "";
                book.Quantity = 1;
                this.Refresh();
            }
            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show($"This ISBN {book.ISBN.ToString()} has already been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            HidePanel();
        }
    }
}
