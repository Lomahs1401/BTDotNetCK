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
        public FormHoaDonDatMon()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnAddMon_Click(object sender, EventArgs e)
        {
            panelMon.Controls.Add(new FormMon());
        }

        private void timer1_Tick(object sender, EventArgs e)
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
    }
}