
namespace BTDotNetCK.GUI
{
    partial class FormTTKH
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
            this.lblDetailCustomer = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbIDCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDCustomer = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Chocolate;
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.lblDetailCustomer);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(833, 41);
            this.panelTitleBar.TabIndex = 4;
            // 
            // lblDetailCustomer
            // 
            this.lblDetailCustomer.AutoSize = true;
            this.lblDetailCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetailCustomer.Location = new System.Drawing.Point(7, 12);
            this.lblDetailCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailCustomer.Name = "lblDetailCustomer";
            this.lblDetailCustomer.Size = new System.Drawing.Size(176, 19);
            this.lblDetailCustomer.TabIndex = 1;
            this.lblDetailCustomer.Text = "Thông tin khách hàng";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContainer.Controls.Add(this.tbGender);
            this.panelContainer.Controls.Add(this.lblGender);
            this.panelContainer.Controls.Add(this.tbIDCustomer);
            this.panelContainer.Controls.Add(this.lblIDCustomer);
            this.panelContainer.Controls.Add(this.btnOK);
            this.panelContainer.Controls.Add(this.tbPhone);
            this.panelContainer.Controls.Add(this.tbAddress);
            this.panelContainer.Controls.Add(this.tbNameCustomer);
            this.panelContainer.Controls.Add(this.lblPhone);
            this.panelContainer.Controls.Add(this.lblAddress);
            this.panelContainer.Controls.Add(this.lblNameCustomer);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(833, 507);
            this.panelContainer.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(131, 211);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 18);
            this.lblGender.TabIndex = 63;
            this.lblGender.Text = "Giới tính";
            // 
            // tbIDCustomer
            // 
            this.tbIDCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDCustomer.BorderRadius = 6;
            this.tbIDCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDCustomer.DefaultText = "";
            this.tbIDCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDCustomer.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbIDCustomer.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbIDCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbIDCustomer.Enabled = false;
            this.tbIDCustomer.FillColor = System.Drawing.Color.Tan;
            this.tbIDCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDCustomer.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIDCustomer.ForeColor = System.Drawing.Color.Black;
            this.tbIDCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDCustomer.Location = new System.Drawing.Point(258, 45);
            this.tbIDCustomer.Name = "tbIDCustomer";
            this.tbIDCustomer.PasswordChar = '\0';
            this.tbIDCustomer.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbIDCustomer.PlaceholderText = "Mã khách hàng";
            this.tbIDCustomer.SelectedText = "";
            this.tbIDCustomer.Size = new System.Drawing.Size(393, 30);
            this.tbIDCustomer.TabIndex = 60;
            // 
            // lblIDCustomer
            // 
            this.lblIDCustomer.AutoSize = true;
            this.lblIDCustomer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblIDCustomer.Location = new System.Drawing.Point(131, 51);
            this.lblIDCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDCustomer.Name = "lblIDCustomer";
            this.lblIDCustomer.Size = new System.Drawing.Size(114, 18);
            this.lblIDCustomer.TabIndex = 61;
            this.lblIDCustomer.Text = "Mã khách hàng";
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
            this.btnOK.Location = new System.Drawing.Point(346, 440);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 36);
            this.btnOK.TabIndex = 55;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPhone.BorderRadius = 6;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbPhone.Enabled = false;
            this.tbPhone.FillColor = System.Drawing.Color.Tan;
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPhone.ForeColor = System.Drawing.Color.Black;
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(258, 285);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbPhone.PlaceholderText = "Số điện thoại";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(393, 30);
            this.tbPhone.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddress.BorderRadius = 6;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbAddress.Enabled = false;
            this.tbAddress.FillColor = System.Drawing.Color.Tan;
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddress.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Location = new System.Drawing.Point(258, 365);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbAddress.PlaceholderText = "Địa chỉ";
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(393, 30);
            this.tbAddress.TabIndex = 3;
            // 
            // tbNameCustomer
            // 
            this.tbNameCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameCustomer.BorderRadius = 6;
            this.tbNameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameCustomer.DefaultText = "";
            this.tbNameCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameCustomer.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbNameCustomer.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbNameCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameCustomer.Enabled = false;
            this.tbNameCustomer.FillColor = System.Drawing.Color.Tan;
            this.tbNameCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameCustomer.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.tbNameCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameCustomer.Location = new System.Drawing.Point(258, 125);
            this.tbNameCustomer.Name = "tbNameCustomer";
            this.tbNameCustomer.PasswordChar = '\0';
            this.tbNameCustomer.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameCustomer.PlaceholderText = "Tên khách hàng";
            this.tbNameCustomer.SelectedText = "";
            this.tbNameCustomer.Size = new System.Drawing.Size(393, 30);
            this.tbNameCustomer.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(131, 291);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 18);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(131, 373);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 18);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblNameCustomer.Location = new System.Drawing.Point(131, 130);
            this.lblNameCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(121, 18);
            this.lblNameCustomer.TabIndex = 1;
            this.lblNameCustomer.Text = "Tên khách hàng";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.user_info;
            this.pictureBox1.Location = new System.Drawing.Point(187, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.tbGender.Location = new System.Drawing.Point(258, 205);
            this.tbGender.Name = "tbGender";
            this.tbGender.PasswordChar = '\0';
            this.tbGender.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbGender.PlaceholderText = "Giới tính";
            this.tbGender.SelectedText = "";
            this.tbGender.Size = new System.Drawing.Size(393, 30);
            this.tbGender.TabIndex = 64;
            // 
            // FormTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 548);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTTKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTTKH";
            this.Load += new System.EventHandler(this.FormTTKH_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetailCustomer;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2TextBox tbNameCustomer;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNameCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2TextBox tbIDCustomer;
        private System.Windows.Forms.Label lblIDCustomer;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2TextBox tbGender;
    }
}