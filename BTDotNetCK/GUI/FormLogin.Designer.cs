
namespace BTDotNetCK.GUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.cbSaveAcc = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioEmployee = new System.Windows.Forms.RadioButton();
            this.lblSaveAcc = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.exitIcon = new System.Windows.Forms.PictureBox();
            this.HidePass = new System.Windows.Forms.PictureBox();
            this.ShowPass = new System.Windows.Forms.PictureBox();
            this.CoffeeShopIcon = new System.Windows.Forms.PictureBox();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.picPasswordIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeShopIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUsername.Location = new System.Drawing.Point(99, 218);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tài Khoản";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPassword.Location = new System.Drawing.Point(98, 324);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLogin.Location = new System.Drawing.Point(104, 143);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(208, 42);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Đăng Nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(102, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(102, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(131, 542);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 51);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Vào";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtUserName.Location = new System.Drawing.Point(102, 254);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(254, 24);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.Location = new System.Drawing.Point(102, 360);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(254, 24);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(227, 425);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(129, 20);
            this.linkLabelForgotPassword.TabIndex = 3;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Quên Mật Khẩu?";
            this.linkLabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelForgotPassword_LinkClicked);
            // 
            // cbSaveAcc
            // 
            this.cbSaveAcc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSaveAcc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSaveAcc.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cbSaveAcc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cbSaveAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSaveAcc.Location = new System.Drawing.Point(25, 425);
            this.cbSaveAcc.Name = "cbSaveAcc";
            this.cbSaveAcc.Size = new System.Drawing.Size(35, 20);
            this.cbSaveAcc.TabIndex = 14;
            this.cbSaveAcc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSaveAcc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSaveAcc.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cbSaveAcc.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioAdmin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioAdmin.Location = new System.Drawing.Point(78, 484);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(83, 24);
            this.radioAdmin.TabIndex = 4;
            this.radioAdmin.Text = "Quản trị";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioEmployee
            // 
            this.radioEmployee.AutoSize = true;
            this.radioEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioEmployee.Location = new System.Drawing.Point(241, 484);
            this.radioEmployee.Name = "radioEmployee";
            this.radioEmployee.Size = new System.Drawing.Size(97, 24);
            this.radioEmployee.TabIndex = 4;
            this.radioEmployee.Text = "Nhân viên";
            this.radioEmployee.UseVisualStyleBackColor = true;
            // 
            // lblSaveAcc
            // 
            this.lblSaveAcc.AutoSize = true;
            this.lblSaveAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaveAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSaveAcc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSaveAcc.Location = new System.Drawing.Point(66, 425);
            this.lblSaveAcc.Name = "lblSaveAcc";
            this.lblSaveAcc.Size = new System.Drawing.Size(116, 20);
            this.lblSaveAcc.TabIndex = 16;
            this.lblSaveAcc.Text = "Lưu đăng nhập";
            this.lblSaveAcc.Click += new System.EventHandler(this.LblSaveAcc_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 0;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // exitIcon
            // 
            this.exitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIcon.Image = global::BTDotNetCK.Properties.Resources.exit_blue_icon;
            this.exitIcon.Location = new System.Drawing.Point(357, 0);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(58, 47);
            this.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitIcon.TabIndex = 20;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // HidePass
            // 
            this.HidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePass.Image = global::BTDotNetCK.Properties.Resources.blue_eye_slash_icon;
            this.HidePass.Location = new System.Drawing.Point(300, 335);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(52, 49);
            this.HidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePass.TabIndex = 18;
            this.HidePass.TabStop = false;
            this.HidePass.Click += new System.EventHandler(this.Show_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPass.Image = global::BTDotNetCK.Properties.Resources.blue_eye_icon;
            this.ShowPass.Location = new System.Drawing.Point(300, 335);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(52, 49);
            this.ShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPass.TabIndex = 17;
            this.ShowPass.TabStop = false;
            this.ShowPass.Click += new System.EventHandler(this.Hide_Click);
            // 
            // CoffeeShopIcon
            // 
            this.CoffeeShopIcon.Image = global::BTDotNetCK.Properties.Resources.coffee_shop_icon;
            this.CoffeeShopIcon.Location = new System.Drawing.Point(122, 12);
            this.CoffeeShopIcon.Name = "CoffeeShopIcon";
            this.CoffeeShopIcon.Size = new System.Drawing.Size(161, 112);
            this.CoffeeShopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CoffeeShopIcon.TabIndex = 21;
            this.CoffeeShopIcon.TabStop = false;
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = global::BTDotNetCK.Properties.Resources.user_icon;
            this.picUserIcon.Location = new System.Drawing.Point(0, 206);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(100, 75);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 11;
            this.picUserIcon.TabStop = false;
            // 
            // picPasswordIcon
            // 
            this.picPasswordIcon.Image = global::BTDotNetCK.Properties.Resources.password_icon;
            this.picPasswordIcon.Location = new System.Drawing.Point(0, 311);
            this.picPasswordIcon.Name = "picPasswordIcon";
            this.picPasswordIcon.Size = new System.Drawing.Size(100, 80);
            this.picPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPasswordIcon.TabIndex = 12;
            this.picPasswordIcon.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 622);
            this.Controls.Add(this.exitIcon);
            this.Controls.Add(this.HidePass);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.lblSaveAcc);
            this.Controls.Add(this.radioEmployee);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.cbSaveAcc);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoffeeShopIcon);
            this.Controls.Add(this.picUserIcon);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picPasswordIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeShopIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPasswordIcon;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.PictureBox CoffeeShopIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch cbSaveAcc;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioEmployee;
        private System.Windows.Forms.Label lblSaveAcc;
        private System.Windows.Forms.PictureBox ShowPass;
        private System.Windows.Forms.PictureBox HidePass;
        private System.Windows.Forms.PictureBox exitIcon;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

