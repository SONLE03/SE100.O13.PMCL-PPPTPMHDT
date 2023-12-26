using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EventDetails : Form
    {
        private EVENT Event;
        public EventDetails(int id)
        {
            InitializeComponent();
            Bind(id);
        }

        private void Bind(int id)
        {
            Event = BUSEvent.Instance.GetEventById(id);
            lbEventID.Text = Event.EventID;
            lbEventName.Text = Event.EventName;
            lbStartdate.Text = Event.StartDate.Value.Date.ToString("dd/MM/yyyy");
            lbEndDate.Text = Event.DueDate.Value.Date.ToString("dd/MM/yyyy");
            if (Event.EventType)
            {
                lbEventType.Text = "Discount by percentage";
            }
            else
            {
                lbEventType.Text = "Sale same price";
            }
            lbValue.Text = Event.Discount.ToString() + " " + Event.Unit.ToString();
            foreach(var ev in Event.DRINKS)
            {
                gridviewEventAppliedProductDetails.Rows.Add(ev.DrinksID, ev.DrinksName, ev.CATEGORY.CategoryName);
            }
        }

        private void bthClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
