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
    public partial class FormHoaDonDatMon : Form
    {
        private int Count = 0;
        private string ID_Table = "";
        public static bool isConfirmPrintOrder = false;
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
            cbTable.DropDownStyle = ComboBoxStyle.DropDown;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
            List<CBB_TableItem> list = BLL_QLHD.Instance.GetCBB_TableItems();
            foreach (CBB_TableItem item in list)
            {
                cbTable.Items.Add(item);
            }
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
            if (ID_Table == "")
                MessageBox.Show("Vui lòng chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (panelMon.Controls.Count != 0)
            {
                foreach (FormMon formMon in panelMon.Controls)
                {
                    string ID_Product = formMon.GetID_Product();
                    Product product = BLL_QLBH.Instance.GetProductByID(ID_Product);
                    if (formMon.GetQuantityText() == "0" || formMon.GetQuantityText() == "" || ID_Table == "")
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
                            Convert.ToInt32(total.Remove(total.Length - 3, 3)), ID_Staff, ID_Customer, ID_Table);
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

                            if (isConfirmPrintOrder)
                            {
                                string[] orderInfo = BLL_QLHD.Instance.ShowOrderInfo(newID_Order.ToString());
                                string[][] orderDetailInfo = BLL_QLHD.Instance.ShowOrderTable(newID_Order.ToString());
                                File.WriteAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t\t\tTHANH TOÁN HÓA ĐƠN\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t\t==================================\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Mã hóa đơn: " + orderInfo[0] + "\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Tên nhân viên: " + orderInfo[1] + "\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Ngày đặt món: " + orderInfo[3] + "\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Tên khách hàng: " + orderInfo[2] + "\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t\t==================================\n");
                                for (int i = 0; i < orderDetailInfo.Length; i++)
                                {
                                    File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Tên món: " + orderDetailInfo[i][0] + "\tSố lượng: "
                                                    + orderDetailInfo[i][1] + "\tGiá tiền: " + orderDetailInfo[i][2] + "VNĐ\tThành tiền: " + orderDetailInfo[i][3] + "VNĐ\n");
                                }
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Mã bàn: " + orderInfo[5] + "\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Tầng: " + orderInfo[6] + "\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t\t==================================\n");
                                File.AppendAllText("C:\\Users\\lelon\\Desktop\\BTDotNetCK\\BTDotNetCK\\Order\\Order.txt", "\t Tổng tiền: " + orderInfo[4] + "VNĐ\n");

                                MessageBox.Show("Đặt món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Đặt món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            panelMon.Controls.Clear();
                            ID_Table = "";
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
            if (panelMon.Controls.Count > 0 || ID_Table != "")
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

        private void CbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTable.SelectedIndex >= 0)
            {
                ID_Table = ((CBB_TableItem)cbTable.SelectedItem).ID_Table.ToString();
            }
        }
    }
}