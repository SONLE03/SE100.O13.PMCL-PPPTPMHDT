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
        }

        private void btnUsergroup_Click(object sender, EventArgs e)
        {
            Control[] con = panelControl.Controls.Find("IU", false);
            con[0].BringToFront();
        }
    }
}
