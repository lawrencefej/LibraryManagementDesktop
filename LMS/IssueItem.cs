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
    public partial class IssueItem : Form
    {
        public IssueItem()
        {
            InitializeComponent();
        }

        private void IssueItem_Load(object sender, EventArgs e)
        {
            DisplayUser(userSearchTxt.text);
        }

        private void DisplayUser(string search)
        {
            //SqlConnections access = new SqlConnections();
            //search = searchTxt.text;
            //var data = access.SearchMedia(search);
            //dataGrid.DataSource = data;
            //dataGrid.Columns[9].Visible = false;
            //yearTxt.Text = DateTime.Now.Year.ToString();

            SqlConnections access = new SqlConnections();
            search = userSearchTxt.text;
            var data = access.GetUsers();
            userDataGrid.DataSource = data;
            
        }

        
    }
}
