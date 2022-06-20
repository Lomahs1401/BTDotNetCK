
namespace BTDotNetCK.GUI
{
    partial class FormMainMenuQTV
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLKH = new FontAwesome.Sharp.IconButton();
            this.btnQLDT = new FontAwesome.Sharp.IconButton();
            this.btnQLBH = new FontAwesome.Sharp.IconButton();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.AdminPicture = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjAdminUserSettingMenu = new BTDotNetCK.GUI.RJDropDownMenu(this.components);
            this.chỉnhSửaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiChúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.rjAdminUserSettingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnQLKH);
            this.panelMenu.Controls.Add(this.btnQLDT);
            this.panelMenu.Controls.Add(this.btnQLBH);
            this.panelMenu.Controls.Add(this.btnQLNV);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 668);
            this.panelMenu.TabIndex = 1;
            // 
            // btnQLKH
            // 
            this.btnQLKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.Black;
            this.btnQLKH.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnQLKH.IconColor = System.Drawing.Color.Black;
            this.btnQLKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKH.IconSize = 32;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(0, 371);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLKH.Size = new System.Drawing.Size(218, 77);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.BtnQLKH_Click);
            // 
            // btnQLDT
            // 
            this.btnQLDT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDT.FlatAppearance.BorderSize = 0;
            this.btnQLDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDT.ForeColor = System.Drawing.Color.Black;
            this.btnQLDT.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnQLDT.IconColor = System.Drawing.Color.Black;
            this.btnQLDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDT.IconSize = 32;
            this.btnQLDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.Location = new System.Drawing.Point(0, 294);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLDT.Size = new System.Drawing.Size(218, 77);
            this.btnQLDT.TabIndex = 3;
            this.btnQLDT.Text = "Quản lý doanh thu";
            this.btnQLDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDT.UseVisualStyleBackColor = true;
            this.btnQLDT.Click += new System.EventHandler(this.BtnQLDT_Click);
            // 
            // btnQLBH
            // 
            this.btnQLBH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLBH.FlatAppearance.BorderSize = 0;
            this.btnQLBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLBH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBH.ForeColor = System.Drawing.Color.Black;
            this.btnQLBH.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQLBH.IconColor = System.Drawing.Color.Black;
            this.btnQLBH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLBH.IconSize = 32;
            this.btnQLBH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLBH.Location = new System.Drawing.Point(0, 217);
            this.btnQLBH.Name = "btnQLBH";
            this.btnQLBH.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLBH.Size = new System.Drawing.Size(218, 77);
            this.btnQLBH.TabIndex = 2;
            this.btnQLBH.Text = "Quản lý bán hàng";
            this.btnQLBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLBH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLBH.UseVisualStyleBackColor = true;
            this.btnQLBH.Click += new System.EventHandler(this.BtnQLBH_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.Black;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnQLNV.IconColor = System.Drawing.Color.Black;
            this.btnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNV.IconSize = 32;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 140);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLNV.Size = new System.Drawing.Size(218, 77);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.BtnQLNV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::BTDotNetCK.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(-4, -2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(222, 142);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitleBar.Controls.Add(this.lblAdmin);
            this.panelTitleBar.Controls.Add(this.AdminPicture);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(980, 74);
            this.panelTitleBar.TabIndex = 2;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.Location = new System.Drawing.Point(804, 33);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(58, 19);
            this.lblAdmin.TabIndex = 22;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.LblAdmin_Click);
            // 
            // AdminPicture
            // 
            this.AdminPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminPicture.BackColor = System.Drawing.Color.Gainsboro;
            this.AdminPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AdminPicture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AdminPicture.IconColor = System.Drawing.SystemColors.ControlText;
            this.AdminPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdminPicture.IconSize = 50;
            this.AdminPicture.Location = new System.Drawing.Point(748, 14);
            this.AdminPicture.Name = "AdminPicture";
            this.AdminPicture.Size = new System.Drawing.Size(50, 50);
            this.AdminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminPicture.TabIndex = 13;
            this.AdminPicture.TabStop = false;
            this.AdminPicture.Click += new System.EventHandler(this.AdminPicture_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(879, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnMinimize.Size = new System.Drawing.Size(30, 20);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(912, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnMaximize.Size = new System.Drawing.Size(30, 20);
            this.btnMaximize.TabIndex = 9;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            this.btnMaximize.MouseEnter += new System.EventHandler(this.BtnMaximize_MouseEnter);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.BtnMaximize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(945, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(30, 20);
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Black;
            this.lblTitleChildForm.Location = new System.Drawing.Point(70, 33);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(54, 19);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 45;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 19);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(46, 45);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Controls.Add(this.iconPictureBox6);
            this.panelDesktop.Controls.Add(this.iconPictureBox5);
            this.panelDesktop.Controls.Add(this.iconPictureBox3);
            this.panelDesktop.Controls.Add(this.iconPictureBox4);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.iconPictureBox2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.Time);
            this.panelDesktop.Controls.Add(this.lblAdminName);
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(980, 594);
            this.panelDesktop.TabIndex = 4;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconPictureBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox6.BackgroundImage = global::BTDotNetCK.Properties.Resources.api;
            this.iconPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox6.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 50;
            this.iconPictureBox6.Location = new System.Drawing.Point(424, 543);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.iconPictureBox6.Size = new System.Drawing.Size(52, 50);
            this.iconPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox6.TabIndex = 28;
            this.iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconPictureBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox5.BackgroundImage = global::BTDotNetCK.Properties.Resources.c_sharp;
            this.iconPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 46;
            this.iconPictureBox5.Location = new System.Drawing.Point(362, 543);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.iconPictureBox5.Size = new System.Drawing.Size(46, 47);
            this.iconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox5.TabIndex = 27;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconPictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox3.BackgroundImage = global::BTDotNetCK.Properties.Resources.sql_file2;
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 46;
            this.iconPictureBox3.Location = new System.Drawing.Point(298, 543);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.iconPictureBox3.Size = new System.Drawing.Size(46, 47);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox3.TabIndex = 26;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconPictureBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox4.BackgroundImage = global::BTDotNetCK.Properties.Resources.web_browser;
            this.iconPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 46;
            this.iconPictureBox4.Location = new System.Drawing.Point(231, 543);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(46, 47);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox4.TabIndex = 25;
            this.iconPictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 570);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bài tập cuối kỳ DotNet";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 21;
            this.iconPictureBox2.Location = new System.Drawing.Point(947, 569);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(21, 25);
            this.iconPictureBox2.TabIndex = 23;
            this.iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(514, 570);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Developed by Group: Nguyễn Khắc Thái, Lý Văn Tánh, Lê Hoàng Long";
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Black;
            this.Time.Location = new System.Drawing.Point(853, 32);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(40, 16);
            this.Time.TabIndex = 21;
            this.Time.Text = "Time";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.Black;
            this.lblAdminName.Location = new System.Drawing.Point(4, 4);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(57, 16);
            this.lblAdminName.TabIndex = 20;
            this.lblAdminName.Text = "Admin: ";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(799, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // rjAdminUserSettingMenu
            // 
            this.rjAdminUserSettingMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.rjAdminUserSettingMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjAdminUserSettingMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjAdminUserSettingMenu.IsMainMenu = false;
            this.rjAdminUserSettingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaTàiKhoảnToolStripMenuItem,
            this.ghiChúToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.rjAdminUserSettingMenu.MenuItemHeight = 25;
            this.rjAdminUserSettingMenu.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.rjAdminUserSettingMenu.Name = "rjddmAdminSettingMenu";
            this.rjAdminUserSettingMenu.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.rjAdminUserSettingMenu.Size = new System.Drawing.Size(208, 82);
            this.rjAdminUserSettingMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RjAdminUserSettingMenu_ItemClicked);
            // 
            // chỉnhSửaTàiKhoảnToolStripMenuItem
            // 
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Image = global::BTDotNetCK.Properties.Resources.icons8_user_settings_30px;
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Name = "chỉnhSửaTàiKhoảnToolStripMenuItem";
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Text = "Chỉnh sửa tài khoản";
            // 
            // ghiChúToolStripMenuItem
            // 
            this.ghiChúToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ghiChúToolStripMenuItem.Image = global::BTDotNetCK.Properties.Resources.icons8_reserve_30px_1;
            this.ghiChúToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ghiChúToolStripMenuItem.Name = "ghiChúToolStripMenuItem";
            this.ghiChúToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.ghiChúToolStripMenuItem.Text = "Ghi chú";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.đăngXuấtToolStripMenuItem.Image = global::BTDotNetCK.Properties.Resources.icons8_Logout_30px;
            this.đăngXuấtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // FormMainMenuQTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 668);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenuQTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenuQTV_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.rjAdminUserSettingMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnQLKH;
        private FontAwesome.Sharp.IconButton btnQLDT;
        private FontAwesome.Sharp.IconButton btnQLBH;
        private FontAwesome.Sharp.IconButton btnQLNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox AdminPicture;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label lblAdmin;
        private RJDropDownMenu rjAdminUserSettingMenu;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiChúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
    }
}