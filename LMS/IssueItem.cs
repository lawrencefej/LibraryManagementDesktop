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
            SqlConnections access = new SqlConnections();
            User user = new User();
            search = userSearchTxt.text;
            var data = access.GetUsers();
            userDataGrid.DataSource = data;
            memberID = user.UserID;
            
            
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
    }
}
