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
        private readonly string ID_Employee;
        public FormTTNV(string ID_Employee)
        {
            InitializeComponent();
            this.ID_Employee = ID_Employee;
        }

        private void FormTTNV_Load(object sender, EventArgs e)
        {

        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
