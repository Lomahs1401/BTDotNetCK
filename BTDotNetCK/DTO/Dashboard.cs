using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumCategoryProduct { get; private set; }
        public int NumQuantitySold { get; private set; }
        public List<KeyValuePair<string, int>> TopProductList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockProductList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal ToTalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public Dashboard()
        {

        }

        private void GetNumberItems()
        {
            // Số khách hàng
            NumCustomers = BLL_QLDT.Instance.GetNumCustomers();
            // Số mặt hàng hiện tại
            NumCategoryProduct = BLL_QLDT.Instance.GetNumCategoryProduct();
            // Số lượng hàng đã bán
            NumQuantitySold = BLL_QLDT.Instance.GetNumQuantitySold();
            // Số hóa đơn
            NumOrders = BLL_QLDT.Instance.GetNumOrders();
        }

        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            ToTalRevenue = 0;
            TotalProfit = 0;

            List<Revenue> listRevenues = BLL_QLDT.Instance.GetListRevenues(startDate, endDate);
            List<KeyValuePair<DateTime, decimal>> result = new List<KeyValuePair<DateTime, decimal>>();
            if (listRevenues == null)
            {
                ToTalRevenue = 0;
                TotalProfit = 0;
            }
            else
            {
                for (int i = 0; i < listRevenues.Count; i++)
                {
                    result.Add(new KeyValuePair<DateTime, decimal>(listRevenues[i].OrderDate, listRevenues[i].TotalAmount));
                    ToTalRevenue += listRevenues[i].TotalAmount;
                }
                TotalProfit = ToTalRevenue * 0.2m; // 20%
                // Group by hours
                if (numberDays <= 1)
                {
                    GrossRevenueList = (from orderList in result
                                        group orderList by orderList.Key.ToString("HH:mm")
                                        into order
                                        select new RevenueByDate
                                        {
                                            Date = order.Key,
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                }
                // Group by days
                else if (numberDays <= 30)
                {
                    foreach (var item in result)
                    {
                        GrossRevenueList.Add(new RevenueByDate()
                        {
                            Date = item.Key.ToString("dd/MM"),
                            TotalAmount = item.Value
                        });
                    }
                }
                // Group by weeks
                else if (numberDays <= 92)
                {
                    GrossRevenueList = (from orderList in result
                                        group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                            orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                        into order
                                        select new RevenueByDate
                                        {
                                            Date = "Tuần " + order.Key.ToString(),
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                }
                //Group by months
                else if (numberDays <= (365 * 2))
                {
                    bool isYear = numberDays <= 365;
                    GrossRevenueList = (from orderList in result
                                        group orderList by orderList.Key.ToString("MMM yyyy")
                                        into order
                                        select new RevenueByDate
                                        {
                                            Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                }
                // Group by years
                else
                {
                    GrossRevenueList = (from orderList in result
                                        group orderList by orderList.Key.ToString("yyyy")
                                        into order
                                        select new RevenueByDate
                                        {
                                            Date = order.Key,
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                }
            }
        }

        private void GetProductAnalisys()
        {
            TopProductList = new List<KeyValuePair<string, int>>();
            UnderstockProductList = new List<KeyValuePair<string, int>>();
            {
                var topProducts = BLL_QLDT.Instance.GetTopProducts(startDate, endDate);
                if (topProducts != null)
                {
                    for (int i = 0; i < topProducts.Count; i++)
                    {
                        TopProductList.Add(new KeyValuePair<string, int>(topProducts[i].NameProduct, topProducts[i].QuantitySold));
                    }
                }

                var understockProducts = BLL_QLDT.Instance.GetUnderstockProduct(startDate, endDate);
                if (understockProducts != null)
                {
                    for (int i = 0; i < understockProducts.Count; i++)
                    {
                        UnderstockProductList.Add(new KeyValuePair<string, int>(understockProducts[i].NameProduct, understockProducts[i].QuantitySold));
                    }
                } 
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetOrderAnalisys();
                GetProductAnalisys();
                return true;
            }
            else
                return false;
        }
    }
}
