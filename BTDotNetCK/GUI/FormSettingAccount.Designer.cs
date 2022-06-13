
namespace BTDotNetCK.GUI
{
    partial class FormSettingAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingAccount));
            this.msgValidateConfirmPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.msgValidateNewPassword = new System.Windows.Forms.Label();
            this.btnSaveChange = new Guna.UI2.WinForms.Guna2Button();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDeleteImg = new BTDotNetCK.GUI.RJButton();
            this.btnEditImg = new BTDotNetCK.GUI.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // msgValidateConfirmPassword
            // 
            this.msgValidateConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msgValidateConfirmPassword.AutoSize = true;
            this.msgValidateConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.msgValidateConfirmPassword.Location = new System.Drawing.Point(376, 198);
            this.msgValidateConfirmPassword.Name = "msgValidateConfirmPassword";
            this.msgValidateConfirmPassword.Size = new System.Drawing.Size(0, 20);
            this.msgValidateConfirmPassword.TabIndex = 27;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.tbConfirmPassword.BorderRadius = 10;
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.DefaultText = "";
            this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Location = new System.Drawing.Point(379, 154);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '●';
            this.tbConfirmPassword.PlaceholderText = "";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.Size = new System.Drawing.Size(200, 36);
            this.tbConfirmPassword.TabIndex = 2;
            this.tbConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbConfirmPassword_KeyPress);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmPassword.Location = new System.Drawing.Point(192, 166);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(140, 18);
            this.lblConfirmPassword.TabIndex = 25;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // msgValidateNewPassword
            // 
            this.msgValidateNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msgValidateNewPassword.AutoSize = true;
            this.msgValidateNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateNewPassword.ForeColor = System.Drawing.Color.White;
            this.msgValidateNewPassword.Location = new System.Drawing.Point(375, 112);
            this.msgValidateNewPassword.Name = "msgValidateNewPassword";
            this.msgValidateNewPassword.Size = new System.Drawing.Size(0, 20);
            this.msgValidateNewPassword.TabIndex = 24;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveChange.BorderRadius = 6;
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnSaveChange.Location = new System.Drawing.Point(420, 495);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSaveChange.Size = new System.Drawing.Size(110, 36);
            this.btnSaveChange.TabIndex = 5;
            this.btnSaveChange.Text = "Lưu";
            this.btnSaveChange.Click += new System.EventHandler(this.BtnSaveChange_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPassword.BorderColor = System.Drawing.Color.Black;
            this.tbPassword.BorderRadius = 10;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(378, 68);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(200, 36);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(229, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 18);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Mật khẩu mới";
            // 
            // lblAvatar
            // 
            this.lblAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.BackColor = System.Drawing.Color.Transparent;
            this.lblAvatar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.ForeColor = System.Drawing.Color.Black;
            this.lblAvatar.Location = new System.Drawing.Point(231, 244);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(101, 18);
            this.lblAvatar.TabIndex = 19;
            this.lblAvatar.Text = "Hình đại diện";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.ErrorImage = null;
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(378, 244);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(200, 200);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 20;
            this.pbAvatar.TabStop = false;
            // 
            // btnDeleteImg
            // 
            this.btnDeleteImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteImg.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteImg.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDeleteImg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteImg.BorderRadius = 20;
            this.btnDeleteImg.BorderSize = 0;
            this.btnDeleteImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteImg.FlatAppearance.BorderSize = 0;
            this.btnDeleteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImg.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImg.Image = global::BTDotNetCK.Properties.Resources.delete_30px;
            this.btnDeleteImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteImg.Location = new System.Drawing.Point(606, 307);
            this.btnDeleteImg.Name = "btnDeleteImg";
            this.btnDeleteImg.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteImg.TabIndex = 4;
            this.btnDeleteImg.Text = "Xóa ảnh";
            this.btnDeleteImg.TextColor = System.Drawing.Color.White;
            this.btnDeleteImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteImg.UseVisualStyleBackColor = false;
            this.btnDeleteImg.Click += new System.EventHandler(this.BtnDeleteImg_Click);
            // 
            // btnEditImg
            // 
            this.btnEditImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditImg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditImg.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnEditImg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditImg.BorderRadius = 20;
            this.btnEditImg.BorderSize = 0;
            this.btnEditImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditImg.FlatAppearance.BorderSize = 0;
            this.btnEditImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditImg.ForeColor = System.Drawing.Color.White;
            this.btnEditImg.Image = global::BTDotNetCK.Properties.Resources.icons8_picture_30px;
            this.btnEditImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditImg.Location = new System.Drawing.Point(606, 244);
            this.btnEditImg.Name = "btnEditImg";
            this.btnEditImg.Size = new System.Drawing.Size(110, 40);
            this.btnEditImg.TabIndex = 3;
            this.btnEditImg.Text = "Chọn ảnh";
            this.btnEditImg.TextColor = System.Drawing.Color.White;
            this.btnEditImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditImg.UseVisualStyleBackColor = false;
            this.btnEditImg.Click += new System.EventHandler(this.BtnEditImg_Click);
            // 
            // FormSettingAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.msgValidateConfirmPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.msgValidateNewPassword);
            this.Controls.Add(this.btnDeleteImg);
            this.Controls.Add(this.btnEditImg);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettingAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi tài khoản";
            this.Load += new System.EventHandler(this.FormSettingAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgValidateConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label msgValidateNewPassword;
        private RJButton btnDeleteImg;
        private RJButton btnEditImg;
        private Guna.UI2.WinForms.Guna2Button btnSaveChange;
        private Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAvatar;
    }
}