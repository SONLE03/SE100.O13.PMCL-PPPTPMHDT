using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public List<DRINK> GetAllDrinkForEvent(int cateId)
        {
            return DALDrink.Instance.GetAllDrinkForEvent(cateId);
        }

        public DRINK GetDrinkById(int id)
        {
            return DALDrink.Instance.GetDrinkById(id);
        }

        public DRINK GetDrinkyByName(string drinkName)
        {
            return DALDrink.Instance.GetDrinkByName(drinkName);
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
            try
            {
                if (GetDrinkyByName(DrinksName) != null)
                {
                    MessageBox.Show("The drink already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                DRINK drink = DALDrink.Instance.AddDrink(DrinksName, drinkCategory, Description, Image, status);
                if (drink != null) return drink;
                MessageBox.Show("Add failure drink", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch
            {
                MessageBox.Show("Add failure drink", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool UpdDrink(int idDrink, string DrinksName, int drinkCategory,
            string Description, string Image, List<DRINKS_SIZE> Drink_SIZEs, string Status)
        {
            try
            {
                var drink = GetDrinkyByName(DrinksName);
                if (drink != null && drink.id != idDrink)
                {
                    MessageBox.Show("The drink already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (DALDrink.Instance.UpdDrink(idDrink, DrinksName, drinkCategory, Description, Image, Drink_SIZEs, Status)) return true;
                MessageBox.Show("Modify failure drink", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch
            {
                MessageBox.Show("Modify failure drink", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdDrinkEvent(int idDrink, EVENT ev)
        {
            return DALDrink.Instance.UpdDrinkEvent(idDrink, ev);
        }

        public bool UpdateImageErrorNotFound(int idDrink, string Image)
        {
            return DALDrink.Instance.UpdDrinkImageNotFound(idDrink, Image);
        }
        public List<DRINK> SearchDrinks(string searchText, string selectedCategory, string selectedStatus)
        {
            return DALDrink.Instance.SearchDrinks(searchText, selectedCategory, selectedStatus);
        }
    }
}
