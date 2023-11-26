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

        public List<C_USER> GetAllUser()
        {
            return DALUser.Instance.GetAllUser();
        }

        public C_USER GetUserById(int id)
        {
            return DALUser.Instance.GetUserById(id);
        }

        public C_USER GetUserByCode(string UserID)
        {
            return DALUser.Instance.GetUserByCode(UserID);
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
                                 string UserName, string Password, string Email, int GroupUserID)
        {
            return DALUser.Instance.AddUser(UserFullName, DateofBirth, Address, Phone, UserName, Password, Email, GroupUserID);
        }
        public bool UpdUser(int id, string UserFullName, DateTime? DateofBirth, string Address, string Email, string Phone,
                                 int? GroupUserID)
        {
            return DALUser.Instance.UpdUser(id, UserFullName, DateofBirth, Address, Email, Phone, GroupUserID);
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
