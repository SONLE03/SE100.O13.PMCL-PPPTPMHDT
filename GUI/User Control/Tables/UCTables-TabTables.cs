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
        }
    }
}
