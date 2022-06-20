
namespace BTDotNetCK.GUI
{
    partial class FormAddKH
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.msgValidateAddress = new System.Windows.Forms.Label();
            this.msgValidateIDCard = new System.Windows.Forms.Label();
            this.msgValidatePhone = new System.Windows.Forms.Label();
            this.msgValidateGender = new System.Windows.Forms.Label();
            this.msgValidateDateOfBirth = new System.Windows.Forms.Label();
            this.msgValidateEmail = new System.Windows.Forms.Label();
            this.msgValidateName = new System.Windows.Forms.Label();
            this.tbEmailKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSDTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCMNDKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBD = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnDeleteImg = new Guna.UI2.WinForms.Guna2Button();
            this.btnNVImg = new Guna.UI2.WinForms.Guna2Button();
            this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelTitleBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm khách hàng mới";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContainer.Controls.Add(this.btnCancel);
            this.panelContainer.Controls.Add(this.btnOK);
            this.panelContainer.Controls.Add(this.btnDeleteImg);
            this.panelContainer.Controls.Add(this.btnNVImg);
            this.panelContainer.Controls.Add(this.cbGender);
            this.panelContainer.Controls.Add(this.avatar);
            this.panelContainer.Controls.Add(this.msgValidateAddress);
            this.panelContainer.Controls.Add(this.msgValidateIDCard);
            this.panelContainer.Controls.Add(this.msgValidatePhone);
            this.panelContainer.Controls.Add(this.msgValidateGender);
            this.panelContainer.Controls.Add(this.msgValidateDateOfBirth);
            this.panelContainer.Controls.Add(this.msgValidateEmail);
            this.panelContainer.Controls.Add(this.msgValidateName);
            this.panelContainer.Controls.Add(this.tbEmailKH);
            this.panelContainer.Controls.Add(this.tbSDTKH);
            this.panelContainer.Controls.Add(this.tbAddressKH);
            this.panelContainer.Controls.Add(this.tbCMNDKH);
            this.panelContainer.Controls.Add(this.tbBD);
            this.panelContainer.Controls.Add(this.tbNameKH);
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
            this.panelContainer.Size = new System.Drawing.Size(833, 664);
            this.panelContainer.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.DimGray;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(427, 595);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 36);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Hủy";
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 15;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.SeaGreen;
            this.btnOK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(254, 595);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 36);
            this.btnOK.TabIndex = 55;
            this.btnOK.Text = "OK";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.cbGender.BorderRadius = 6;
            this.cbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FillColor = System.Drawing.Color.Tan;
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.ItemHeight = 30;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(393, 245);
            this.cbGender.MaximumSize = new System.Drawing.Size(409, 0);
            this.cbGender.MinimumSize = new System.Drawing.Size(409, 0);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(409, 36);
            this.cbGender.TabIndex = 52;
            this.cbGender.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // msgValidateAddress
            // 
            this.msgValidateAddress.AutoSize = true;
            this.msgValidateAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateAddress.Location = new System.Drawing.Point(402, 492);
            this.msgValidateAddress.Name = "msgValidateAddress";
            this.msgValidateAddress.Size = new System.Drawing.Size(0, 16);
            this.msgValidateAddress.TabIndex = 50;
            // 
            // msgValidateIDCard
            // 
            this.msgValidateIDCard.AutoSize = true;
            this.msgValidateIDCard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateIDCard.Location = new System.Drawing.Point(402, 424);
            this.msgValidateIDCard.Name = "msgValidateIDCard";
            this.msgValidateIDCard.Size = new System.Drawing.Size(0, 16);
            this.msgValidateIDCard.TabIndex = 50;
            // 
            // msgValidatePhone
            // 
            this.msgValidatePhone.AutoSize = true;
            this.msgValidatePhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidatePhone.Location = new System.Drawing.Point(402, 352);
            this.msgValidatePhone.Name = "msgValidatePhone";
            this.msgValidatePhone.Size = new System.Drawing.Size(0, 16);
            this.msgValidatePhone.TabIndex = 50;
            // 
            // msgValidateGender
            // 
            this.msgValidateGender.AutoSize = true;
            this.msgValidateGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateGender.Location = new System.Drawing.Point(402, 284);
            this.msgValidateGender.Name = "msgValidateGender";
            this.msgValidateGender.Size = new System.Drawing.Size(0, 16);
            this.msgValidateGender.TabIndex = 50;
            // 
            // msgValidateDateOfBirth
            // 
            this.msgValidateDateOfBirth.AutoSize = true;
            this.msgValidateDateOfBirth.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateDateOfBirth.Location = new System.Drawing.Point(402, 211);
            this.msgValidateDateOfBirth.Name = "msgValidateDateOfBirth";
            this.msgValidateDateOfBirth.Size = new System.Drawing.Size(0, 16);
            this.msgValidateDateOfBirth.TabIndex = 50;
            // 
            // msgValidateEmail
            // 
            this.msgValidateEmail.AutoSize = true;
            this.msgValidateEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateEmail.Location = new System.Drawing.Point(402, 141);
            this.msgValidateEmail.Name = "msgValidateEmail";
            this.msgValidateEmail.Size = new System.Drawing.Size(0, 16);
            this.msgValidateEmail.TabIndex = 50;
            // 
            // msgValidateName
            // 
            this.msgValidateName.AutoSize = true;
            this.msgValidateName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateName.Location = new System.Drawing.Point(402, 72);
            this.msgValidateName.Name = "msgValidateName";
            this.msgValidateName.Size = new System.Drawing.Size(0, 16);
            this.msgValidateName.TabIndex = 50;
            // 
            // tbEmailKH
            // 
            this.tbEmailKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailKH.BorderRadius = 6;
            this.tbEmailKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmailKH.DefaultText = "";
            this.tbEmailKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailKH.FillColor = System.Drawing.Color.Tan;
            this.tbEmailKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbEmailKH.ForeColor = System.Drawing.Color.Black;
            this.tbEmailKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailKH.Location = new System.Drawing.Point(393, 108);
            this.tbEmailKH.Name = "tbEmailKH";
            this.tbEmailKH.PasswordChar = '\0';
            this.tbEmailKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEmailKH.PlaceholderText = "Nhập email";
            this.tbEmailKH.SelectedText = "";
            this.tbEmailKH.Size = new System.Drawing.Size(409, 30);
            this.tbEmailKH.TabIndex = 2;
            // 
            // tbSDTKH
            // 
            this.tbSDTKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTKH.BorderRadius = 6;
            this.tbSDTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSDTKH.DefaultText = "";
            this.tbSDTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTKH.FillColor = System.Drawing.Color.Tan;
            this.tbSDTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSDTKH.ForeColor = System.Drawing.Color.Black;
            this.tbSDTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTKH.Location = new System.Drawing.Point(393, 319);
            this.tbSDTKH.Name = "tbSDTKH";
            this.tbSDTKH.PasswordChar = '\0';
            this.tbSDTKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSDTKH.PlaceholderText = "Nhập số điện thoại";
            this.tbSDTKH.SelectedText = "";
            this.tbSDTKH.Size = new System.Drawing.Size(409, 30);
            this.tbSDTKH.TabIndex = 5;
            // 
            // tbAddressKH
            // 
            this.tbAddressKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressKH.BorderRadius = 6;
            this.tbAddressKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddressKH.DefaultText = "";
            this.tbAddressKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.FillColor = System.Drawing.Color.Tan;
            this.tbAddressKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddressKH.ForeColor = System.Drawing.Color.Black;
            this.tbAddressKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressKH.Location = new System.Drawing.Point(393, 459);
            this.tbAddressKH.Name = "tbAddressKH";
            this.tbAddressKH.PasswordChar = '\0';
            this.tbAddressKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbAddressKH.PlaceholderText = "Nhập địa chỉ";
            this.tbAddressKH.SelectedText = "";
            this.tbAddressKH.Size = new System.Drawing.Size(409, 30);
            this.tbAddressKH.TabIndex = 7;
            // 
            // tbCMNDKH
            // 
            this.tbCMNDKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDKH.BorderRadius = 6;
            this.tbCMNDKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMNDKH.DefaultText = "";
            this.tbCMNDKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDKH.FillColor = System.Drawing.Color.Tan;
            this.tbCMNDKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCMNDKH.ForeColor = System.Drawing.Color.Black;
            this.tbCMNDKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDKH.Location = new System.Drawing.Point(393, 391);
            this.tbCMNDKH.Name = "tbCMNDKH";
            this.tbCMNDKH.PasswordChar = '\0';
            this.tbCMNDKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCMNDKH.PlaceholderText = "Nhập CMND";
            this.tbCMNDKH.SelectedText = "";
            this.tbCMNDKH.Size = new System.Drawing.Size(409, 30);
            this.tbCMNDKH.TabIndex = 6;
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
            this.tbBD.FillColor = System.Drawing.Color.Tan;
            this.tbBD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbBD.ForeColor = System.Drawing.Color.Black;
            this.tbBD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Location = new System.Drawing.Point(393, 178);
            this.tbBD.Name = "tbBD";
            this.tbBD.PasswordChar = '\0';
            this.tbBD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBD.PlaceholderText = "Nhập ngày sinh";
            this.tbBD.SelectedText = "";
            this.tbBD.Size = new System.Drawing.Size(409, 30);
            this.tbBD.TabIndex = 3;
            // 
            // tbNameKH
            // 
            this.tbNameKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.BorderRadius = 6;
            this.tbNameKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameKH.DefaultText = "";
            this.tbNameKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.FillColor = System.Drawing.Color.Tan;
            this.tbNameKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameKH.ForeColor = System.Drawing.Color.Black;
            this.tbNameKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Location = new System.Drawing.Point(393, 39);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.PasswordChar = '\0';
            this.tbNameKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameKH.PlaceholderText = "Nhập họ và tên";
            this.tbNameKH.SelectedText = "";
            this.tbNameKH.Size = new System.Drawing.Size(409, 30);
            this.tbNameKH.TabIndex = 1;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.Black;
            this.lblCMND.Location = new System.Drawing.Point(286, 397);
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
            this.lblEmail.Location = new System.Drawing.Point(286, 113);
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
            this.lblSDT.Location = new System.Drawing.Point(286, 323);
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
            this.lblAddress.Location = new System.Drawing.Point(286, 462);
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
            this.lblGender.Location = new System.Drawing.Point(286, 254);
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
            this.lblBD.Location = new System.Drawing.Point(286, 183);
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
            this.lblNameNV.Location = new System.Drawing.Point(286, 44);
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // btnDeleteImg
            // 
            this.btnDeleteImg.BorderRadius = 20;
            this.btnDeleteImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteImg.FillColor = System.Drawing.Color.Crimson;
            this.btnDeleteImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteImg.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImg.Image = global::BTDotNetCK.Properties.Resources.icons8_Close_30px;
            this.btnDeleteImg.Location = new System.Drawing.Point(142, 313);
            this.btnDeleteImg.Name = "btnDeleteImg";
            this.btnDeleteImg.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteImg.TabIndex = 54;
            this.btnDeleteImg.Text = "Xóa ảnh";
            // 
            // btnNVImg
            // 
            this.btnNVImg.BorderRadius = 20;
            this.btnNVImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNVImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNVImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNVImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNVImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNVImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNVImg.ForeColor = System.Drawing.Color.White;
            this.btnNVImg.Image = global::BTDotNetCK.Properties.Resources.icons8_picture_30px;
            this.btnNVImg.Location = new System.Drawing.Point(10, 313);
            this.btnNVImg.Name = "btnNVImg";
            this.btnNVImg.Size = new System.Drawing.Size(110, 40);
            this.btnNVImg.TabIndex = 53;
            this.btnNVImg.Text = "Chọn ảnh";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(10, 44);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(242, 240);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 51;
            this.avatar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.shopping1;
            this.pictureBox1.Location = new System.Drawing.Point(187, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 705);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddKH";
            this.Text = "FormAddKH";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button btnDeleteImg;
        private Guna.UI2.WinForms.Guna2Button btnNVImg;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2PictureBox avatar;
        private System.Windows.Forms.Label msgValidateAddress;
        private System.Windows.Forms.Label msgValidateIDCard;
        private System.Windows.Forms.Label msgValidatePhone;
        private System.Windows.Forms.Label msgValidateGender;
        private System.Windows.Forms.Label msgValidateDateOfBirth;
        private System.Windows.Forms.Label msgValidateEmail;
        private System.Windows.Forms.Label msgValidateName;
        private Guna.UI2.WinForms.Guna2TextBox tbEmailKH;
        private Guna.UI2.WinForms.Guna2TextBox tbSDTKH;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressKH;
        private Guna.UI2.WinForms.Guna2TextBox tbCMNDKH;
        private Guna.UI2.WinForms.Guna2TextBox tbBD;
        private Guna.UI2.WinForms.Guna2TextBox tbNameKH;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblNameNV;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}