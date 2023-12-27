using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRule
    {
        private static DALRule instance;

        public static DALRule Instance
        {
            get
            {
                if (instance == null) instance = new DALRule();
                return instance;
            }
            set => instance = value;
        }

        public DALRule()
        {
            if (!CFEntities.Instance.C_RULE.Any())
            {
                CFEntities.Instance.C_RULE.Add(new C_RULE
                {
                    MinimumAge = 18,
                    MaximumAge = 25,
                    Tax = 8,
                    MaximumDateForEvent = 7,
                    MaximumPercentDiscount = 20,
                });
                CFEntities.Instance.SaveChanges();
            }
        }
        public C_RULE GetAllRule()
        {

            return CFEntities.Instance.C_RULE.First();
        }
        public bool UpdMinimumAge(int age)
        {
            try
            {
                C_RULE ts = GetAllRule();
                ts.MinimumAge = age;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool UpdMaximumAge(int age)
        {
            try
            {
                C_RULE ts = GetAllRule();
                ts.MaximumAge = age;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool UpdTax(int tax)
        {
            try
            {
                C_RULE ts = GetAllRule();
                ts.Tax = tax;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool UpdMaximumDateForEvent(int MaximumDateForEvent)
        {
            try
            {
                C_RULE ts = GetAllRule();
                ts.MaximumDateForEvent = MaximumDateForEvent;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool UpdMaximumPercentDiscount(int MaximumPercentDiscount)
        {
            try
            {
                C_RULE ts = GetAllRule();
                ts.MaximumPercentDiscount = MaximumPercentDiscount;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
