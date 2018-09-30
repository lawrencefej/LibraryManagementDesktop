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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void closeAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            //Expand
            //1. Expand the panel.
            //2. Shhow the picture


            //Minimize
            //1.Hide the Picture
            //2. Slide the panel

            if (dashboardMenuPanel.Width == 50)
            {
                //dashboardMenuPanel.Visible = false;
                //dashboardMenuPanel.Width = 200;
                //PanelAnimator.ShowSync(dashboardMenuPanel);
                //PictureAnimator.ShowSync(libraryPicture);
                OpenPanel();
            }
            else
            {
                //PictureAnimator.Hide(libraryPicture);
                //dashboardMenuPanel.Visible = false;
                //dashboardMenuPanel.Width = 50;
                //PanelAnimator.ShowSync(dashboardMenuPanel);
                MinimizePanel();
            }

        }

        private void OpenPanel()
        {
            if (dashboardMenuPanel.Width == 50)
            {
                dashboardMenuPanel.Visible = false;
                dashboardMenuPanel.Width = 200;
                PanelAnimator.ShowSync(dashboardMenuPanel);
                PictureAnimator.ShowSync(libraryPicture); 
            }
        }

        private void MinimizePanel()
        {
            if (dashboardMenuPanel.Width == 200)
            {
                PictureAnimator.Hide(libraryPicture);
                dashboardMenuPanel.Visible = false;
                dashboardMenuPanel.Width = 50;
                PanelAnimator.ShowSync(dashboardMenuPanel); 
            }
            //if (dashboardMenuPanel.Width == 50)
            //{
            //    dashboardMenuPanel.Visible = false;
            //    dashboardMenuPanel.Width = 200;
            //    PanelAnimator.ShowSync(dashboardMenuPanel);
            //    PictureAnimator.ShowSync(libraryPicture);
            //}
            //else
            //{
            //    PictureAnimator.Hide(libraryPicture);
            //    dashboardMenuPanel.Visible = false;
            //    dashboardMenuPanel.Width = 50;
            //    PanelAnimator.ShowSync(dashboardMenuPanel);
            //}
        }

        //private void bunifuFlatButton2_Click(object sender, EventArgs e)
        //{
        //    displayPanel.Controls.Clear();
        //    ViewBook form = ViewBook.GetInstance();
        //    form.TopLevel = false;
        //    displayPanel.Controls.Add(form);
        //    form.Show();
        //}

        private void booksBtn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            ViewBook form = ViewBook.GetInstance();
            form.TopLevel = false;
            displayPanel.Controls.Add(form);
            form.Show();
            MinimizePanel();
        }

        private void myProfileBtn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            MinimizePanel(); 
        }

        private void mediaBtn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            ViewMedia media = new ViewMedia();
            media.TopLevel = false;
            displayPanel.Controls.Add(media);
            media.Show();
            MinimizePanel();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            MinimizePanel();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            Users users = new Users();
            users.TopLevel = false;
            displayPanel.Controls.Add(users);
            users.Show();
            MinimizePanel();
        }

        private void issueItemsBtn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            IssueItem issueItem = new IssueItem();
            issueItem.TopLevel = false;
            displayPanel.Controls.Add(issueItem);
            issueItem.Show();
            MinimizePanel();
        }
    }
}
