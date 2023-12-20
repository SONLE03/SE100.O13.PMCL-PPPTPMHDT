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

        public List<GROUPUSER> GetAllGroupUser()
        {
            return CFEntities.Instance.GROUPUSERs.AsNoTracking().ToList();
        }
        public List<GROUPUSER> GetAllGroupUserActive()
        {
            return CFEntities.Instance.GROUPUSERs.AsNoTracking().Where(n => n.Status == "Active").ToList();
        }
        public bool GetGroupUserByName(string name)
        {
            var res = CFEntities.Instance.GROUPUSERs.AsNoTracking().Where(n => n.GroupUserName.ToLower().Contains(name)).ToList();
            if (res.Any())
                return true;
            return false;
        }
        public GROUPUSER GetGroupUserById(int id)
        {
            return CFEntities.Instance.GROUPUSERs.Find(id);
        }
        public List<GROUPUSER> SearchGroupUser(string searchText, string selectedStatus)
        {
            List<GROUPUSER> listGroupUser = CFEntities.Instance.GROUPUSERs.ToList();
            List<GROUPUSER> filteredList = new List<GROUPUSER>();
            filteredList = listGroupUser
                .Where(p =>
                    (string.IsNullOrEmpty(searchText) || p.GroupUserName.ToLower().Contains(searchText.ToLower())) &&
                    (selectedStatus == "All" || string.Equals(p.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
            return filteredList;
        }

        public GROUPUSER GetGroupUserByCode(string GroupUserID)
        {
            var res = CFEntities.Instance.GROUPUSERs.AsNoTracking().Where(n => n.GroupUserID == GroupUserID);
            return (res.Any() ? res.First() : null);
        }

        public int AddGroupUser(string GroupUserName, string status)
        {
            try
            {
                var group = new GROUPUSER
                {
                    GroupUserName = GroupUserName,
                    Status = status
                };
                CFEntities.Instance.GROUPUSERs.Add(group);
                CFEntities.Instance.SaveChanges();
                return group.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool UpdGroupUser(int id, string GroupUserName, string Status, List<SERVICE> service)
        {
            try
            {
                var group = GetGroupUserById(id);
                if (group == null) return false;
                if (GroupUserName != group.GroupUserName)
                {
                    group.GroupUserName = GroupUserName;
                }
                if (Status != group.Status)
                {
                    group.Status = Status;
                    foreach(var us in group.C_USER)
                    {
                        us.Status = Status;
                    }
                }
                if (service != null)
                {
                    group.SERVICEs = service;
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
