using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return CFEntities.Instance.EVENTs.AsNoTracking().OrderByDescending(ev => ev.StartDate).ThenBy(ev => ev.Status != "Active").ToList();
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
            try
            {
                var transformedNameEvent = DALConstraint.Instance.TransformString(searchText);
                List<EVENT> listEvents = CFEntities.Instance.EVENTs.ToList();
                List<EVENT> filteredList = new List<EVENT>();
                filteredList = listEvents
                    .Where(p =>
                        (string.IsNullOrEmpty(transformedNameEvent) || p.EventName.ToLower().Contains(transformedNameEvent) || p.Status.ToLower().Equals(transformedNameEvent)))
                    .ToList();
                return filteredList;
            }
            catch
            {
                return null;
            }
        

        }

        public bool CheckDrinkEvent(DRINK drink, DateTime startDate, DateTime dueDate)
        {
            try
            {
                var isEventExist = CFEntities.Instance.EVENTs
                            .Any(e => e.DRINKS.Any(d => d.DrinksID == drink.DrinksID)
                                && e.Status == "Active"
                                && !(dueDate < e.StartDate && e.DueDate < startDate));
                return isEventExist;
            }
            catch
            {
                return false;
            }
          
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
                obj.Status = "Active";
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
        public void UpdateStatusEvent()
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                var events = CFEntities.Instance.EVENTs
                    .Where(p => p.DueDate < currentDate && p.Status.Equals("Active"))
                    .ToList();
                foreach (var ev in events)
                {
                    ev.Status = "Expire";
                }
                CFEntities.Instance.SaveChanges();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
