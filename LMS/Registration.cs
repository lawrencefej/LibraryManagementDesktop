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
using LMSLibrary.DataAccess;
using LMSLibrary.Models;
using LMSLibrary.Validation;

namespace LMS
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            SqlConnections access = new SqlConnections();
            User p = new User();

            p.FirstName = firstNametxt.Text;
            p.LastName = lastNametxt.Text;
            p.EmailAddress = emailAddresstxt.Text;
            p.Password = passwordtxt.Text;
            p.PhoneNumber = phoneNumbertxt.Text;
            p.Address1 = address1txt.Text;
            p.Address2 = address2txt.Text;
            p.City = citytxt.Text;
            p.State = statetxt.Text;
            p.Zipcode = zipcodetxt.Text;

            p = access.UserRegistration(p);

        }

        private bool InputValidation()
        {
            if (firstNametxt.Text.Length == 0)
            {
                return false;
            }

            if (lastNametxt.Text.Length == 0)
            {
                return false;
            }

            if (emailAddresstxt.Text.Length == 0)
            {
                return false;
            }

            if (passwordtxt.Text.Length == 0)
            {
                return false;
            }

            if (address1txt.Text.Length == 0)
            {
                return false;
            }

            if (citytxt.Text.Length == 0)
            {
                return false;
            }

            if (statetxt.Text.Length == 0)
            {
                return false;
            }

            if (zipcodetxt.Text.Length == 0 || zipcodetxt.Text.Length < 5)
            {
                return false;
            }

            return true;

        }
    }
}
