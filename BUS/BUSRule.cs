using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSRule
    {
        private static BUSRule instance;

        public static BUSRule Instance
        {
            get
            {
                if (instance == null) instance = new BUSRule();
                return instance;
            }
            set => instance = value;
        }
        public C_RULE GetAllThamSo()
        {
            return DALRule.Instance.GetAllRule();
        }
        public string UpdMinimumAge(int age)
        {
            if (DALRule.Instance.UpdMinimumAge(age))
                return "";
            return "Error";
        }
        public string UpdMaximumAge(int age)
        {
            if (DALRule.Instance.UpdMaximumAge(age))
                return "";
            return "Error";
        }
        public string UpdMinimumPrice(int price)
        {
            if (DALRule.Instance.UpdMinimumPrice(price))
                return "";
            return "Error";
        }
        public string UpdMaximumPrice(int price)
        {
            if (DALRule.Instance.UpdMaximumPrice(price))
                return "";
            return "Error";
        }
        public string UpdTax(int tax)
        {
            if (DALRule.Instance.UpdTax(tax))
                return "";
            return "Error";
        }
    }
}
