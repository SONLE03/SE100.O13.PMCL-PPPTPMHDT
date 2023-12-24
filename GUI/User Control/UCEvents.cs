﻿using DTO;
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
            if (addNewEvent.getAnyChanged() == true)
            {
                LoadEvent(BUS.BUSEvent.Instance.GetAllEvent());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var events = new List<EVENT>();
            foreach(var p in BUS.BUSEvent.Instance.GetAllEvent())
            {
                if (p.EventName.Contains(txtSearch.Text))
                {
                    events.Add(p);
                }    
            }
            LoadEvent(events);
        }

        private void gridviewEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == gridviewEvent.Columns["Edit"].Index)
            {
                var editEvent = new AddNewEvent(gridviewEvent.Rows[idx].Cells["Event_ID"].Value.ToString());
                editEvent.ShowDialog();
                LoadEvent(BUS.BUSEvent.Instance.GetAllEvent());
            }
        }
    }
}
