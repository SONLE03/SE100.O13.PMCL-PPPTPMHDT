using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALService
    {
        private static DALService instance;

        public static DALService Instance
        {
            get
            {
                if (instance == null) instance = new DALService();
                return instance;
            }
            set => instance = value;
        }

        public List<SERVICE> GetAllService()
        {
            return CFEntities.Instance.SERVICEs.AsNoTracking().ToList();
        }
        public List<SERVICE> GetService()
        {
            return CFEntities.Instance.SERVICEs.Where(service => service.id != 10).AsNoTracking().ToList();
        }

        public SERVICE GetServiceById(int id)
        {
            return CFEntities.Instance.SERVICEs.Find(id);
        }

        public SERVICE GetServiceByCode(string ServiceID)
        {
            var res = CFEntities.Instance.SERVICEs.Where(c => c.ServiceID == ServiceID);
            return (res.Any() ? res.First() : null);
        }
    }
}
