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
    public partial class UCEvents : UserControl
    {
        public UCEvents()
        {
            InitializeComponent();
            LoadEvent(BUS.BUSEvent.Instance.GetAllEvent());
        }

        private void LoadEvent(List<EVENT> events)
        {
            string unit = "%";
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            Image del_img = Properties.Resources.trash;
            del_img = (Image)(new Bitmap(del_img, new Size(25, 25)));
            gridviewEvent.Rows.Clear();
            gridviewEvent.Refresh();
            events.ForEach(p =>
            {
                if (p.Unit.Equals("%"))
                {
                    unit = "Percentage";
                }
                else
                {
                    unit = "VND";
                }
                gridviewEvent.Rows.Add(p.id, p.EventID, p.EventName, p.StartDate, p.DueDate, p.Discount, unit, p.Status, edit_img, del_img);
            });
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddNewEvent addNewEvent = new AddNewEvent();
            addNewEvent.ShowDialog();
            LoadEvent(BUS.BUSEvent.Instance.GetAllEvent());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            LoadEvent(BUSEvent.Instance.SearchEvent(searchText));
        }

        private void gridviewEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == gridviewEvent.Columns["Edit"].Index)
            {
                var editEvent = new EditEvent(Convert.ToInt32(gridviewEvent.Rows[idx].Cells["ID"].Value));
                editEvent.ShowDialog();
                LoadEvent(BUSEvent.Instance.GetAllEvent());
            }else if (e.ColumnIndex == gridviewEvent.Columns["Delete"].Index)
            {
                DialogResult result = MessageBox.Show("Are you sure want to remove?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSEvent.Instance.DelEvent(Convert.ToInt32(gridviewEvent.Rows[idx].Cells["ID"].Value));
                    LoadEvent(BUSEvent.Instance.GetAllEvent());
                }
            }
            else
            {
                var eventdetail = new EventDetails(Convert.ToInt32(gridviewEvent.Rows[idx].Cells["ID"].Value));
                eventdetail.ShowDialog();
            }
        }
    }
}
