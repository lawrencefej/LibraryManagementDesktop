namespace LMS
{
    partial class Media
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityComboBox = new System.Windows.Forms.ComboBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.searchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationCb = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.dataGridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(121)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this.locationComboBox);
            this.panel1.Controls.Add(this.quantityComboBox);
            this.panel1.Controls.Add(this.locationCb);
            this.panel1.Controls.Add(this.yearDateTimePicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descriptionTxt);
            this.panel1.Controls.Add(this.directionTxt);
            this.panel1.Controls.Add(this.titleTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 227);
            this.panel1.TabIndex = 0;
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(203, 19);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(183, 25);
            this.titleTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // directionTxt
            // 
            this.directionTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionTxt.Location = new System.Drawing.Point(203, 53);
            this.directionTxt.Name = "directionTxt";
            this.directionTxt.Size = new System.Drawing.Size(183, 25);
            this.directionTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(555, 53);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(293, 127);
            this.descriptionTxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantity";
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearDateTimePicker.Location = new System.Drawing.Point(555, 27);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(66, 22);
            this.yearDateTimePicker.TabIndex = 2;
            this.yearDateTimePicker.Value = new System.DateTime(2018, 9, 21, 21, 48, 11, 0);
            // 
            // quantityComboBox
            // 
            this.quantityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityComboBox.FormattingEnabled = true;
            this.quantityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantityComboBox.Location = new System.Drawing.Point(203, 89);
            this.quantityComboBox.Name = "quantityComboBox";
            this.quantityComboBox.Size = new System.Drawing.Size(28, 24);
            this.quantityComboBox.TabIndex = 3;
            this.quantityComboBox.Text = "1";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No});
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1392, 553);
            this.bunifuCustomDataGrid1.TabIndex = 4;
            this.bunifuCustomDataGrid1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.bunifuCustomDataGrid1_RowPostPaint);
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Controls.Add(this.bunifuCustomDataGrid1);
            this.dataGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPanel.Location = new System.Drawing.Point(0, 227);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Size = new System.Drawing.Size(1392, 553);
            this.dataGridPanel.TabIndex = 1;
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.Silver;
            this.searchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTxt.BackgroundImage")));
            this.searchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(121)))), ((int)(((byte)(150)))));
            this.searchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("searchTxt.Icon")));
            this.searchTxt.Location = new System.Drawing.Point(1199, 187);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(160, 34);
            this.searchTxt.TabIndex = 5;
            this.searchTxt.text = "";
            this.searchTxt.OnTextChange += new System.EventHandler(this.searchTxt_OnTextChange);
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // locationCb
            // 
            this.locationCb.AutoSize = true;
            this.locationCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationCb.Location = new System.Drawing.Point(115, 123);
            this.locationCb.Name = "locationCb";
            this.locationCb.Size = new System.Drawing.Size(61, 17);
            this.locationCb.TabIndex = 1;
            this.locationCb.Text = "Location";
            // 
            // locationComboBox
            // 
            this.locationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "2A",
            "2B",
            "2C",
            "3A",
            "3B",
            "3C"});
            this.locationComboBox.Location = new System.Drawing.Point(203, 119);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(28, 24);
            this.locationComboBox.TabIndex = 3;
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 780);
            this.Controls.Add(this.dataGridPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Media";
            this.Text = "Media";
            this.Load += new System.EventHandler(this.Media_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.dataGridPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox quantityComboBox;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox directionTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Panel dataGridPanel;
        private Bunifu.Framework.UI.BunifuTextbox searchTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label locationCb;
    }
}