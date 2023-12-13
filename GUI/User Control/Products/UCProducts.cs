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
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            uCProducts_TabProducts = new UCProducts_TabProducts();
            uCProducts_TabProducts.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(uCProducts_TabProducts);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            uCProducts_TabCategory = new UCProducts_TabCategory();
            uCProducts_TabCategory.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(uCProducts_TabCategory);
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            uCProducts_TabProducts = new UCProducts_TabProducts();
            uCProducts_TabProducts.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(uCProducts_TabProducts);
        }
    }
}
