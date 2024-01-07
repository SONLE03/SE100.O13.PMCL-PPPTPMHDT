using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace DAL
{
    public class DALAnalysis
    {
        private static DALAnalysis instance;
        private DateTime startDate;
        private DateTime endDate;
        private int numberOfDays;
        public static DALAnalysis Instance
        {
            get
            {
                if (instance == null) instance = new DALAnalysis();
                return instance;
            }
            set => instance = value;
        }
        public List<TopSellingDrinkDTO> topSellingDrinks()
        {
            try
            {
                var topSellingDrinks = CFEntities.Instance.DRINKS
                    .GroupJoin(
                        CFEntities.Instance.BILL_DETAIL,
                        drink => drink.id,
                        detail => detail.DrinksID,
                        (drink, details) => new TopSellingDrinkDTO
                        {
                            DrinkId = drink.DrinksID,
                            DrinkName = drink.DrinksName,
                            TotalQuantity = (int)(details.Sum(detail => detail.Quantity) ?? 0)
                        })
                    .OrderByDescending(result => result.TotalQuantity)
                    .Take(6)
                    .ToList();
                return topSellingDrinks;
            }
            catch
            {
                return null;
            }
        }

        public List<CustomRevenueDTO> MonthlyRevenues(int year)
        {
            try
            {
                var monthlyRevenues = CFEntities.Instance.BILLs
                .Where(bill => bill.BillDate.Year == year)
                .GroupBy(bill => new { Month = bill.BillDate.Month })
                .Select(group => new
                {
                    Month = group.Key.Month,
                    TotalRevenue = (double)group.Sum(bill => bill.Total)
                })
                .OrderBy(result => result.Month)
                .ToList()
                .Select(result => new CustomRevenueDTO
                {
                    Month = result.Month,
                    Date = $"{result.Month}/{year}",
                    TotalRevenue = result.TotalRevenue
                })
                .ToList();

                return monthlyRevenues;
            }catch { return null; }
        }
        public List<CustomRevenueDTO> dayOfMonthRevenueDTOs(int month, int year)
        {
            try
            {
                var customRevenues = CFEntities.Instance.BILLs
                .Where(bill => bill.BillDate.Month == month && bill.BillDate.Year == year)
                .GroupBy(bill => EntityFunctions.TruncateTime(bill.BillDate))
                .Select(group => new
                {
                    Day = EntityFunctions.TruncateTime(group.Key.Value),
                    TotalRevenue = (double)group.Sum(bill => bill.Total)
                })
                .OrderBy(result => result.Day)
                .ToList()
                .Select(result => new CustomRevenueDTO
                {
                    Date = result.Day?.ToString("dd/MM/yyyy"),
                    TotalRevenue = result.TotalRevenue
                })
                .ToList();
                    return customRevenues;
            }
            catch { return null; }
             

        }
        public List<CustomRevenueDTO> yearsRevenueDTOs(int startYear, int endYear)
        {
            try
            {
                DateTime startDate = new DateTime(startYear, 1, 1);
                DateTime endDate = new DateTime(endYear, 12, 31);

                var customRevenues = CFEntities.Instance.BILLs
                    .Where(bill => bill.BillDate >= startDate && bill.BillDate <= endDate)
                    .GroupBy(bill => bill.BillDate.Year)
                    .Select(group => new
                    {
                        Year = group.Key,
                        TotalRevenue = (double)group.Sum(bill => bill.Total)
                    })
                    .OrderBy(result => result.Year)
                    .ToList()
                    .Select(result => new CustomRevenueDTO
                    {
                        Date = result.Year.ToString(),
                        TotalRevenue = result.TotalRevenue
                    })
                    .ToList();

                return customRevenues;
            }
            catch { return null; }
            
        }
        public List<DrinkReportDTO> DrinkReports(DateTime date)
        {
            try
            {
                DateTime startDate = new DateTime(date.Year, date.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                var drinkReports = CFEntities.Instance.BILL_DETAIL
                    .Where(billDetail => billDetail.BILL.BillDate >= startDate && billDetail.BILL.BillDate <= endDate)
                    .GroupBy(billDetail => new { drinkId = billDetail.DrinksID, drinkName = billDetail.DRINK.DrinksName })
                    .Select(group => new DrinkReportDTO
                    {
                        drinkId = group.Key.drinkId,
                        drinkName = group.Key.drinkName,
                        drinkQuantity = (int)group.Sum(billDetail => billDetail.Quantity),
                        drinkTotalPrice = (double)group.Sum(billDetail => billDetail.Amount)
                    })
                    .ToList();
                return drinkReports;
            }
            catch { return null; }
         
        }
    }
}
