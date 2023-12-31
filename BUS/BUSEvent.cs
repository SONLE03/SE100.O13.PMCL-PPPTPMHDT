using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
        public List<EVENT> SearchEvent(string searchText)
        {
            return DALEvent.Instance.SearchEvent(searchText);
        }

        public int AddEvent(string EventName, bool EventType, string Unit, DateTime StartDate, DateTime DueDate, float Discount, List<DRINK> drinks, int userId)
        {
            if(!BUSConstraint.Instance.DateTimeValidatorInEvent(StartDate, DueDate))
            {
                MessageBox.Show("Date validation failed. Please check again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            if (Unit.Equals("%") && Discount > BUSRule.Instance.GetAllRule().MaximumPercentDiscount)
            {
                MessageBox.Show("Invalid discount value. Please check again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return DALEvent.Instance.AddEvent(EventName, EventType, Unit, StartDate, DueDate, Discount, drinks, userId);
        }
        public bool UpdEvent(int idEV, string EventName, bool EventType, string Unit, DateTime StartDate, DateTime DueDate, float Discount, List<DRINK> drinks, string Status, int userId)
        {
            //if (!BUSConstraint.Instance.DateTimeValidatorInEvent(StartDate, DueDate))
            //{
            //    MessageBox.Show("Date validation failed. Please check again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            if (Unit.Equals("%") && Discount > BUSRule.Instance.GetAllRule().MaximumPercentDiscount)
            {
                MessageBox.Show("Invalid discount value. Please check again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return DALEvent.Instance.UpdEvent(idEV, EventName, EventType, Unit, StartDate, DueDate, Discount, drinks, Status, userId);
        }
        public bool DelEvent(int idEV)
        {
            return DALEvent.Instance.DelEvent(idEV);
        }
        public void UpdateStatusEvent()
        {
            DALEvent.Instance.UpdateStatusEvent();
        }
    }
}
