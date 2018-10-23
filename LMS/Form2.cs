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
using LMSLibrary;

namespace LMS
{
    public partial class Form2 : Form
    {
        private IMemberModel _member;

        private List<ICheckoutModel> _checkoutHistory;
        private IDataConnection _dataConnection;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<ICheckoutModel> checkoutHistory, IMemberModel member, IDataConnection dataConnection)
        {
            //_dataConnection = dataConnection;
            //_checkoutHistory = checkoutHistory;
            //_member = member;
            //InitializeComponent();
        }

        private void Intitiateinterfaces()
        {
            
           // var checkouts = _dataConnection.GetMemberCheckoutHistory(_member);
        }

        private void DisplayMemberHistory()
        {
            IMemberModel memberModel = GlobalConfig.CreateMemberModel();
            //_member.
            //var id = _member.MemberID;
            //_member.MemberID = Convert.ToInt32(bunifuTextbox1.text);
            memberModel.MemberID = Convert.ToInt32(bunifuTextbox1.text);
            //var member = memberModel.MemberID;
            //var hello = _dataConnection.GetMemberCheckoutHistory(memberModel.MemberID);
            
            //itemListBox.DataSource = items;
            //itemListBox.DisplayMember = "Items";
            //_dataConnection = gol
            var data = GlobalConfig.Connection.GetMemberCheckoutHistory(memberModel.MemberID);
            listBox1.DataSource = data;
            listBox1.DisplayMember = "FullName";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Intitiateinterfaces();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //IMemberModel memberModel = GlobalConfig.CreateMemberModel();
            //_member.
            //var id = _member.MemberID;
            //memberModel.MemberID = Convert.ToInt32(bunifuTextbox1.text);

            DisplayMemberHistory();
        }
    }
}
