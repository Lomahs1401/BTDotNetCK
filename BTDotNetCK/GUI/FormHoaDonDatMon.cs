using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    public partial class FormHoaDonDatMon : Form
    {
        private readonly string accountUsername;

        public FormHoaDonDatMon(string accountUsername)
        {
            this.accountUsername = accountUsername;
            InitializeComponent();
            timer1.Start();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void BtnAddMon_Click(object sender, EventArgs e)
        {
            FormMon b = new FormMon();
            b.TopLevel = false;
            b.FormBorderStyle = FormBorderStyle.None;
            b.Dock = DockStyle.Top;
            panelMon.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            long money = 0;
            foreach (FormMon b in panelMon.Controls)
            {


                if (b.GetMoney() == 0)
                    money += 0;
                else
                    money += b.GetMoney();

            }
            tbSL.Text = panelMon.Controls.Count.ToString();
            tbMoney.Text = money.ToString();

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}