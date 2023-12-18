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
            return CFEntities.Instance.DRINKS.AsNoTracking().Where(t => t.Status == DALStatus.active.ToString()).ToList();
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
      

        public List<DRINK> FindDrink(string DrinkName)
        {
            List<DRINK> res = CFEntities.Instance.DRINKS.AsNoTracking().ToList();
            if (DrinkName != null) res = res.Where(t => t.DrinksName == DrinkName).Select(t => t).ToList();
            return res;
        }

        public DRINK AddDrink(string DrinksName, CATEGORY drinkCategory, 
            string Description, string Image)
        {
            try
            {
                DRINK Drink = new DRINK();
                Drink.DrinksName = DrinksName;
                Drink.CategoryID = drinkCategory.id;
                Drink.Description = Description;
                Drink.Image = Image;
                Drink.Status = DALStatus.active.ToString();
                CFEntities.Instance.DRINKS.Add(Drink);
                CFEntities.Instance.SaveChanges();

                return Drink;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool UpdDrink(int idDrink, string DrinksName, CATEGORY drinkCategory,
            string Description, string Image, List<DRINKS_SIZE> Drink_SIZEs, string Status)
        {
            try
            {
                DRINK Drink = CFEntities.Instance.DRINKS.Find(idDrink);
                if (Drink == null) return false;
                if (DrinksName != null) Drink.DrinksName = DrinksName;
                if (drinkCategory != null) Drink.CategoryID = drinkCategory.id;
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
