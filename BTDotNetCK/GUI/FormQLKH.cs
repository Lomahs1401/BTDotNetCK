using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using BTDotNetCK.Validator;
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
    public partial class FormQLKH : Form
    {
        public FormQLKH()
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

        private void BtnHDKH_MouseEnter(object sender, EventArgs e)
        {
            btnHDKH.BackColor = RGBColors.color4;
        }

        private void BtnTTKH_MouseLeave(object sender, EventArgs e)
        {
            btnTTKH.BackColor = Color.RoyalBlue;
        }

        private void BtnHDKH_MouseLeave(object sender, EventArgs e)
        {
            btnHDKH.BackColor = Color.RoyalBlue;
        }

        private void BtnTTKH_MouseEnter(object sender, EventArgs e)
        {
            btnTTKH.BackColor = RGBColors.color4;
        }

        private void FormQLKH_Load(object sender, EventArgs e)
        {
            dgvQLKH.BorderStyle = BorderStyle.FixedSingle;
            dgvQLKH.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLKH.RowHeadersVisible = true;
            List<Customer> listCustomers = BLL_QLKH.Instance.GetCustomers();
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("NameCustomer", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("Phone", typeof(string)),
                new DataColumn("Address", typeof(string)),
            });
            if (listCustomers != null)
            {
                for (int i = 0; i < listCustomers.Count; i++)
                {
                    DataRow dataRow = data.NewRow();
                    dataRow["ID"] = listCustomers[i].ID_Customer;
                    dataRow["NameCustomer"] = listCustomers[i].NameCustomer;
                    dataRow["Gender"] = listCustomers[i].Gender;
                    dataRow["Phone"] = listCustomers[i].Phone;
                    dataRow["Address"] = listCustomers[i].Address;
                    data.Rows.Add(dataRow);
                }
                dgvQLKH.DataSource = data;
                totalCustomer.Text = BLL_QLKH.Instance.GetNumberTotalCustomer().ToString();
                maleCustomer.Text = BLL_QLKH.Instance.GetNumberTotalMaleCustomer().ToString();
                femaleCustomer.Text = BLL_QLKH.Instance.GetNumberTotalFemaleCustomer().ToString();
            }
            else
            {
                dgvQLKH.DataSource = null;
                totalCustomer.Text = "0";
                maleCustomer.Text = "0";
                femaleCustomer.Text = "0";
            }
        }

        private void DgvQLKH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTKH(GetID_Product()).ShowDialog();
        }

        private string GetID_Product()
        {
            return dgvQLKH.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void BtnTK_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("NameCustomer", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("Phone", typeof(string)),
                new DataColumn("Address", typeof(string)),
            });
            if (tbTK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin khách hàng cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbTK.Text.Contains("KH0"))
            {
                Customer customer = BLL_QLKH.Instance.GetCustomerByID(tbTK.Text);
                if (customer == null)
                {
                    MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow dataRow = data.NewRow();
                    dataRow["ID"] = customer.ID_Customer;
                    dataRow["NameCustomer"] = customer.NameCustomer;
                    dataRow["Gender"] = customer.Gender;
                    dataRow["Phone"] = customer.Phone;
                    dataRow["Address"] = customer.Address;
                    data.Rows.Add(dataRow);
                    dgvQLKH.DataSource = data;
                }
            }
            else if (Validators.IsValidPhoneNumber(tbTK.Text, Validators.PHONE_REGEX))
            {
                Customer customer = BLL_QLKH.Instance.GetCustomerByPhone(tbTK.Text);
                if (customer == null)
                {
                    MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow dataRow = data.NewRow();
                    dataRow["ID"] = customer.ID_Customer;
                    dataRow["NameCustomer"] = customer.NameCustomer;
                    dataRow["Gender"] = customer.Gender;
                    dataRow["Phone"] = customer.Phone;
                    dataRow["Address"] = customer.Address;
                    data.Rows.Add(dataRow);
                    dgvQLKH.DataSource = data;
                }
            }
            else
            {
                List<Customer> listCustomers = BLL_QLKH.Instance.GetCustomersByName(tbTK.Text);
                if (listCustomers == null)
                {
                    MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < listCustomers.Count; i++)
                    {
                        DataRow dataRow = data.NewRow();
                        dataRow["ID"] = listCustomers[i].ID_Customer;
                        dataRow["NameCustomer"] = listCustomers[i].NameCustomer;
                        dataRow["Gender"] = listCustomers[i].Gender;
                        dataRow["Phone"] = listCustomers[i].Phone;
                        dataRow["Address"] = listCustomers[i].Address;
                        data.Rows.Add(dataRow);
                    }
                    dgvQLKH.DataSource = data;
                }
            }
        }

        private void TbTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTK.PerformClick();
                e.Handled = true;
            }
        }
    }
}