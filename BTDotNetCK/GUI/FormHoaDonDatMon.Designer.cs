
namespace BTDotNetCK.GUI
{
    partial class FormHoaDonDatMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDonDatMon));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.panelMon = new System.Windows.Forms.Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnAddMon = new Guna.UI2.WinForms.Guna2Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(905, 41);
            this.panelTitleBar.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BTDotNetCK.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(89, 4);
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
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt món";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
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
            this.btnCancel.Location = new System.Drawing.Point(486, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 36);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.btnOK.Location = new System.Drawing.Point(272, 448);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 36);
            this.btnOK.TabIndex = 57;
            this.btnOK.Text = "Đặt";
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // panelMon
            // 
            this.panelMon.AutoScroll = true;
            this.panelMon.Location = new System.Drawing.Point(0, 115);
            this.panelMon.Name = "panelMon";
            this.panelMon.Size = new System.Drawing.Size(905, 267);
            this.panelMon.TabIndex = 60;
            this.panelMon.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelMon_ControlAdded);
            this.panelMon.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PanelMon_ControlRemoved);
            this.panelMon.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMon_Paint);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Số lượng";
            // 
            // tbSL
            // 
            this.tbSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSL.DefaultText = "";
            this.tbSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSL.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbSL.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSL.Enabled = false;
            this.tbSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSL.Location = new System.Drawing.Point(10, 409);
            this.tbSL.Name = "tbSL";
            this.tbSL.PasswordChar = '\0';
            this.tbSL.PlaceholderText = "";
            this.tbSL.SelectedText = "";
            this.tbSL.Size = new System.Drawing.Size(70, 28);
            this.tbSL.TabIndex = 62;
            this.tbSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMoney
            // 
            this.tbMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMoney.DefaultText = "";
            this.tbMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMoney.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbMoney.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMoney.Enabled = false;
            this.tbMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMoney.Location = new System.Drawing.Point(705, 409);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.PasswordChar = '\0';
            this.tbMoney.PlaceholderText = "";
            this.tbMoney.SelectedText = "";
            this.tbMoney.Size = new System.Drawing.Size(159, 28);
            this.tbMoney.TabIndex = 64;
            this.tbMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tổng tiền";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btnAddMon
            // 
            this.btnAddMon.BorderRadius = 15;
            this.btnAddMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMon.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddMon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddMon.ForeColor = System.Drawing.Color.White;
            this.btnAddMon.Image = global::BTDotNetCK.Properties.Resources.icons8_plus_math_30px;
            this.btnAddMon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddMon.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnAddMon.Location = new System.Drawing.Point(368, 58);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnAddMon.Size = new System.Drawing.Size(145, 36);
            this.btnAddMon.TabIndex = 59;
            this.btnAddMon.Text = "Thêm món";
            this.btnAddMon.Click += new System.EventHandler(this.BtnAddMon_Click);
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.IntegralHeight = false;
            this.cbTable.Location = new System.Drawing.Point(638, 65);
            this.cbTable.MaxDropDownItems = 5;
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 21);
            this.cbTable.TabIndex = 65;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.CbTable_SelectedIndexChanged);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(581, 65);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(37, 21);
            this.lblTable.TabIndex = 66;
            this.lblTable.Text = "Bàn";
            // 
            // FormHoaDonDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 510);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelMon);
            this.Controls.Add(this.btnAddMon);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHoaDonDatMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDonDatMon_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnAddMon;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private System.Windows.Forms.Panel panelMon;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbMoney;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSL;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label lblTable;
    }
}