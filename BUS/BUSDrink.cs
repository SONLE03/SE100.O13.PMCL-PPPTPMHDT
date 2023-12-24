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
        public List<DRINK> GetAllDrinkActiveByCategory(int cateId)
        {
            return DALDrink.Instance.GetAllDrinkActiveByCategory(cateId);
        }

        public DRINK GetDrinkById(int id)
        {
            return DALDrink.Instance.GetDrinkById(id);
        }

        public DRINK GetDrinkByCode(string DrinksID)
        {
            return DALDrink.Instance.GetDrinkByCode(DrinksID);
        }
        public bool checkCategoryStatus(int catId, string status)
        {
            CATEGORY cat = DALCategory.Instance.GetCategoryById(catId);
            if (cat.Status.Equals("InActive") && status.Equals("Active")) return false;
            return true;
        }

        public DRINK AddDrink(string DrinksName, int drinkCategory,
            string Description, string Image, string status)
        {
            if (!checkCategoryStatus(drinkCategory, status)) return null;
            return DALDrink.Instance.AddDrink(DrinksName, drinkCategory, Description, Image, status);
        }

        public bool UpdDrink(int idDrink, string DrinksName, int drinkCategory,
            string Description, string Image, List<DRINKS_SIZE> Drink_SIZEs, string Status)
        {
            if (!checkCategoryStatus(drinkCategory, Status)) return false;
            return DALDrink.Instance.UpdDrink(idDrink, DrinksName, drinkCategory, Description, Image, Drink_SIZEs, Status);
        }

        public bool UpdDrinkEvent(int idDrink, EVENT ev)
        {
            return DALDrink.Instance.UpdDrinkEvent(idDrink, ev);
        }

        public bool UpdateImageErrorNotFound(int idDrink, string Image)
        {
            return DALDrink.Instance.UpdDrinkImageNotFound(idDrink, Image);
        }

        public bool DelDrink(int id)
        {
            return DALDrink.Instance.DelDrink(id);
        }
        public List<DRINK> SearchDrinks(string searchText, string selectedCategory, string selectedStatus)
        {
            return DALDrink.Instance.SearchDrinks(searchText, selectedCategory, selectedStatus);
        }
    }
}
