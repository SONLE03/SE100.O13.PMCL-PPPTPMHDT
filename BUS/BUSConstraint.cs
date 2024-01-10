using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSConstraint
    {
        private static BUSConstraint instance;

        public static BUSConstraint Instance
        {
            get
            {
                if (instance == null) instance = new BUSConstraint();
                return instance;
            }
            set { instance = value; }
        }
        public bool PhoneNumberValidator(string phone)
        {
            string phoneNumber = DALConstraint.Instance.TransformString(phone); 
            return phoneNumber.Length == 10 && phoneNumber.StartsWith("0");
        }
        public bool DateTimeValidatorInEvent(DateTime startDate, DateTime dueDate, int type)
        {
            TimeSpan span = dueDate - startDate;
            int gap = span.Days;
            DateTime checkDate = type == 1 ? startDate: dueDate;
            return (checkDate.Date >= DateTime.Now.Date) && (dueDate.Date >= startDate.Date) && gap <= BUSRule.Instance.GetAllRule().MaximumDateForEvent;
        }
    }
}
