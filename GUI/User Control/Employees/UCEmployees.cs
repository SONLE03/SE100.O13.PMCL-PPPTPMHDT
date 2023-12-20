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
    public partial class UCEmployees : UserControl
    {
        private UCEmployees_TabEmployees tabEmployees;
        private UCEmployees_TabUserGroup userUserGroup;
        public UCEmployees()
        {
            InitializeComponent();
            InitializeContainer();
            CheckedBtnState(btnEmployees);
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
        private void InitializeContainer()
        {
            this.panelControl.Controls.Clear();
            tabEmployees = new UCEmployees_TabEmployees() { Dock = DockStyle.Fill, Name = "IE" };
            userUserGroup = new UCEmployees_TabUserGroup() { Dock = DockStyle.Fill, Name = "IU" };
            this.panelControl.Controls.Add(tabEmployees);
            this.panelControl.Controls.Add(userUserGroup);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Control[] con = panelControl.Controls.Find("IE", false);
            con[0].BringToFront();
            CheckedBtnState(sender);
        }

        private void btnUsergroup_Click(object sender, EventArgs e)
        {
            Control[] con = panelControl.Controls.Find("IU", false);
            con[0].BringToFront();
            CheckedBtnState(sender);
        }
    }
}
