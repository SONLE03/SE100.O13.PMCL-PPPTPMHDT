using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Thêm tên sự kiện
    public class DALEvent
    {
        private static DALEvent instance;
        public static DALEvent Instance
        {
            get
            {
                if (instance == null) instance = new DALEvent();
                return instance;
            }
            set => instance = value;
        }
        public List<EVENT> GetAllEvent()
        {
            return CFEntities.Instance.EVENTs.AsNoTracking().ToList();
        }
        public EVENT GetEventById(int id)
        {
            return CFEntities.Instance.EVENTs.Find(id);
        }
        public EVENT GetEventByCode(string EventID)
        {
            var res = CFEntities.Instance.EVENTs.AsNoTracking().Where(m => m.EventID == EventID);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<EVENT> FindEvent(string EventID)
        {
            var res = CFEntities.Instance.EVENTs.ToList();
            if (EventID != null) res = res.Where(t => t.EventID == EventID).Select(t => t).ToList();
            return res;
        }
        public bool AddEvent (string EventName, bool EventType, DateTime StartDate, DateTime DueDate, float Discount)
        {
            string Unit = (EventType == false) ? "%" : "VND";
            try
            {
                var obj = new EVENT();
                obj.EventName = EventName;
                obj.StartDate = StartDate;
                obj.DueDate = DueDate;
                obj.Discount = Discount;
                obj.EventType = EventType;
                obj.Unit = Unit;
                CFEntities.Instance.EVENTs.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdEvent(int idEV, DateTime DueDate, float Discount)
        {
            try
            {
                EVENT ev = GetEventById(idEV);
                if (ev == null) return false;
                if (DueDate != null) ev.DueDate = DueDate;
                if (Discount != ev.Discount) ev.Discount = Discount;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelEvent(int idEV)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    EVENT ev = GetEventById(idEV);
                    if (ev == null) return false;
                    CFEntities.Instance.EVENTs.Remove(ev);
                    CFEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}
