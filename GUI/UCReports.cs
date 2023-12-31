using BUS;
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
    public partial class UCReports : UserControl
    {
        public UCReports()
        {
            InitializeComponent();
            InitializeContainer();
            CheckedBtnState(btnRevenue);
        }
        private UCReportRevenue _reportRevenue;
        private UCReportDrink _reportDrink;

        private void InitializeContainer()
        {
            this.PanelImport.Controls.Clear();
            _reportRevenue = new UCReportRevenue() { Dock = DockStyle.Fill, Name = "RR" };
            _reportDrink = new UCReportDrink() { Dock = DockStyle.Fill, Name = "RD" };
            this.PanelImport.Controls.Add(_reportRevenue);
            this.PanelImport.Controls.Add(_reportDrink);
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
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Control[] con = PanelImport.Controls.Find("RR", false);
            con[0].BringToFront();
            CheckedBtnState(sender);
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            Control[] con = PanelImport.Controls.Find("RD", false);
            con[0].BringToFront();
            CheckedBtnState(sender);
        }
    }
}
