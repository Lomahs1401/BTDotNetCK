
namespace BTDotNetCK.GUI
{
    partial class FormQLKH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTTKH = new FontAwesome.Sharp.IconButton();
            this.btnHDKH = new FontAwesome.Sharp.IconButton();
            this.tbTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTSNV = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblSNVNam = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblSNVNu = new System.Windows.Forms.Label();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.dgvQLKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTTKH);
            this.panel1.Controls.Add(this.btnHDKH);
            this.panel1.Location = new System.Drawing.Point(833, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 119);
            this.panel1.TabIndex = 47;
            // 
            // btnTTKH
            // 
            this.btnTTKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTTKH.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTTKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnTTKH.FlatAppearance.BorderSize = 0;
            this.btnTTKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTKH.ForeColor = System.Drawing.Color.White;
            this.btnTTKH.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnTTKH.IconColor = System.Drawing.Color.White;
            this.btnTTKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTTKH.IconSize = 30;
            this.btnTTKH.Location = new System.Drawing.Point(1, 3);
            this.btnTTKH.Name = "btnTTKH";
            this.btnTTKH.Size = new System.Drawing.Size(142, 47);
            this.btnTTKH.TabIndex = 8;
            this.btnTTKH.Text = "Thông tin khách hàng";
            this.btnTTKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTTKH.UseVisualStyleBackColor = false;
            this.btnTTKH.MouseEnter += new System.EventHandler(this.BtnTTKH_MouseEnter);
            this.btnTTKH.MouseLeave += new System.EventHandler(this.BtnTTKH_MouseLeave);
            // 
            // btnHDKH
            // 
            this.btnHDKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHDKH.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHDKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHDKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnHDKH.FlatAppearance.BorderSize = 0;
            this.btnHDKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDKH.ForeColor = System.Drawing.Color.White;
            this.btnHDKH.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnHDKH.IconColor = System.Drawing.Color.White;
            this.btnHDKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHDKH.IconSize = 30;
            this.btnHDKH.Location = new System.Drawing.Point(1, 69);
            this.btnHDKH.Name = "btnHDKH";
            this.btnHDKH.Size = new System.Drawing.Size(142, 47);
            this.btnHDKH.TabIndex = 10;
            this.btnHDKH.Text = " Hóa đơn khách hàng";
            this.btnHDKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHDKH.UseVisualStyleBackColor = false;
            this.btnHDKH.MouseEnter += new System.EventHandler(this.BtnHDKH_MouseEnter);
            this.btnHDKH.MouseLeave += new System.EventHandler(this.BtnHDKH_MouseLeave);
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
            this.tbTK.PlaceholderText = "Tìm kiếm theo tên hoặc SĐT";
            this.tbTK.SelectedText = "";
            this.tbTK.Size = new System.Drawing.Size(250, 31);
            this.tbTK.TabIndex = 50;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.btnTTKH;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            this.guna2Elipse2.TargetControl = this.btnHDKH;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.lblTSNV);
            this.panelHeader.Controls.Add(this.pictureBox4);
            this.panelHeader.Controls.Add(this.lblSNVNam);
            this.panelHeader.Controls.Add(this.pictureBox5);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Controls.Add(this.pictureBox6);
            this.panelHeader.Controls.Add(this.lblSNVNu);
            this.panelHeader.Location = new System.Drawing.Point(11, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(403, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Số khách hàng nam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tổng số khách hàng";
            // 
            // lblTSNV
            // 
            this.lblTSNV.AutoSize = true;
            this.lblTSNV.BackColor = System.Drawing.Color.Transparent;
            this.lblTSNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSNV.ForeColor = System.Drawing.Color.Black;
            this.lblTSNV.Location = new System.Drawing.Point(97, 49);
            this.lblTSNV.Name = "lblTSNV";
            this.lblTSNV.Size = new System.Drawing.Size(29, 16);
            this.lblTSNV.TabIndex = 48;
            this.lblTSNV.Text = "100";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BTDotNetCK.Properties.Resources.shopping1;
            this.pictureBox4.Location = new System.Drawing.Point(181, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // lblSNVNam
            // 
            this.lblSNVNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSNVNam.AutoSize = true;
            this.lblSNVNam.BackColor = System.Drawing.Color.Transparent;
            this.lblSNVNam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNVNam.ForeColor = System.Drawing.Color.Black;
            this.lblSNVNam.Location = new System.Drawing.Point(452, 49);
            this.lblSNVNam.Name = "lblSNVNam";
            this.lblSNVNam.Size = new System.Drawing.Size(29, 16);
            this.lblSNVNam.TabIndex = 50;
            this.lblSNVNam.Text = "100";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::BTDotNetCK.Properties.Resources.women;
            this.pictureBox5.Location = new System.Drawing.Point(883, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(747, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Số khách hàng nữ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::BTDotNetCK.Properties.Resources.man_1;
            this.pictureBox6.Location = new System.Drawing.Point(542, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // lblSNVNu
            // 
            this.lblSNVNu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSNVNu.AutoSize = true;
            this.lblSNVNu.BackColor = System.Drawing.Color.Transparent;
            this.lblSNVNu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNVNu.ForeColor = System.Drawing.Color.Black;
            this.lblSNVNu.Location = new System.Drawing.Point(796, 49);
            this.lblSNVNu.Name = "lblSNVNu";
            this.lblSNVNu.Size = new System.Drawing.Size(29, 16);
            this.lblSNVNu.TabIndex = 52;
            this.lblSNVNu.Text = "100";
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
            this.btnTK.TabIndex = 51;
            this.btnTK.Text = "Tìm kiếm";
            // 
            // dgvQLKH
            // 
            this.dgvQLKH.AllowUserToAddRows = false;
            this.dgvQLKH.AllowUserToDeleteRows = false;
            this.dgvQLKH.AllowUserToResizeColumns = false;
            this.dgvQLKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvQLKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQLKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLKH.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvQLKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQLKH.ColumnHeadersHeight = 30;
            this.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameCustomer,
            this.Gender,
            this.Phone,
            this.Address});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKH.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQLKH.EnableHeadersVisualStyles = false;
            this.dgvQLKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLKH.Location = new System.Drawing.Point(11, 170);
            this.dgvQLKH.Name = "dgvQLKH";
            this.dgvQLKH.ReadOnly = true;
            this.dgvQLKH.RowHeadersVisible = false;
            this.dgvQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLKH.Size = new System.Drawing.Size(816, 413);
            this.dgvQLKH.TabIndex = 61;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLKH.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvQLKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLKH.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLKH.ThemeStyle.ReadOnly = true;
            this.dgvQLKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLKH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameCustomer
            // 
            this.NameCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCustomer.DataPropertyName = "NameCustomer";
            this.NameCustomer.HeaderText = "Họ và tên";
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // FormQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.dgvQLKH);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTTKH;
        private FontAwesome.Sharp.IconButton btnHDKH;
        private Guna.UI2.WinForms.Guna2TextBox tbTK;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTSNV;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblSNVNam;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblSNVNu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}