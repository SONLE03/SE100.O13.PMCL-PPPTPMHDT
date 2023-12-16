using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSGroupUser
    {
        private static BUSGroupUser instance;

        public static BUSGroupUser Instance
        {
            get
            {
                if (instance == null) instance = new BUSGroupUser();
                return instance;
            }
            set { instance = value; }
        }

        public List<GROUPUSER> GetAllGroupUser()
        {
            return DALGroupUser.Instance.GetAllGroupUser();
        }

        public GROUPUSER GetGroupUserById(int id)
        {
            return DALGroupUser.Instance.GetGroupUserById(id);
        }

        public GROUPUSER GetGroupUserByCode(string GroupUserID)
        {
            return DALGroupUser.Instance.GetGroupUserByCode(GroupUserID);
        }

        public int AddGroupUser(string GroupUserName)
        {
            return DALGroupUser.Instance.AddGroupUser(GroupUserName);
        }

        public bool UpdGroupUser(int id, string GroupUserName)
        {
            return DALGroupUser.Instance.UpdGroupUser(id, GroupUserName);
        }
        public bool DelGroupUser(int id)
        {
            return DALGroupUser.Instance.DelGroupUser(id);
        }
        public bool AddGroupService(int id, List<SERVICE> listService)
        {
            return DALGroupUser.Instance.AddGroupService(id, listService);
        }

        public bool DelGroupService(int id, List<SERVICE> listService)
        {
            return DALGroupUser.Instance.DelGroupService(id, listService);
        }
    }
}
