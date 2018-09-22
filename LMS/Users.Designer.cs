namespace LMS
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet1 = new LMS.LibraryDBDataSet1();
            this.userTableAdapter = new LMS.LibraryDBDataSet1TableAdapters.UserTableAdapter();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.slideUpBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.inputPanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox3 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox4 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox5 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox6 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox7 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox8 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox9 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox10 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox11 = new Bunifu.Framework.UI.BunifuTextbox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet1)).BeginInit();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.FirstName,
            this.LastName,
            this.EmailAddress,
            this.PhoneNumber,
            this.Address1,
            this.City,
            this.State,
            this.Zipcode,
            this.dateRegisteredDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.userBindingSource;
            this.inputPanelTransition.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(390, 130);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1002, 650);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.AddRowNumber);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.libraryDBDataSet1;
            // 
            // libraryDBDataSet1
            // 
            this.libraryDBDataSet1.DataSetName = "LibraryDBDataSet1";
            this.libraryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inputPanel.Controls.Add(this.bunifuTextbox1);
            this.inputPanel.Controls.Add(this.slideUpBtn);
            this.inputPanelTransition.SetDecoration(this.inputPanel, BunifuAnimatorNS.DecorationType.None);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(1392, 130);
            this.inputPanel.TabIndex = 2;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Red;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(1021, 93);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(133, 31);
            this.bunifuTextbox1.TabIndex = 4;
            this.bunifuTextbox1.text = "";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // slideUpBtn
            // 
            this.slideUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slideUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inputPanelTransition.SetDecoration(this.slideUpBtn, BunifuAnimatorNS.DecorationType.None);
            this.slideUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("slideUpBtn.Image")));
            this.slideUpBtn.ImageActive = null;
            this.slideUpBtn.Location = new System.Drawing.Point(607, 93);
            this.slideUpBtn.Name = "slideUpBtn";
            this.slideUpBtn.Size = new System.Drawing.Size(149, 36);
            this.slideUpBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slideUpBtn.TabIndex = 0;
            this.slideUpBtn.TabStop = false;
            this.slideUpBtn.Zoom = 10;
            this.slideUpBtn.Click += new System.EventHandler(this.slideUpBtn_Click);
            // 
            // inputPanelTransition
            // 
            this.inputPanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.inputPanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.inputPanelTransition.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(121)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.bunifuTextbox11);
            this.panel1.Controls.Add(this.bunifuTextbox10);
            this.panel1.Controls.Add(this.bunifuTextbox9);
            this.panel1.Controls.Add(this.bunifuTextbox8);
            this.panel1.Controls.Add(this.bunifuTextbox7);
            this.panel1.Controls.Add(this.bunifuTextbox6);
            this.panel1.Controls.Add(this.bunifuTextbox5);
            this.panel1.Controls.Add(this.bunifuTextbox4);
            this.panel1.Controls.Add(this.bunifuTextbox3);
            this.panel1.Controls.Add(this.bunifuTextbox2);
            this.inputPanelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 650);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // bunifuTextbox2
            // 
            this.bunifuTextbox2.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.BackgroundImage")));
            this.bunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.Icon")));
            this.bunifuTextbox2.Location = new System.Drawing.Point(191, 47);
            this.bunifuTextbox2.Name = "bunifuTextbox2";
            this.bunifuTextbox2.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox2.TabIndex = 4;
            this.bunifuTextbox2.text = "Bunifu TextBox";
            // 
            // bunifuTextbox3
            // 
            this.bunifuTextbox3.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox3.BackgroundImage")));
            this.bunifuTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox3.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox3.Icon")));
            this.bunifuTextbox3.Location = new System.Drawing.Point(191, 79);
            this.bunifuTextbox3.Name = "bunifuTextbox3";
            this.bunifuTextbox3.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox3.TabIndex = 4;
            this.bunifuTextbox3.text = "Bunifu TextBox";
            // 
            // bunifuTextbox4
            // 
            this.bunifuTextbox4.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox4.BackgroundImage")));
            this.bunifuTextbox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox4.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox4.Icon")));
            this.bunifuTextbox4.Location = new System.Drawing.Point(191, 111);
            this.bunifuTextbox4.Name = "bunifuTextbox4";
            this.bunifuTextbox4.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox4.TabIndex = 4;
            this.bunifuTextbox4.text = "Bunifu TextBox";
            // 
            // bunifuTextbox5
            // 
            this.bunifuTextbox5.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox5.BackgroundImage")));
            this.bunifuTextbox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox5.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox5.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox5.Icon")));
            this.bunifuTextbox5.Location = new System.Drawing.Point(191, 143);
            this.bunifuTextbox5.Name = "bunifuTextbox5";
            this.bunifuTextbox5.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox5.TabIndex = 4;
            this.bunifuTextbox5.text = "Bunifu TextBox";
            // 
            // bunifuTextbox6
            // 
            this.bunifuTextbox6.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox6.BackgroundImage")));
            this.bunifuTextbox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox6.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox6.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox6.Icon")));
            this.bunifuTextbox6.Location = new System.Drawing.Point(191, 175);
            this.bunifuTextbox6.Name = "bunifuTextbox6";
            this.bunifuTextbox6.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox6.TabIndex = 4;
            this.bunifuTextbox6.text = "Bunifu TextBox";
            // 
            // bunifuTextbox7
            // 
            this.bunifuTextbox7.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox7.BackgroundImage")));
            this.bunifuTextbox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox7.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox7.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox7.Icon")));
            this.bunifuTextbox7.Location = new System.Drawing.Point(191, 207);
            this.bunifuTextbox7.Name = "bunifuTextbox7";
            this.bunifuTextbox7.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox7.TabIndex = 4;
            this.bunifuTextbox7.text = "Bunifu TextBox";
            // 
            // bunifuTextbox8
            // 
            this.bunifuTextbox8.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox8.BackgroundImage")));
            this.bunifuTextbox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox8.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox8.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox8.Icon")));
            this.bunifuTextbox8.Location = new System.Drawing.Point(191, 239);
            this.bunifuTextbox8.Name = "bunifuTextbox8";
            this.bunifuTextbox8.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox8.TabIndex = 4;
            this.bunifuTextbox8.text = "Bunifu TextBox";
            // 
            // bunifuTextbox9
            // 
            this.bunifuTextbox9.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox9.BackgroundImage")));
            this.bunifuTextbox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox9.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox9.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox9.Icon")));
            this.bunifuTextbox9.Location = new System.Drawing.Point(191, 271);
            this.bunifuTextbox9.Name = "bunifuTextbox9";
            this.bunifuTextbox9.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox9.TabIndex = 4;
            this.bunifuTextbox9.text = "Bunifu TextBox";
            // 
            // bunifuTextbox10
            // 
            this.bunifuTextbox10.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox10.BackgroundImage")));
            this.bunifuTextbox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox10.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox10.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox10.Icon")));
            this.bunifuTextbox10.Location = new System.Drawing.Point(191, 303);
            this.bunifuTextbox10.Name = "bunifuTextbox10";
            this.bunifuTextbox10.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox10.TabIndex = 4;
            this.bunifuTextbox10.text = "Bunifu TextBox";
            // 
            // bunifuTextbox11
            // 
            this.bunifuTextbox11.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox11.BackgroundImage")));
            this.bunifuTextbox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPanelTransition.SetDecoration(this.bunifuTextbox11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox11.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox11.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox11.Icon")));
            this.bunifuTextbox11.Location = new System.Drawing.Point(191, 335);
            this.bunifuTextbox11.Name = "bunifuTextbox11";
            this.bunifuTextbox11.Size = new System.Drawing.Size(135, 26);
            this.bunifuTextbox11.TabIndex = 4;
            this.bunifuTextbox11.text = "Bunifu TextBox";
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.Name = "No";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Address1
            // 
            this.Address1.DataPropertyName = "Address1";
            this.Address1.HeaderText = "Address1";
            this.Address1.Name = "Address1";
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            // 
            // Zipcode
            // 
            this.Zipcode.DataPropertyName = "Zipcode";
            this.Zipcode.HeaderText = "Zipcode";
            this.Zipcode.Name = "Zipcode";
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 780);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputPanel);
            this.inputPanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.ShowIcon = false;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet1)).EndInit();
            this.inputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slideUpBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private LibraryDBDataSet1 libraryDBDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private LibraryDBDataSet1TableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Panel inputPanel;
        private Bunifu.Framework.UI.BunifuImageButton slideUpBtn;
        private BunifuAnimatorNS.BunifuTransition inputPanelTransition;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox11;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox10;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox9;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox8;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox7;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox6;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox5;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox4;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox3;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
    }
}