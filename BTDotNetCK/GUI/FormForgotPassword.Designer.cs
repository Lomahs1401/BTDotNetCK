
namespace BTDotNetCK.GUI
{
    partial class FormForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailPassword = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.exitIcon = new System.Windows.Forms.PictureBox();
            this.HidePass = new System.Windows.Forms.PictureBox();
            this.ShowPass = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CoffeeShopIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeShopIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblForgotPassword.Location = new System.Drawing.Point(70, 147);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(280, 42);
            this.lblForgotPassword.TabIndex = 0;
            this.lblForgotPassword.Text = "Quên Mật Khẩu";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmail.Location = new System.Drawing.Point(96, 207);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(100, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 5;
            // 
            // btnSendCode
            // 
            this.btnSendCode.AutoSize = true;
            this.btnSendCode.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(234, 448);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(130, 51);
            this.btnSendCode.TabIndex = 4;
            this.btnSendCode.Text = "Gửi Mã";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.BtnSendCode_ClickAsync);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(43, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 51);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEmail.Location = new System.Drawing.Point(100, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 19);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // lblEmailPassword
            // 
            this.lblEmailPassword.AutoSize = true;
            this.lblEmailPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmailPassword.Location = new System.Drawing.Point(96, 316);
            this.lblEmailPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailPassword.Name = "lblEmailPassword";
            this.lblEmailPassword.Size = new System.Drawing.Size(120, 20);
            this.lblEmailPassword.TabIndex = 1;
            this.lblEmailPassword.Text = "Mật Khẩu Email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(100, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 1);
            this.panel3.TabIndex = 5;
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEmailPassword.Location = new System.Drawing.Point(100, 367);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(280, 19);
            this.txtEmailPassword.TabIndex = 2;
            this.txtEmailPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailPassword_KeyPress);
            // 
            // exitIcon
            // 
            this.exitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIcon.Image = global::BTDotNetCK.Properties.Resources.exit_blue_icon;
            this.exitIcon.Location = new System.Drawing.Point(357, 0);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(58, 47);
            this.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitIcon.TabIndex = 19;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // HidePass
            // 
            this.HidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePass.Image = global::BTDotNetCK.Properties.Resources.blue_eye_slash_icon;
            this.HidePass.Location = new System.Drawing.Point(328, 337);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(52, 49);
            this.HidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePass.TabIndex = 13;
            this.HidePass.TabStop = false;
            this.HidePass.Click += new System.EventHandler(this.Show_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPass.Image = global::BTDotNetCK.Properties.Resources.blue_eye_icon;
            this.ShowPass.Location = new System.Drawing.Point(328, 337);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(52, 49);
            this.ShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPass.TabIndex = 12;
            this.ShowPass.TabStop = false;
            this.ShowPass.Click += new System.EventHandler(this.Hide_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BTDotNetCK.Properties.Resources.Email_icon;
            this.pictureBox4.Location = new System.Drawing.Point(-11, 201);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BTDotNetCK.Properties.Resources.lock_xxl;
            this.pictureBox2.Location = new System.Drawing.Point(-15, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // CoffeeShopIcon
            // 
            this.CoffeeShopIcon.Image = global::BTDotNetCK.Properties.Resources.coffee_shop_icon;
            this.CoffeeShopIcon.Location = new System.Drawing.Point(122, 12);
            this.CoffeeShopIcon.Name = "CoffeeShopIcon";
            this.CoffeeShopIcon.Size = new System.Drawing.Size(161, 112);
            this.CoffeeShopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CoffeeShopIcon.TabIndex = 22;
            this.CoffeeShopIcon.TabStop = false;
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 553);
            this.Controls.Add(this.CoffeeShopIcon);
            this.Controls.Add(this.exitIcon);
            this.Controls.Add(this.HidePass);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.txtEmailPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEmailPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblForgotPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác Nhận Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeShopIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblEmailPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.PictureBox ShowPass;
        private System.Windows.Forms.PictureBox HidePass;
        private System.Windows.Forms.PictureBox exitIcon;
        private System.Windows.Forms.PictureBox CoffeeShopIcon;
    }
}