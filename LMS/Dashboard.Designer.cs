namespace LMS
{
    partial class Dashboard
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.displayPanel = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PictureAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dashboardMenuPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.menuBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.libraryPicture = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mediaBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.booksBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.myProfileBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeAppbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.header.SuspendLayout();
            this.dashboardMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.header.Controls.Add(this.closeAppbtn);
            this.PictureAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(870, 30);
            this.header.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // displayPanel
            // 
            this.PictureAnimator.SetDecoration(this.displayPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.displayPanel, BunifuAnimatorNS.DecorationType.None);
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(200, 30);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(670, 678);
            this.displayPanel.TabIndex = 9;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.PanelAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation4;
            // 
            // PictureAnimator
            // 
            this.PictureAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.PictureAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PictureAnimator.DefaultAnimation = animation3;
            // 
            // dashboardMenuPanel
            // 
            this.dashboardMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.dashboardMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardMenuPanel.BackgroundImage")));
            this.dashboardMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardMenuPanel.Controls.Add(this.menuBtn);
            this.dashboardMenuPanel.Controls.Add(this.libraryPicture);
            this.dashboardMenuPanel.Controls.Add(this.dashboardBtn);
            this.dashboardMenuPanel.Controls.Add(this.mediaBtn);
            this.dashboardMenuPanel.Controls.Add(this.booksBtn);
            this.dashboardMenuPanel.Controls.Add(this.userBtn);
            this.dashboardMenuPanel.Controls.Add(this.myProfileBtn);
            this.PictureAnimator.SetDecoration(this.dashboardMenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.dashboardMenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.dashboardMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardMenuPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.dashboardMenuPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.dashboardMenuPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.dashboardMenuPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.dashboardMenuPanel.Location = new System.Drawing.Point(0, 30);
            this.dashboardMenuPanel.Name = "dashboardMenuPanel";
            this.dashboardMenuPanel.Quality = 10;
            this.dashboardMenuPanel.Size = new System.Drawing.Size(200, 678);
            this.dashboardMenuPanel.TabIndex = 0;
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.PictureAnimator.SetDecoration(this.menuBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.menuBtn, BunifuAnimatorNS.DecorationType.None);
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.ImageActive = null;
            this.menuBtn.Location = new System.Drawing.Point(158, 12);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(33, 32);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 3;
            this.menuBtn.TabStop = false;
            this.menuBtn.Zoom = 10;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // libraryPicture
            // 
            this.PanelAnimator.SetDecoration(this.libraryPicture, BunifuAnimatorNS.DecorationType.None);
            this.PictureAnimator.SetDecoration(this.libraryPicture, BunifuAnimatorNS.DecorationType.None);
            this.libraryPicture.Image = ((System.Drawing.Image)(resources.GetObject("libraryPicture.Image")));
            this.libraryPicture.Location = new System.Drawing.Point(3, 12);
            this.libraryPicture.Name = "libraryPicture";
            this.libraryPicture.Size = new System.Drawing.Size(149, 127);
            this.libraryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libraryPicture.TabIndex = 2;
            this.libraryPicture.TabStop = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardBtn.BorderRadius = 0;
            this.dashboardBtn.ButtonText = "Dashboard";
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureAnimator.SetDecoration(this.dashboardBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.dashboardBtn, BunifuAnimatorNS.DecorationType.None);
            this.dashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Iconimage")));
            this.dashboardBtn.Iconimage_right = null;
            this.dashboardBtn.Iconimage_right_Selected = null;
            this.dashboardBtn.Iconimage_Selected = null;
            this.dashboardBtn.IconMarginLeft = 0;
            this.dashboardBtn.IconMarginRight = 0;
            this.dashboardBtn.IconRightVisible = true;
            this.dashboardBtn.IconRightZoom = 0D;
            this.dashboardBtn.IconVisible = true;
            this.dashboardBtn.IconZoom = 40D;
            this.dashboardBtn.IsTab = true;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 341);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.dashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.dashboardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboardBtn.selected = false;
            this.dashboardBtn.Size = new System.Drawing.Size(200, 48);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashboardBtn.Textcolor = System.Drawing.Color.Silver;
            this.dashboardBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // mediaBtn
            // 
            this.mediaBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mediaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.mediaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mediaBtn.BorderRadius = 0;
            this.mediaBtn.ButtonText = "Media";
            this.mediaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureAnimator.SetDecoration(this.mediaBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.mediaBtn, BunifuAnimatorNS.DecorationType.None);
            this.mediaBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mediaBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mediaBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("mediaBtn.Iconimage")));
            this.mediaBtn.Iconimage_right = null;
            this.mediaBtn.Iconimage_right_Selected = null;
            this.mediaBtn.Iconimage_Selected = null;
            this.mediaBtn.IconMarginLeft = 0;
            this.mediaBtn.IconMarginRight = 0;
            this.mediaBtn.IconRightVisible = true;
            this.mediaBtn.IconRightZoom = 0D;
            this.mediaBtn.IconVisible = true;
            this.mediaBtn.IconZoom = 40D;
            this.mediaBtn.IsTab = true;
            this.mediaBtn.Location = new System.Drawing.Point(0, 293);
            this.mediaBtn.Name = "mediaBtn";
            this.mediaBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.mediaBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.mediaBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.mediaBtn.selected = false;
            this.mediaBtn.Size = new System.Drawing.Size(200, 48);
            this.mediaBtn.TabIndex = 4;
            this.mediaBtn.Text = "Media";
            this.mediaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mediaBtn.Textcolor = System.Drawing.Color.Silver;
            this.mediaBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBtn.Click += new System.EventHandler(this.mediaBtn_Click);
            // 
            // booksBtn
            // 
            this.booksBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.booksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.booksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.booksBtn.BorderRadius = 0;
            this.booksBtn.ButtonText = "Books";
            this.booksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureAnimator.SetDecoration(this.booksBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.booksBtn, BunifuAnimatorNS.DecorationType.None);
            this.booksBtn.DisabledColor = System.Drawing.Color.Gray;
            this.booksBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.booksBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("booksBtn.Iconimage")));
            this.booksBtn.Iconimage_right = null;
            this.booksBtn.Iconimage_right_Selected = null;
            this.booksBtn.Iconimage_Selected = null;
            this.booksBtn.IconMarginLeft = 0;
            this.booksBtn.IconMarginRight = 0;
            this.booksBtn.IconRightVisible = true;
            this.booksBtn.IconRightZoom = 0D;
            this.booksBtn.IconVisible = true;
            this.booksBtn.IconZoom = 40D;
            this.booksBtn.IsTab = true;
            this.booksBtn.Location = new System.Drawing.Point(0, 245);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.booksBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.booksBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.booksBtn.selected = false;
            this.booksBtn.Size = new System.Drawing.Size(200, 48);
            this.booksBtn.TabIndex = 4;
            this.booksBtn.Text = "Books";
            this.booksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.booksBtn.Textcolor = System.Drawing.Color.Silver;
            this.booksBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.userBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userBtn.BorderRadius = 0;
            this.userBtn.ButtonText = "Users";
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureAnimator.SetDecoration(this.userBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.userBtn, BunifuAnimatorNS.DecorationType.None);
            this.userBtn.DisabledColor = System.Drawing.Color.Gray;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.userBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("userBtn.Iconimage")));
            this.userBtn.Iconimage_right = null;
            this.userBtn.Iconimage_right_Selected = null;
            this.userBtn.Iconimage_Selected = null;
            this.userBtn.IconMarginLeft = 0;
            this.userBtn.IconMarginRight = 0;
            this.userBtn.IconRightVisible = true;
            this.userBtn.IconRightZoom = 0D;
            this.userBtn.IconVisible = true;
            this.userBtn.IconZoom = 40D;
            this.userBtn.IsTab = true;
            this.userBtn.Location = new System.Drawing.Point(0, 197);
            this.userBtn.Name = "userBtn";
            this.userBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.userBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.userBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.userBtn.selected = false;
            this.userBtn.Size = new System.Drawing.Size(200, 48);
            this.userBtn.TabIndex = 4;
            this.userBtn.Text = "Users";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userBtn.Textcolor = System.Drawing.Color.Silver;
            this.userBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // myProfileBtn
            // 
            this.myProfileBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.myProfileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.myProfileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myProfileBtn.BorderRadius = 0;
            this.myProfileBtn.ButtonText = "          My Profile";
            this.myProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureAnimator.SetDecoration(this.myProfileBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.myProfileBtn, BunifuAnimatorNS.DecorationType.None);
            this.myProfileBtn.DisabledColor = System.Drawing.Color.Gray;
            this.myProfileBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.myProfileBtn.Iconimage = global::LMS.Properties.Resources.profilepicture;
            this.myProfileBtn.Iconimage_right = null;
            this.myProfileBtn.Iconimage_right_Selected = null;
            this.myProfileBtn.Iconimage_Selected = null;
            this.myProfileBtn.IconMarginLeft = 0;
            this.myProfileBtn.IconMarginRight = 0;
            this.myProfileBtn.IconRightVisible = true;
            this.myProfileBtn.IconRightZoom = 0D;
            this.myProfileBtn.IconVisible = true;
            this.myProfileBtn.IconZoom = 40D;
            this.myProfileBtn.IsTab = true;
            this.myProfileBtn.Location = new System.Drawing.Point(0, 149);
            this.myProfileBtn.Name = "myProfileBtn";
            this.myProfileBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.myProfileBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.myProfileBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.myProfileBtn.selected = false;
            this.myProfileBtn.Size = new System.Drawing.Size(200, 48);
            this.myProfileBtn.TabIndex = 4;
            this.myProfileBtn.Text = "          My Profile";
            this.myProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myProfileBtn.Textcolor = System.Drawing.Color.Silver;
            this.myProfileBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileBtn.Click += new System.EventHandler(this.myProfileBtn_Click);
            // 
            // closeAppbtn
            // 
            this.closeAppbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PictureAnimator.SetDecoration(this.closeAppbtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.closeAppbtn, BunifuAnimatorNS.DecorationType.None);
            this.closeAppbtn.Image = ((System.Drawing.Image)(resources.GetObject("closeAppbtn.Image")));
            this.closeAppbtn.ImageActive = null;
            this.closeAppbtn.Location = new System.Drawing.Point(834, 5);
            this.closeAppbtn.Name = "closeAppbtn";
            this.closeAppbtn.Size = new System.Drawing.Size(20, 20);
            this.closeAppbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeAppbtn.TabIndex = 10;
            this.closeAppbtn.TabStop = false;
            this.closeAppbtn.Zoom = 20;
            this.closeAppbtn.Click += new System.EventHandler(this.closeAppbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 708);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.dashboardMenuPanel);
            this.Controls.Add(this.header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PictureAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.header.ResumeLayout(false);
            this.dashboardMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppbtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel dashboardMenuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton myProfileBtn;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuFlatButton dashboardBtn;
        private Bunifu.Framework.UI.BunifuFlatButton mediaBtn;
        private Bunifu.Framework.UI.BunifuFlatButton booksBtn;
        private Bunifu.Framework.UI.BunifuFlatButton userBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton closeAppbtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox libraryPicture;
        private Bunifu.Framework.UI.BunifuImageButton menuBtn;
        private System.Windows.Forms.Panel displayPanel;
        private BunifuAnimatorNS.BunifuTransition PictureAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
    }
}



