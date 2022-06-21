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
    public partial class FormTTKH : Form
    {
        private readonly string ID_Customer;

        public FormTTKH(string ID_Customer)
        {
            this.ID_Customer = ID_Customer;
            InitializeComponent();
        }

        private void FormTTKH_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            ShowInfo(BLL_QLKH.Instance.GetCustomerByID(ID_Customer));
        }

        private void ShowInfo(Customer customer)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbIDCustomer.Text = customer.ID_Customer;
            tbNameCustomer.Text = customer.NameCustomer;
            tbGender.Text = customer.Gender;
            tbPhone.Text = customer.Phone;
            tbPhone.Text = customer.Address;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
