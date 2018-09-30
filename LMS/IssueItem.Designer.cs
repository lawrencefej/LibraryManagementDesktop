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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueItem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.memberLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.memPhoneNumberLbl = new System.Windows.Forms.Label();
            this.memEmailLbl = new System.Windows.Forms.Label();
            this.memNameLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.userDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.userSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.itemSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.itemFilterCb = new MetroFramework.Controls.MetroComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cartListBox);
            this.groupBox1.Location = new System.Drawing.Point(1044, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.memEmailLbl);
            this.panel1.Controls.Add(this.memPhoneNumberLbl);
            this.panel1.Controls.Add(this.memNameLbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.memberLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 156);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "MemberID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // memberLbl
            // 
            this.memberLbl.AutoSize = true;
            this.memberLbl.Location = new System.Drawing.Point(130, 12);
            this.memberLbl.Name = "memberLbl";
            this.memberLbl.Size = new System.Drawing.Size(13, 13);
            this.memberLbl.TabIndex = 4;
            this.memberLbl.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "3";
            // 
            // memPhoneNumberLbl
            // 
            this.memPhoneNumberLbl.AutoSize = true;
            this.memPhoneNumberLbl.Location = new System.Drawing.Point(130, 84);
            this.memPhoneNumberLbl.Name = "memPhoneNumberLbl";
            this.memPhoneNumberLbl.Size = new System.Drawing.Size(73, 13);
            this.memPhoneNumberLbl.TabIndex = 4;
            this.memPhoneNumberLbl.Text = "316-871-0406";
            // 
            // memEmailLbl
            // 
            this.memEmailLbl.AutoSize = true;
            this.memEmailLbl.Location = new System.Drawing.Point(130, 59);
            this.memEmailLbl.Name = "memEmailLbl";
            this.memEmailLbl.Size = new System.Drawing.Size(119, 13);
            this.memEmailLbl.TabIndex = 4;
            this.memEmailLbl.Text = "lawrencefej@gmail.com";
            // 
            // memNameLbl
            // 
            this.memNameLbl.AutoSize = true;
            this.memNameLbl.Location = new System.Drawing.Point(130, 36);
            this.memNameLbl.Name = "memNameLbl";
            this.memNameLbl.Size = new System.Drawing.Size(97, 13);
            this.memNameLbl.TabIndex = 4;
            this.memNameLbl.Text = "Lawrence Fejokwu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemFilterCb);
            this.groupBox3.Controls.Add(this.itemSearchTxt);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(12, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1368, 536);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Items";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.itemDataGrid);
            this.panel2.Location = new System.Drawing.Point(285, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 474);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(15, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 511);
            this.panel3.TabIndex = 1;
            // 
            // itemDataGrid
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.itemDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.itemDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemDataGrid.DoubleBuffered = true;
            this.itemDataGrid.EnableHeadersVisualStyles = false;
            this.itemDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.itemDataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.itemDataGrid.Location = new System.Drawing.Point(0, 0);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemDataGrid.Size = new System.Drawing.Size(1077, 474);
            this.itemDataGrid.TabIndex = 0;
            // 
            // userDataGrid
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.userDataGrid.AutoGenerateColumns = false;
            this.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.userDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(16, 32);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(314, 95);
            this.cartListBox.TabIndex = 0;
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
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LMSLibrary.Models.User);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label memEmailLbl;
        private System.Windows.Forms.Label memPhoneNumberLbl;
        private System.Windows.Forms.Label memNameLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label memberLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
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
    }
}