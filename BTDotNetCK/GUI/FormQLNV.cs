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
    public partial class FormQLNV : Form
    {
        private readonly string password;

        public FormQLNV(string password)
        {
            this.password = password;
            InitializeComponent();
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            dgvQLNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLNV.RowHeadersVisible = true;
            dgvQLNV.BorderStyle = BorderStyle.FixedSingle;
            List<Staff> listStaffs = BLL_QLNV.Instance.GetStaffs();
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("NameStaff", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("Phone", typeof(string)),
            });
            if (listStaffs != null)
            {
                for (int i = 0; i < listStaffs.Count; i++)
                {
                    DataRow dataRow = data.NewRow();
                    dataRow["ID"] = listStaffs[i].ID_Staff;
                    dataRow["NameStaff"] = listStaffs[i].NameStaff;
                    dataRow["Email"] = listStaffs[i].Email;
                    dataRow["Gender"] = listStaffs[i].Gender;
                    dataRow["Phone"] = listStaffs[i].Phone;
                    data.Rows.Add(dataRow);
                }
                dgvQLNV.DataSource = data;
                lblTSNV.Text = BLL_QLNV.Instance.GetNumberTotalStaff().ToString();
                lblSNVNam.Text = BLL_QLNV.Instance.GetNumberTotalMaleStaff().ToString();
                lblSNVNu.Text = BLL_QLNV.Instance.GetNumberTotalFemaleStaff().ToString();
            }
            else
            {
                dgvQLNV.DataSource = null;
                lblTSNV.Text = "0";
                lblSNVNam.Text = "0";
                lblSNVNu.Text = "0";
            }
        }

        private void BtnAddNV_Click(object sender, EventArgs e)
        {
            FormAddNV formAddNV = new FormAddNV();
            formAddNV.RefreshData += new FormAddNV.LoadData(FormQLNV_Load);
            formAddNV.ShowDialog();
        }

        private void BtnEditNV_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow == null)
                MessageBox.Show("Hệ thống chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                FormEditNV formEditNV = new FormEditNV(GetID_Staff());
                formEditNV.RefreshData += new FormEditNV.LoadData(FormQLNV_Load);
                formEditNV.ShowDialog();
            }
        }

        private void BtnDeleteNV_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow == null)
                MessageBox.Show("Hệ thống chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Staff staff = BLL_QLNV.Instance.GetStaffByID(GetID_Staff());
                DialogResult result = MessageBox.Show("Xác nhận xóa nhân viên " + staff.NameStaff + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormIdentify formIdentify = new FormIdentify(staff.AccountUsername, password, "");
                    formIdentify.RefreshData += new FormIdentify.LoadData(FormQLNV_Load);
                    formIdentify.Show();
                }
                else
                    return;
            }
        }

        private void DgvQLNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTNV(GetID_Staff()).ShowDialog();
        }

        private string GetID_Staff()
        {
            return dgvQLNV.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void TbTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTK.PerformClick();
                e.Handled = true;
            }
        }

        private void BtnTK_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("NameStaff", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("Phone", typeof(string)),
            });
            if (tbTK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin nhân viên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbTK.Text.Contains("S00"))
            {
                Staff staff = BLL_QLNV.Instance.GetStaffByID(tbTK.Text);
                if (staff == null)
                {
                    MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow dataRow = data.NewRow();
                    dataRow["ID"] = staff.ID_Staff;
                    dataRow["NameStaff"] = staff.NameStaff;
                    dataRow["Email"] = staff.Email;
                    dataRow["Gender"] = staff.Gender;
                    dataRow["Phone"] = staff.Phone;
                    data.Rows.Add(dataRow);
                    dgvQLNV.DataSource = data;
                }
            }
            else if (Validators.IsValidPhoneNumber(tbTK.Text, Validators.PHONE_REGEX))
            {
                Staff staff = BLL_QLNV.Instance.GetStaffByPhone(tbTK.Text);
                if (staff == null)
                {
                    MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow dataRow = data.NewRow();
                    dataRow["ID"] = staff.ID_Staff;
                    dataRow["NameStaff"] = staff.NameStaff;
                    dataRow["Email"] = staff.Email;
                    dataRow["Gender"] = staff.Gender;
                    dataRow["Phone"] = staff.Phone;
                    data.Rows.Add(dataRow);
                    dgvQLNV.DataSource = data;
                }
            }
            else
            {
                List<Staff> listStaffs = BLL_QLNV.Instance.GetStaffByName(tbTK.Text);
                if (listStaffs == null)
                {
                    MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < listStaffs.Count; i++)
                    {
                        DataRow dataRow = data.NewRow();
                        dataRow["ID"] = listStaffs[i].ID_Staff;
                        dataRow["NameStaff"] = listStaffs[i].NameStaff;
                        dataRow["Email"] = listStaffs[i].Email;
                        dataRow["Gender"] = listStaffs[i].Gender;
                        dataRow["Phone"] = listStaffs[i].Phone;
                        data.Rows.Add(dataRow);
                    }
                    dgvQLNV.DataSource = data;
                }
            }
        }
    }
}