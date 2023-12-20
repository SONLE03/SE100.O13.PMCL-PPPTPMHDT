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
    public partial class UCTables : UserControl
    {
        public UCTables()
        {
            InitializeComponent();
            CheckedBtnState(btnTable);
        }

        private Guna2GradientButton CurrentBtn;

        private void CheckedBtnState(object button)
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

        private void btnTable_Click(object sender, EventArgs e)
        {
            ucTables_Tables = new UCTables_TabTables();
            ucTables_Tables.Dock = DockStyle.Fill;
            this.PanelTables.Controls.Clear();
            this.PanelTables.Controls.Add(ucTables_Tables);
            CheckedBtnState(sender);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            ucTables_Areas = new UCTables_TabAreas();
            ucTables_Areas.Dock = DockStyle.Fill;
            this.PanelTables.Controls.Clear();
            this.PanelTables.Controls.Add(ucTables_Areas);
            CheckedBtnState(sender);
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
