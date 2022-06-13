using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using BTDotNetCK.GUI;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    public partial class FormMainMenuQTV : Form
    {
        private IconButton btnCurrent;
        private readonly Panel btnLeftBorder;
        private Form currentChildForm;
        private readonly string accountUsername;
        private readonly string password;
        private readonly string nameStaff;

        public FormMainMenuQTV(string accountUsername, string password, string nameStaff)
        {
            InitializeComponent();
            btnLeftBorder = new Panel
            {
                Size = new Size(7, 77)
            };
            panelMenu.Controls.Add(btnLeftBorder);

            //Form
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            this.accountUsername = accountUsername;
            this.password = password;
            this.nameStaff = nameStaff;
            ShowUserInfo();
        }

        private void ShowUserInfo()
        {
            lblAdmin.Text = accountUsername;
            lblAdminName.Text = nameStaff;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                btnCurrent = (IconButton)senderBtn;
                btnCurrent.BackColor = Color.Silver;
                btnCurrent.ForeColor = color;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = color;
                btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight;

                btnLeftBorder.BackColor = color;
                btnLeftBorder.Location = new Point(0, btnCurrent.Location.Y);
                btnLeftBorder.Visible = true;
                btnLeftBorder.BringToFront();

                // Icon Current Child Form
                iconCurrentChildForm.IconChar = btnCurrent.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(255, 255, 255);
                btnCurrent.ForeColor = Color.Black;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = Color.Black;
                btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            btnLeftBorder.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        private void BtnQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormQLNV(password));
        }

        private void BtnQLBH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormQLBH());
        }

        private void BtnQLDT_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormQLDT());
        }

        private void BtnQLKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormQLKH());
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else WindowState = FormWindowState.Normal;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = RGBColors.color5;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.BackColor = RGBColors.color1;
        }

        private void BtnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = RGBColors.color6;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormMainMenuQTV_Load(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();

            lblDate.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
            string img = BLL_QLNV.Instance.GetImage(accountUsername);
            if (img == DBNull.Value.ToString())
                AdminPicture.Image = null;
            else
                AdminPicture.Image = Image.FromFile(Path.Combine(projectDirectory, img));
            guna2ShadowForm1.SetShadowForm(this);
            lblTitleChildForm.Text = "Home";
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.ForeColor = Color.FromArgb(128, 64, 0);

        }

        private void AdminPicture_Click(object sender, EventArgs e)
        {
            rjAdminUserSettingMenu.Show(AdminPicture, new Point(0, AdminPicture.Height));
        }

        private void LblAdmin_Click(object sender, EventArgs e)
        {
            AdminPicture_Click(sender, e);
        }

        private void RjAdminUserSettingMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (đăngXuấtToolStripMenuItem.Selected == true)
            {
                Hide();
                new FormLogin().Show();
                Close();
            }
            if (chỉnhSửaTàiKhoảnToolStripMenuItem.Selected == true)
            {
                DisableButton();
                iconCurrentChildForm.IconChar = IconChar.Cog;
                btnLeftBorder.Visible = false;
                FormSettingAccount formSettingAccount = new FormSettingAccount(accountUsername, password, 0);
                formSettingAccount.RefreshData += new FormSettingAccount.LoadData(FormMainMenuQTV_Load);
                OpenChildForm(formSettingAccount);
            }
        }
    }
}