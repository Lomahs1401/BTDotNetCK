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
    public partial class FormMon : Form
    {
        private int index;
        public FormMon(int index)
        {
            InitializeComponent();
            this.index = index;
            Index.Text = index.ToString();
            if (index > 9)
                Index.Location = new Point(3, 16);
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbQuantity_TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(tbQuantity.Text);
            foreach (byte b in asciiBytes)
            {
                if (b > 57 || b < 47)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Chỉ được nhập số", "Lỗi ");
                tbQuantity.Text = "";
            }
            else
            {
                if (tbQuantity.Text != "")
                {
                    if (tbPrice.Text == "")
                    {
                        MessageBox.Show("ID món không hợp lệ", "Lỗi ");
                        tbQuantity.Text = "";
                    }
                    else
                        tbSum.Text = (Convert.ToInt64(tbQuantity.Text) * Convert.ToInt64(tbPrice.Text)).ToString();
                }
                else
                    tbSum.Text = "";
                Parent.Refresh();
            }
            Parent.Refresh();
        }

        private void TbID_TextChanged(object sender, EventArgs e)
        {
            Product product = BLL_QLBH.Instance.GetProductByID(tbID.Text);
            if (product != null)
            {
                tbID.Text = product.ID_Product;
                tbName.Text = product.NameProduct;
                tbPrice.Text = product.Price.ToString();
            }
            else
            {
                tbName.Text = "";
                tbPrice.Text = "";
            }
        }

        public string GetID_Product()
        {
            return tbID.Text;
        }

        public string GetNameProduct()
        {
            return tbName.Text;
        }

        public string GetQuantityText()
        {
            return tbQuantity.Text;
        }

        public int GetQuantity()
        {
            if (tbQuantity.Text != "")
                return Convert.ToInt32(tbQuantity.Text);
            else
                return 0;
        }

        public int GetPrice()
        {
            if (tbPrice.Text != "")
                return Convert.ToInt32(tbPrice.Text);
            else
                return 0;
        }

        public long GetMoney()
        {
            long Sum = 0;
            if (tbSum.Text != "")
                Sum = Convert.ToInt64(tbSum.Text);
            else
                Sum = 0;
            return Sum;
        }

        public void SetIndexText()
        {
            Index.Text = index.ToString();
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }
    }
}