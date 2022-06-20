
namespace BTDotNetCK.GUI
{
    partial class FormEditHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditHang));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.msgValidatePrice = new System.Windows.Forms.Label();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteImg = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodImg = new Guna.UI2.WinForms.Guna2Button();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.foodAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.msgValidateCategory = new System.Windows.Forms.Label();
            this.msgValidateNameHang = new System.Windows.Forms.Label();
            this.tbNameHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNameHang = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodAvatar)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.food;
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
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm mặt hàng mới";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContainer.Controls.Add(this.msgValidatePrice);
            this.panelContainer.Controls.Add(this.tbPrice);
            this.panelContainer.Controls.Add(this.lblPrice);
            this.panelContainer.Controls.Add(this.btnCancel);
            this.panelContainer.Controls.Add(this.btnSave);
            this.panelContainer.Controls.Add(this.btnOK);
            this.panelContainer.Controls.Add(this.btnDeleteImg);
            this.panelContainer.Controls.Add(this.btnFoodImg);
            this.panelContainer.Controls.Add(this.cbCategory);
            this.panelContainer.Controls.Add(this.foodAvatar);
            this.panelContainer.Controls.Add(this.msgValidateCategory);
            this.panelContainer.Controls.Add(this.msgValidateNameHang);
            this.panelContainer.Controls.Add(this.tbNameHang);
            this.panelContainer.Controls.Add(this.lblCategory);
            this.panelContainer.Controls.Add(this.lblNameHang);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(833, 433);
            this.panelContainer.TabIndex = 6;
            // 
            // msgValidatePrice
            // 
            this.msgValidatePrice.AutoSize = true;
            this.msgValidatePrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidatePrice.Location = new System.Drawing.Point(402, 226);
            this.msgValidatePrice.Name = "msgValidatePrice";
            this.msgValidatePrice.Size = new System.Drawing.Size(0, 16);
            this.msgValidatePrice.TabIndex = 59;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPrice.BorderRadius = 6;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPrice.FillColor = System.Drawing.Color.Tan;
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Location = new System.Drawing.Point(393, 193);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbPrice.PlaceholderText = "Nhập giá";
            this.tbPrice.SelectedText = "";
            this.tbPrice.Size = new System.Drawing.Size(409, 30);
            this.tbPrice.TabIndex = 57;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(286, 198);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 18);
            this.lblPrice.TabIndex = 58;
            this.lblPrice.Text = "Giá tiền";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.DimGray;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(434, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 36);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(257, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 36);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.BtnOKs_Click);
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
            this.btnOK.Location = new System.Drawing.Point(257, 360);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 36);
            this.btnOK.TabIndex = 55;
            this.btnOK.Text = "OK";
            // 
            // btnDeleteImg
            // 
            this.btnDeleteImg.BorderRadius = 20;
            this.btnDeleteImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteImg.FillColor = System.Drawing.Color.Crimson;
            this.btnDeleteImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteImg.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImg.Image = global::BTDotNetCK.Properties.Resources.icons8_Close_30px;
            this.btnDeleteImg.Location = new System.Drawing.Point(142, 251);
            this.btnDeleteImg.Name = "btnDeleteImg";
            this.btnDeleteImg.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteImg.TabIndex = 54;
            this.btnDeleteImg.Text = "Xóa ảnh";
            this.btnDeleteImg.Click += new System.EventHandler(this.BtnDeleteImg_Click);
            // 
            // btnFoodImg
            // 
            this.btnFoodImg.BorderRadius = 20;
            this.btnFoodImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnFoodImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFoodImg.ForeColor = System.Drawing.Color.White;
            this.btnFoodImg.Image = global::BTDotNetCK.Properties.Resources.icons8_picture_30px;
            this.btnFoodImg.Location = new System.Drawing.Point(10, 251);
            this.btnFoodImg.Name = "btnFoodImg";
            this.btnFoodImg.Size = new System.Drawing.Size(110, 40);
            this.btnFoodImg.TabIndex = 53;
            this.btnFoodImg.Text = "Chọn ảnh";
            this.btnFoodImg.Click += new System.EventHandler(this.BtnFoodImg_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.cbCategory.BorderRadius = 6;
            this.cbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FillColor = System.Drawing.Color.Tan;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Items.AddRange(new object[] {
            "Thức ăn",
            "Đồ uống"});
            this.cbCategory.Location = new System.Drawing.Point(393, 117);
            this.cbCategory.MaximumSize = new System.Drawing.Size(409, 0);
            this.cbCategory.MinimumSize = new System.Drawing.Size(409, 0);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(409, 36);
            this.cbCategory.TabIndex = 52;
            this.cbCategory.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // foodAvatar
            // 
            this.foodAvatar.BackColor = System.Drawing.Color.Transparent;
            this.foodAvatar.ImageRotate = 0F;
            this.foodAvatar.Location = new System.Drawing.Point(10, 44);
            this.foodAvatar.Name = "foodAvatar";
            this.foodAvatar.Size = new System.Drawing.Size(242, 179);
            this.foodAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foodAvatar.TabIndex = 51;
            this.foodAvatar.TabStop = false;
            // 
            // msgValidateCategory
            // 
            this.msgValidateCategory.AutoSize = true;
            this.msgValidateCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateCategory.Location = new System.Drawing.Point(402, 156);
            this.msgValidateCategory.Name = "msgValidateCategory";
            this.msgValidateCategory.Size = new System.Drawing.Size(0, 16);
            this.msgValidateCategory.TabIndex = 50;
            // 
            // msgValidateNameHang
            // 
            this.msgValidateNameHang.AutoSize = true;
            this.msgValidateNameHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateNameHang.Location = new System.Drawing.Point(402, 79);
            this.msgValidateNameHang.Name = "msgValidateNameHang";
            this.msgValidateNameHang.Size = new System.Drawing.Size(0, 16);
            this.msgValidateNameHang.TabIndex = 50;
            // 
            // tbNameHang
            // 
            this.tbNameHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameHang.BorderRadius = 6;
            this.tbNameHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameHang.DefaultText = "";
            this.tbNameHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameHang.FillColor = System.Drawing.Color.Tan;
            this.tbNameHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameHang.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameHang.ForeColor = System.Drawing.Color.Black;
            this.tbNameHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameHang.Location = new System.Drawing.Point(393, 46);
            this.tbNameHang.Name = "tbNameHang";
            this.tbNameHang.PasswordChar = '\0';
            this.tbNameHang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameHang.PlaceholderText = "Nhập tên mặt hàng";
            this.tbNameHang.SelectedText = "";
            this.tbNameHang.Size = new System.Drawing.Size(409, 30);
            this.tbNameHang.TabIndex = 1;
            this.tbNameHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNameHang_KeyPress);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(286, 126);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 18);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Loại hàng";
            // 
            // lblNameHang
            // 
            this.lblNameHang.AutoSize = true;
            this.lblNameHang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHang.ForeColor = System.Drawing.Color.Black;
            this.lblNameHang.Location = new System.Drawing.Point(286, 51);
            this.lblNameHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameHang.Name = "lblNameHang";
            this.lblNameHang.Size = new System.Drawing.Size(104, 18);
            this.lblNameHang.TabIndex = 1;
            this.lblNameHang.Text = "Tên mặt hàng";
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FormEditHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 474);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddHang";
            this.Load += new System.EventHandler(this.FormEditHang_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodAvatar)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btnFoodImg;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2PictureBox foodAvatar;
        private System.Windows.Forms.Label msgValidateCategory;
        private System.Windows.Forms.Label msgValidateNameHang;
        private Guna.UI2.WinForms.Guna2TextBox tbNameHang;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblNameHang;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label msgValidatePrice;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}