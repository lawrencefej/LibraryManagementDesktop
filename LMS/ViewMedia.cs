using LMSLibrary.DataAccess;
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


namespace LMS
{
    public partial class ViewMedia : Form
    {
        public ViewMedia()
        {
            InitializeComponent();
        }

        private void Media_Load(object sender, EventArgs e)
        {
            yearDateTimePicker.CustomFormat = "yyyy";
            //dateTimePicker1.ShowUpDown = true;
            DisplayData(searchTxt.text);
        }

        private void DisplayData(string search)
        {
            SqlConnections access = new SqlConnections();
            search = searchTxt.text;
            var data = access.SearchMedia(search);
            bunifuCustomDataGrid1.DataSource = data;
            bunifuCustomDataGrid1.Columns[1].Visible = false;
        }

        private void searchTxt_OnTextChange(object sender, EventArgs e)
        {
            DisplayData(searchTxt.text);
        }

        private void bunifuCustomDataGrid1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void AddMedia()
        {
            Media media = new Media();
            SqlConnections access = new SqlConnections();
            media.Title = titleTxt.Text;
            media.Director = directionTxt.Text;
            media.Description = descriptionTxt.Text;
            //media.Year = yearDateTimePicker.Text;
            media.Quantity = Convert.ToInt32(quantityComboBox.Text);
            media.Location = locationComboBox.Text;
            media.Year = yearTxt.Text;
            media = access.AddMedia(media);
            DisplayData(searchTxt.text);
            this.Refresh();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Media media = new Media();

            try
            {
                AddMedia();
                MessageBox.Show($"{media.Title} has been added");
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            titleTxt.Text = directionTxt.Text = descriptionTxt.Text = locationlbl.Text = "";
            quantityComboBox.Text = "1";
            //yearDateTimePicker.Text = "2018";
        }

        private void bunifuCustomDataGrid1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditMedia();
            MessageBox.Show("Edit Row");
        }

        private void EditMedia()
        {
            titleTxt.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            yearTxt.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            directionTxt.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            descriptionTxt.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            quantityComboBox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();
            locationComboBox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[7].Value.ToString();
            addBtn.Visible = false;
            editBtn.Visible = true;
        }
    }
}
