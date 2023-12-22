using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public C_RULE GetAllRule()
        {
            return DALRule.Instance.GetAllRule();
        }
        public void UpdRule(int minAge, int maxAge, int tax)
        {
            if (DALRule.Instance.UpdMinimumAge(minAge) && DALRule.Instance.UpdMaximumAge(maxAge) && DALRule.Instance.UpdTax(tax))
            {
                MessageBox.Show("Changes have been saved", "Notifycation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Invalid information. Please check again", "Notifycation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
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
        public string UpdTax(int tax)
        {
            if (DALRule.Instance.UpdTax(tax))
                return "";
            return "Error";
        }
    }
}
