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
        public List<MonthlyRevenueDTO> monthlyRevenueDTOs()
        {
            return DALAnalysis.Instance.MonthlyRevenues();
        }
        public List<CustomRevenueDTO> customRevenueDTOs(DateTime startDate, DateTime endDate)
        {
            return DALAnalysis.Instance.CustomRevenues(startDate, endDate);
        }
    }
}
