using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSAnalysis
    {
        private static BUSAnalysis instance;

        public static BUSAnalysis Instance
        {
            get
            {
                if (instance == null) instance = new BUSAnalysis();
                return instance;
            }
            set => instance = value;
        }
        public List<TopSellingDrinkDTO> TopSellingDrinks()
        {
            return DALAnalysis.Instance.topSellingDrinks();
        }
        public List<CustomRevenueDTO> monthOfYearRevenueDTOs(int year)
        {
            return DALAnalysis.Instance.MonthlyRevenues(year);
        }
        public List<CustomRevenueDTO> dayOfMonthRevenueDTOs(int month, int year)
        {
            return DALAnalysis.Instance.dayOfMonthRevenueDTOs(month, year);
        } 
        public List<CustomRevenueDTO> yearsRevenueDTOs(int startYear, int endYear)
        {
            return DALAnalysis.Instance.yearsRevenueDTOs(startYear, endYear);
        }
        public List<DrinkReportDTO> drinkReportDTOs(DateTime date)
        {
            return DALAnalysis.Instance.DrinkReports(date);
        }
        public List<ImportDTO> monthOfYearCostDTOs(int year)
        {
            return DALAnalysis.Instance.MonthlyCost(year);
        }
        public List<ImportDTO> dayOfMonthCostDTOs(int month, int year)
        {
            return DALAnalysis.Instance.dayOfMonthCostDTOs(month, year);
        }
        public List<ImportDTO> yearsCostDTOs(int startYear, int endYear)
        {
            return DALAnalysis.Instance.yearsCostDTOs(startYear, endYear);
        }
    }
}
