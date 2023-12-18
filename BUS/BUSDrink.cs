using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSDrink
    {
        private static BUSDrink instance;

        public static BUSDrink Instance
        {
            get
            {
                if (instance == null) instance = new BUSDrink();
                return instance;
            }
            set { instance = value; }
        }

        public List<DRINK> GetAllDrink()
        {
            return DALDrink.Instance.GetAllDrink();
        }
        public List<DRINK> GetAllDrinkActive()
        {
            return DALDrink.Instance.GetAllDrinkActive();
        }

        public DRINK GetDrinkById(int id)
        {
            return DALDrink.Instance.GetDrinkById(id);
        }

        public DRINK GetDrinkByCode(string DrinksID)
        {
            return DALDrink.Instance.GetDrinkByCode(DrinksID);
        }

        public DRINK AddDrink(string DrinksName, CATEGORY drinkCategory, string Unit,
            string Description, string Image, int? idEV, List<DRINKS_SIZE> Drink_SIZEs)
        {
            return DALDrink.Instance.AddDrink(DrinksName, drinkCategory, Description, Image);
        }

        public bool UpdDrink(int idDrink, string DrinksName, CATEGORY drinkCategory, string Unit,
            string Description, string Image, int? idEV, List<DRINKS_SIZE> Drink_SIZEs, string Status)
        {
            return DALDrink.Instance.UpdDrink(idDrink, DrinksName, drinkCategory, Description, Image, Drink_SIZEs, Status);
        }

        public bool UpdateImageErrorNotFound(int idDrink, string Image)
        {
            return DALDrink.Instance.UpdDrinkImageNotFound(idDrink, Image);
        }

        public bool DelDrink(int id)
        {
            return DALDrink.Instance.DelDrink(id);
        }
    }
}
