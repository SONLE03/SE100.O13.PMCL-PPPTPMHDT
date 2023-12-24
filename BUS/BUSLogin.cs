using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSLogin
    {
        private C_USER c_user;
        private static BUSLogin instance;
        public static BUSLogin Instance
        {
            get
            {
                if (instance == null) instance = new BUSLogin();
                return instance;
            }
            set => instance = value;
        }

        public C_USER checkValidLogin(string usrname, string usrpwd)
        {
            foreach (var user in DALUser.Instance.GetAllUser())
            {
                if (user.UserName.Equals(usrname) && BCrypt.Net.BCrypt.EnhancedVerify(usrpwd, user.Password)){ 
                        c_user = user;
                        return c_user;
                }
                
            }
            return null;
        }
        public bool checkStatus(C_USER c_user)
        {
            if (string.Equals(c_user.Status, "Active", StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
    }
}