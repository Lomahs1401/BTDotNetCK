using BTDotNetCK.BLL;
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

namespace BTDotNetCK.GUI
{
    public partial class FormQLBH : Form
    {
        public FormQLBH()
        {
            InitializeComponent();
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

        private void BtnSXS_MouseEnter(object sender, EventArgs e)
        {
            btnSXS.BackColor = RGBColors.color4;
        }

        private void BtnHDTN_MouseEnter(object sender, EventArgs e)
        {
            btnHDTN.BackColor = RGBColors.color4;
        }

        private void BtnSXS_MouseLeave(object sender, EventArgs e)
        {
            btnSXS.BackColor = Color.RoyalBlue;
        }

        private void BtnHDTN_MouseLeave(object sender, EventArgs e)
        {
            btnHDTN.BackColor = Color.RoyalBlue;
        }

        private void FormQLBH_Load(object sender, EventArgs e)
        {
            dgvQLBH.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLBH.RowHeadersVisible = true;
            List<Product> listProducts = BLL_QLBH.Instance.GetProducts();
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("NameProduct", typeof(string)),
                new DataColumn("QuantitySold", typeof(int)),
                new DataColumn("Price", typeof(int)),
            });
            for (int i = 0; i < listProducts.Count; i++)
            {
                DataRow dataRow = data.NewRow();
                dataRow["ID"] = listProducts[i].ID_Product;
                dataRow["NameProduct"] = listProducts[i].NameProduct;
                dataRow["QuantitySold"] = listProducts[i].QuantitySold;
                dataRow["Price"] = listProducts[i].Price;
                data.Rows.Add(dataRow);
            }
            dgvQLBH.DataSource = data;
        }

        private void DgvQLBH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTMH(GetID_Product()).ShowDialog();
        }

        private string GetID_Product()
        {
            return dgvQLBH.CurrentRow.Cells["ID"].Value.ToString();
        }
    }
}