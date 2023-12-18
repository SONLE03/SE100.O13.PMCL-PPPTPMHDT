using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSEvent
    {
        private static BUSEvent instance;

        public static BUSEvent Instance
        {
            get
            {
                if (instance == null) instance = new BUSEvent();
                return instance;
            }
            set { instance = value; }
        }

        public List<EVENT> GetAllEvent()
        {
            return DALEvent.Instance.GetAllEvent();
        }
        public EVENT GetEventById(int id)
        {
            return DALEvent.Instance.GetEventById(id);
        }
        public EVENT GetEventByCode(string EventID)
        {
            return DALEvent.Instance.GetEventByCode(EventID);
        }
        public bool AddEvent(string EventName, bool EventType, string Unit, DateTime StartDate, DateTime DueDate, float Discount, List<DRINK> drinks)
        {
            return DALEvent.Instance.AddEvent(EventName, EventType, Unit, StartDate, DueDate, Discount, drinks);
        }
        public bool UpdEvent(int idEV, DateTime DueDate, float Discount, List<DRINK> drinks, string Status)
        {
            return DALEvent.Instance.UpdEvent(idEV, DueDate, Discount, Status, drinks);
        }
        public bool DelEvent(int idEV)
        {
            return DALEvent.Instance.DelEvent(idEV);
        }
    }
}
