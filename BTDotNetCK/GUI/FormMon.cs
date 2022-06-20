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
        public FormMon()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tbQuantity_TextChanged(object sender, EventArgs e)
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
                this.Parent.Refresh();
            }

            this.Parent.Refresh();

        }
    }
}