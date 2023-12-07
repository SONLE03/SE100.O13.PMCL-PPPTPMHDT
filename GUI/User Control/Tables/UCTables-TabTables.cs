using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class UCTables_TabTables : UserControl
    {
        public UCTables_TabTables()
        {
            InitializeComponent();
            LoadTable(BUS.BUSTable.Instance.GetAllTable());
            combobox_area.Items.Add("All");
            BUS.BUSArea.Instance.GetAllArea().ToList().ForEach(p =>
            {
                combobox_area.Items.Add(p.AreaName);
            });
            combobox_area.SelectedItem = "All";
        }

        public void LoadTable(List<C_TABLE> listTables)
        {
            gridviewTable.Rows.Clear();
            gridviewTable.Refresh();
            listTables.ForEach(p =>
            {
                gridviewTable.Rows.Add(p.TableID, p.TableName, p.AREA.AreaName, p.Status);
            });
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddNewTable addNewTable = new AddNewTable();
            addNewTable.ShowDialog();
            if (addNewTable.getAnyChanged())
            {
                LoadTable(BUS.BUSTable.Instance.GetAllTable());
            }    
        }

        private void gridviewTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == gridviewTable.Columns["TableID"].Index || e.ColumnIndex == gridviewTable.Columns["TableName"].Index || e.ColumnIndex == gridviewTable.Columns["AreaID"].Index || e.ColumnIndex == gridviewTable.Columns["Status"].Index)
            {
                TableDetails addNewTable = new TableDetails(gridviewTable.Rows[e.RowIndex].Cells["TableID"].Value.ToString());
                addNewTable.ShowDialog();
                if (addNewTable.getAnyChanged())
                {
                    LoadTable(BUS.BUSTable.Instance.GetAllTable());
                }
            }
            else
            {
                MessageBox.Show("Please double click at rows to update or delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!combobox_area.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<C_TABLE> listTableByAreaAndSearching = new List<C_TABLE>();
                foreach (var p in BUS.BUSTable.Instance.GetAllTable())
                {
                    if (p.TableName.ToLower().Contains(txtSearch.Text.ToString().ToLower()) && p.AREA.AreaName.Equals(combobox_area.SelectedItem.ToString()))
                    {
                        listTableByAreaAndSearching.Add(p);
                    }
                }
                LoadTable(listTableByAreaAndSearching);
            }
            else if (!combobox_area.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<C_TABLE> listTableByAreaAndSearching = new List<C_TABLE>();
                foreach (var p in BUS.BUSTable.Instance.GetAllTable())
                {
                    if (p.AREA.AreaName.Equals(combobox_area.SelectedItem.ToString()))
                    {
                        listTableByAreaAndSearching.Add(p);
                    }
                }
                LoadTable(listTableByAreaAndSearching);
            }
            else if (combobox_area.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<C_TABLE> listTableByAreaAndSearching = new List<C_TABLE>();
                foreach (var p in BUS.BUSTable.Instance.GetAllTable())
                {
                    if (p.TableName.ToLower().Contains(txtSearch.Text.ToString().ToLower()))
                    {
                        listTableByAreaAndSearching.Add(p);
                    }
                }
                LoadTable(listTableByAreaAndSearching);
            }
            else
            {
                LoadTable(BUS.BUSTable.Instance.GetAllTable());
            }
        }

        private void combobox_area_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!combobox_area.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<C_TABLE> listTableByAreaAndSearching = new List<C_TABLE>();
                foreach (var p in BUS.BUSTable.Instance.GetAllTable())
                {
                    if (p.TableName.ToLower().Contains(txtSearch.Text.ToString().ToLower()) && p.AREA.AreaName.Equals(combobox_area.SelectedItem.ToString()))
                    {
                        listTableByAreaAndSearching.Add(p);
                    }
                }
                LoadTable(listTableByAreaAndSearching);
            }
            else if (!combobox_area.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<C_TABLE> listTableByAreaAndSearching = new List<C_TABLE>();
                foreach (var p in BUS.BUSTable.Instance.GetAllTable())
                {
                    if (p.AREA.AreaName.Equals(combobox_area.SelectedItem.ToString()))
                    {
                        listTableByAreaAndSearching.Add(p);
                    }
                }
                LoadTable(listTableByAreaAndSearching);
            }
            else if (combobox_area.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<C_TABLE> listTableByAreaAndSearching = new List<C_TABLE>();
                foreach (var p in BUS.BUSTable.Instance.GetAllTable())
                {
                    if (p.TableName.ToLower().Contains(txtSearch.Text.ToString().ToLower()))
                    {
                        listTableByAreaAndSearching.Add(p);
                    }
                }
                LoadTable(listTableByAreaAndSearching);
            }
            else
            {
                LoadTable(BUS.BUSTable.Instance.GetAllTable());
            }
        }
    }
}
