using DTO;
using System;
using System.Collections.Generic;
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

    }
}
