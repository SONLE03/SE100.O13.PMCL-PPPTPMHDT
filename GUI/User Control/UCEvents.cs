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
    public partial class UCEvents : UserControl
    {
        public UCEvents()
        {
            InitializeComponent();
            LoadEvent(BUS.BUSEvent.Instance.GetAllEvent());
        }

        private void LoadEvent(List<EVENT> eVENTs)
        {
            gridviewEvent.Rows.Clear();
            gridviewEvent.Refresh();
            eVENTs.ForEach(p =>
            {
                gridviewEvent.Rows.Add(p.EventID, p.EventName, p.StartDate, p.DueDate, p.EventType, p.Unit);
            });
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddNewEvent addNewEvent = new AddNewEvent();
            addNewEvent.ShowDialog();
        }
    }
}
