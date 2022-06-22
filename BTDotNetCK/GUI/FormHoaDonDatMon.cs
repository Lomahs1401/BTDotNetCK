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
    public partial class FormHoaDonDatMon : Form
    {
        private int Count = 0;
        static int z = 0;
        private readonly string accountUsername;
        public static string ID_Customer = "";

        public FormHoaDonDatMon(string accountUsername)
        {
            this.accountUsername = accountUsername;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void FormHoaDonDatMon_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
        }

        private void BtnAddMon_Click(object sender, EventArgs e)
        {
            FormMon b = new FormMon(z + 1)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Top,
            };
            z++;
            panelMon.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Tinh();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            bool check = true;
            int[] error = new int[100];
            int indexError = 0;
            if (panelMon.Controls.Count != 0)
            {
                foreach(FormMon formMon in panelMon.Controls)
                {
                    string ID_Product = formMon.GetID_Product();
                    Product product = BLL_QLBH.Instance.GetProductByID(ID_Product);
                    if (formMon.GetQuantityText() == "0" || formMon.GetQuantityText() == "")
                    {
                        check = false;
                        error[indexError] = panelMon.Controls.Count - panelMon.Controls.GetChildIndex(formMon);
                        indexError++;
                    }
                }
                if (check)
                {
                    new FormAuthenticateCustomer().ShowDialog();
                    if (ID_Customer == "")
                        return;
                    else
                    {
                        StringBuilder newID_Order;
                        string ID_Order = BLL_QLHD.Instance.GetLastID_Order();
                        string ID_Staff = BLL_QLNV.Instance.GetIDByAccountUsername(accountUsername);
                        if (ID_Order == null)
                            newID_Order = new StringBuilder("HD0000");
                        else
                        {
                            string id = ID_Order; // HD0001
                            string code = id.Substring(2, id.Length - 2); // 0001
                            int num = Convert.ToInt32(code); // 1
                            num++; // 1 + 1 -> 2
                            string numStr = num.ToString(); // "2"
                            int lenNumStr = numStr.Length; // 1
                            newID_Order = new StringBuilder(id.Remove(id.Length - lenNumStr, lenNumStr));// HD000
                            newID_Order.Append(numStr); // HD000 + 2 => HD0002
                        }

                        string total = tbMoney.Text;
                        Order newOrder = new Order(newID_Order.ToString(), DateTime.Now, 0.0, 
                            Convert.ToInt32(total.Remove(total.Length - 3, 3)), ID_Staff, ID_Customer, "T0001");
                        if (BLL_QLHD.Instance.AddOrder(newOrder))
                        {
                            OrderDetail newOrderDetail;

                            foreach (FormMon formMon in panelMon.Controls)
                            {
                                newOrderDetail = new OrderDetail(newID_Order.ToString(), formMon.GetID_Product(), formMon.GetQuantity(), (int)formMon.GetMoney());
                                if (!BLL_QLHD.Instance.AddOrderDetail(newOrderDetail))
                                {
                                    MessageBox.Show("Đặt món thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                string ID_Product = formMon.GetID_Product();
                                Product product = BLL_QLBH.Instance.GetProductByID(ID_Product);
                                product.QuantitySold += formMon.GetQuantity();
                                if (!BLL_QLBH.Instance.UpdateQuantityProduct(ID_Product, product.QuantitySold))
                                    return;
                            }

                            MessageBox.Show("Đặt món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panelMon.Controls.Clear();
                        }
                        else
                            MessageBox.Show("Đặt món thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ID_Customer = "";
                }
                else
                {
                    int o = 0;
                    int[] v = new int[indexError];
                    for (int i = indexError - 1; i >= 0; i--)
                    {
                        v[i] = error[o];
                        o++;
                    }
                    MessageBox.Show("Xuất hiện sai sót tại dòng: " + string.Join(", ", v), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chưa có món nào được đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (panelMon.Controls.Count > 0)
            {
                DialogResult result = MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Dispose();
                else
                    return;
            }
            else
                Dispose();
        }

        private void PanelMon_Paint(object sender, PaintEventArgs e)
        {
            Tinh();
        }

        private void Tinh()
        {
            int quantity = 0;
            long total = 0;
            foreach (FormMon formMon in panelMon.Controls)
            {
                if (formMon.GetQuantityText() == "")
                    quantity += 0;
                else
                    quantity += formMon.GetQuantity();
                if (formMon.GetMoney() == 0)
                    total += 0;
                else
                    total += formMon.GetMoney();
            }
            tbMoney.Text = total.ToString() + "VNĐ";
            tbSL.Text = panelMon.Controls.Count.ToString();
        }

        private void PanelMon_ControlAdded(object sender, ControlEventArgs e)
        {
            Tinh();
        }

        private void PanelMon_ControlRemoved(object sender, ControlEventArgs e)
        {
            z = panelMon.Controls.Count;
            Count--;
            foreach (FormMon formMon in panelMon.Controls)
            {
                formMon.SetIndex(panelMon.Controls.Count - panelMon.Controls.GetChildIndex(formMon));
                formMon.SetIndexText();
            }
            Tinh();
        }
    }
}