﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static System.Windows.Forms.MonthCalendar;

namespace GUI
{
    public partial class UCTables_TabTables : UserControl
    {
        public UCTables_TabTables()
        {
            InitializeComponent();
            LoadTable(BUS.BUSTable.Instance.GetAllTable());
            LoadArea();
        }

        public void LoadTable(List<C_TABLE> listTables)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewTable.Rows.Clear();
            gridviewTable.Refresh();
            listTables.ForEach(p =>
            {
                gridviewTable.Rows.Add(p.id, p.TableID, p.TableName, p.AREA.AreaName, p.Status, edit_img);
            });
        }
        public void LoadArea()
        {
            combobox_area.Items.Add("All");
            BUS.BUSArea.Instance.GetAllArea().ToList().ForEach(p =>
            {
                combobox_area.Items.Add(p.AreaName);
            });
            combobox_area.SelectedItem = "All";
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddNewTable addNewTable = new AddNewTable();
            addNewTable.ShowDialog();
            LoadTable(BUS.BUSTable.Instance.GetAllTable());   
        }

        private void Search()
        {
            List<C_TABLE> listTable = new List<C_TABLE>();
            if (String.IsNullOrEmpty(txtSearch.Text.ToString()) && !combobox_area.SelectedItem.ToString().Equals("All"))
            {
                BUSTable.Instance.GetAllTable().ToList().ForEach(p =>
                {
                    if (p.AREA.AreaName.Equals(combobox_area.SelectedItem.ToString()))
                    {
                        listTable.Add(p);
                    }
                });
            }
            else if (!String.IsNullOrEmpty(txtSearch.Text.ToString()) && !combobox_area.SelectedItem.ToString().Equals("All"))
            {
                BUSTable.Instance.GetAllTable().ToList().ForEach(p =>
                {
                    if (p.TableName.ToLower().Contains(txtSearch.Text.ToString().ToLower()) && p.AREA.AreaName.Equals(combobox_area.SelectedItem.ToString()))
                    {
                        listTable.Add(p);
                    }
                });
            }
            else if (!String.IsNullOrEmpty(txtSearch.Text.ToString()) && combobox_area.SelectedItem.ToString().Equals("All"))
            {
                BUSTable.Instance.GetAllTable().ToList().ForEach(p =>
                {
                    if (p.TableName.ToLower().Contains(txtSearch.Text.ToString().ToLower()))
                    {
                        listTable.Add(p);
                    }
                });
            }
            else
            {
                listTable = BUSTable.Instance.GetAllTable();
            }
            LoadTable(listTable);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void combobox_area_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void gridviewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == gridviewTable.Columns["Edit"].Index)
            {
                EditTable editTable = new EditTable(Convert.ToInt32(gridviewTable.Rows[idx].Cells["ID"].Value));
                editTable.ShowDialog();
                LoadTable(BUSTable.Instance.GetAllTable());
            }
            else
            {
                TableDetails tableDetail = new TableDetails(Convert.ToInt32(gridviewTable.Rows[idx].Cells["ID"].Value));
                tableDetail.ShowDialog();
            }
        }
    }
}
