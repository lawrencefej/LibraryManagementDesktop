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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CheckoutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.userDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.memEmailLbl = new System.Windows.Forms.Label();
            this.memPhoneNumberLbl = new System.Windows.Forms.Label();
            this.memNameLbl = new System.Windows.Forms.Label();
            this.memberLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.memid = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemFilterCb = new MetroFramework.Controls.MetroComboBox();
            this.itemSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.selectedItemsPanel = new System.Windows.Forms.Panel();
            this.itemTypeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.addToCartBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.amountOutputLbl = new System.Windows.Forms.Label();
            this.authorOutputLbl = new System.Windows.Forms.Label();
            this.yearOutputLbl = new System.Windows.Forms.Label();
            this.titleoutputLbl = new System.Windows.Forms.Label();
            this.itemidOutputLbl = new System.Windows.Forms.Label();
            this.isbnOutputLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.stoclLbl = new System.Windows.Forms.Label();
            this.directorLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.iItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMemberModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMemberModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iItemModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.selectedItemsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMemberModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMemberModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iItemModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeBtn);
            this.groupBox1.Controls.Add(this.CheckoutBtn);
            this.groupBox1.Controls.Add(this.cartListBox);
            this.groupBox1.Location = new System.Drawing.Point(1044, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // removeBtn
            // 
            this.removeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBtn.BorderRadius = 0;
            this.removeBtn.ButtonText = "Remove";
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.removeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.removeBtn.Iconimage = null;
            this.removeBtn.Iconimage_right = null;
            this.removeBtn.Iconimage_right_Selected = null;
            this.removeBtn.Iconimage_Selected = null;
            this.removeBtn.IconMarginLeft = 0;
            this.removeBtn.IconMarginRight = 0;
            this.removeBtn.IconRightVisible = true;
            this.removeBtn.IconRightZoom = 0D;
            this.removeBtn.IconVisible = true;
            this.removeBtn.IconZoom = 90D;
            this.removeBtn.IsTab = false;
            this.removeBtn.Location = new System.Drawing.Point(160, 120);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.removeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.removeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.removeBtn.selected = false;
            this.removeBtn.Size = new System.Drawing.Size(82, 31);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeBtn.Textcolor = System.Drawing.Color.White;
            this.removeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CheckoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CheckoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckoutBtn.BorderRadius = 0;
            this.CheckoutBtn.ButtonText = "Checkout";
            this.CheckoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckoutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CheckoutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CheckoutBtn.Iconimage = null;
            this.CheckoutBtn.Iconimage_right = null;
            this.CheckoutBtn.Iconimage_right_Selected = null;
            this.CheckoutBtn.Iconimage_Selected = null;
            this.CheckoutBtn.IconMarginLeft = 0;
            this.CheckoutBtn.IconMarginRight = 0;
            this.CheckoutBtn.IconRightVisible = true;
            this.CheckoutBtn.IconRightZoom = 0D;
            this.CheckoutBtn.IconVisible = true;
            this.CheckoutBtn.IconZoom = 90D;
            this.CheckoutBtn.IsTab = false;
            this.CheckoutBtn.Location = new System.Drawing.Point(248, 120);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CheckoutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.CheckoutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckoutBtn.selected = false;
            this.CheckoutBtn.Size = new System.Drawing.Size(82, 31);
            this.CheckoutBtn.TabIndex = 4;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckoutBtn.Textcolor = System.Drawing.Color.White;
            this.CheckoutBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
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
            this.groupBox2.Text = "Select Member";
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGrid.AutoGenerateColumns = false;
            this.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.userDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn});
            this.userDataGrid.DataSource = this.memberModelBindingSource;
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
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Width = 42;
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
            this.emailAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailAddressDataGridViewTextBoxColumn.Width = 106;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 111;
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            this.statusNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusNameDataGridViewTextBoxColumn.Width = 98;
            // 
            // memberModelBindingSource
            // 
            this.memberModelBindingSource.DataSource = typeof(LMSLibrary.Models.MemberModel);
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
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(2, 14);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(52, 17);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "ItemID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
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
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(984, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 474);
            this.panel3.TabIndex = 2;
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
            this.selectedItemsPanel.Controls.Add(this.itemTypeLbl);
            this.selectedItemsPanel.Controls.Add(this.label3);
            this.selectedItemsPanel.Controls.Add(this.bunifuDatepicker1);
            this.selectedItemsPanel.Controls.Add(this.returnDateLbl);
            this.selectedItemsPanel.Controls.Add(this.addToCartBtn);
            this.selectedItemsPanel.Controls.Add(this.amountOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.authorOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.yearOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.titleoutputLbl);
            this.selectedItemsPanel.Controls.Add(this.itemidOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.isbnOutputLbl);
            this.selectedItemsPanel.Controls.Add(this.isbnLbl);
            this.selectedItemsPanel.Controls.Add(this.stoclLbl);
            this.selectedItemsPanel.Controls.Add(this.directorLbl);
            this.selectedItemsPanel.Controls.Add(this.yearLbl);
            this.selectedItemsPanel.Controls.Add(this.titleLbl);
            this.selectedItemsPanel.Controls.Add(this.idLbl);
            this.selectedItemsPanel.Location = new System.Drawing.Point(0, 19);
            this.selectedItemsPanel.Name = "selectedItemsPanel";
            this.selectedItemsPanel.Size = new System.Drawing.Size(258, 511);
            this.selectedItemsPanel.TabIndex = 1;
            // 
            // itemTypeLbl
            // 
            this.itemTypeLbl.AutoSize = true;
            this.itemTypeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLbl.Location = new System.Drawing.Point(127, 203);
            this.itemTypeLbl.Name = "itemTypeLbl";
            this.itemTypeLbl.Size = new System.Drawing.Size(20, 17);
            this.itemTypeLbl.TabIndex = 6;
            this.itemTypeLbl.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Type:";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(96, 260);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(137, 17);
            this.bunifuDatepicker1.TabIndex = 1;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 9, 30, 16, 30, 9, 819);
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLbl.Location = new System.Drawing.Point(6, 260);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(84, 17);
            this.returnDateLbl.TabIndex = 5;
            this.returnDateLbl.Text = "Return Date:";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.addToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.addToCartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addToCartBtn.BorderRadius = 0;
            this.addToCartBtn.ButtonText = "Add to Cart";
            this.addToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addToCartBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addToCartBtn.Iconimage = null;
            this.addToCartBtn.Iconimage_right = null;
            this.addToCartBtn.Iconimage_right_Selected = null;
            this.addToCartBtn.Iconimage_Selected = null;
            this.addToCartBtn.IconMarginLeft = 0;
            this.addToCartBtn.IconMarginRight = 0;
            this.addToCartBtn.IconRightVisible = true;
            this.addToCartBtn.IconRightZoom = 0D;
            this.addToCartBtn.IconVisible = true;
            this.addToCartBtn.IconZoom = 90D;
            this.addToCartBtn.IsTab = false;
            this.addToCartBtn.Location = new System.Drawing.Point(126, 353);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.addToCartBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.addToCartBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addToCartBtn.selected = false;
            this.addToCartBtn.Size = new System.Drawing.Size(117, 37);
            this.addToCartBtn.TabIndex = 4;
            this.addToCartBtn.Text = "Add to Cart";
            this.addToCartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addToCartBtn.Textcolor = System.Drawing.Color.White;
            this.addToCartBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // amountOutputLbl
            // 
            this.amountOutputLbl.AutoSize = true;
            this.amountOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOutputLbl.Location = new System.Drawing.Point(126, 170);
            this.amountOutputLbl.Name = "amountOutputLbl";
            this.amountOutputLbl.Size = new System.Drawing.Size(20, 17);
            this.amountOutputLbl.TabIndex = 3;
            this.amountOutputLbl.Text = "10";
            // 
            // authorOutputLbl
            // 
            this.authorOutputLbl.AutoSize = true;
            this.authorOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorOutputLbl.Location = new System.Drawing.Point(65, 76);
            this.authorOutputLbl.Name = "authorOutputLbl";
            this.authorOutputLbl.Size = new System.Drawing.Size(42, 17);
            this.authorOutputLbl.TabIndex = 3;
            this.authorOutputLbl.Text = "name";
            // 
            // yearOutputLbl
            // 
            this.yearOutputLbl.AutoSize = true;
            this.yearOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOutputLbl.Location = new System.Drawing.Point(65, 107);
            this.yearOutputLbl.Name = "yearOutputLbl";
            this.yearOutputLbl.Size = new System.Drawing.Size(34, 17);
            this.yearOutputLbl.TabIndex = 3;
            this.yearOutputLbl.Text = "2018";
            // 
            // titleoutputLbl
            // 
            this.titleoutputLbl.AutoSize = true;
            this.titleoutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleoutputLbl.Location = new System.Drawing.Point(65, 45);
            this.titleoutputLbl.Name = "titleoutputLbl";
            this.titleoutputLbl.Size = new System.Drawing.Size(31, 17);
            this.titleoutputLbl.TabIndex = 3;
            this.titleoutputLbl.Text = "title";
            // 
            // itemidOutputLbl
            // 
            this.itemidOutputLbl.AutoSize = true;
            this.itemidOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemidOutputLbl.Location = new System.Drawing.Point(65, 14);
            this.itemidOutputLbl.Name = "itemidOutputLbl";
            this.itemidOutputLbl.Size = new System.Drawing.Size(13, 17);
            this.itemidOutputLbl.TabIndex = 3;
            this.itemidOutputLbl.Text = "1";
            // 
            // isbnOutputLbl
            // 
            this.isbnOutputLbl.AutoSize = true;
            this.isbnOutputLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnOutputLbl.Location = new System.Drawing.Point(65, 138);
            this.isbnOutputLbl.Name = "isbnOutputLbl";
            this.isbnOutputLbl.Size = new System.Drawing.Size(56, 17);
            this.isbnOutputLbl.TabIndex = 3;
            this.isbnOutputLbl.Text = "number";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLbl.Location = new System.Drawing.Point(2, 138);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(40, 17);
            this.isbnLbl.TabIndex = 3;
            this.isbnLbl.Text = "ISBN:";
            // 
            // stoclLbl
            // 
            this.stoclLbl.AutoSize = true;
            this.stoclLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoclLbl.Location = new System.Drawing.Point(5, 169);
            this.stoclLbl.Name = "stoclLbl";
            this.stoclLbl.Size = new System.Drawing.Size(119, 17);
            this.stoclLbl.TabIndex = 3;
            this.stoclLbl.Text = "Available Amount:";
            // 
            // directorLbl
            // 
            this.directorLbl.AutoSize = true;
            this.directorLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorLbl.Location = new System.Drawing.Point(2, 76);
            this.directorLbl.Name = "directorLbl";
            this.directorLbl.Size = new System.Drawing.Size(55, 17);
            this.directorLbl.TabIndex = 3;
            this.directorLbl.Text = "Author:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(2, 107);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(38, 17);
            this.yearLbl.TabIndex = 3;
            this.yearLbl.Text = "Year:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(2, 45);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(36, 17);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Title:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.itemListBox);
            this.panel2.Location = new System.Drawing.Point(285, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 474);
            this.panel2.TabIndex = 0;
            // 
            // itemListBox
            // 
            this.itemListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(0, 0);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(544, 474);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // iItemModelBindingSource
            // 
            this.iItemModelBindingSource.DataSource = typeof(LMSLibrary.Models.IItemModel);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LMSLibrary.Models.UserModel);
            // 
            // iMemberModelBindingSource
            // 
            this.iMemberModelBindingSource.DataSource = typeof(LMSLibrary.Models.IMemberModel);
            // 
            // iMemberModelBindingSource1
            // 
            this.iMemberModelBindingSource1.DataSource = typeof(LMSLibrary.Models.IMemberModel);
            // 
            // iItemModelBindingSource1
            // 
            this.iItemModelBindingSource1.DataSource = typeof(LMSLibrary.Models.IItemModel);
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
            this.Click += new System.EventHandler(this.addToCartBtn_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.selectedItemsPanel.ResumeLayout(false);
            this.selectedItemsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMemberModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMemberModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iItemModelBindingSource1)).EndInit();
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
        private System.Windows.Forms.ListBox cartListBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid userDataGrid;
        private Bunifu.Framework.UI.BunifuTextbox userSearchTxt;
        private Bunifu.Framework.UI.BunifuTextbox itemSearchTxt;
        private MetroFramework.Controls.MetroComboBox itemFilterCb;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label stoclLbl;
        private System.Windows.Forms.Label directorLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label itemidOutputLbl;
        private System.Windows.Forms.Label memid;
        private System.Windows.Forms.Label amountOutputLbl;
        private System.Windows.Forms.Label authorOutputLbl;
        private System.Windows.Forms.Label yearOutputLbl;
        private System.Windows.Forms.Label titleoutputLbl;
        private System.Windows.Forms.Label isbnOutputLbl;
        private System.Windows.Forms.Label isbnLbl;
        private Bunifu.Framework.UI.BunifuFlatButton addToCartBtn;
        private Bunifu.Framework.UI.BunifuFlatButton removeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton CheckoutBtn;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.BindingSource iItemModelBindingSource;
        private System.Windows.Forms.BindingSource iMemberModelBindingSource;
        private System.Windows.Forms.BindingSource iMemberModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberModelBindingSource;
        private System.Windows.Forms.BindingSource iItemModelBindingSource1;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label itemTypeLbl;
        private System.Windows.Forms.Label label3;
    }
}