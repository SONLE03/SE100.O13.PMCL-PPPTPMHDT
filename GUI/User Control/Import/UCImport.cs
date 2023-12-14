using Guna.UI2.WinForms;
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
            InitializeContainer();
        }
        private UCImport_TabSupplier _tabSupplier;
        private UCImport_TabImportOrder _tabImportOrder;

        private void InitializeContainer()
        {
            this.PanelImport.Controls.Clear();
            _tabImportOrder = new UCImport_TabImportOrder() { Dock = DockStyle.Fill, Name = "IO" };
            _tabSupplier = new UCImport_TabSupplier() { Dock = DockStyle.Fill, Name = "IS" };
            this.PanelImport.Controls.Add(_tabSupplier);
            this.PanelImport.Controls.Add(_tabImportOrder);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Control[] con = PanelImport.Controls.Find("IS", false);
            con[0].BringToFront();
        }

        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            Control[] con = PanelImport.Controls.Find("IO", false);
            con[0].BringToFront();
        }

        private void UCImport_Load(object sender, EventArgs e)
        {
          
        }
    }
}
