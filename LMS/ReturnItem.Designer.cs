namespace LMS
{
    partial class ReturnItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentCheckoutCB = new MetroFramework.Controls.MetroComboBox();
            this.CurrentCheckoutItemsLB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.returnBasketLB = new System.Windows.Forms.ListBox();
            this.selectedItemBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.returnItemBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addAllItemsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchMemberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchMemberBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkoutHistoryDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberIDlbl = new System.Windows.Forms.Label();
            this.memberNameLbl = new System.Windows.Forms.Label();
            this.memberEmailLbl = new System.Windows.Forms.Label();
            this.memberPhoneNumberLbl = new System.Windows.Forms.Label();
            this.checkoutIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actReturnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutHistoryDataGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberPhoneNumberLbl);
            this.groupBox1.Controls.Add(this.memberIDlbl);
            this.groupBox1.Controls.Add(this.memberEmailLbl);
            this.groupBox1.Controls.Add(this.memberNameLbl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected member Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CurrentCheckoutItemsLB);
            this.groupBox2.Controls.Add(this.currentCheckoutCB);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Checked Out";
            // 
            // currentCheckoutCB
            // 
            this.currentCheckoutCB.FormattingEnabled = true;
            this.currentCheckoutCB.ItemHeight = 23;
            this.currentCheckoutCB.Location = new System.Drawing.Point(16, 40);
            this.currentCheckoutCB.Name = "currentCheckoutCB";
            this.currentCheckoutCB.Size = new System.Drawing.Size(133, 29);
            this.currentCheckoutCB.TabIndex = 0;
            this.currentCheckoutCB.UseSelectable = true;
            this.currentCheckoutCB.SelectedIndexChanged += new System.EventHandler(this.currentCheckoutCB_SelectedIndexChanged);
            // 
            // CurrentCheckoutItemsLB
            // 
            this.CurrentCheckoutItemsLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentCheckoutItemsLB.FormattingEnabled = true;
            this.CurrentCheckoutItemsLB.ItemHeight = 20;
            this.CurrentCheckoutItemsLB.Location = new System.Drawing.Point(0, 85);
            this.CurrentCheckoutItemsLB.Name = "CurrentCheckoutItemsLB";
            this.CurrentCheckoutItemsLB.Size = new System.Drawing.Size(314, 340);
            this.CurrentCheckoutItemsLB.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.returnBasketLB);
            this.groupBox3.Controls.Add(this.returnItemBtn);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(365, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Return Basket";
            // 
            // returnBasketLB
            // 
            this.returnBasketLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.returnBasketLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.returnBasketLB.FormattingEnabled = true;
            this.returnBasketLB.ItemHeight = 20;
            this.returnBasketLB.Location = new System.Drawing.Point(3, 23);
            this.returnBasketLB.Name = "returnBasketLB";
            this.returnBasketLB.Size = new System.Drawing.Size(372, 300);
            this.returnBasketLB.TabIndex = 0;
            // 
            // selectedItemBtn
            // 
            this.selectedItemBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.selectedItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.selectedItemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedItemBtn.BorderRadius = 0;
            this.selectedItemBtn.ButtonText = "Add Selected Item";
            this.selectedItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectedItemBtn.DisabledColor = System.Drawing.Color.Gray;
            this.selectedItemBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.selectedItemBtn.Iconimage = null;
            this.selectedItemBtn.Iconimage_right = null;
            this.selectedItemBtn.Iconimage_right_Selected = null;
            this.selectedItemBtn.Iconimage_Selected = null;
            this.selectedItemBtn.IconMarginLeft = 0;
            this.selectedItemBtn.IconMarginRight = 0;
            this.selectedItemBtn.IconRightVisible = true;
            this.selectedItemBtn.IconRightZoom = 0D;
            this.selectedItemBtn.IconVisible = true;
            this.selectedItemBtn.IconZoom = 90D;
            this.selectedItemBtn.IsTab = false;
            this.selectedItemBtn.Location = new System.Drawing.Point(13, 654);
            this.selectedItemBtn.Name = "selectedItemBtn";
            this.selectedItemBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.selectedItemBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.selectedItemBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.selectedItemBtn.selected = false;
            this.selectedItemBtn.Size = new System.Drawing.Size(103, 42);
            this.selectedItemBtn.TabIndex = 1;
            this.selectedItemBtn.Text = "Add Selected Item";
            this.selectedItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectedItemBtn.Textcolor = System.Drawing.Color.White;
            this.selectedItemBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // returnItemBtn
            // 
            this.returnItemBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.returnItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.returnItemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnItemBtn.BorderRadius = 0;
            this.returnItemBtn.ButtonText = "Return Items";
            this.returnItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnItemBtn.DisabledColor = System.Drawing.Color.Gray;
            this.returnItemBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.returnItemBtn.Iconimage = null;
            this.returnItemBtn.Iconimage_right = null;
            this.returnItemBtn.Iconimage_right_Selected = null;
            this.returnItemBtn.Iconimage_Selected = null;
            this.returnItemBtn.IconMarginLeft = 0;
            this.returnItemBtn.IconMarginRight = 0;
            this.returnItemBtn.IconRightVisible = true;
            this.returnItemBtn.IconRightZoom = 0D;
            this.returnItemBtn.IconVisible = true;
            this.returnItemBtn.IconZoom = 90D;
            this.returnItemBtn.IsTab = false;
            this.returnItemBtn.Location = new System.Drawing.Point(20, 349);
            this.returnItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnItemBtn.Name = "returnItemBtn";
            this.returnItemBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.returnItemBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.returnItemBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.returnItemBtn.selected = false;
            this.returnItemBtn.Size = new System.Drawing.Size(84, 36);
            this.returnItemBtn.TabIndex = 3;
            this.returnItemBtn.Text = "Return Items";
            this.returnItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnItemBtn.Textcolor = System.Drawing.Color.White;
            this.returnItemBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // addAllItemsBtn
            // 
            this.addAllItemsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.addAllItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.addAllItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAllItemsBtn.BorderRadius = 0;
            this.addAllItemsBtn.ButtonText = "Add All Items";
            this.addAllItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAllItemsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addAllItemsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addAllItemsBtn.Iconimage = null;
            this.addAllItemsBtn.Iconimage_right = null;
            this.addAllItemsBtn.Iconimage_right_Selected = null;
            this.addAllItemsBtn.Iconimage_Selected = null;
            this.addAllItemsBtn.IconMarginLeft = 0;
            this.addAllItemsBtn.IconMarginRight = 0;
            this.addAllItemsBtn.IconRightVisible = true;
            this.addAllItemsBtn.IconRightZoom = 0D;
            this.addAllItemsBtn.IconVisible = true;
            this.addAllItemsBtn.IconZoom = 90D;
            this.addAllItemsBtn.IsTab = false;
            this.addAllItemsBtn.Location = new System.Drawing.Point(232, 654);
            this.addAllItemsBtn.Name = "addAllItemsBtn";
            this.addAllItemsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.addAllItemsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.addAllItemsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addAllItemsBtn.selected = false;
            this.addAllItemsBtn.Size = new System.Drawing.Size(94, 42);
            this.addAllItemsBtn.TabIndex = 4;
            this.addAllItemsBtn.Text = "Add All Items";
            this.addAllItemsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addAllItemsBtn.Textcolor = System.Drawing.Color.White;
            this.addAllItemsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchMemberBtn);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.searchMemberTxt);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(365, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 190);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Members";
            // 
            // searchMemberTxt
            // 
            this.searchMemberTxt.Location = new System.Drawing.Point(20, 86);
            this.searchMemberTxt.Name = "searchMemberTxt";
            this.searchMemberTxt.Size = new System.Drawing.Size(122, 27);
            this.searchMemberTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Member ID";
            // 
            // searchMemberBtn
            // 
            this.searchMemberBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.searchMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.searchMemberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchMemberBtn.BorderRadius = 0;
            this.searchMemberBtn.ButtonText = "Search";
            this.searchMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchMemberBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchMemberBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchMemberBtn.Iconimage = null;
            this.searchMemberBtn.Iconimage_right = null;
            this.searchMemberBtn.Iconimage_right_Selected = null;
            this.searchMemberBtn.Iconimage_Selected = null;
            this.searchMemberBtn.IconMarginLeft = 0;
            this.searchMemberBtn.IconMarginRight = 0;
            this.searchMemberBtn.IconRightVisible = true;
            this.searchMemberBtn.IconRightZoom = 0D;
            this.searchMemberBtn.IconVisible = true;
            this.searchMemberBtn.IconZoom = 90D;
            this.searchMemberBtn.IsTab = false;
            this.searchMemberBtn.Location = new System.Drawing.Point(20, 124);
            this.searchMemberBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.searchMemberBtn.Name = "searchMemberBtn";
            this.searchMemberBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.searchMemberBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.searchMemberBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchMemberBtn.selected = false;
            this.searchMemberBtn.Size = new System.Drawing.Size(84, 30);
            this.searchMemberBtn.TabIndex = 4;
            this.searchMemberBtn.Text = "Search";
            this.searchMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchMemberBtn.Textcolor = System.Drawing.Color.White;
            this.searchMemberBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberBtn.Click += new System.EventHandler(this.searchMemberBtn_Click);
            // 
            // checkoutHistoryDataGrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkoutHistoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.checkoutHistoryDataGrid.AutoGenerateColumns = false;
            this.checkoutHistoryDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.checkoutHistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkoutHistoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkoutHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.checkoutHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkoutHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkoutIDDataGridViewTextBoxColumn,
            this.checkoutDateDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.actReturnDateDataGridViewTextBoxColumn,
            this.itemCountReturnedDataGridViewTextBoxColumn});
            this.checkoutHistoryDataGrid.DataSource = this.checkoutModelBindingSource;
            this.checkoutHistoryDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutHistoryDataGrid.DoubleBuffered = true;
            this.checkoutHistoryDataGrid.EnableHeadersVisualStyles = false;
            this.checkoutHistoryDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.checkoutHistoryDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.checkoutHistoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.checkoutHistoryDataGrid.Name = "checkoutHistoryDataGrid";
            this.checkoutHistoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.checkoutHistoryDataGrid.Size = new System.Drawing.Size(529, 607);
            this.checkoutHistoryDataGrid.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(806, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(535, 633);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Checkout History";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkoutHistoryDataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 607);
            this.panel1.TabIndex = 0;
            // 
            // memberIDlbl
            // 
            this.memberIDlbl.AutoSize = true;
            this.memberIDlbl.Location = new System.Drawing.Point(13, 36);
            this.memberIDlbl.Name = "memberIDlbl";
            this.memberIDlbl.Size = new System.Drawing.Size(50, 20);
            this.memberIDlbl.TabIndex = 8;
            this.memberIDlbl.Text = "label2";
            // 
            // memberNameLbl
            // 
            this.memberNameLbl.AutoSize = true;
            this.memberNameLbl.Location = new System.Drawing.Point(14, 71);
            this.memberNameLbl.Name = "memberNameLbl";
            this.memberNameLbl.Size = new System.Drawing.Size(50, 20);
            this.memberNameLbl.TabIndex = 9;
            this.memberNameLbl.Text = "label3";
            // 
            // memberEmailLbl
            // 
            this.memberEmailLbl.AutoSize = true;
            this.memberEmailLbl.Location = new System.Drawing.Point(15, 106);
            this.memberEmailLbl.Name = "memberEmailLbl";
            this.memberEmailLbl.Size = new System.Drawing.Size(51, 20);
            this.memberEmailLbl.TabIndex = 10;
            this.memberEmailLbl.Text = "label4";
            // 
            // memberPhoneNumberLbl
            // 
            this.memberPhoneNumberLbl.AutoSize = true;
            this.memberPhoneNumberLbl.Location = new System.Drawing.Point(16, 141);
            this.memberPhoneNumberLbl.Name = "memberPhoneNumberLbl";
            this.memberPhoneNumberLbl.Size = new System.Drawing.Size(50, 20);
            this.memberPhoneNumberLbl.TabIndex = 11;
            this.memberPhoneNumberLbl.Text = "label5";
            // 
            // checkoutIDDataGridViewTextBoxColumn
            // 
            this.checkoutIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkoutIDDataGridViewTextBoxColumn.DataPropertyName = "CheckoutID";
            this.checkoutIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.checkoutIDDataGridViewTextBoxColumn.Name = "checkoutIDDataGridViewTextBoxColumn";
            this.checkoutIDDataGridViewTextBoxColumn.Width = 47;
            // 
            // checkoutDateDataGridViewTextBoxColumn
            // 
            this.checkoutDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkoutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckoutDate";
            this.checkoutDateDataGridViewTextBoxColumn.HeaderText = "Checkout Date";
            this.checkoutDateDataGridViewTextBoxColumn.Name = "checkoutDateDataGridViewTextBoxColumn";
            this.checkoutDateDataGridViewTextBoxColumn.Width = 132;
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            this.itemCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemCountDataGridViewTextBoxColumn.DataPropertyName = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.HeaderText = "Borrowed";
            this.itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            this.itemCountDataGridViewTextBoxColumn.Width = 99;
            // 
            // actReturnDateDataGridViewTextBoxColumn
            // 
            this.actReturnDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.actReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ActReturnDate";
            this.actReturnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.actReturnDateDataGridViewTextBoxColumn.Name = "actReturnDateDataGridViewTextBoxColumn";
            this.actReturnDateDataGridViewTextBoxColumn.Width = 114;
            // 
            // itemCountReturnedDataGridViewTextBoxColumn
            // 
            this.itemCountReturnedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemCountReturnedDataGridViewTextBoxColumn.DataPropertyName = "ItemCountReturned";
            this.itemCountReturnedDataGridViewTextBoxColumn.HeaderText = "Returned";
            this.itemCountReturnedDataGridViewTextBoxColumn.Name = "itemCountReturnedDataGridViewTextBoxColumn";
            this.itemCountReturnedDataGridViewTextBoxColumn.Width = 95;
            // 
            // checkoutModelBindingSource
            // 
            this.checkoutModelBindingSource.DataSource = typeof(LMSLibrary.Models.CheckoutModel);
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(LMSLibrary.Models.UserModel);
            // 
            // ReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 741);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.addAllItemsBtn);
            this.Controls.Add(this.selectedItemBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnItem";
            this.Text = "Return Items";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutHistoryDataGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkoutModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox CurrentCheckoutItemsLB;
        private MetroFramework.Controls.MetroComboBox currentCheckoutCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox returnBasketLB;
        private Bunifu.Framework.UI.BunifuFlatButton selectedItemBtn;
        private Bunifu.Framework.UI.BunifuFlatButton returnItemBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addAllItemsBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuFlatButton searchMemberBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchMemberTxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid checkoutHistoryDataGrid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource checkoutModelBindingSource;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actReturnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountReturnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label memberPhoneNumberLbl;
        private System.Windows.Forms.Label memberIDlbl;
        private System.Windows.Forms.Label memberEmailLbl;
        private System.Windows.Forms.Label memberNameLbl;
    }
}