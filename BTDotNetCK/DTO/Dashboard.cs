using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
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
        public int NumRemainingBooks { get; private set; }
        public int NumSellBooks { get; private set; }
        public List<KeyValuePair<string, int>> TopBookLists { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockBookList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal ToTalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public Dashboard()
        {

        }

        //private void GetNumberItems()
        //{
        //    using (BookStoreContext context = new BookStoreContext())
        //    {
        //        // Số khách hàng
        //        NumCustomers = context.Customers.Count();
        //        // Số sách đã bán
        //        NumSellBooks = context.OrderDetails
        //            .Select(book => book.Quantity)
        //            .Sum();
        //        // Số lượng sách còn
        //        NumRemainingBooks = context.Books
        //            .Sum(book => book.Quantity);
        //        // Số hóa đơn
        //        NumOrders = context.Orders
        //            .Where(order => order.OrderDate >= startDate)
        //            .Where(order => order.OrderDate <= endDate)
        //            .Count();
        //    }
        //}

        //private void GetOrderAnalisys()
        //{
        //    GrossRevenueList = new List<RevenueByDate>();
        //    ToTalRevenue = 0;
        //    TotalProfit = 0;

        //    using (BookStoreContext context = new BookStoreContext())
        //    {
        //        var revenue = context.Orders
        //            .Where(order => order.OrderDate >= startDate)
        //            .Where(order => order.OrderDate <= endDate)
        //            .GroupBy(order => order.OrderDate)
        //            .Select(order => new
        //            {
        //                OrderDate = order.Key,
        //                TotalAmount = order.Sum(x => x.TotalPrice)
        //            })
        //            .ToList();
        //        var result = new List<KeyValuePair<DateTime, decimal>>();
        //        for (int i = 0; i < revenue.Count; i++)
        //        {
        //            result.Add(new KeyValuePair<DateTime, decimal>(revenue[i].OrderDate, revenue[i].TotalAmount));
        //            ToTalRevenue += revenue[i].TotalAmount;
        //        }
        //        TotalProfit = ToTalRevenue * 0.2m; // 20%
        //        // Group by hours
        //        if (numberDays <= 1)
        //        {
        //            GrossRevenueList = (from orderList in result
        //                                group orderList by orderList.Key.ToString("HH:mm")
        //                                into order
        //                                select new RevenueByDate
        //                                {
        //                                    Date = order.Key,
        //                                    TotalAmount = order.Sum(amount => amount.Value)
        //                                }).ToList();
        //        }
        //        // Group by days
        //        if (numberDays <= 30)
        //        {
        //            foreach (var item in result)
        //            {
        //                GrossRevenueList.Add(new RevenueByDate()
        //                {
        //                    Date = item.Key.ToString("dd/MM"),
        //                    TotalAmount = item.Value
        //                });
        //            }
        //        }
        //        // Group by weeks
        //        else if (numberDays <= 92)
        //        {
        //            GrossRevenueList = (from orderList in result
        //                                group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
        //                                    orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
        //                               into order
        //                                select new RevenueByDate
        //                                {
        //                                    Date = "Tuần " + order.Key.ToString(),
        //                                    TotalAmount = order.Sum(amount => amount.Value)
        //                                }).ToList();
        //        }
        //        //Group by months
        //        else if (numberDays <= (365 * 2))
        //        {
        //            bool isYear = numberDays <= 365;
        //            GrossRevenueList = (from orderList in result
        //                                group orderList by orderList.Key.ToString("MMM yyyy")
        //                                into order
        //                                select new RevenueByDate
        //                                {
        //                                    Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
        //                                    TotalAmount = order.Sum(amount => amount.Value)
        //                                }).ToList();
        //        }
        //        // Group by years
        //        else
        //        {
        //            GrossRevenueList = (from orderList in result
        //                                group orderList by orderList.Key.ToString("yyyy")
        //                                into order
        //                                select new RevenueByDate
        //                                {
        //                                    Date = order.Key,
        //                                    TotalAmount = order.Sum(amount => amount.Value)
        //                                }).ToList();
        //        }
        //    }
        //}

        //private void GetBookAnalisys()
        //{
        //    TopBookLists = new List<KeyValuePair<string, int>>();
        //    UnderstockBookList = new List<KeyValuePair<string, int>>();
        //    using (BookStoreContext context = new BookStoreContext())
        //    {
        //        var topFiveBooks = context.OrderDetails
        //            .Join(
        //                context.Books,
        //                orderDetail => orderDetail.ID_Book,
        //                book => book.ID_Book,
        //                (orderDetail, book) => new
        //                {
        //                    book.NameBook,
        //                    orderDetail.Quantity,
        //                    orderDetail.ID_Order
        //                })
        //            .Join(
        //                context.Orders,
        //                orderDetail => orderDetail.ID_Order,
        //                order => order.ID_Order,
        //                (orderDetail, order) => new
        //                {
        //                    orderDetail.NameBook,
        //                    orderDetail.Quantity,
        //                    order.OrderDate
        //                })
        //            .Where(orderDetail => orderDetail.OrderDate >= startDate)
        //            .Where(orderDetail => orderDetail.OrderDate <= endDate)
        //            .GroupBy(orderDetail => orderDetail.NameBook)
        //            .Select(orderDetail => new
        //            {
        //                NameBook = orderDetail.Key,
        //                Quantity = orderDetail.Sum(o => o.Quantity)
        //            })
        //            .OrderByDescending(o => o.Quantity)
        //            .Take(5)
        //            .ToList();
        //        for (int i = 0; i < topFiveBooks.Count; i++)
        //        {
        //            TopBookLists.Add(new KeyValuePair<string, int>(topFiveBooks[i].NameBook, topFiveBooks[i].Quantity));
        //        }

        //        var understockBooks = context.Books
        //            .Where(book => book.Quantity <= 6)
        //            .OrderBy(book => book.Quantity)
        //            .ToList();
        //        for (int i = 0; i < understockBooks.Count; i++)
        //        {
        //            UnderstockBookList.Add(new KeyValuePair<string, int>(understockBooks[i].NameBook, understockBooks[i].Quantity));
        //        }
        //    }
        //}

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                numberDays = (endDate - startDate).Days;
                //GetNumberItems();
                //GetOrderAnalisys();
                //GetBookAnalisys();
                return true;
            }
            else
                return false;
        }
    }
}
