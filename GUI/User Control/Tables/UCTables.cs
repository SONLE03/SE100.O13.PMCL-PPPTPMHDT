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
    public partial class UCTables : UserControl
    {
        public UCTables()
        {
            InitializeComponent();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            ucTables_Tables = new UCTables_TabTables();
            ucTables_Tables.Dock = DockStyle.Fill;
            this.PanelTables.Controls.Clear();
            this.PanelTables.Controls.Add(ucTables_Tables);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            ucTables_Areas = new UCTables_TabAreas();
            ucTables_Areas.Dock = DockStyle.Fill;
            this.PanelTables.Controls.Clear();
            this.PanelTables.Controls.Add(ucTables_Areas);
        }

        private void UCTables_Load(object sender, EventArgs e)
        {
            ucTables_Tables = new UCTables_TabTables();
            ucTables_Tables.Dock = DockStyle.Fill;
            this.PanelTables.Controls.Clear();
            this.PanelTables.Controls.Add(ucTables_Tables);
        }
    }
}
