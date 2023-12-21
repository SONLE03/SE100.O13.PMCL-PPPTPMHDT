using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUSDrink_Size
    {
        private static BUSDrink_Size instance;

        public static BUSDrink_Size Instance
        {
            get
            {
                if (instance == null) instance = new BUSDrink_Size();
                return instance;
            }
            set { instance = value; }
        }

        public bool AddDrink_Size(DRINK Drink, int SizeId, double price)
        {
            return DALDrink_Size.Instance.AddDrink_Size(Drink, SizeId, price);
        }

        public List<DRINKS_SIZE> GetAllDrinkSize()
        {
            return DALDrink_Size.Instance.GetAllDrinkSize();
        }

        public DRINKS_SIZE FindDrinkSize(string sizeName, int drinkId)
        {
            return DALDrink_Size.Instance.FindDrinkSize(sizeName, drinkId);
        }

        public bool UpdDrinkSize(int idDrinkSize, int sizeId, double newPrice)
        {
            return DALDrink_Size.Instance.UpdDrinkSize(idDrinkSize, sizeId, newPrice);
        }

        public bool delDrinkSize(DRINKS_SIZE drinkSize, DRINK drink, C_SIZE size)
        {
            drink.DRINKS_SIZE = new List<DRINKS_SIZE>();
            foreach (var ds in BUSDrink_Size.Instance.GetAllDrinkSize())
            {
                if (ds.DrinksID == drink.id)
                {
                    drink.DRINKS_SIZE.Add(ds);
                }
            }
            return DALDrink_Size.Instance.delDrinkSize(drinkSize, drink, size);
        }
    }
}
