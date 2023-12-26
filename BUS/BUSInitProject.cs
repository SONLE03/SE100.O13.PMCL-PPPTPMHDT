using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSInitProject
    {
        private static BUSInitProject instance;

        public static BUSInitProject Instance
        {
            get
            {
                if (instance == null) instance = new BUSInitProject();
                return instance;
            }
            set => instance = value;
        }
        public void AddFirstUser()
        {
            var user = BUSUser.Instance.GetAllUser();
            if (user == null)
            {
                BUSUser.Instance.AddUser("Quản lý", DateTime.MinValue, null, "0945679061", "admin", "admin123", "admin123", "tenh66517@gmail.com", 1, null, "Active");
                BUSUser.Instance.AddUser("Nhân viên thu ngân", DateTime.MinValue, null, "0945679061", "cashier", "cashier123", "cashier123", "tenh66517@gmail.com", 2, null, "Active");
            }
        }
    }
}
