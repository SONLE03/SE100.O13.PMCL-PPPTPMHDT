using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSArea
    {
        private static BUSArea instance;

        public static BUSArea Instance
        {
            get 
            {
                if (instance == null) instance = new BUSArea();
                return instance; 
            }
            set { instance = value; }
        }

        public List<AREA> GetAllArea()
        {
            return DALArea.Instance.GetAllArea();
        }
        public List<AREA> GetAllAreaActive()
        {
            return DALArea.Instance.GetAllAreaActive();
        }
        public AREA GetAreaById(int id)
        {
            return DALArea.Instance.GetAreaById(id);
        }
        public AREA GetAreaByCode(string AreaId)
        {
            return DALArea.Instance.GetAreaByCode(AreaId);
        }
        public bool AddArea(string AreaName, string Status)
        {
            return DALArea.Instance.AddArea(AreaName, Status);
        }
        public bool UpdArea(int idArea, string AreaName, string Status)
        {
            return DALArea.Instance.UpdArea(idArea, AreaName, Status);
        }
        public bool DelArea(int idArea)
        {
            return DALArea.Instance.DelArea(idArea);
        }
    }
}
