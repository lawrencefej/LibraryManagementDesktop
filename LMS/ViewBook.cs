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
        public ViewBook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hides the menu panel.
        /// </summary>
        private void HidePanel()
        {
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
            searchtxt.text = "";
        }
        /// <summary>
        /// Menu button that opens or closes the input panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menubtn_Click(object sender, EventArgs e)
        {
            HidePanel();
        }
        /// <summary>
        /// Throws an exception if there are empty strings in all required textboxes.
        /// </summary>
        private void InputValidation()
        {
            if (titletxt.Text.Length == 0 || authortxt.Text.Length == 0 || isbntxt.Text.Length == 0 || yeartxt.Text.Length == 0 || quantitytxt.Text.Length == 0)
            {
                throw new Exception("Please fill out all tabs");
            }
        }

        private void AddBook()
        {
            Book book = new Book();
            SqlConnections access = new SqlConnections();
            book.Title = titletxt.Text;
            book.Author = authortxt.Text;
            book.ISBN = isbntxt.Text;
            book.Year = yeartxt.Text;
            book.Quantity = int.Parse(quantitytxt.Text);
            book = access.AddBook(book);
            DisplayData(searchtxt.text.Trim());
            MetroFramework.MetroMessageBox.Show(this, "Successfully added");
            this.Refresh();
        }
        /// <summary>
        /// Clears the form input.
        /// </summary>
        private void Clear()
        {
            titletxt.Text = authortxt.Text = isbntxt.Text = yeartxt.Text = "";
            quantitytxt.Text = "1";
        }
        /// <summary>
        /// Validates, adds and clears the input form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            try
            {
                // Todo Add book input validation.
                InputValidation();
                AddBook();
                Clear();
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
        /// <summary>
        /// Calls the hidepanel method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCloseBtn_Click(object sender, EventArgs e)
        {
            HidePanel();
        }
    }
}
