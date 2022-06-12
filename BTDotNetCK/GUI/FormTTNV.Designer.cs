
namespace BTDotNetCK.GUI
{
    partial class FormTTNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTTNV));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tbIDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.tbGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEndDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStartDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbEmailNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSDTNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCMNDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBD = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Chocolate;
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(833, 41);
            this.panelTitleBar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.user_info;
            this.pictureBox1.Location = new System.Drawing.Point(173, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContainer.Controls.Add(this.tbIDNV);
            this.panelContainer.Controls.Add(this.lblIDNV);
            this.panelContainer.Controls.Add(this.tbGender);
            this.panelContainer.Controls.Add(this.tbEndDate);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.tbStartDate);
            this.panelContainer.Controls.Add(this.lblStartDate);
            this.panelContainer.Controls.Add(this.btnOK);
            this.panelContainer.Controls.Add(this.avatar);
            this.panelContainer.Controls.Add(this.tbEmailNV);
            this.panelContainer.Controls.Add(this.tbSDTNV);
            this.panelContainer.Controls.Add(this.tbAddressNV);
            this.panelContainer.Controls.Add(this.tbCMNDNV);
            this.panelContainer.Controls.Add(this.tbBD);
            this.panelContainer.Controls.Add(this.tbNameNV);
            this.panelContainer.Controls.Add(this.lblCMND);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.lblSDT);
            this.panelContainer.Controls.Add(this.lblAddress);
            this.panelContainer.Controls.Add(this.lblGender);
            this.panelContainer.Controls.Add(this.lblBD);
            this.panelContainer.Controls.Add(this.lblNameNV);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(833, 748);
            this.panelContainer.TabIndex = 5;
            // 
            // tbIDNV
            // 
            this.tbIDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.BorderRadius = 6;
            this.tbIDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDNV.DefaultText = "";
            this.tbIDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbIDNV.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbIDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbIDNV.Enabled = false;
            this.tbIDNV.FillColor = System.Drawing.Color.Tan;
            this.tbIDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIDNV.ForeColor = System.Drawing.Color.Black;
            this.tbIDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDNV.Location = new System.Drawing.Point(399, 40);
            this.tbIDNV.Name = "tbIDNV";
            this.tbIDNV.PasswordChar = '\0';
            this.tbIDNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbIDNV.PlaceholderText = "Mã nhân viên";
            this.tbIDNV.SelectedText = "";
            this.tbIDNV.Size = new System.Drawing.Size(409, 30);
            this.tbIDNV.TabIndex = 60;
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNV.ForeColor = System.Drawing.Color.Black;
            this.lblIDNV.Location = new System.Drawing.Point(286, 44);
            this.lblIDNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(103, 18);
            this.lblIDNV.TabIndex = 61;
            this.lblIDNV.Text = "Mã nhân viên";
            // 
            // tbGender
            // 
            this.tbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbGender.BorderRadius = 6;
            this.tbGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGender.DefaultText = "";
            this.tbGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbGender.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbGender.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbGender.Enabled = false;
            this.tbGender.FillColor = System.Drawing.Color.Tan;
            this.tbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGender.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbGender.ForeColor = System.Drawing.Color.Black;
            this.tbGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGender.Location = new System.Drawing.Point(399, 400);
            this.tbGender.Name = "tbGender";
            this.tbGender.PasswordChar = '\0';
            this.tbGender.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbGender.PlaceholderText = "Giới tính";
            this.tbGender.SelectedText = "";
            this.tbGender.Size = new System.Drawing.Size(409, 30);
            this.tbGender.TabIndex = 59;
            // 
            // tbEndDate
            // 
            this.tbEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEndDate.BorderRadius = 6;
            this.tbEndDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEndDate.DefaultText = "Ngày nghỉ việc";
            this.tbEndDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEndDate.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbEndDate.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbEndDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEndDate.Enabled = false;
            this.tbEndDate.FillColor = System.Drawing.Color.Tan;
            this.tbEndDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEndDate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbEndDate.ForeColor = System.Drawing.Color.Black;
            this.tbEndDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEndDate.Location = new System.Drawing.Point(399, 340);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.PasswordChar = '\0';
            this.tbEndDate.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEndDate.PlaceholderText = "";
            this.tbEndDate.SelectedText = "";
            this.tbEndDate.Size = new System.Drawing.Size(409, 30);
            this.tbEndDate.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(286, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Ngày nghỉ việc";
            // 
            // tbStartDate
            // 
            this.tbStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.BorderRadius = 6;
            this.tbStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStartDate.DefaultText = "";
            this.tbStartDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbStartDate.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbStartDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbStartDate.Enabled = false;
            this.tbStartDate.FillColor = System.Drawing.Color.Tan;
            this.tbStartDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbStartDate.ForeColor = System.Drawing.Color.Black;
            this.tbStartDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Location = new System.Drawing.Point(399, 280);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.PasswordChar = '\0';
            this.tbStartDate.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbStartDate.PlaceholderText = "Ngày vào làm";
            this.tbStartDate.SelectedText = "";
            this.tbStartDate.Size = new System.Drawing.Size(409, 30);
            this.tbStartDate.TabIndex = 58;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(288, 287);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(101, 18);
            this.lblStartDate.TabIndex = 57;
            this.lblStartDate.Text = "Ngày vào làm";
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 15;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.SeaGreen;
            this.btnOK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(346, 659);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 36);
            this.btnOK.TabIndex = 55;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.ErrorImage = null;
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(11, 39);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(242, 240);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 51;
            this.avatar.TabStop = false;
            // 
            // tbEmailNV
            // 
            this.tbEmailNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.BorderRadius = 6;
            this.tbEmailNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmailNV.DefaultText = "";
            this.tbEmailNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbEmailNV.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbEmailNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEmailNV.Enabled = false;
            this.tbEmailNV.FillColor = System.Drawing.Color.Tan;
            this.tbEmailNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbEmailNV.ForeColor = System.Drawing.Color.Black;
            this.tbEmailNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Location = new System.Drawing.Point(399, 160);
            this.tbEmailNV.Name = "tbEmailNV";
            this.tbEmailNV.PasswordChar = '\0';
            this.tbEmailNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEmailNV.PlaceholderText = "Email";
            this.tbEmailNV.SelectedText = "";
            this.tbEmailNV.Size = new System.Drawing.Size(409, 30);
            this.tbEmailNV.TabIndex = 2;
            // 
            // tbSDTNV
            // 
            this.tbSDTNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.BorderRadius = 6;
            this.tbSDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSDTNV.DefaultText = "";
            this.tbSDTNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbSDTNV.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbSDTNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSDTNV.Enabled = false;
            this.tbSDTNV.FillColor = System.Drawing.Color.Tan;
            this.tbSDTNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSDTNV.ForeColor = System.Drawing.Color.Black;
            this.tbSDTNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Location = new System.Drawing.Point(399, 460);
            this.tbSDTNV.Name = "tbSDTNV";
            this.tbSDTNV.PasswordChar = '\0';
            this.tbSDTNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSDTNV.PlaceholderText = "Số điện thoại";
            this.tbSDTNV.SelectedText = "";
            this.tbSDTNV.Size = new System.Drawing.Size(409, 30);
            this.tbSDTNV.TabIndex = 5;
            // 
            // tbAddressNV
            // 
            this.tbAddressNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.BorderRadius = 6;
            this.tbAddressNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddressNV.DefaultText = "";
            this.tbAddressNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbAddressNV.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbAddressNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbAddressNV.Enabled = false;
            this.tbAddressNV.FillColor = System.Drawing.Color.Tan;
            this.tbAddressNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddressNV.ForeColor = System.Drawing.Color.Black;
            this.tbAddressNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Location = new System.Drawing.Point(399, 580);
            this.tbAddressNV.Name = "tbAddressNV";
            this.tbAddressNV.PasswordChar = '\0';
            this.tbAddressNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbAddressNV.PlaceholderText = "Địa chỉ";
            this.tbAddressNV.SelectedText = "";
            this.tbAddressNV.Size = new System.Drawing.Size(409, 30);
            this.tbAddressNV.TabIndex = 7;
            // 
            // tbCMNDNV
            // 
            this.tbCMNDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.BorderRadius = 6;
            this.tbCMNDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMNDNV.DefaultText = "";
            this.tbCMNDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbCMNDNV.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbCMNDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCMNDNV.Enabled = false;
            this.tbCMNDNV.FillColor = System.Drawing.Color.Tan;
            this.tbCMNDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCMNDNV.ForeColor = System.Drawing.Color.Black;
            this.tbCMNDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Location = new System.Drawing.Point(399, 520);
            this.tbCMNDNV.Name = "tbCMNDNV";
            this.tbCMNDNV.PasswordChar = '\0';
            this.tbCMNDNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCMNDNV.PlaceholderText = "CMND";
            this.tbCMNDNV.SelectedText = "";
            this.tbCMNDNV.Size = new System.Drawing.Size(409, 30);
            this.tbCMNDNV.TabIndex = 6;
            // 
            // tbBD
            // 
            this.tbBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.BorderRadius = 6;
            this.tbBD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBD.DefaultText = "";
            this.tbBD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbBD.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbBD.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBD.Enabled = false;
            this.tbBD.FillColor = System.Drawing.Color.Tan;
            this.tbBD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbBD.ForeColor = System.Drawing.Color.Black;
            this.tbBD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Location = new System.Drawing.Point(399, 220);
            this.tbBD.Name = "tbBD";
            this.tbBD.PasswordChar = '\0';
            this.tbBD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBD.PlaceholderText = "Ngày sinh";
            this.tbBD.SelectedText = "";
            this.tbBD.Size = new System.Drawing.Size(409, 30);
            this.tbBD.TabIndex = 3;
            // 
            // tbNameNV
            // 
            this.tbNameNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.BorderRadius = 6;
            this.tbNameNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameNV.DefaultText = "";
            this.tbNameNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbNameNV.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbNameNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameNV.Enabled = false;
            this.tbNameNV.FillColor = System.Drawing.Color.Tan;
            this.tbNameNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameNV.ForeColor = System.Drawing.Color.Black;
            this.tbNameNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Location = new System.Drawing.Point(399, 100);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.PasswordChar = '\0';
            this.tbNameNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameNV.PlaceholderText = "Họ và tên";
            this.tbNameNV.SelectedText = "";
            this.tbNameNV.Size = new System.Drawing.Size(409, 30);
            this.tbNameNV.TabIndex = 1;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.Black;
            this.lblCMND.Location = new System.Drawing.Point(288, 523);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(54, 18);
            this.lblCMND.TabIndex = 5;
            this.lblCMND.Text = "CMND";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(286, 164);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSDT.Location = new System.Drawing.Point(286, 463);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(80, 18);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(286, 586);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 18);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(286, 406);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 18);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.ForeColor = System.Drawing.Color.Black;
            this.lblBD.Location = new System.Drawing.Point(289, 225);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(77, 18);
            this.lblBD.TabIndex = 2;
            this.lblBD.Text = "Ngày sinh";
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = true;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.ForeColor = System.Drawing.Color.Black;
            this.lblNameNV.Location = new System.Drawing.Point(286, 104);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(76, 18);
            this.lblNameNV.TabIndex = 1;
            this.lblNameNV.Text = "Họ và tên";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FormTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 789);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTTNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTTNV";
            this.Load += new System.EventHandler(this.FormTTNV_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2PictureBox avatar;
        private Guna.UI2.WinForms.Guna2TextBox tbEmailNV;
        private Guna.UI2.WinForms.Guna2TextBox tbSDTNV;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressNV;
        private Guna.UI2.WinForms.Guna2TextBox tbCMNDNV;
        private Guna.UI2.WinForms.Guna2TextBox tbBD;
        private Guna.UI2.WinForms.Guna2TextBox tbNameNV;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblNameNV;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2TextBox tbStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private Guna.UI2.WinForms.Guna2TextBox tbGender;
        private Guna.UI2.WinForms.Guna2TextBox tbIDNV;
        private System.Windows.Forms.Label lblIDNV;
        private Guna.UI2.WinForms.Guna2TextBox tbEndDate;
        private System.Windows.Forms.Label label2;
    }
}