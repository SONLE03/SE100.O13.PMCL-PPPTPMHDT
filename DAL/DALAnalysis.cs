using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALAnalysis
    {
        private static DALAnalysis instance;

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

        public List<MonthlyRevenueDTO> MonthlyRevenues()
        {
            int currentYear = DateTime.Now.Year;

            var monthlyRevenues = CFEntities.Instance.BILLs
                .Where(bill => bill.BillDate.Year == currentYear)
                .GroupBy(bill => new { Month = bill.BillDate.Month })
                .Select(group => new MonthlyRevenueDTO
                {
                    Month = group.Key.Month,
                    TotalRevenue = (double)group.Sum(bill => bill.Total)
                })
                .OrderBy(result => result.Month)
                .ToList();

            return monthlyRevenues;
        }
        public List<CustomRevenueDTO> CustomRevenues(DateTime startDate, DateTime endDate)
        {
            var customRevenues = CFEntities.Instance.BILLs
                .Where(bill => bill.BillDate >= startDate && bill.BillDate <= endDate)
                .GroupBy(bill => EntityFunctions.TruncateTime(bill.BillDate))
                .Select(group => new CustomRevenueDTO
                {
                    Day = group.Key.Value,
                    TotalAmount = (double)group.Sum(bill => bill.Total)
                })
                .OrderBy(result => result.Day)
                .ToList();

            return customRevenues;
        }
        public List<DrinkReportDTO> DrinkReports(DateTime date)
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
    }
}
