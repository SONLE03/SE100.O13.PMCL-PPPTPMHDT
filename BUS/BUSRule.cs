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
        public void UpdRule(int minAge, int maxAge, int tax, int maxDate, int maxPercent)
        {
            if (DALRule.Instance.UpdMinimumAge(minAge) && DALRule.Instance.UpdMaximumAge(maxAge) && DALRule.Instance.UpdTax(tax) 
                && DALRule.Instance.UpdMaximumDateForEvent(maxDate) && DALRule.Instance.UpdMaximumPercentDiscount(maxPercent))
            {
                MessageBox.Show("Changes have been saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Invalid information. Please check again", "Notifycation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
