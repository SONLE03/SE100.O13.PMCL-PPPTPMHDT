using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUser
    {
        private static DALUser instance;

        public static DALUser Instance
        {
            get
            {
                if (instance == null) instance = new DALUser();
                return instance;
            }
            set => instance = value;
        }

        public List<C_USER> GetAllUser()
        {
            return CFEntities.Instance.C_USER.AsNoTracking().ToList();
        }
        public List<C_USER> GetAllUserActive()
        {
            return CFEntities.Instance.C_USER.AsNoTracking().Where(n => n.Status == DALStatus.active.ToString()).ToList();
        }


        public C_USER GetUserById(int id)
        {
            return CFEntities.Instance.C_USER.Find(id);
        }

        public C_USER GetUserByCode(string UserID)
        {
            var res = CFEntities.Instance.C_USER.AsNoTracking().Where(n => n.UserID == UserID);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        public C_USER GetUserByUsername(string username)
        {
            var res = CFEntities.Instance.C_USER.AsNoTracking().Where(n => n.UserName == username);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        public C_USER GetUserByUsernameAndEmail(string username, string email)
        {
            var res = CFEntities.Instance.C_USER.AsNoTracking().Where(n => n.UserName == username && n.Email == email);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        public bool GetUserByIDGroupUser(int idGU)
        {
            var res = CFEntities.Instance.C_USER.AsNoTracking().Where(n => n.GroupUserID == idGU);
            if (res.Any())
                return true;
            return false;
        }

        public int AddUser(string UserFullName, DateTime DateofBirth, string Address, string Phone,
                                 string UserName, string Password, string Email, int GroupUserID, string Image)
        {
            try
            {
                var us = new C_USER
                {
                    UserFullName = UserFullName,
                    DateOfBirth = DateofBirth,
                    Phone = Phone,
                    Address = Address,
                    Email = Email,
                    UserName = UserName,
                    Password = Password,
                    GroupUserID = GroupUserID,
                    Status = "Active",
                    Image  = Image,
                    GROUPUSER = DALGroupUser.Instance.GetGroupUserById(GroupUserID)
                };
                CFEntities.Instance.C_USER.Add(us);
                CFEntities.Instance.SaveChanges();
                return us.id;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public bool UpdUser(int id, string UserFullName, DateTime? DateofBirth, string Address, string Email, string Phone,
                                 int? GroupUserID, string Status, string Image)
        {
            try
            {
                var us = GetUserById(id);
                if (us == null) return false;
                if (UserFullName != null) us.UserFullName = UserFullName;
                if (Phone != null) us.Phone = Phone;
                if (DateofBirth != null) us.DateOfBirth = DateofBirth;
                if (Address != null) us.Address = Address;
                if (GroupUserID != null) us.GroupUserID = (int)GroupUserID;
                if (Email != null) us.Email = Email;
                if (Status != us.Status) us.Status = Status;
                if (Image != us.Image) us.Image = Image;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool DelUser(int id)
        {
            try
            {
                var us = GetUserById(id);
                if (us == null) return false;

                CFEntities.Instance.C_USER.Remove(us);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdPassword(int id, string password)
        {
            try
            {
                var us = GetUserById(id);
                if (us == null) return false;

                us.Password = password;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
