namespace LMS
{
    partial class IssueItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.userDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memEmailLbl = new System.Windows.Forms.Label();
            this.memPhoneNumberLbl = new System.Windows.Forms.Label();
            this.memNameLbl = new System.Windows.Forms.Label();
            this.memberLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemFilterCb = new MetroFramework.Controls.MetroComboBox();
            this.itemSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.selectedItemsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.directorLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.stoclLbl = new System.Windows.Forms.Label();
            this.itemidOutputLbl = new System.Windows.Forms.Label();
            this.memid = new System.Windows.Forms.Label();
            this.titleoutputLbl = new System.Windows.Forms.Label();
            this.yearOutputLbl = new System.Windows.Forms.Label();
            this.authorOutputLbl = new System.Windows.Forms.Label();
            this.locationOutputLbl = new System.Windows.Forms.Label();
            this.amountOutputLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.isbnOutputLbl = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.selectedItemsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuFlatButton3);
            this.groupBox1.Controls.Add(this.bunifuFlatButton2);
            this.groupBox1.Controls.Add(this.cartListBox);
            this.groupBox1.Location = new System.Drawing.Point(1044, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(16, 19);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(314, 95);
            this.cartListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userSearchTxt);
            this.groupBox2.Controls.Add(this.userDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Users";
            // 
            // userSearchTxt
            // 
            this.userSearchTxt.BackColor = System.Drawing.Color.Silver;
            this.userSearchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userSearchTxt.BackgroundImage")));
            this.userSearchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userSearchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.userSearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("userSearchTxt.Icon")));
            this.userSearchTxt.Location = new System.Drawing.Point(6, 24);
            this.userSearchTxt.Name = "userSearchTxt";
            this.userSearchTxt.Size = new System.Drawing.Size(108, 25);
            this.userSearchTxt.TabIndex = 1;
            this.userSearchTxt.text = "";
            this.userSearchTxt.OnTextChange += new System.EventHandler(this.userSearchTxt_OnTextChange);
            // 
            // userDataGrid
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.userDataGrid.AutoGenerateColumns = false;
            this.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.userDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.userDataGrid.DataSource = this.userBindingSource;
            this.userDataGrid.DoubleBuffered = true;
            this.userDataGrid.EnableHeadersVisualStyles = false;
            this.userDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.userDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.userDataGrid.Location = new System.Drawing.Point(121, 17);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.ReadOnly = true;
            this.userDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userDataGrid.Size = new System.Drawing.Size(604, 131);
            this.userDataGrid.TabIndex = 0;
            this.userDataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataGrid_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memEmailLbl);
            this.panel1.Controls.Add(this.memPhoneNumberLbl);
            this.panel1.Controls.Add(this.memNameLbl);
            this.panel1.Controls.Add(this.memberLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.memid);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 156);
            this.panel1.TabIndex = 2;
            // 
            // memEmailLbl
            // 
            this.memEmailLbl.AutoSize = true;
            this.memEmailLbl.Location = new System.Drawing.Point(123, 59);
            this.memEmailLbl.Name = "memEmailLbl";
            this.memEmailLbl.Size = new System.Drawing.Size(0, 13);
            this.memEmailLbl.TabIndex = 4;
            // 
            // memPhoneNumberLbl
            // 
            this.memPhoneNumberLbl.AutoSize = true;
            this.memPhoneNumberLbl.Location = new System.Drawing.Point(123, 84);
            this.memPhoneNumberLbl.Name = "memPhoneNumberLbl";
            this.memPhoneNumberLbl.Size = new System.Drawing.Size(0, 13);
            this.memPhoneNumberLbl.TabIndex = 4;
            // 
            // memNameLbl
            // 
            this.memNameLbl.AutoSize = true;
            this.memNameLbl.Location = new System.Drawing.Point(123, 36);
            this.memNameLbl.Name = "memNameLbl";
            this.memNameLbl.Size = new System.Drawing.Size(0, 13);
            this.memNameLbl.TabIndex = 4;
            // 
            // memberLbl
            // 
            this.memberLbl.AutoSize = true;
            this.memberLbl.Location = new System.Drawing.Point(123, 12);
            this.memberLbl.Name = "memberLbl";
            this.memberLbl.Size = new System.Drawing.Size(0, 13);
            this.memberLbl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(5, 59);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(47, 17);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email: ";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(5, 37);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 17);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(9, 14);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(52, 17);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "ItemID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemFilterCb);
            this.groupBox3.Controls.Add(this.itemSearchTxt);
            this.groupBox3.Controls.Add(this.selectedItemsPanel);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(3, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1377, 536);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Items";
            // 
            // itemFilterCb
            // 
            this.itemFilterCb.FormattingEnabled = true;
            this.itemFilterCb.ItemHeight = 23;
            this.itemFilterCb.Items.AddRange(new object[] {
            "Books",
            "Media"});
            this.itemFilterCb.Location = new System.Drawing.Point(462, 23);
            this.itemFilterCb.Name = "itemFilterCb";
            this.itemFilterCb.Size = new System.Drawing.Size(121, 29);
            this.itemFilterCb.TabIndex = 1;
            this.itemFilterCb.UseSelectable = true;
            this.itemFilterCb.SelectedIndexChanged += new System.EventHandler(this.itemFilterCb_SelectedIndexChanged);
            // 
            // itemSearchTxt
            // 
            this.itemSearchTxt.BackColor = System.Drawing.Color.Silver;
            this.itemSearchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemSearchTxt.BackgroundImage")));
            this.itemSearchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemSearchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.itemSearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("itemSearchTxt.Icon")));
            this.itemSearchTxt.Location = new System.Drawing.Point(291, 23);
            this.itemSearchTxt.Name = "itemSearchTxt";
            this.itemSearchTxt.Size = new System.Drawing.Size(147, 27);
            this.itemSearchTxt.TabIndex = 1;
            this.itemSearchTxt.text = "";
            this.itemSearchTxt.OnTextChange += new System.EventHandler(this.itemSearchTxt_OnTextChange);
            // 
            // selectedItemsPanel
            // 
            this.selectedItemsPanel.Controls.Add(this.bunifuDatepicker1);
            this.selectedItemsPanel.Controls.Add(this.returnDateLbl);
            this.selectedItemsPanel.Controls.Add(this.bunifuFlatButton1);
            this.selectedItemsPanel.Controls.Add(this.amountOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.locationOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.authorOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.yearOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.titleoutputLbl);
            this.selectedItemsPanel.Controls.Add(this.itemidOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.isbnOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.isbnLbl);
            this.selectedItemsPanel.Controls.Add(this.stoclLbl);
            this.selectedItemsPanel.Controls.Add(this.locationLbl);
            this.selectedItemsPanel.Controls.Add(this.directorLbl);
            this.selectedItemsPanel.Controls.Add(this.yearLbl);
            this.selectedItemsPanel.Controls.Add(this.titleLbl);
            this.selectedItemsPanel.Controls.Add(this.idLbl);
            this.selectedItemsPanel.Location = new System.Drawing.Point(0, 19);
            this.selectedItemsPanel.Name = "selectedItemsPanel";
            this.selectedItemsPanel.Size = new System.Drawing.Size(258, 511);
            this.selectedItemsPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.itemDataGrid);
            this.panel2.Location = new System.Drawing.Point(285, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 474);
            this.panel2.TabIndex = 0;
            // 
            // itemDataGrid
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.itemDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.itemDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemDataGrid.DoubleBuffered = true;
            this.itemDataGrid.EnableHeadersVisualStyles = false;
            this.itemDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.itemDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.itemDataGrid.Location = new System.Drawing.Point(0, 0);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemDataGrid.Size = new System.Drawing.Size(1077, 474);
            this.itemDataGrid.TabIndex = 0;
            this.itemDataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemDataGrid_RowHeaderMouseDoubleClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LMSLibrary.Models.UserModel);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(9, 31);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(36, 17);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Title:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(9, 48);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(38, 17);
            this.yearLbl.TabIndex = 3;
            this.yearLbl.Text = "Year:";
            // 
            // directorLbl
            // 
            this.directorLbl.AutoSize = true;
            this.directorLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorLbl.Location = new System.Drawing.Point(9, 65);
            this.directorLbl.Name = "directorLbl";
            this.directorLbl.Size = new System.Drawing.Size(60, 17);
            this.directorLbl.TabIndex = 3;
            this.directorLbl.Text = "Director:";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(9, 83);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(62, 17);
            this.locationLbl.TabIndex = 3;
            this.locationLbl.Text = "Location:";
            // 
            // stoclLbl
            // 
            this.stoclLbl.AutoSize = true;
            this.stoclLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoclLbl.Location = new System.Drawing.Point(9, 119);
            this.stoclLbl.Name = "stoclLbl";
            this.stoclLbl.Size = new System.Drawing.Size(119, 17);
            this.stoclLbl.TabIndex = 3;
            this.stoclLbl.Text = "Available Amount:";
            // 
            // itemidOutputLbl
            // 
            this.itemidOutputLbl.AutoSize = true;
            this.itemidOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemidOutputLbl.Location = new System.Drawing.Point(72, 14);
            this.itemidOutputLbl.Name = "itemidOutputLbl";
            this.itemidOutputLbl.Size = new System.Drawing.Size(13, 17);
            this.itemidOutputLbl.TabIndex = 3;
            this.itemidOutputLbl.Text = "1";
            // 
            // memid
            // 
            this.memid.AutoSize = true;
            this.memid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memid.Location = new System.Drawing.Point(6, 15);
            this.memid.Name = "memid";
            this.memid.Size = new System.Drawing.Size(75, 17);
            this.memid.TabIndex = 3;
            this.memid.Text = "MemberID:";
            // 
            // titleoutputLbl
            // 
            this.titleoutputLbl.AutoSize = true;
            this.titleoutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleoutputLbl.Location = new System.Drawing.Point(72, 31);
            this.titleoutputLbl.Name = "titleoutputLbl";
            this.titleoutputLbl.Size = new System.Drawing.Size(31, 17);
            this.titleoutputLbl.TabIndex = 3;
            this.titleoutputLbl.Text = "title";
            // 
            // yearOutputLbl
            // 
            this.yearOutputLbl.AutoSize = true;
            this.yearOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOutputLbl.Location = new System.Drawing.Point(72, 48);
            this.yearOutputLbl.Name = "yearOutputLbl";
            this.yearOutputLbl.Size = new System.Drawing.Size(34, 17);
            this.yearOutputLbl.TabIndex = 3;
            this.yearOutputLbl.Text = "2018";
            // 
            // authorOutputLbl
            // 
            this.authorOutputLbl.AutoSize = true;
            this.authorOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorOutputLbl.Location = new System.Drawing.Point(72, 65);
            this.authorOutputLbl.Name = "authorOutputLbl";
            this.authorOutputLbl.Size = new System.Drawing.Size(42, 17);
            this.authorOutputLbl.TabIndex = 3;
            this.authorOutputLbl.Text = "name";
            // 
            // locationOutputLbl
            // 
            this.locationOutputLbl.AutoSize = true;
            this.locationOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationOutputLbl.Location = new System.Drawing.Point(72, 83);
            this.locationOutputLbl.Name = "locationOutputLbl";
            this.locationOutputLbl.Size = new System.Drawing.Size(25, 17);
            this.locationOutputLbl.TabIndex = 3;
            this.locationOutputLbl.Text = "loc";
            // 
            // amountOutputLbl
            // 
            this.amountOutputLbl.AutoSize = true;
            this.amountOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOutputLbl.Location = new System.Drawing.Point(123, 119);
            this.amountOutputLbl.Name = "amountOutputLbl";
            this.amountOutputLbl.Size = new System.Drawing.Size(20, 17);
            this.amountOutputLbl.TabIndex = 3;
            this.amountOutputLbl.Text = "10";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLbl.Location = new System.Drawing.Point(9, 102);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(40, 17);
            this.isbnLbl.TabIndex = 3;
            this.isbnLbl.Text = "ISBN:";
            // 
            // isbnOutputLbl
            // 
            this.isbnOutputLbl.AutoSize = true;
            this.isbnOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnOutputLbl.Location = new System.Drawing.Point(72, 102);
            this.isbnOutputLbl.Name = "isbnOutputLbl";
            this.isbnOutputLbl.Size = new System.Drawing.Size(56, 17);
            this.isbnOutputLbl.TabIndex = 3;
            this.isbnOutputLbl.Text = "number";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Add to Cart";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(126, 188);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(117, 37);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Add to Cart";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Checkout";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(248, 120);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(82, 31);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "Checkout";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Remove";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(160, 120);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(82, 31);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "Remove";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLbl.Location = new System.Drawing.Point(6, 147);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(84, 17);
            this.returnDateLbl.TabIndex = 5;
            this.returnDateLbl.Text = "Return Date:";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(96, 147);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(137, 17);
            this.bunifuDatepicker1.TabIndex = 1;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 9, 30, 16, 30, 9, 819);
            // 
            // IssueItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 780);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueItem";
            this.Text = "IssueItem";
            this.Load += new System.EventHandler(this.IssueItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.selectedItemsPanel.ResumeLayout(false);
            this.selectedItemsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label memEmailLbl;
        private System.Windows.Forms.Label memPhoneNumberLbl;
        private System.Windows.Forms.Label memNameLbl;
        private System.Windows.Forms.Label memberLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel selectedItemsPanel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid itemDataGrid;
        private System.Windows.Forms.ListBox cartListBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid userDataGrid;
        private Bunifu.Framework.UI.BunifuTextbox userSearchTxt;
        private Bunifu.Framework.UI.BunifuTextbox itemSearchTxt;
        private MetroFramework.Controls.MetroComboBox itemFilterCb;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label stoclLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label directorLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label itemidOutputLbl;
        private System.Windows.Forms.Label memid;
        private System.Windows.Forms.Label amountOutputLbl;
        private System.Windows.Forms.Label locationOutputLbl;
        private System.Windows.Forms.Label authorOutputLbl;
        private System.Windows.Forms.Label yearOutputLbl;
        private System.Windows.Forms.Label titleoutputLbl;
        private System.Windows.Forms.Label isbnOutputLbl;
        private System.Windows.Forms.Label isbnLbl;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label returnDateLbl;
    }
}