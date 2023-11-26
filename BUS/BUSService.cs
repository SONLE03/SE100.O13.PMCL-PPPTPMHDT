using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSService
    {
        private static BUSService instance;

        public static BUSService Instance
        {
            get
            {
                if (instance == null) instance = new BUSService();
                return instance;
            }
            set { instance = value; }
        }
        public List<SERVICE> GetAllService()
        {
            return DALService.Instance.GetAllService();
        }

        public SERVICE GetServiceById(int id)
        {
            return DALService.Instance.GetServiceById(id);
        }

        public SERVICE GetServiceByCode(string ServiceID)
        {
            return DALService.Instance.GetServiceByCode(ServiceID);
        }
    }
}
