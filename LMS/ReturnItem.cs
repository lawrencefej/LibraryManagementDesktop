using LMSLibrary;
using LMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class ReturnItem : Form
    {
        private int MemberID;
        private IMemberModel member;
        private List<CheckoutModel> CheckoutHistory;

        public ReturnItem()
        {
            InitializeComponent();
        }

        private void WireupSelectedMemberDetail()
        {
            memberIDlbl.Text = member.MemberID.ToString();
            memberNameLbl.Text = member.FullName;
            memberEmailLbl.Text = member.EmailAddress;
            memberPhoneNumberLbl.Text = member.PhoneNumber;
        }

        private void WireupCurrentCheckoutCB(int ID)
        {
            CheckoutHistory = GlobalConfig.Connection.GetMemberCheckoutHistory(ID);
            currentCheckoutCB.DataSource = CheckoutHistory;
            currentCheckoutCB.DisplayMember = "CheckoutID";

            WireupCurrentCheckoutItemsLB();
        }

        private void WireupCurrentCheckoutItemsLB()
        {
            CheckoutModel i = (CheckoutModel)currentCheckoutCB.SelectedItem;
            CurrentCheckoutItemsLB.DataSource = i.Items;
            CurrentCheckoutItemsLB.DisplayMember = "Title";
        }

        private void WireupReturnBasket()
        {

        }

        private void WireupCheckoutHistaryDataGrid()
        {

        }

        private void GetMember(int ID)
        {
            member = GlobalConfig.Connection.GetMembers(ID);
        }


        private void searchMemberBtn_Click(object sender, EventArgs e)
        {
            member = GlobalConfig.CreateMemberModel();
            member.MemberID = Convert.ToInt32(searchMemberTxt.Text);
            MemberID = member.MemberID;
            GetMember(MemberID);
            WireupSelectedMemberDetail();
            WireupCurrentCheckoutCB(member.MemberID);
        }

        private void currentCheckoutCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireupCurrentCheckoutItemsLB();
        }
    }
}
