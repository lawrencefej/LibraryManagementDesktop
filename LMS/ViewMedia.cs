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
            DisplayData(searchTxt.text);
        }

        private void DisplayData(string search)
        {
            SqlConnections access = new SqlConnections();
            search = searchTxt.text;
            var data = access.SearchMedia(search);
            dataGrid.DataSource = data;
            //dataGrid.Columns[1].Visible = false;
            yearTxt.Text = DateTime.Now.Year.ToString();
        }

        private void searchTxt_OnTextChange(object sender, EventArgs e)
        {
            DisplayData(searchTxt.text);
        }

        private void bunifuCustomDataGrid1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGrid.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
            this.dataGrid.Rows[e.RowIndex].Cells["Edit"].Value = "Edit";
        }

        private void AddMedia()
        {
            // TODO make location databound
            Media media = new Media();
            SqlConnections access = new SqlConnections();
            media.Title = titleTxt.Text;
            media.Director = directorTxt.Text;
            media.Description = descriptionTxt.Text;
            media.Quantity = Convert.ToInt32(quantityComboBox.Text);
            media.Location = locationComboBox.Text;
            media.Year = yearTxt.Text;
            media = access.AddMedia(media);
            DisplayData(searchTxt.text);
            this.Refresh();
        }

        private void Clear()
        {
            titleTxt.Text = directorTxt.Text = descriptionTxt.Text = "";
            locationComboBox.Text = null;
            quantityComboBox.Text = "1";
            yearTxt.Text = DateTime.Now.Year.ToString();
            addBtn.Visible = true;
            editBtn.Visible = false;
            resetBtn.Visible = false;
            deleteBtn.Visible = false;

        }

        private void bunifuCustomDataGrid1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // TODO change this to see who currently has the bmedia and potential return date.
            EditMedia();
            MessageBox.Show("Edit Row");
        }

        private void EditMedia()
        {
            //TODO wire up the edit button
            titleTxt.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            yearTxt.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            directorTxt.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            descriptionTxt.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
            quantityComboBox.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            locationComboBox.Text = dataGrid.CurrentRow.Cells[6].Value.ToString();
            addBtn.Visible = false;
            editBtn.Visible = true;
            deleteBtn.Visible = true;
            resetBtn.Visible = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
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

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //titleTxt.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            //yearTxt.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            //directorTxt.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            //descriptionTxt.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            //quantityComboBox.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            //locationComboBox.Text = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            //addBtn.Visible = false;
            //editBtn.Visible = true;
            //deleteBtn.Visible = true;

            EditMedia();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // TODO wire up the edit button
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // TODO wire up the delete button
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // TODO wire up the reset button
            Clear();
        }
    }
}
