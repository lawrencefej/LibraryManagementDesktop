namespace LMS
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menubtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchtxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.menuCloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(966, 640);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menubtn);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 36);
            this.panel1.TabIndex = 1;
            // 
            // menubtn
            // 
            this.menubtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.menubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menubtn.BorderRadius = 0;
            this.menubtn.ButtonText = "Menu";
            this.menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubtn.DisabledColor = System.Drawing.Color.Gray;
            this.menubtn.Iconcolor = System.Drawing.Color.Transparent;
            this.menubtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("menubtn.Iconimage")));
            this.menubtn.Iconimage_right = null;
            this.menubtn.Iconimage_right_Selected = null;
            this.menubtn.Iconimage_Selected = null;
            this.menubtn.IconMarginLeft = 0;
            this.menubtn.IconMarginRight = 0;
            this.menubtn.IconRightVisible = true;
            this.menubtn.IconRightZoom = 0D;
            this.menubtn.IconVisible = true;
            this.menubtn.IconZoom = 90D;
            this.menubtn.IsTab = false;
            this.menubtn.Location = new System.Drawing.Point(382, 3);
            this.menubtn.Name = "menubtn";
            this.menubtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.menubtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.menubtn.OnHoverTextColor = System.Drawing.Color.White;
            this.menubtn.selected = false;
            this.menubtn.Size = new System.Drawing.Size(104, 33);
            this.menubtn.TabIndex = 3;
            this.menubtn.Text = "Menu";
            this.menubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menubtn.Textcolor = System.Drawing.Color.Silver;
            this.menubtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbtn.BorderRadius = 0;
            this.searchbtn.ButtonText = "";
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("searchbtn.Iconimage")));
            this.searchbtn.Iconimage_right = null;
            this.searchbtn.Iconimage_right_Selected = null;
            this.searchbtn.Iconimage_Selected = null;
            this.searchbtn.IconMarginLeft = 0;
            this.searchbtn.IconMarginRight = 0;
            this.searchbtn.IconRightVisible = true;
            this.searchbtn.IconRightZoom = 0D;
            this.searchbtn.IconVisible = true;
            this.searchbtn.IconZoom = 90D;
            this.searchbtn.IsTab = false;
            this.searchbtn.Location = new System.Drawing.Point(615, 6);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.searchbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchbtn.selected = false;
            this.searchbtn.Size = new System.Drawing.Size(31, 29);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Textcolor = System.Drawing.Color.White;
            this.searchbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.Silver;
            this.searchtxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchtxt.BackgroundImage")));
            this.searchtxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchtxt.ForeColor = System.Drawing.Color.Gray;
            this.searchtxt.Icon = ((System.Drawing.Image)(resources.GetObject("searchtxt.Icon")));
            this.searchtxt.Location = new System.Drawing.Point(492, 6);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(121, 28);
            this.searchtxt.TabIndex = 0;
            this.searchtxt.text = "";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            this.inputPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inputPanel.Controls.Add(this.menuCloseBtn);
            this.inputPanel.Controls.Add(this.bunifuFlatButton1);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.isbntxt);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.authortxt);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.yeartxt);
            this.inputPanel.Controls.Add(this.quantitytxt);
            this.inputPanel.Controls.Add(this.label5);
            this.inputPanel.Controls.Add(this.titletxt);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputPanel.Location = new System.Drawing.Point(0, 36);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(300, 640);
            this.inputPanel.TabIndex = 0;
            this.inputPanel.Visible = false;
            // 
            // menuCloseBtn
            // 
            this.menuCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            this.menuCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuCloseBtn.Image")));
            this.menuCloseBtn.ImageActive = null;
            this.menuCloseBtn.Location = new System.Drawing.Point(271, 6);
            this.menuCloseBtn.Name = "menuCloseBtn";
            this.menuCloseBtn.Size = new System.Drawing.Size(26, 26);
            this.menuCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.menuCloseBtn.TabIndex = 4;
            this.menuCloseBtn.TabStop = false;
            this.menuCloseBtn.Zoom = 10;
            this.menuCloseBtn.Click += new System.EventHandler(this.menuCloseBtn_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Add Book";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(164, 193);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(123, 48);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Add Book";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Year:";
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(82, 117);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(205, 20);
            this.isbntxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN:";
            // 
            // authortxt
            // 
            this.authortxt.Location = new System.Drawing.Point(82, 91);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(205, 20);
            this.authortxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author:";
            // 
            // yeartxt
            // 
            this.yeartxt.Location = new System.Drawing.Point(82, 143);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(205, 20);
            this.yeartxt.TabIndex = 4;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(82, 167);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(205, 20);
            this.quantitytxt.TabIndex = 5;
            this.quantitytxt.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity:";
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(82, 65);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(205, 20);
            this.titletxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 676);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBook";
            this.ShowIcon = false;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuCloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox searchtxt;
        private Bunifu.Framework.UI.BunifuFlatButton searchbtn;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton menubtn;
        private Bunifu.Framework.UI.BunifuImageButton menuCloseBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}