using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSLibrary;
using LMSLibrary.Models;
using LMSLibrary.DataAccess;
using System.Data.SqlClient;
using LMSLibrary.Validation;

namespace LMS
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                InputValidation();
                LoginValidation access = new LoginValidation();
                var data = access.InputValidation(emailaddressltxt.Text, Passwordtxt.Text);
                Dashboard dashboard = new Dashboard();
                this.Hide();
                if (access.GetRole(data))
                {
                    dashboard.Show();
                }
                else
                {
                    // Todo add login page for users.
                    MessageBox.Show("you are not an admin");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Method to validate the user input
        /// </summary>
        private void InputValidation()
        {
            if (emailaddressltxt.Text.Length == 0 || Passwordtxt.Text.Length == 0)
            {
                throw new Exception("Please enter a valid email and password");
                //MessageBox.Show("Please enter a valid email and password");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
