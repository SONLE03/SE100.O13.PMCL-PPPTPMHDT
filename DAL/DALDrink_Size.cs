using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALDrink_Size
    {
        private static DALDrink_Size instance;
        public static DALDrink_Size Instance
        {
            get
            {
                if (instance == null) instance = new DALDrink_Size();
                return instance;
            }
            set => instance = value;
        }

        public List<DRINKS_SIZE> GetAllDrinkSize()
        {
            return CFEntities.Instance.DRINKS_SIZE.AsNoTracking().ToList();
        }

        public bool AddDrink_Size(DRINK Drink, int? SizeId, double price)
        {
            try
            {
                if (Drink == null || SizeId == null) return false;
                double discount = 0;
                var ct = new DRINKS_SIZE
                {
                    DrinksID = Drink.id,
                    SizeID = (int)SizeId,
                    OriginalPrice = price,
                    Discount = discount

                };
                Drink.DRINKS_SIZE.Add(ct);
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

        public bool UpdDrinkSize(int idDrinkSize, int sizeId, double newPrice)
        {
            try
            {
                var drinkSize = (from p in CFEntities.Instance.DRINKS_SIZE where p.SizeID == sizeId && p.DrinksID == idDrinkSize select p).FirstOrDefault();
                if (drinkSize == null) return false;
                drinkSize.SizeID = sizeId;
                drinkSize.OriginalPrice = newPrice;
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
                    //drink.DRINKS_SIZE.Remove(drinkSize);
                    CFEntities.Instance.DRINKS_SIZE.Remove(drinkSize);
                    CFEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}
