using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using DoAnPBL3.Models;
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
    public partial class FormTTMH : Form
    {
        private readonly string ID_Product;

        public FormTTMH(string ID_Product)
        {
            InitializeComponent();
            this.ID_Product = ID_Product;
        }

        private void FormTTMH_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            ShowInfo(BLL_QLBH.Instance.GetProductByID(ID_Product));
        }

        private void ShowInfo(Product product)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbIDProduct.Text = product.ID_Product;
            tbNameProduct.Text = product.NameProduct;
            tbCategory.Text = product.Category;
            tbQuantitySold.Text = product.QuantitySold.ToString();
            tbPrice.Text = product.Price.ToString("##,#") + "VNĐ";
            if (product.Image == DBNull.Value.ToString())
                productImg.Image = null;
            else
                productImg.Image = Image.FromFile(Path.Combine(projectDirectory, product.Image));
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
