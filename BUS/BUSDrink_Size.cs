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

        public bool AddDrink_Size(int idDrink, int idSize, double price)
        {
            return DALDrink_Size.Instance.AddDrink_Size(idDrink, idSize, price);
        }

        public List<DTO.DRINKS_SIZE> GetAllSize()
        {
            return DALDrink_Size.Instance.GetAllSize();
        }

        public bool delDrinkSize(DRINKS_SIZE drinkSize, DRINK drink, C_SIZE size)
        {
            return DALDrink_Size.Instance.delDrinkSize(drinkSize, drink, size);
        }

    }
}
