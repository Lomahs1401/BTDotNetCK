
namespace BTDotNetCK.GUI
{
    partial class FormQLMH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.drinkCategory = new System.Windows.Forms.Label();
            this.lblDrinkCategory = new System.Windows.Forms.Label();
            this.foodCategory = new System.Windows.Forms.Label();
            this.lblFoodCategory = new System.Windows.Forms.Label();
            this.totalCategory = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.tbTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvQLMH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.rjDropDownMenuSXMH = new BTDotNetCK.GUI.RJDropDownMenu(this.components);
            this.giáMặtHàngTăngDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáMặtHàngGiảmDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new FontAwesome.Sharp.IconButton();
            this.btnAddProduct = new FontAwesome.Sharp.IconButton();
            this.btnEditProduct = new FontAwesome.Sharp.IconButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMH)).BeginInit();
            this.rjDropDownMenuSXMH.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // drinkCategory
            // 
            this.drinkCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drinkCategory.AutoSize = true;
            this.drinkCategory.BackColor = System.Drawing.Color.Transparent;
            this.drinkCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkCategory.ForeColor = System.Drawing.Color.Black;
            this.drinkCategory.Location = new System.Drawing.Point(787, 55);
            this.drinkCategory.Name = "drinkCategory";
            this.drinkCategory.Size = new System.Drawing.Size(29, 16);
            this.drinkCategory.TabIndex = 44;
            this.drinkCategory.Text = "100";
            // 
            // lblDrinkCategory
            // 
            this.lblDrinkCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrinkCategory.AutoSize = true;
            this.lblDrinkCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblDrinkCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkCategory.ForeColor = System.Drawing.Color.Black;
            this.lblDrinkCategory.Location = new System.Drawing.Point(729, 24);
            this.lblDrinkCategory.Name = "lblDrinkCategory";
            this.lblDrinkCategory.Size = new System.Drawing.Size(145, 16);
            this.lblDrinkCategory.TabIndex = 43;
            this.lblDrinkCategory.Text = "Số mặt hàng đồ uống";
            // 
            // foodCategory
            // 
            this.foodCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.foodCategory.AutoSize = true;
            this.foodCategory.BackColor = System.Drawing.Color.Transparent;
            this.foodCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCategory.ForeColor = System.Drawing.Color.Black;
            this.foodCategory.Location = new System.Drawing.Point(437, 55);
            this.foodCategory.Name = "foodCategory";
            this.foodCategory.Size = new System.Drawing.Size(29, 16);
            this.foodCategory.TabIndex = 42;
            this.foodCategory.Text = "100";
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFoodCategory.AutoSize = true;
            this.lblFoodCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodCategory.ForeColor = System.Drawing.Color.Black;
            this.lblFoodCategory.Location = new System.Drawing.Point(381, 24);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(141, 16);
            this.lblFoodCategory.TabIndex = 41;
            this.lblFoodCategory.Text = "Số mặt hàng thức ăn";
            // 
            // totalCategory
            // 
            this.totalCategory.AutoSize = true;
            this.totalCategory.BackColor = System.Drawing.Color.Transparent;
            this.totalCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCategory.ForeColor = System.Drawing.Color.Black;
            this.totalCategory.Location = new System.Drawing.Point(88, 55);
            this.totalCategory.Name = "totalCategory";
            this.totalCategory.Size = new System.Drawing.Size(29, 16);
            this.totalCategory.TabIndex = 40;
            this.totalCategory.Text = "100";
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
            this.tbTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTK_KeyPress);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblFoodCategory);
            this.panelHeader.Controls.Add(this.lblTotalProduct);
            this.panelHeader.Controls.Add(this.totalCategory);
            this.panelHeader.Controls.Add(this.foodCategory);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.lblDrinkCategory);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.drinkCategory);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Location = new System.Drawing.Point(11, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 59;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BTDotNetCK.Properties.Resources.Set_Product;
            this.pictureBox3.Location = new System.Drawing.Point(168, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.product;
            this.pictureBox1.Location = new System.Drawing.Point(880, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::BTDotNetCK.Properties.Resources.cookies;
            this.pictureBox2.Location = new System.Drawing.Point(528, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // dgvQLMH
            // 
            this.dgvQLMH.AllowUserToAddRows = false;
            this.dgvQLMH.AllowUserToDeleteRows = false;
            this.dgvQLMH.AllowUserToResizeColumns = false;
            this.dgvQLMH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLMH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLMH.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvQLMH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLMH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLMH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLMH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLMH.ColumnHeadersHeight = 30;
            this.dgvQLMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameProduct,
            this.Category,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLMH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLMH.EnableHeadersVisualStyles = false;
            this.dgvQLMH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLMH.Location = new System.Drawing.Point(12, 170);
            this.dgvQLMH.Name = "dgvQLMH";
            this.dgvQLMH.ReadOnly = true;
            this.dgvQLMH.RowHeadersVisible = false;
            this.dgvQLMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLMH.Size = new System.Drawing.Size(816, 413);
            this.dgvQLMH.TabIndex = 60;
            this.dgvQLMH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLMH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLMH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLMH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLMH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLMH.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvQLMH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLMH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLMH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLMH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLMH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLMH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLMH.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLMH.ThemeStyle.ReadOnly = true;
            this.dgvQLMH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLMH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLMH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLMH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLMH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLMH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLMH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLMH.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLBH_RowHeaderMouseClick);
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
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Loại";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "QuantitySold";
            this.Quantity.HeaderText = "Số lượng đã bán";
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
            this.btnTK.Click += new System.EventHandler(this.BtnTK_Click);
            // 
            // rjDropDownMenuSXMH
            // 
            this.rjDropDownMenuSXMH.IsMainMenu = false;
            this.rjDropDownMenuSXMH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giáMặtHàngTăngDầnToolStripMenuItem,
            this.giáMặtHàngGiảmDầnToolStripMenuItem});
            this.rjDropDownMenuSXMH.MenuItemHeight = 25;
            this.rjDropDownMenuSXMH.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropDownMenuSXMH.Name = "rjDropDownMenuSXMH";
            this.rjDropDownMenuSXMH.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropDownMenuSXMH.Size = new System.Drawing.Size(204, 48);
            // 
            // giáMặtHàngTăngDầnToolStripMenuItem
            // 
            this.giáMặtHàngTăngDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.giáMặtHàngTăngDầnToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.giáMặtHàngTăngDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.giáMặtHàngTăngDầnToolStripMenuItem.Name = "giáMặtHàngTăngDầnToolStripMenuItem";
            this.giáMặtHàngTăngDầnToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.giáMặtHàngTăngDầnToolStripMenuItem.Text = "Giá mặt hàng tăng dần";
            this.giáMặtHàngTăngDầnToolStripMenuItem.Click += new System.EventHandler(this.GiáMặtHàngTăngDầnToolStripMenuItem_Click);
            // 
            // giáMặtHàngGiảmDầnToolStripMenuItem
            // 
            this.giáMặtHàngGiảmDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.giáMặtHàngGiảmDầnToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.giáMặtHàngGiảmDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.giáMặtHàngGiảmDầnToolStripMenuItem.Name = "giáMặtHàngGiảmDầnToolStripMenuItem";
            this.giáMặtHàngGiảmDầnToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.giáMặtHàngGiảmDầnToolStripMenuItem.Text = "Giá mặt hàng giảm dần";
            this.giáMặtHàngGiảmDầnToolStripMenuItem.Click += new System.EventHandler(this.GiáMặtHàngGiảmDầnToolStripMenuItem_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptions.BackColor = System.Drawing.Color.Gainsboro;
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.btnDeleteProduct);
            this.panelOptions.Controls.Add(this.btnAddProduct);
            this.panelOptions.Controls.Add(this.btnEditProduct);
            this.panelOptions.Location = new System.Drawing.Point(829, 170);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(149, 149);
            this.panelOptions.TabIndex = 61;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteProduct.IconColor = System.Drawing.Color.White;
            this.btnDeleteProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteProduct.IconSize = 30;
            this.btnDeleteProduct.Location = new System.Drawing.Point(3, 97);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(143, 44);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddProduct.IconColor = System.Drawing.Color.White;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProduct.IconSize = 30;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 1);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(143, 44);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditProduct.IconColor = System.Drawing.Color.White;
            this.btnEditProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProduct.IconSize = 30;
            this.btnEditProduct.Location = new System.Drawing.Point(3, 49);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(143, 44);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // FormQLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.dgvQLMH);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.tbTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.FormQLMH_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMH)).EndInit();
            this.rjDropDownMenuSXMH.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label drinkCategory;
        private System.Windows.Forms.Label lblDrinkCategory;
        private System.Windows.Forms.Label foodCategory;
        private System.Windows.Forms.Label lblFoodCategory;
        private System.Windows.Forms.Label totalCategory;
        private System.Windows.Forms.Label lblTotalProduct;
        private Guna.UI2.WinForms.Guna2TextBox tbTK;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private RJDropDownMenu rjDropDownMenuSXMH;
        private System.Windows.Forms.ToolStripMenuItem giáMặtHàngTăngDầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáMặtHàngGiảmDầnToolStripMenuItem;
        private System.Windows.Forms.Panel panelOptions;
        private FontAwesome.Sharp.IconButton btnDeleteProduct;
        private FontAwesome.Sharp.IconButton btnAddProduct;
        private FontAwesome.Sharp.IconButton btnEditProduct;
    }
}