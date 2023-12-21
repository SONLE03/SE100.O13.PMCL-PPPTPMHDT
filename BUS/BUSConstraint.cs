using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool PhoneNumberValidator(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.StartsWith("0");
        }
    }
}
