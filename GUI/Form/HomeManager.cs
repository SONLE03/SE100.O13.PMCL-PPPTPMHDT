using BUS;
using DTO;
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
    public partial class HomeManager : Form
    {
        private C_USER user;
        public HomeManager(C_USER user)
        {
            InitializeComponent();
            this.user = user;
            BUSUser.Instance.idUserLogin = user.id;
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }    
        }

        bool menuExpand = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!guna2Transition1.IsCompleted) return;
            if (Menu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!menuExpand)
                {
                    menuExpand = true;
                    Menu.Visible = false;
                    Menu.Width = 200;
                    guna2Transition1.Show(Menu);
                }
            }
            else
            {
                if (menuExpand)
                {
                    menuExpand = false;
                    Menu.Visible = false;
                    Menu.Width = 75;
                    guna2Transition1.Show(Menu);
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ucHome = new UCHome();
            ucHome.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucHome);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            ucProducts = new UCProducts();
            ucProducts.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucProducts);
        }

        private void Tables_Click(object sender, EventArgs e)
        {
            ucTables = new UCTables();
            ucTables.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucTables);
        }

        private void Bills_Click(object sender, EventArgs e)
        {
            ucBills = new UCBill(user);
            ucBills.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucBills);
        }

        private void Events_Click(object sender, EventArgs e)
        {
            ucEvents = new UCEvents();
            ucEvents.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucEvents);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            ucImport = new UCImport();
            ucImport.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucImport);        
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            ucEmployees = new UCEmployees();
            ucEmployees.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucEmployees);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            var ucSetting = new UCSettings(user);
            ucSetting.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucSetting);
        }

        private void btnChangeRegulation_Click(object sender, EventArgs e)
        {
            ucChangeRegulations = new UCChangeRegulations();
            ucChangeRegulations.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucChangeRegulations);
        }
    }
}
