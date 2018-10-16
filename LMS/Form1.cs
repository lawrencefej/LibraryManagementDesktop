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

namespace LMS
{
    public partial class Form1 : Form
    {
        private List<ItemModel> itemModels = new List<ItemModel>();
        //private string search;
        //private List<ItemModel> itemModels = GlobalConfig.Connection.GetItems( search);
        //private List<IItemModel> itemModels = new List<IItemModel>();

        private List<ItemModel> items = new List<ItemModel>();
        public Form1()
        {
            InitializeComponent();
            WireupListBox();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemModels = GlobalConfig.Connection.GetItems(bunifuTextbox1.text);
            WireupListBox();
            
        }

        //private List<ItemModel> itemModels = new List<ItemModel>();

        

        private void WireupListBox()
        {
            //itemModels = GlobalConfig.Connection.GetItems(bunifuTextbox1.text);
            //var test = itemModels.Where(p => p.Title == bunifuTextbox1.text);
            comboBox1.DataSource = itemModels;
            comboBox1.DisplayMember = "FullName";

            listBox1.DataSource = null;

            listBox1.DataSource = items;
            listBox1.DisplayMember = "FullName";

            listBox2.DataSource = itemModels;
            listBox2.DisplayMember = "FullName";

            //checkedListBox1.dat = items;
            //listBox1.DisplayMember = "FullName";

        }

        
        private void DisplayItems()
        {
            //listBox1 = null;
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "FullName";

            //listBox1.DataSource = itemModels;
            //itemDataGrid.DataSource = data;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ItemModel i = (ItemModel)listBox2.SelectedItem;
            //ItemModel i = (ItemModel)dataGridView1.SelectedRows;

            if (listBox1.Items.Contains(listBox2.SelectedItem))
            {
                MessageBox.Show("Duplicare");
            }
            else
            {
                items.Add(i);
            }

            //itemModels.Remove(i);
            //items.Add(i);
            WireupListBox();
            listBox1.Refresh();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            itemModels = GlobalConfig.Connection.GetItems(bunifuTextbox1.text);
            WireupListBox();
        }
    }
}
