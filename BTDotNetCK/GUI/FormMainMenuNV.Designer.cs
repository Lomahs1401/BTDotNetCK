
namespace BTDotNetCK.GUI
{
    partial class FormMainMenuNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenuNV));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLKH = new FontAwesome.Sharp.IconButton();
            this.btnBS = new FontAwesome.Sharp.IconButton();
            this.btnQLS = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.EmployeePicture = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rjStaffUserSettingMenu = new BTDotNetCK.GUI.RJDropDownMenu(this.components);
            this.chỉnhSửaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiChúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
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
            this.rjStaffUserSettingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnQLKH);
            this.panelMenu.Controls.Add(this.btnBS);
            this.panelMenu.Controls.Add(this.btnQLS);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 668);
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
            this.btnQLKH.Location = new System.Drawing.Point(0, 294);
            this.btnQLKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Padding = new System.Windows.Forms.Padding(8, 0, 16, 0);
            this.btnQLKH.Size = new System.Drawing.Size(215, 77);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.BtnQLKH_Click);
            // 
            // btnBS
            // 
            this.btnBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBS.FlatAppearance.BorderSize = 0;
            this.btnBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.ForeColor = System.Drawing.Color.Black;
            this.btnBS.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnBS.IconColor = System.Drawing.Color.Black;
            this.btnBS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBS.IconSize = 32;
            this.btnBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBS.Location = new System.Drawing.Point(0, 217);
            this.btnBS.Margin = new System.Windows.Forms.Padding(2);
            this.btnBS.Name = "btnBS";
            this.btnBS.Padding = new System.Windows.Forms.Padding(8, 0, 16, 0);
            this.btnBS.Size = new System.Drawing.Size(215, 77);
            this.btnBS.TabIndex = 2;
            this.btnBS.Text = "Bán hàng";
            this.btnBS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.BtnBH_Click);
            // 
            // btnQLS
            // 
            this.btnQLS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLS.FlatAppearance.BorderSize = 0;
            this.btnQLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLS.ForeColor = System.Drawing.Color.Black;
            this.btnQLS.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQLS.IconColor = System.Drawing.Color.Black;
            this.btnQLS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLS.IconSize = 32;
            this.btnQLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLS.Location = new System.Drawing.Point(0, 140);
            this.btnQLS.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLS.Name = "btnQLS";
            this.btnQLS.Padding = new System.Windows.Forms.Padding(8, 0, 16, 0);
            this.btnQLS.Size = new System.Drawing.Size(215, 77);
            this.btnQLS.TabIndex = 1;
            this.btnQLS.Text = "Quản lý mặt hàng";
            this.btnQLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLS.UseVisualStyleBackColor = true;
            this.btnQLS.Click += new System.EventHandler(this.BtnQLMH_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::BTDotNetCK.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(-1, -2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(217, 142);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTitleBar.Controls.Add(this.lblStaffName);
            this.panelTitleBar.Controls.Add(this.EmployeePicture);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(217, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(983, 77);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStaffName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaffName.ForeColor = System.Drawing.Color.Black;
            this.lblStaffName.Location = new System.Drawing.Point(800, 28);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(44, 19);
            this.lblStaffName.TabIndex = 14;
            this.lblStaffName.Text = "Staff";
            this.lblStaffName.Click += new System.EventHandler(this.LblEmployeeUsername_Click);
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeePicture.BackColor = System.Drawing.Color.Gainsboro;
            this.EmployeePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EmployeePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeePicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeePicture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmployeePicture.IconColor = System.Drawing.SystemColors.ControlText;
            this.EmployeePicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeePicture.IconSize = 50;
            this.EmployeePicture.Location = new System.Drawing.Point(745, 15);
            this.EmployeePicture.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(50, 50);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePicture.TabIndex = 13;
            this.EmployeePicture.TabStop = false;
            this.EmployeePicture.Click += new System.EventHandler(this.EmployeePicture_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(884, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnMaximize.Location = new System.Drawing.Point(917, 1);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnClose.Location = new System.Drawing.Point(950, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(30, 20);
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseHover += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Black;
            this.lblTitleChildForm.Location = new System.Drawing.Point(67, 28);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 15);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(46, 45);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.Controls.Add(this.iconPictureBox6);
            this.panelDesktop.Controls.Add(this.lblUserName);
            this.panelDesktop.Controls.Add(this.iconPictureBox5);
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Controls.Add(this.iconPictureBox3);
            this.panelDesktop.Controls.Add(this.iconPictureBox4);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.iconPictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(217, 77);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(983, 591);
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
            this.iconPictureBox6.Location = new System.Drawing.Point(431, 542);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.iconPictureBox6.Size = new System.Drawing.Size(52, 50);
            this.iconPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox6.TabIndex = 35;
            this.iconPictureBox6.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(4, 3);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(40, 16);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User:";
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
            this.iconPictureBox5.Location = new System.Drawing.Point(369, 542);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.iconPictureBox5.Size = new System.Drawing.Size(46, 47);
            this.iconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox5.TabIndex = 34;
            this.iconPictureBox5.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(815, 5);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
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
            this.iconPictureBox3.Location = new System.Drawing.Point(305, 542);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.iconPictureBox3.Size = new System.Drawing.Size(46, 47);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox3.TabIndex = 33;
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
            this.iconPictureBox4.Location = new System.Drawing.Point(238, 542);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(46, 47);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox4.TabIndex = 32;
            this.iconPictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(521, 569);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Developed by Group: Nguyễn Khắc Thái, Lý Văn Tánh, Lê Hoàng Long";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 569);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 31;
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
            this.iconPictureBox2.Location = new System.Drawing.Point(954, 568);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(21, 25);
            this.iconPictureBox2.TabIndex = 30;
            this.iconPictureBox2.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // rjStaffUserSettingMenu
            // 
            this.rjStaffUserSettingMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.rjStaffUserSettingMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjStaffUserSettingMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjStaffUserSettingMenu.IsMainMenu = false;
            this.rjStaffUserSettingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaTàiKhoảnToolStripMenuItem,
            this.ghiChúToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.rjStaffUserSettingMenu.MenuItemHeight = 25;
            this.rjStaffUserSettingMenu.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.rjStaffUserSettingMenu.Name = "rjddmAdminSettingMenu";
            this.rjStaffUserSettingMenu.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.rjStaffUserSettingMenu.Size = new System.Drawing.Size(208, 82);
            this.rjStaffUserSettingMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RjddmUserSettingMenu_ItemClicked);
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
            // FormMainMenuNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 668);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainMenuNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainMenuNV_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
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
            this.rjStaffUserSettingMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnQLKH;
        private FontAwesome.Sharp.IconButton btnBS;
        private FontAwesome.Sharp.IconButton btnQLS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox EmployeePicture;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private RJDropDownMenu rjStaffUserSettingMenu;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiChúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblStaffName;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}