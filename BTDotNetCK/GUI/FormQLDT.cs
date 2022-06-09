using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BTDotNetCK.GUI
{

    public partial class FormQLDT : Form
    {
        private Button btnCurrent;
        //private readonly Dashboard model;
        public FormQLDT()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            //model = new Dashboard();
            //LoadData();
            
            btnOK.Hide();
            ActivateButton(btnLast7Days, Color.FromArgb(107, 83, 255));
        }

        private void FormQLDT_Load(object sender, EventArgs e)
        {
            dgvHHTLI.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvHHTLI.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }

        //private void LoadData()
        //{
        //    bool refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
        //    if (refreshData)
        //    {
        //        numberOrder.Text = model.NumOrders.ToString();
        //        totalRevenue.Text = model.ToTalRevenue.ToString("##,#") + "VNĐ";
        //        totalProfit.Text = model.TotalProfit.ToString("##,#") + "VNĐ";
        //        numberCustomer.Text = model.NumCustomers.ToString();
        //        remainingBook.Text = model.NumRemainingBooks.ToString();
        //        sellBook.Text = model.NumSellBooks.ToString();

        //        chartGrossRevenue.DataSource = model.GrossRevenueList;
        //        chartGrossRevenue.DataBind();

        //        chartTopFiveBooks.DataSource = model.TopBookLists;
        //        chartTopFiveBooks.DataBind();

        //        dgvHHTLI.DataSource = model.UnderstockBookList;
        //    }
        //}

        private void DisableButton()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.Transparent;
                if (btnCurrent == btnCustomDate)
                {
                    btnOK.Hide();
                }
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                btnCurrent = (Button)senderBtn;
                btnCurrent.BackColor = color;
                btnCurrent.ForeColor = Color.Gainsboro;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;

                btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
            }
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

        private void LblStartDate_Click(object sender, EventArgs e)
        {
            if (btnCurrent == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void LblEndDate_Click(object sender, EventArgs e)
        {
            if (btnCurrent == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        private void BtnCustomDate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            btnOK.Show();
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            dtpStartDate.Value = DateTime.Today.AddHours(0);
            dtpEndDate.Value = DateTime.Now;
            //LoadData();
        }

        private void BtnLast7Days_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            //LoadData();
        }

        private void BtnThisMonth_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            //LoadData();
        }

        private void BtnThisQuarter_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            if (DateTime.Today.Month >= 1 && DateTime.Today.Month <= 3)
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 1, 1);
            else if (DateTime.Today.Month >= 4 && DateTime.Today.Month <= 6)
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 4, 1);
            else if (DateTime.Today.Month >= 7 && DateTime.Today.Month <= 9)
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 7, 1);
            else
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 10, 1);
            dtpEndDate.Value = DateTime.Now;
            //LoadData();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //LoadData();
        }
    }
}
