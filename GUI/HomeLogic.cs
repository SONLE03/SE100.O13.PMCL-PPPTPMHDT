using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace GUI
{
    //SỬA CÁC LỆNH SELECT TRONG NÀY THEO THUỘC TÍNH TRONG DATABASE NHÁ!!!!!!!

    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class DBLogic : DbConnection
    {

        //Properties
        private DateTime startdate;
        private DateTime enddate;
        private int NumsOfDays;
        public int NumCustomer { get; set; }
        public int NumEmployee { get; set; }
        public int NumSupplier { get; set; }
        public int NumProduct { get; set; }
        public List<KeyValuePair<string, int>> TopProduct { get; private set; }
        public List<RevenueByDate> TotalRevenues { get; private set; }
        public int NumOrder { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        //Constructor
        public DBLogic()
        {

        }

        //3 first panels, info: Total Bill - Total Revenue - Total Profit
        private void GetNumItem()
        {

            using (var connect = GetConnection())
            {
                connect.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = connect;
                    //Get total num of Customers
                    com.CommandText = @"select count(CUS_ID) from CUSTOMER";
                    NumCustomer = (int)com.ExecuteScalar();

                    //Get total num of Customers
                    com.CommandText = @"select count(EMP_ID) from EMPLOYEE";
                    NumEmployee = (int)com.ExecuteScalar();

                    //Get total num of Suppliers
                    com.CommandText = "select count(S_ID) from SUPPLIER";
                    NumSupplier = (int)com.ExecuteScalar();

                    //Get total num of PRODUCTS (selling products)
                    com.CommandText = "select count(PRO_ID) from PRODUCT";
                    NumProduct = (int)com.ExecuteNonQuery();

                    //Get total num of OrderS 
                    com.CommandText = @"select count(B_ID) from [BILL]" +
                                        "where B_DATE between @startdate and @enddate";
                    com.Parameters.Add("@startdate", System.Data.SqlDbType.DateTime).Value = startdate;
                    com.Parameters.Add("@enddate", System.Data.SqlDbType.DateTime).Value = enddate;
                    NumOrder = (int)com.ExecuteScalar();
                }
            }
        }

        //Area Chart of Revenue group by Custom Time
        private void GetOrderAnalys()
        {
            TotalRevenues = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            using (var connect = GetConnection())
            {
                connect.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = connect;
                    com.CommandText = @"select B_DATE, sum(B_PRICE)
                                        from [BILL]
                                        where B_DATE between @startdate and @enddate
                                        group by B_DATE";
                    com.Parameters.Add("@startdate", System.Data.SqlDbType.DateTime).Value = startdate;
                    com.Parameters.Add("@enddate", System.Data.SqlDbType.DateTime).Value = enddate;

                    var read = com.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, int>>();
                    while (read.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, int>((DateTime)read[0], (int)read[1]));
                        TotalRevenue += (int)read[1];
                    }
                    TotalProfit = TotalRevenue * 0.2m;
                    read.Close();


                    //Group by Hours
                    if (NumsOfDays <= 1)
                    {
                        //Đây là Ngôn gữ LINQ được tích hợp bởi Microsoft, hỗ trợ ver .NET3.5 - truy vấn dl từ tập dl
                        TotalRevenues = (from orderList in resultTable
                                         group orderList by orderList.Key.ToString("hh tt")
                                        into order
                                         select new RevenueByDate
                                         {
                                             Date = order.Key,
                                             TotalAmount = order.Sum(amount => amount.Value)
                                         }).ToList();
                    }
                    //Group by Days
                    else if (NumsOfDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            TotalRevenues.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }
                    //Group by Weeks
                    else if (NumsOfDays <= 92)
                    {
                        TotalRevenues = (from orderList in resultTable
                                         group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                             orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                         select new RevenueByDate
                                         {
                                             Date = "Week " + order.Key.ToString(),
                                             TotalAmount = order.Sum(amount => amount.Value)
                                         }).ToList();
                    }
                    //Group by Months
                    else if (NumsOfDays <= (365 * 2))
                    {
                        bool isyear;
                        if (NumsOfDays <= 365)
                        {
                            isyear = true;
                        }
                        else isyear = false;
                        TotalRevenues = (from orderList in resultTable
                                         group orderList by orderList.Key.ToString("MMM yyyy")
                                        into order
                                         select new RevenueByDate
                                         {
                                             Date = isyear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                             TotalAmount = order.Sum(amount => amount.Value)
                                         }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        TotalRevenues = (from orderList in resultTable
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
        }

        //Dounut chart of Select top 5 bestselling products
        private void GetProductAnalys()
        {
            TopProduct = new List<KeyValuePair<string, int>>();
            Stock = new List<KeyValuePair<string, int>>();

            using (var connect = GetConnection())
            {
                connect.Open();
                using (var com = new SqlCommand())
                {
                    SqlDataReader reader;
                    com.Connection = connect;

                    //Get top 6 best seller
                    com.CommandText = @"select top 6 P.PRO_NAME, sum(BILLINFO.QUANTITY) as Q
                                        from BILLINFO
                                        inner join PRODUCT P on P.PRO_ID = BILLINFO.PRO_ID
                                        inner join BILL B on B.B_ID = BILLINFO.B_ID
                                        where B_DATE between @startdate and @enddate
                                        group by P.PRO_NAME
                                        order by Q desc";
                    com.Parameters.Add("@startdate", System.Data.SqlDbType.DateTime).Value = startdate;
                    com.Parameters.Add("@enddate", System.Data.SqlDbType.DateTime).Value = enddate;
                    reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProduct.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    
                }
            }
        }

        //Load Data
        public bool LoadData(DateTime startdate, DateTime enddate)
        {
            enddate = new DateTime(enddate.Year, enddate.Month, enddate.Day, enddate.Hour, enddate.Minute, 59);
            if (startdate != this.startdate || enddate != this.enddate)
            {
                this.startdate = startdate;
                this.enddate = enddate;
                this.NumsOfDays = (enddate - startdate).Days;

                GetNumItem();
                GetProductAnalys();
                GetOrderAnalys();
                Console.WriteLine("Refresh data: {0} - {1}", startdate.ToString(), enddate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Fail to referesh because invalid date");
                return false;
            }
        }
    }
}
