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
                if (user.UserName.Equals(usrname) && user.Password.Equals(usrpwd))
                {
                    return user;
                }
            }
            return null;
        }
    }
}