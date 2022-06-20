using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
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
    public partial class FormAddHang : Form
    {
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        public FormAddHang()
        {
            InitializeComponent();
        }

        private void BtnOKs_Click(object sender, EventArgs e)
        {
            bool isValidNameHang, isValidCategory, isValidPrice;
            isValidNameHang = BLL_QLBH.Instance.ValidateNameHang(tbNameHang.Text);
            // Validate name
            if (!isValidNameHang)
            {
                msgValidateNameHang.Text = "Tên hàng không được để trống";
                msgValidateNameHang.ForeColor = Color.Red;
            }
            else
            {
                msgValidateNameHang.Text = "";
                msgValidateNameHang.ForeColor = Color.Black;
            }
            // Validate category
            isValidCategory = BLL_QLBH.Instance.ValidateCategory(cbCategory.SelectedItem);
            if (!isValidCategory)
            {
                msgValidateCategory.Text = "Loại mặt hàng không được để trống";
                msgValidateCategory.ForeColor = Color.Red;
            }
            else
            {
                msgValidateCategory.Text = "";
                msgValidateCategory.ForeColor = Color.Black;
            }
            // Validate price
            isValidPrice = BLL_QLBH.Instance.ValidatePrice(tbPrice.Text);
            if (!isValidPrice)
            {
                msgValidatePrice.Text = "Giá tiền không hợp lệ";
                msgValidatePrice.ForeColor = Color.Red;
            }
            else
            {
                msgValidatePrice.Text = "";
                msgValidatePrice.ForeColor = Color.Black;
            }
            if (isValidNameHang && isValidCategory && isValidPrice)
            {
                StringBuilder newProductID;
                string ID_Product = BLL_QLBH.Instance.GetLastID();

                if (ID_Product == "P0000")
                {
                    newProductID = new StringBuilder(ID_Product);
                }
                else
                {
                    string code = ID_Product.Substring(1, ID_Product.Length - 1); // 0006
                    int num = Convert.ToInt32(code); // 6
                    num++; // 6 + 1 -> 7
                    string numStr = num.ToString(); // "7"
                    int lenNumStr = numStr.Length; // 1
                    newProductID = new StringBuilder(ID_Product); // P0006
                    newProductID = newProductID.Remove(newProductID.Length - lenNumStr, lenNumStr);// P000
                    newProductID.Append(numStr); // P000 + 7 => P0007
                }

                if (BLL_QLBH.Instance.AddProduct(GetAllInfo(newProductID.ToString())))
                {
                    MessageBox.Show("Thêm mặt hàng mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData(sender, e);
                    Dispose();
                }
                else
                    MessageBox.Show("Thêm thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            string nameHang, price;
            nameHang = tbNameHang.Text;
            price = tbPrice.Text;
            if (nameHang != "" || cbCategory.SelectedItem != null || price != "" || foodAvatar.Image != null)
            {
                DialogResult result = MessageBox.Show("Dữ liệu chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Dispose();
                else
                    return;
            }
            else
                Dispose();
        }

        private Product GetAllInfo(string newID_Product)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            return new Product
            {
                ID_Product = newID_Product,
                NameProduct = tbNameHang.Text,
                Category = cbCategory.SelectedItem.ToString(),
                QuantitySold = 0,
                Price = Convert.ToInt32(tbPrice.Text),
                Image = foodAvatar.ImageLocation.Remove(0, projectDirectory.Length + 1)
            };
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
        {
            if (foodAvatar.ImageLocation != null)
            {
                foodAvatar.ImageLocation = "";
                foodAvatar.Image = null;
            }
        }

        private void BtnFoodImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foodAvatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void TbNameHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOKs.PerformClick();
                e.Handled = true;
            }
        }

        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOKs.PerformClick();
                e.Handled = true;
            }
        }
    }
}
