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
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
            CheckedBtnState(btnProductList);
        }

        private Guna2GradientButton CurrentBtn;

        private void CheckedBtnState (object button)
        {
            var btn = (Guna2GradientButton)button;
            btn.BackColor = Color.Transparent;
            btn.FillColor = Color.FromArgb(147, 90, 21);
            btn.FillColor2 = Color.FromArgb(147, 90, 21);
            btn.ForeColor = Color.White;

            if (CurrentBtn != null && CurrentBtn != btn)
            {
                CurrentBtn.FillColor = Color.FromArgb(234, 182, 134);
                CurrentBtn.FillColor2 = Color.FromArgb(234, 182, 134);
                CurrentBtn.ForeColor = Color.White;
            }
            CurrentBtn = btn;
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            
            uCProducts_TabProducts = new UCProducts_TabProducts();
            uCProducts_TabProducts.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(uCProducts_TabProducts);
            CheckedBtnState(sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            
            uCProducts_TabCategory = new UCProducts_TabCategory();
            uCProducts_TabCategory.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(uCProducts_TabCategory);
            CheckedBtnState(sender);
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
           
            uCProducts_TabProducts = new UCProducts_TabProducts();
            uCProducts_TabProducts.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(uCProducts_TabProducts);
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            ucSize = new UCSize();
            ucSize.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(ucSize);
            CheckedBtnState(sender);
        }
    }
}
