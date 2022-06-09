
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
            this.tbStartDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tbIDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmailNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSDTNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCMNDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBD = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.rjbtnOK = new BTDotNetCK.GUI.RJButton();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.panelTitleBar.Size = new System.Drawing.Size(812, 41);
            this.panelTitleBar.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.user_info;
            this.pictureBox1.Location = new System.Drawing.Point(173, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
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
            this.panelContainer.Controls.Add(this.tbStartDate);
            this.panelContainer.Controls.Add(this.lblStartDate);
            this.panelContainer.Controls.Add(this.tbIDNV);
            this.panelContainer.Controls.Add(this.lblIDNV);
            this.panelContainer.Controls.Add(this.avatar);
            this.panelContainer.Controls.Add(this.tbGender);
            this.panelContainer.Controls.Add(this.tbEmailNV);
            this.panelContainer.Controls.Add(this.tbSDTNV);
            this.panelContainer.Controls.Add(this.tbAddressNV);
            this.panelContainer.Controls.Add(this.tbCMNDNV);
            this.panelContainer.Controls.Add(this.tbBD);
            this.panelContainer.Controls.Add(this.tbNameNV);
            this.panelContainer.Controls.Add(this.rjbtnOK);
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
            this.panelContainer.Size = new System.Drawing.Size(812, 733);
            this.panelContainer.TabIndex = 3;
            // 
            // tbStartDate
            // 
            this.tbStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.BorderRadius = 6;
            this.tbStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStartDate.DefaultText = "";
            this.tbStartDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.Enabled = false;
            this.tbStartDate.FillColor = System.Drawing.Color.Tan;
            this.tbStartDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbStartDate.ForeColor = System.Drawing.Color.Black;
            this.tbStartDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Location = new System.Drawing.Point(395, 310);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.PasswordChar = '\0';
            this.tbStartDate.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbStartDate.PlaceholderText = "Ngày bắt đầu";
            this.tbStartDate.SelectedText = "";
            this.tbStartDate.Size = new System.Drawing.Size(409, 30);
            this.tbStartDate.TabIndex = 56;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(286, 316);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 18);
            this.lblStartDate.TabIndex = 55;
            this.lblStartDate.Text = "Ngày bắt đầu";
            // 
            // tbIDNV
            // 
            this.tbIDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.BorderRadius = 6;
            this.tbIDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDNV.DefaultText = "";
            this.tbIDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbIDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbIDNV.Enabled = false;
            this.tbIDNV.FillColor = System.Drawing.Color.Tan;
            this.tbIDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIDNV.ForeColor = System.Drawing.Color.Black;
            this.tbIDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDNV.Location = new System.Drawing.Point(395, 50);
            this.tbIDNV.Name = "tbIDNV";
            this.tbIDNV.PasswordChar = '\0';
            this.tbIDNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbIDNV.PlaceholderText = "Mã nhân viên";
            this.tbIDNV.SelectedText = "";
            this.tbIDNV.Size = new System.Drawing.Size(409, 30);
            this.tbIDNV.TabIndex = 54;
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNV.ForeColor = System.Drawing.Color.Black;
            this.lblIDNV.Location = new System.Drawing.Point(286, 55);
            this.lblIDNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(103, 18);
            this.lblIDNV.TabIndex = 53;
            this.lblIDNV.Text = "Mã nhân viên";
            // 
            // avatar
            // 
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(11, 50);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(242, 240);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 52;
            this.avatar.TabStop = false;
            // 
            // tbGender
            // 
            this.tbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbGender.BorderRadius = 6;
            this.tbGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGender.DefaultText = "";
            this.tbGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbGender.Enabled = false;
            this.tbGender.FillColor = System.Drawing.Color.Tan;
            this.tbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGender.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbGender.ForeColor = System.Drawing.Color.Black;
            this.tbGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGender.Location = new System.Drawing.Point(395, 375);
            this.tbGender.Name = "tbGender";
            this.tbGender.PasswordChar = '\0';
            this.tbGender.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbGender.PlaceholderText = "Giới tính";
            this.tbGender.SelectedText = "";
            this.tbGender.Size = new System.Drawing.Size(409, 30);
            this.tbGender.TabIndex = 47;
            // 
            // tbEmailNV
            // 
            this.tbEmailNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.BorderRadius = 6;
            this.tbEmailNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmailNV.DefaultText = "";
            this.tbEmailNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.Enabled = false;
            this.tbEmailNV.FillColor = System.Drawing.Color.Tan;
            this.tbEmailNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbEmailNV.ForeColor = System.Drawing.Color.Black;
            this.tbEmailNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Location = new System.Drawing.Point(395, 176);
            this.tbEmailNV.Name = "tbEmailNV";
            this.tbEmailNV.PasswordChar = '\0';
            this.tbEmailNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEmailNV.PlaceholderText = "Email";
            this.tbEmailNV.SelectedText = "";
            this.tbEmailNV.Size = new System.Drawing.Size(409, 30);
            this.tbEmailNV.TabIndex = 21;
            // 
            // tbSDTNV
            // 
            this.tbSDTNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.BorderRadius = 6;
            this.tbSDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSDTNV.DefaultText = "";
            this.tbSDTNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.Enabled = false;
            this.tbSDTNV.FillColor = System.Drawing.Color.Tan;
            this.tbSDTNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSDTNV.ForeColor = System.Drawing.Color.Black;
            this.tbSDTNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Location = new System.Drawing.Point(395, 572);
            this.tbSDTNV.Name = "tbSDTNV";
            this.tbSDTNV.PasswordChar = '\0';
            this.tbSDTNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSDTNV.PlaceholderText = "Số điện thoại";
            this.tbSDTNV.SelectedText = "";
            this.tbSDTNV.Size = new System.Drawing.Size(409, 30);
            this.tbSDTNV.TabIndex = 20;
            // 
            // tbAddressNV
            // 
            this.tbAddressNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.BorderRadius = 6;
            this.tbAddressNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddressNV.DefaultText = "";
            this.tbAddressNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.Enabled = false;
            this.tbAddressNV.FillColor = System.Drawing.Color.Tan;
            this.tbAddressNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddressNV.ForeColor = System.Drawing.Color.Black;
            this.tbAddressNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Location = new System.Drawing.Point(395, 506);
            this.tbAddressNV.Name = "tbAddressNV";
            this.tbAddressNV.PasswordChar = '\0';
            this.tbAddressNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbAddressNV.PlaceholderText = "Địa chỉ";
            this.tbAddressNV.SelectedText = "";
            this.tbAddressNV.Size = new System.Drawing.Size(409, 30);
            this.tbAddressNV.TabIndex = 19;
            // 
            // tbCMNDNV
            // 
            this.tbCMNDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.BorderRadius = 6;
            this.tbCMNDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMNDNV.DefaultText = "";
            this.tbCMNDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.Enabled = false;
            this.tbCMNDNV.FillColor = System.Drawing.Color.Tan;
            this.tbCMNDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCMNDNV.ForeColor = System.Drawing.Color.Black;
            this.tbCMNDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Location = new System.Drawing.Point(395, 441);
            this.tbCMNDNV.Name = "tbCMNDNV";
            this.tbCMNDNV.PasswordChar = '\0';
            this.tbCMNDNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCMNDNV.PlaceholderText = "CMND";
            this.tbCMNDNV.SelectedText = "";
            this.tbCMNDNV.Size = new System.Drawing.Size(409, 30);
            this.tbCMNDNV.TabIndex = 18;
            // 
            // tbBD
            // 
            this.tbBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.BorderRadius = 6;
            this.tbBD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBD.DefaultText = "";
            this.tbBD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.Enabled = false;
            this.tbBD.FillColor = System.Drawing.Color.Tan;
            this.tbBD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbBD.ForeColor = System.Drawing.Color.Black;
            this.tbBD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Location = new System.Drawing.Point(395, 240);
            this.tbBD.Name = "tbBD";
            this.tbBD.PasswordChar = '\0';
            this.tbBD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBD.PlaceholderText = "Ngày sinh";
            this.tbBD.SelectedText = "";
            this.tbBD.Size = new System.Drawing.Size(409, 30);
            this.tbBD.TabIndex = 17;
            // 
            // tbNameNV
            // 
            this.tbNameNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.BorderRadius = 6;
            this.tbNameNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameNV.DefaultText = "";
            this.tbNameNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.Enabled = false;
            this.tbNameNV.FillColor = System.Drawing.Color.Tan;
            this.tbNameNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameNV.ForeColor = System.Drawing.Color.Black;
            this.tbNameNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Location = new System.Drawing.Point(395, 113);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.PasswordChar = '\0';
            this.tbNameNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameNV.PlaceholderText = "Họ và tên";
            this.tbNameNV.SelectedText = "";
            this.tbNameNV.Size = new System.Drawing.Size(409, 30);
            this.tbNameNV.TabIndex = 16;
            // 
            // rjbtnOK
            // 
            this.rjbtnOK.BackColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnOK.BorderRadius = 15;
            this.rjbtnOK.BorderSize = 0;
            this.rjbtnOK.FlatAppearance.BorderSize = 0;
            this.rjbtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnOK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnOK.ForeColor = System.Drawing.Color.White;
            this.rjbtnOK.Location = new System.Drawing.Point(359, 655);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 14;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.RjbtnCancel_Click);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.Black;
            this.lblCMND.Location = new System.Drawing.Point(286, 447);
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
            this.lblEmail.Location = new System.Drawing.Point(286, 181);
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
            this.lblSDT.Location = new System.Drawing.Point(286, 576);
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
            this.lblAddress.Location = new System.Drawing.Point(286, 509);
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
            this.lblGender.Location = new System.Drawing.Point(286, 380);
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
            this.lblBD.Location = new System.Drawing.Point(286, 245);
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
            this.lblNameNV.Location = new System.Drawing.Point(286, 118);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(76, 18);
            this.lblNameNV.TabIndex = 1;
            this.lblNameNV.Text = "Họ và tên";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelContainer;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panelTitleBar;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // FormTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 774);
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
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblNameNV;
        private Guna.UI2.WinForms.Guna2TextBox tbNameNV;
        private Guna.UI2.WinForms.Guna2TextBox tbBD;
        private Guna.UI2.WinForms.Guna2TextBox tbCMNDNV;
        private Guna.UI2.WinForms.Guna2TextBox tbSDTNV;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressNV;
        private Guna.UI2.WinForms.Guna2TextBox tbEmailNV;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private RJButton rjbtnOK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2TextBox tbGender;
        private Guna.UI2.WinForms.Guna2PictureBox avatar;
        private Guna.UI2.WinForms.Guna2TextBox tbIDNV;
        public System.Windows.Forms.Label lblIDNV;
        private Guna.UI2.WinForms.Guna2TextBox tbStartDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}