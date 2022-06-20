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
    public partial class FormEditHang : Form
    {
        private readonly string ID_Product;
        private string oldPath;
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        public FormEditHang(string ID_Product)
        {
            this.ID_Product = ID_Product;
            InitializeComponent();
        }

        private void FormEditHang_Load(object sender, EventArgs e)
        {
            ShowInfo(BLL_QLBH.Instance.GetProductByID(ID_Product));
        }

        private void ShowInfo(Product product)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbNameHang.Text = product.NameProduct;
            cbCategory.SelectedItem = product.Category;
            tbPrice.Text = product.Price.ToString();
            if (product.Image == DBNull.Value.ToString())
                foodAvatar.Image = null;
            else
            {
                foodAvatar.ImageLocation = product.Image;
                oldPath = foodAvatar.ImageLocation;
                foodAvatar.Image = Image.FromFile(Path.Combine(projectDirectory, product.Image));
            }
        }

        private void BtnOKs_Click(object sender, EventArgs e)
        {
            bool isValidNameHang, isValidCategory, isValidPrice, isNewImage = false;
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
            // Validate image
            if (foodAvatar.ImageLocation == DBNull.Value.ToString())
            {
                if (foodAvatar.Image != null)
                    isNewImage = true;
            }
            else
            {
                if (foodAvatar.ImageLocation != oldPath)
                    isNewImage = true;
            }
            if (isValidNameHang && isValidCategory && isValidPrice)
            {
                DialogResult result = MessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BLL_QLBH.Instance.UpdateProduct(GetAllInfo(ID_Product, isNewImage)))
                    {
                        MessageBox.Show("Sửa thông tin mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(sender, e);
                        Dispose();
                    }
                    else
                        MessageBox.Show("Sửa thông tin thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return;
            }
            else
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            bool isNewNameHang, isNewCategory, isNewPrice, isNewImage = false;
            Product oldProduct = BLL_QLBH.Instance.GetProductByID(ID_Product);
            isNewNameHang = oldProduct.NameProduct != tbNameHang.Text;
            isNewCategory = oldProduct.Category != cbCategory.SelectedItem.ToString();
            isNewPrice = oldProduct.Price.ToString() != tbPrice.Text;
            if (oldProduct.Image == DBNull.Value.ToString())
            {
                if (foodAvatar.Image != null)
                    isNewImage = true;
            }
            else
            {
                if (foodAvatar.ImageLocation != oldProduct.Image)
                    isNewImage = true;
            }
            if (isNewNameHang || isNewCategory || isNewPrice || isNewImage)
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

        private Product GetAllInfo(string newID_Product, bool isNewImage)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            if (isNewImage)
            {
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
            else
            {
                return new Product
                {
                    ID_Product = newID_Product,
                    NameProduct = tbNameHang.Text,
                    Category = cbCategory.SelectedItem.ToString(),
                    QuantitySold = 0,
                    Price = Convert.ToInt32(tbPrice.Text),
                    Image = oldPath
                };
            }
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
                btnSave.PerformClick();
                e.Handled = true;
            }
        }

        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }
    }
}
