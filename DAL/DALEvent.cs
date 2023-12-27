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

        public List<EVENT> GetAllEventActive()
        {
            return CFEntities.Instance.EVENTs.AsNoTracking().Where(m => m.Status == "Active").ToList();
        }

        public EVENT GetEventById(int id)
        {
            return CFEntities.Instance.EVENTs.Find(id);
        }
        public List<EVENT> SearchEvent(string searchText)
        {
            var transformedNameEvent = DALConstraint.Instance.TransformString(searchText);
            List<EVENT> listEvents = CFEntities.Instance.EVENTs.ToList();
            List<EVENT> filteredList = new List<EVENT>();
            filteredList = listEvents
                .Where(p =>
                    (string.IsNullOrEmpty(transformedNameEvent) || p.EventName.ToLower().Contains(transformedNameEvent)))
                .ToList();
            return filteredList;

        }
        public int AddEvent (string EventName, bool EventType, string Unit,  DateTime StartDate, DateTime DueDate, float Discount, List<DRINK> drinks, int userId)
        {
            try
            {
                var obj = new EVENT();
                var transformedNameEvent = DALConstraint.Instance.TransformString(EventName);
                obj.EventName = transformedNameEvent;
                obj.StartDate = StartDate;
                obj.DueDate = DueDate;
                obj.Discount = Discount;
                obj.EventType = EventType;
                obj.Unit = Unit;
                obj.UserID = userId;
                obj.DRINKS = drinks;
                //foreach(var p in drinks)
                //{
                //    DRINK drink = DALDrink.Instance.GetDrinkById(p.id);
                //    if (!drink.EVENTs.Any(c => c.EventName.Equals(EventName)))
                //    {
                //        drink.EVENTs.Add(obj);
                //        obj.DRINKS.Add(drink);
                //    }
                //}    

                CFEntities.Instance.EVENTs.Add(obj);
                CFEntities.Instance.SaveChanges();
                return obj.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }
        public bool UpdEvent(int idEV, string EventName, bool EventType, string Unit, DateTime StartDate, DateTime DueDate, float Discount, List<DRINK> drinks, string Status, int userId)
        {
            try
            {
                EVENT ev = GetEventById(idEV);
                if (ev == null) return false;
                if (EventName != null)
                {
                    var transformedNameEvent = DALConstraint.Instance.TransformString(EventName);
                    ev.EventName = transformedNameEvent;
                }
                if (EventType != ev.EventType) ev.EventType = EventType;
                if (Unit !=  ev.Unit) ev.Unit = Unit;
                if (StartDate != null) ev.StartDate = StartDate;
                if (DueDate != null) ev.DueDate = DueDate;
                if (Discount != ev.Discount) ev.Discount = Discount;
                if (Status != ev.Status) ev.Status = Status;
                if (userId != ev.UserID) ev.UserID = userId;
                if (drinks != null) ev.DRINKS = drinks;
                //foreach (var p in drinks)
                //{
                //    if (!p.EVENTs.Any(s => s.id == ev.id))
                //    {
                //        p.EVENTs.Add(ev);
                //        ev.DRINKS.Add(p);
                //    }    
                //    else
                //    {
                //        p.EVENTs.Remove(ev);
                //        ev.DRINKS.Remove(p);
                //    }    
                //}    
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
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
