using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSUser
    {
        private static BUSUser instance;

        public static BUSUser Instance
        {
            get
            {
                if (instance == null) instance = new BUSUser();
                return instance;
            }
            set { instance = value; }
        }
        public int idUserLogin { get; set; }
        public List<C_USER> GetAllUser()
        {
            return DALUser.Instance.GetAllUser();
        }
        public List<C_USER> GetAllUserActive()
        {
            return DALUser.Instance.GetAllUserActive();
        }

        public C_USER GetUserById(int id)
        {
            return DALUser.Instance.GetUserById(id);
        }

        public C_USER GetUserByCode(string UserID)
        {
            return DALUser.Instance.GetUserByCode(UserID);
        }
        public bool checkUserInUserGroupLogin(int idGroupUser)
        {
            C_USER user = BUSUser.instance.GetUserById(idUserLogin);
            if (user.GroupUserID == idGroupUser)
            {
                return true;
            }
            return false;
        }
        public C_USER GetUserByUsername(string username)
        {
            return DALUser.Instance.GetUserByUsername(username);
        }
        public C_USER GetUserByUsernameAndEmail(string username, string email)
        {
            return DALUser.Instance.GetUserByUsernameAndEmail(username, email);
        }

        public bool GetUserByIDGroupUser(int idGU)
        {
            return DALUser.Instance.GetUserByIDGroupUser(idGU);
        }

        public int AddUser(string UserFullName, DateTime DateofBirth, string Address, string Phone,
                                 string UserName, string Password, string Email, int GroupUserID, string image)
        {
            return DALUser.Instance.AddUser(UserFullName, DateofBirth, Address, Phone, UserName, Password, Email, GroupUserID, image);
        }
        public bool UpdUser(int id, string UserFullName, DateTime? DateofBirth, string Address, string Email, string Phone,
                                 int? GroupUserID, string status, string image)
        {
            return DALUser.Instance.UpdUser(id, UserFullName, DateofBirth, Address, Email, Phone, GroupUserID, status, image);
        }
        public bool DelUser(int id)
        {
            return DALUser.Instance.DelUser(id);
        }
        public bool UpdPassword(int id, string password)
        {
            return DALUser.Instance.UpdPassword(id, password);
        }
    }
}
