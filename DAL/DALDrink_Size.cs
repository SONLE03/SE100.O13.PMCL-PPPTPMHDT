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
        public static DALDrink_Size Instance
        {
            get
            {
                if (instance == null) instance = new DALDrink_Size();
                return instance;
            }
            set => instance = value;
        }

        public List<C_SIZE> GetAllSize()
        {
            return CFEntities.Instance.C_SIZE.AsNoTracking().ToList();
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
    }
}
