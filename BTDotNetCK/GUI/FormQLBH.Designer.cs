
namespace BTDotNetCK.GUI
{
    partial class FormQLBH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.remainingQuantity = new System.Windows.Forms.Label();
            this.lblRemainingQuantity = new System.Windows.Forms.Label();
            this.quantitySold = new System.Windows.Forms.Label();
            this.lblQuantitySold = new System.Windows.Forms.Label();
            this.totalProduct = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSXS = new FontAwesome.Sharp.IconButton();
            this.btnHDTN = new FontAwesome.Sharp.IconButton();
            this.tbTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvQLBH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH)).BeginInit();
            this.SuspendLayout();
            // 
            // remainingQuantity
            // 
            this.remainingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remainingQuantity.AutoSize = true;
            this.remainingQuantity.BackColor = System.Drawing.Color.Transparent;
            this.remainingQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingQuantity.ForeColor = System.Drawing.Color.Black;
            this.remainingQuantity.Location = new System.Drawing.Point(802, 55);
            this.remainingQuantity.Name = "remainingQuantity";
            this.remainingQuantity.Size = new System.Drawing.Size(29, 16);
            this.remainingQuantity.TabIndex = 44;
            this.remainingQuantity.Text = "100";
            // 
            // lblRemainingQuantity
            // 
            this.lblRemainingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemainingQuantity.AutoSize = true;
            this.lblRemainingQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblRemainingQuantity.Location = new System.Drawing.Point(749, 24);
            this.lblRemainingQuantity.Name = "lblRemainingQuantity";
            this.lblRemainingQuantity.Size = new System.Drawing.Size(136, 16);
            this.lblRemainingQuantity.TabIndex = 43;
            this.lblRemainingQuantity.Text = "Số mặt hàng còn lại";
            // 
            // quantitySold
            // 
            this.quantitySold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantitySold.AutoSize = true;
            this.quantitySold.BackColor = System.Drawing.Color.Transparent;
            this.quantitySold.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySold.ForeColor = System.Drawing.Color.Black;
            this.quantitySold.Location = new System.Drawing.Point(449, 55);
            this.quantitySold.Name = "quantitySold";
            this.quantitySold.Size = new System.Drawing.Size(29, 16);
            this.quantitySold.TabIndex = 42;
            this.quantitySold.Text = "100";
            // 
            // lblQuantitySold
            // 
            this.lblQuantitySold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuantitySold.AutoSize = true;
            this.lblQuantitySold.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitySold.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitySold.ForeColor = System.Drawing.Color.Black;
            this.lblQuantitySold.Location = new System.Drawing.Point(398, 24);
            this.lblQuantitySold.Name = "lblQuantitySold";
            this.lblQuantitySold.Size = new System.Drawing.Size(137, 16);
            this.lblQuantitySold.TabIndex = 41;
            this.lblQuantitySold.Text = "Số mặt hàng đã bán";
            // 
            // totalProduct
            // 
            this.totalProduct.AutoSize = true;
            this.totalProduct.BackColor = System.Drawing.Color.Transparent;
            this.totalProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProduct.ForeColor = System.Drawing.Color.Black;
            this.totalProduct.Location = new System.Drawing.Point(88, 55);
            this.totalProduct.Name = "totalProduct";
            this.totalProduct.Size = new System.Drawing.Size(29, 16);
            this.totalProduct.TabIndex = 40;
            this.totalProduct.Text = "100";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduct.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProduct.Location = new System.Drawing.Point(40, 24);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(122, 16);
            this.lblTotalProduct.TabIndex = 39;
            this.lblTotalProduct.Text = "Tổng số mặt hàng";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSXS);
            this.panel1.Controls.Add(this.btnHDTN);
            this.panel1.Location = new System.Drawing.Point(832, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 118);
            this.panel1.TabIndex = 48;
            // 
            // btnSXS
            // 
            this.btnSXS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSXS.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSXS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSXS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnSXS.FlatAppearance.BorderSize = 0;
            this.btnSXS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSXS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXS.ForeColor = System.Drawing.Color.White;
            this.btnSXS.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
            this.btnSXS.IconColor = System.Drawing.Color.White;
            this.btnSXS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSXS.IconSize = 30;
            this.btnSXS.Location = new System.Drawing.Point(0, 3);
            this.btnSXS.Name = "btnSXS";
            this.btnSXS.Size = new System.Drawing.Size(142, 47);
            this.btnSXS.TabIndex = 12;
            this.btnSXS.Text = "Sắp xếp";
            this.btnSXS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSXS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSXS.UseVisualStyleBackColor = false;
            this.btnSXS.MouseEnter += new System.EventHandler(this.BtnSXS_MouseEnter);
            this.btnSXS.MouseLeave += new System.EventHandler(this.BtnSXS_MouseLeave);
            // 
            // btnHDTN
            // 
            this.btnHDTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHDTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHDTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHDTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnHDTN.FlatAppearance.BorderSize = 0;
            this.btnHDTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDTN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDTN.ForeColor = System.Drawing.Color.White;
            this.btnHDTN.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnHDTN.IconColor = System.Drawing.Color.White;
            this.btnHDTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHDTN.IconSize = 30;
            this.btnHDTN.Location = new System.Drawing.Point(0, 67);
            this.btnHDTN.Name = "btnHDTN";
            this.btnHDTN.Size = new System.Drawing.Size(142, 47);
            this.btnHDTN.TabIndex = 13;
            this.btnHDTN.Text = "  Hóa đơn trong ngày";
            this.btnHDTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHDTN.UseVisualStyleBackColor = false;
            this.btnHDTN.MouseEnter += new System.EventHandler(this.BtnHDTN_MouseEnter);
            this.btnHDTN.MouseLeave += new System.EventHandler(this.BtnHDTN_MouseLeave);
            // 
            // tbTK
            // 
            this.tbTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbTK.BorderRadius = 15;
            this.tbTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTK.DefaultText = "";
            this.tbTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.tbTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTK.Location = new System.Drawing.Point(11, 133);
            this.tbTK.Name = "tbTK";
            this.tbTK.PasswordChar = '\0';
            this.tbTK.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbTK.PlaceholderText = "Tìm kiếm theo ID hoặc tên mặt hàng";
            this.tbTK.SelectedText = "";
            this.tbTK.Size = new System.Drawing.Size(250, 31);
            this.tbTK.TabIndex = 49;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.btnSXS;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            this.guna2Elipse2.TargetControl = this.btnHDTN;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblQuantitySold);
            this.panelHeader.Controls.Add(this.lblTotalProduct);
            this.panelHeader.Controls.Add(this.totalProduct);
            this.panelHeader.Controls.Add(this.quantitySold);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.lblRemainingQuantity);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.remainingQuantity);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Location = new System.Drawing.Point(11, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 59;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(168, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(891, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Location = new System.Drawing.Point(541, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // dgvQLBH
            // 
            this.dgvQLBH.AllowUserToAddRows = false;
            this.dgvQLBH.AllowUserToDeleteRows = false;
            this.dgvQLBH.AllowUserToResizeColumns = false;
            this.dgvQLBH.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvQLBH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQLBH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBH.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvQLBH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQLBH.ColumnHeadersHeight = 30;
            this.dgvQLBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameProduct,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBH.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQLBH.EnableHeadersVisualStyles = false;
            this.dgvQLBH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLBH.Location = new System.Drawing.Point(12, 170);
            this.dgvQLBH.Name = "dgvQLBH";
            this.dgvQLBH.ReadOnly = true;
            this.dgvQLBH.RowHeadersVisible = false;
            this.dgvQLBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBH.Size = new System.Drawing.Size(816, 413);
            this.dgvQLBH.TabIndex = 60;
            this.dgvQLBH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLBH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLBH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLBH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLBH.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvQLBH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLBH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLBH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLBH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLBH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBH.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLBH.ThemeStyle.ReadOnly = true;
            this.dgvQLBH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLBH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLBH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLBH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLBH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "Tên mặt hàng";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnTK
            // 
            this.btnTK.BorderRadius = 15;
            this.btnTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Image = global::BTDotNetCK.Properties.Resources.icons8_search_20px;
            this.btnTK.Location = new System.Drawing.Point(264, 132);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(141, 31);
            this.btnTK.TabIndex = 50;
            this.btnTK.Text = "Tìm kiếm";
            // 
            // FormQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.dgvQLBH);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label remainingQuantity;
        private System.Windows.Forms.Label lblRemainingQuantity;
        private System.Windows.Forms.Label quantitySold;
        private System.Windows.Forms.Label lblQuantitySold;
        private System.Windows.Forms.Label totalProduct;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSXS;
        private FontAwesome.Sharp.IconButton btnHDTN;
        private Guna.UI2.WinForms.Guna2TextBox tbTK;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}