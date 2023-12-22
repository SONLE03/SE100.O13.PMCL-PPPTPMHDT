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

        private void LoadEvent(List<EVENT> events)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewEvent.Rows.Clear();
            gridviewEvent.Refresh();
            events.ForEach(p =>
            {
                gridviewEvent.Rows.Add(p.id, p.EventID, p.EventName, p.StartDate, p.DueDate, p.EventType, p.Discount, p.Status, edit_img);
            });
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddNewEvent addNewEvent = new AddNewEvent();
            addNewEvent.ShowDialog();
        }
    }
}
