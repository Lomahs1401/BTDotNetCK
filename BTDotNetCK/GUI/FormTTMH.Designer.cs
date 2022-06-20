
namespace BTDotNetCK.GUI
{
    partial class FormTTMH
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tbIDProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.productImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbQuantitySold = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantitySold = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.tbCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
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
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.product_detail;
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
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin hàng hóa";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContainer.Controls.Add(this.tbCategory);
            this.panelContainer.Controls.Add(this.lblCategory);
            this.panelContainer.Controls.Add(this.tbIDProduct);
            this.panelContainer.Controls.Add(this.lblIDProduct);
            this.panelContainer.Controls.Add(this.btnOK);
            this.panelContainer.Controls.Add(this.productImg);
            this.panelContainer.Controls.Add(this.tbQuantitySold);
            this.panelContainer.Controls.Add(this.tbPrice);
            this.panelContainer.Controls.Add(this.tbNameProduct);
            this.panelContainer.Controls.Add(this.lblQuantitySold);
            this.panelContainer.Controls.Add(this.lblPrice);
            this.panelContainer.Controls.Add(this.lblNameProduct);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(833, 507);
            this.panelContainer.TabIndex = 5;
            // 
            // tbIDProduct
            // 
            this.tbIDProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDProduct.BorderRadius = 6;
            this.tbIDProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDProduct.DefaultText = "";
            this.tbIDProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDProduct.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbIDProduct.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbIDProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbIDProduct.Enabled = false;
            this.tbIDProduct.FillColor = System.Drawing.Color.Tan;
            this.tbIDProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDProduct.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIDProduct.ForeColor = System.Drawing.Color.Black;
            this.tbIDProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDProduct.Location = new System.Drawing.Point(417, 42);
            this.tbIDProduct.Name = "tbIDProduct";
            this.tbIDProduct.PasswordChar = '\0';
            this.tbIDProduct.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbIDProduct.PlaceholderText = "Mã hàng hóa";
            this.tbIDProduct.SelectedText = "";
            this.tbIDProduct.Size = new System.Drawing.Size(393, 30);
            this.tbIDProduct.TabIndex = 60;
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.AutoSize = true;
            this.lblIDProduct.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProduct.ForeColor = System.Drawing.Color.Black;
            this.lblIDProduct.Location = new System.Drawing.Point(290, 48);
            this.lblIDProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(98, 18);
            this.lblIDProduct.TabIndex = 61;
            this.lblIDProduct.Text = "Mã hàng hóa";
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
            // productImg
            // 
            this.productImg.BackColor = System.Drawing.Color.Transparent;
            this.productImg.ErrorImage = null;
            this.productImg.ImageRotate = 0F;
            this.productImg.Location = new System.Drawing.Point(11, 39);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(262, 353);
            this.productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImg.TabIndex = 51;
            this.productImg.TabStop = false;
            // 
            // tbQuantitySold
            // 
            this.tbQuantitySold.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbQuantitySold.BorderRadius = 6;
            this.tbQuantitySold.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantitySold.DefaultText = "";
            this.tbQuantitySold.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbQuantitySold.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbQuantitySold.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbQuantitySold.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbQuantitySold.Enabled = false;
            this.tbQuantitySold.FillColor = System.Drawing.Color.Tan;
            this.tbQuantitySold.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantitySold.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbQuantitySold.ForeColor = System.Drawing.Color.Black;
            this.tbQuantitySold.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantitySold.Location = new System.Drawing.Point(417, 282);
            this.tbQuantitySold.Name = "tbQuantitySold";
            this.tbQuantitySold.PasswordChar = '\0';
            this.tbQuantitySold.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbQuantitySold.PlaceholderText = "Số lượng đã bán";
            this.tbQuantitySold.SelectedText = "";
            this.tbQuantitySold.Size = new System.Drawing.Size(393, 30);
            this.tbQuantitySold.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPrice.BorderRadius = 6;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbPrice.Enabled = false;
            this.tbPrice.FillColor = System.Drawing.Color.Tan;
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Location = new System.Drawing.Point(417, 362);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbPrice.PlaceholderText = "Giá tiền";
            this.tbPrice.SelectedText = "";
            this.tbPrice.Size = new System.Drawing.Size(393, 30);
            this.tbPrice.TabIndex = 3;
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameProduct.BorderRadius = 6;
            this.tbNameProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameProduct.DefaultText = "";
            this.tbNameProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameProduct.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbNameProduct.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbNameProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameProduct.Enabled = false;
            this.tbNameProduct.FillColor = System.Drawing.Color.Tan;
            this.tbNameProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameProduct.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameProduct.ForeColor = System.Drawing.Color.Black;
            this.tbNameProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameProduct.Location = new System.Drawing.Point(417, 122);
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.PasswordChar = '\0';
            this.tbNameProduct.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbNameProduct.PlaceholderText = "Tên hàng hóa";
            this.tbNameProduct.SelectedText = "";
            this.tbNameProduct.Size = new System.Drawing.Size(393, 30);
            this.tbNameProduct.TabIndex = 1;
            // 
            // lblQuantitySold
            // 
            this.lblQuantitySold.AutoSize = true;
            this.lblQuantitySold.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitySold.ForeColor = System.Drawing.Color.Black;
            this.lblQuantitySold.Location = new System.Drawing.Point(290, 288);
            this.lblQuantitySold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantitySold.Name = "lblQuantitySold";
            this.lblQuantitySold.Size = new System.Drawing.Size(126, 18);
            this.lblQuantitySold.TabIndex = 6;
            this.lblQuantitySold.Text = "Số lượng đã bán";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(290, 370);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 18);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá tiền";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.ForeColor = System.Drawing.Color.Black;
            this.lblNameProduct.Location = new System.Drawing.Point(290, 127);
            this.lblNameProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(105, 18);
            this.lblNameProduct.TabIndex = 1;
            this.lblNameProduct.Text = "Tên hàng hóa";
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
            // tbCategory
            // 
            this.tbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCategory.BorderRadius = 6;
            this.tbCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCategory.DefaultText = "";
            this.tbCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCategory.DisabledState.FillColor = System.Drawing.Color.Tan;
            this.tbCategory.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCategory.Enabled = false;
            this.tbCategory.FillColor = System.Drawing.Color.Tan;
            this.tbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCategory.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCategory.ForeColor = System.Drawing.Color.Black;
            this.tbCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCategory.Location = new System.Drawing.Point(417, 202);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.PasswordChar = '\0';
            this.tbCategory.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCategory.PlaceholderText = "Loại hàng hóa";
            this.tbCategory.SelectedText = "";
            this.tbCategory.Size = new System.Drawing.Size(393, 30);
            this.tbCategory.TabIndex = 62;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(290, 208);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(38, 18);
            this.lblCategory.TabIndex = 63;
            this.lblCategory.Text = "Loại";
            // 
            // FormTTMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 548);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTTMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTTMH";
            this.Load += new System.EventHandler(this.FormTTMH_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2PictureBox productImg;
        private Guna.UI2.WinForms.Guna2TextBox tbQuantitySold;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbNameProduct;
        private System.Windows.Forms.Label lblQuantitySold;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNameProduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2TextBox tbIDProduct;
        private System.Windows.Forms.Label lblIDProduct;
        private Guna.UI2.WinForms.Guna2TextBox tbCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}