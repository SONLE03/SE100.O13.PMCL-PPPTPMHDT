using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace DAL
{
    public class DALDrink
    {
        private static DALDrink instance;

        public static DALDrink Instance
        {
            get
            {
                if (instance == null) instance = new DALDrink();
                return instance;
            }
            set => instance = value;
        }
        public List<DRINK> GetAllDrink()
        {
            return CFEntities.Instance.DRINKS.AsNoTracking().ToList();
        }
        public List<DRINK> GetAllDrinkActive()
        {
            return CFEntities.Instance.DRINKS.AsNoTracking().Where(t => t.Status == "Active").ToList();
        }
        public List<DRINK> GetAllDrinkActiveByCategory(int catId)
        {
            return CFEntities.Instance.DRINKS.AsNoTracking().Where(t =>  t.CategoryID == catId && t.Status != "InActive").ToList();
        }

        public DRINK GetDrinkById(int id)
        {
            return CFEntities.Instance.DRINKS.Find(id);
        }

        public DRINK GetDrinkByCode(string DrinksID)
        {
            var res = CFEntities.Instance.DRINKS.AsNoTracking().Where(t => t.DrinksID == DrinksID);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
      

        public List<DRINK> SearchDrinks(string searchText, string selectedCategory, string selectedStatus)
        {
            List<DRINK> listDrinks = CFEntities.Instance.DRINKS.ToList();
            List<DRINK> filteredList = new List<DRINK>();
            filteredList = listDrinks
                .Where(p =>
                    (string.IsNullOrEmpty(searchText) || p.DrinksName.ToLower().Contains(searchText)) &&
                    (selectedCategory == "All" || string.Equals(p.CATEGORY.CategoryName, selectedCategory, StringComparison.OrdinalIgnoreCase)) &&
                    (selectedStatus == "All" || string.Equals(p.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
            return filteredList;
        }

        public DRINK AddDrink(string DrinksName, int drinkCategory, 
            string Description, string Image, string status)
        {
            try
            {
                DRINK Drink = new DRINK();
                Drink.DrinksName = DrinksName;
                Drink.CategoryID = drinkCategory;
                Drink.Description = Description;
                Drink.Image = Image;
                Drink.Status = status;
                CFEntities.Instance.DRINKS.Add(Drink);
                CFEntities.Instance.SaveChanges();

                return Drink;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool UpdDrink(int idDrink, string DrinksName, int drinkCategory,
            string Description, string Image, List<DRINKS_SIZE> Drink_SIZEs, string Status)
        {
            try
            {
                DRINK Drink = CFEntities.Instance.DRINKS.Find(idDrink);
                if (Drink == null) return false;
                if (DrinksName != null) Drink.DrinksName = DrinksName;
                if (drinkCategory != Drink.CategoryID) Drink.CategoryID = drinkCategory;
                if (Description != null) Drink.Description = Description;
                if (Image != null) Drink.Image = Image;
                if (Status != Drink.Status) Drink.Status = Status;
                if (Drink_SIZEs != null) Drink.DRINKS_SIZE = Drink_SIZEs;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdDrinkEvent(int idDrink, EVENT ev)
        {
            using (var context = new CFEntities())
            {
                try
                {
                    DRINK Drink = context.DRINKS.Find(idDrink);
                    if (Drink == null) return false;
                    Drink.EVENTs.Add(ev);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.InnerException.ToString());
                    return false;
                }
            }
        }

        public bool UpdDrinkImageNotFound(int idDrink, string Image)
        {
            try
            {
                DRINK Drink = CFEntities.Instance.DRINKS.Find(idDrink);
                if (Image != null) Drink.Image = Image;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelDrink(int id)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    DRINK Drink = GetDrinkById(id);
                    if (Drink == null) return false;
                    CFEntities.Instance.DRINKS.Remove(Drink);
                    CFEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

    }
}
