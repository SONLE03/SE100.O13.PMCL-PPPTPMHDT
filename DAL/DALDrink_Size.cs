using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDrink_Size
    {
        private static DALDrink_Size instance;

        private static bool check = false;
        public static DALDrink_Size Instance
        {
            get
            {
                if (instance == null) instance = new DALDrink_Size();
                return instance;
            }
            set => instance = value;
        }

        public List<DRINKS_SIZE> GetAllSize()
        {
            return CFEntities.Instance.DRINKS_SIZE.AsNoTracking().ToList();
        }

        public bool AddDrink_Size(int idDrink, int idSize, double price)
        {
            try
            {
                var Drink = DALDrink.Instance.GetDrinkById(idDrink);
                var Size = DALSize.Instance.GetSizeById(idSize);
                if (Drink == null || Size == null) return false;
                double discount = 0;
                if (Drink.EVENT != null)
                {
                    if (Drink.EVENT.EventType == true)
                    {
                        discount = (double)(price - Drink.EVENT.Discount);
                    }
                    else
                    {
                        discount = (double)(price * Drink.EVENT.Discount) / 100;
                    }
                }
                var ct = new DRINKS_SIZE
                {
                    DrinksID = idDrink,
                    SizeID = idSize,
                    OriginalPrice = price,
                    Discount = discount
                    
                };
                CFEntities.Instance.Entry(ct).State = System.Data.Entity.EntityState.Added;
                CFEntities.Instance.DRINKS_SIZE.Add(ct);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool delDrinkSize(DRINKS_SIZE drinkSize, DRINK drink, C_SIZE size)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    CFEntities.Instance.DRINKS_SIZE.Remove(drinkSize);
                    CFEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;

                }
                catch (Exception ex)
                {
                    var existingDrinkSize = (from p in GetAllSize() where p.C_SIZE.id == size.id && p.DrinksID == drink.id select p).FirstOrDefault();
                    
                    if (existingDrinkSize != null)
                    {
                        if (check == false)
                        {
                            if (CFEntities.Instance.Entry(existingDrinkSize).State == System.Data.Entity.EntityState.Detached)
                            {
                                CFEntities.Instance.DRINKS_SIZE.Attach(existingDrinkSize);
                                CFEntities.Instance.Entry(existingDrinkSize).State = System.Data.Entity.EntityState.Unchanged;
                            }
                        }

                        CFEntities.Instance.DRINKS_SIZE.Remove(existingDrinkSize);
                        CFEntities.Instance.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(ex.InnerException.ToString());
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
