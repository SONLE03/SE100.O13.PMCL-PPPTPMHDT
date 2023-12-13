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
    public partial class UCImport : UserControl
    {
        public UCImport()
        {
            InitializeComponent();
          
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ucSuppliers = new UCImport_TabSupplier();
            ucSuppliers.Dock = DockStyle.Fill;
            this.PanelImport.Controls.Clear();
            this.PanelImport.Controls.Add(ucSuppliers);
        }

        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            ucIO = new UCImport_TabImportOrder();
            ucIO.Dock = DockStyle.Fill;
            this.PanelImport.Controls.Clear();
            this.PanelImport.Controls.Add(ucIO);
        }

        private void UCImport_Load(object sender, EventArgs e)
        {
            ucSuppliers = new UCImport_TabSupplier();
            ucSuppliers.Dock = DockStyle.Fill;
            this.PanelImport.Controls.Clear();
            this.PanelImport.Controls.Add(ucSuppliers);
        }
    }
}
