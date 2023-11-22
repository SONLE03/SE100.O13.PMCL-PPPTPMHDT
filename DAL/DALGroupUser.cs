using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALGroupUser
    {
        private static DALGroupUser instance;

        public static DALGroupUser Instance
        {
            get
            {
                if (instance == null) instance = new DALGroupUser();
                return instance;
            }
            set => instance = value;
        }

        public List<GROUPUSER> GetAllNhomNguoiDung()
        {
            return CFEntities.Instance.GROUPUSERs.AsNoTracking().ToList();
        }

        public GROUPUSER GetGroupUserById(int id)
        {
            return CFEntities.Instance.GROUPUSERs.Find(id);
        }

        public GROUPUSER GetGroupUserByCode(string GroupUserID)
        {
            var res = CFEntities.Instance.GROUPUSERs.AsNoTracking().Where(n => n.GroupUserID == GroupUserID);
            return (res.Any() ? res.First() : null);
        }

        public int AddGroupUser(string GroupUserName)
        {
            try
            {
                var nhom = new GROUPUSER
                {
                    GroupUserName = GroupUserName
                };
                CFEntities.Instance.GROUPUSERs.Add(nhom);
                CFEntities.Instance.SaveChanges();
                return nhom.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool UpdGroupUser(int id, string GroupUserName)
        {
            try
            {
                var group = GetGroupUserById(id);
                if (group == null) return false;
                group.GroupUserName = GroupUserName;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool DelGroupUser(int id)
        {
            try
            {
                var group = GetGroupUserById(id);
                if (group == null) return false;
                CFEntities.Instance.GROUPUSERs.Remove(group);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool AddGroupService(int id, List<SERVICE> listService)
        {
            try
            {
                var group = GetGroupUserById(id);
                if (group == null) return false;
                group.SERVICEs.Clear();
                group.SERVICEs = listService;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelGroupService(int id, List<SERVICE> listService)
        {
            try
            {
                var group = GetGroupUserById(id);
                if (group == null) return false;
                foreach (var sv in listService)
                {
                    if (!group.SERVICEs.Contains(sv)) group.SERVICEs.Remove(sv);
                }
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
