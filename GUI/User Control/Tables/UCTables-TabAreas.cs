using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class UCTables_TabAreas : UserControl
    {
        public UCTables_TabAreas()
        {
            InitializeComponent();
            setAreaStatus();
        }

        private void setAreaStatus()
        {
            cbStatus.Items.AddRange(new string[] { "All", "Active", "InActive" });
            cbStatus.SelectedIndex = 0;
        }

        public void LoadArea(List<AREA> listAreas)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewArea.Rows.Clear();
            gridviewArea.Refresh();
            listAreas.ForEach(p =>
            {
                gridviewArea.Rows.Add(p.id, p.AreaID, p.AreaName, p.Status, edit_img);
            });
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            AddArea addArea = new AddArea();
            addArea.ShowDialog();
            LoadArea(BUS.BUSArea.Instance.GetAllArea());
        }

        private void Search()
        {
            //List<AREA> listArea;
            //if (string.Equals(cbStatus.Text, "All", StringComparison.OrdinalIgnoreCase))
            //{
            //    listArea = BUSArea.Instance.GetAllArea();
            //}
            //else if(string.Equals(cbStatus.Text, "Active", StringComparison.OrdinalIgnoreCase))
            //{
            //    listArea = BUS.BUSArea.Instance.GetAllAreaActive();
            //}
            //else
            //{
            //    listArea = BUS.BUSArea.Instance.GetAllAreaInActive();
            //}
            //List<AREA> filteredList = listArea.Where(p => p.AreaName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            //LoadArea(filteredList);
            string searchText = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cbStatus.Text;
            LoadArea(BUSArea.Instance.Search(searchText, selectedStatus));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void gridviewArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == gridviewArea.Columns["Edit"].Index)
            {
                EditArea editArea = new EditArea(Convert.ToInt32(gridviewArea.Rows[idx].Cells["ID"].Value));
                editArea.ShowDialog();
                LoadArea(BUS.BUSArea.Instance.GetAllArea());
            }
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
