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

namespace GUI
{
    public partial class UCTables_TabAreas : UserControl
    {
        public UCTables_TabAreas()
        {
            InitializeComponent();
            LoadArea(BUS.BUSArea.Instance.GetAllArea());
        }

        public void LoadArea(List<AREA> listAreas)
        {
            gridviewArea.Rows.Clear();
            gridviewArea.Refresh();
            listAreas.ForEach(p =>
            {
                gridviewArea.Rows.Add(p.AreaID, p.AreaName, p.ExtraFee, p.Status);
            });
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            AddArea addArea = new AddArea();
            addArea.ShowDialog();
            if (addArea.getAnyChanged())
            {
                LoadArea(BUS.BUSArea.Instance.GetAllArea());
            }    
        }

        private void gridviewArea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == gridviewArea.Columns["AreaID"].Index || e.ColumnIndex == gridviewArea.Columns["Areaname"].Index || e.ColumnIndex == gridviewArea.Columns["ExtraFee"].Index || e.ColumnIndex == gridviewArea.Columns["Status"].Index)
            {
                AddArea addArea = new AddArea(BUS.BUSArea.Instance.GetAreaByCode(gridviewArea.Rows[e.RowIndex].Cells["AreaID"].Value.ToString()).id);
                addArea.ShowDialog();
                if (addArea.getAnyChanged())
                {
                    LoadArea(BUS.BUSArea.Instance.GetAllArea());
                }
            }
            else
            {
                MessageBox.Show("Please double click at rows to update or delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<AREA> listArea = new List<AREA>();
            BUS.BUSArea.Instance.GetAllArea().ToList().ForEach(p =>
            {
                if (p.AreaName.Contains(txtSearch.Text))
                {
                    listArea.Add(p);
                }    
            });
            LoadArea(listArea);
        }
    }
}
