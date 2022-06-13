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
    public partial class FormTTNV : Form
    {
        private readonly string ID_Staff;
        public FormTTNV(string ID_Staff)
        {
            InitializeComponent();
            this.ID_Staff = ID_Staff;
        }

        private void FormTTNV_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            ShowInfo(BLL_QLNV.Instance.GetStaffByID(ID_Staff));
        }

        private void ShowInfo(Staff staff)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbIDNV.Text = staff.ID_Staff;
            tbNameNV.Text = staff.NameStaff;
            tbEmailNV.Text = staff.Email;
            tbBD.Text = staff.DateOfBirth.ToString("dd/MM/yyyy");
            tbStartDate.Text = staff.StartDate.ToString("dd/MM/yyyy");
            if (staff.EndDate == null || staff.EndDate.Value.ToString("dd/MM/yyyy") == "01/01/1900")
                tbEndDate.Text = "";
            else
                tbEndDate.Text = staff.EndDate.Value.ToString("dd/MM/yyyy");
            tbGender.Text = staff.Gender;
            tbCMNDNV.Text = staff.ID_Card;
            tbAddressNV.Text = staff.Address;
            tbSDTNV.Text = staff.Phone;
            if (staff.Image == DBNull.Value.ToString())
                avatar.Image = null;
            else
                avatar.Image = Image.FromFile(Path.Combine(projectDirectory, staff.Image));
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
