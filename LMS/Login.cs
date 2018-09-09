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
using LMSLibrary.DataAccess;
using System.Data.SqlClient;

namespace LMS
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Initiialize instance of SQLConnections
            SqlConnections access = new SqlConnections();
           
            var login = access.Login2(emailaddressltxt.Text, Passwordtxt.Text);
            var message = access.LoginValidation(login);

            MessageBox.Show(message);

            Dashboard db = new Dashboard();
            db.Show();
            //this.Close();
            this.Hide();

        }
    }
}
