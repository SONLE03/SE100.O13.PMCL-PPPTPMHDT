using BUS;
using DTO;
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
    public partial class HomeManager : Form
    {
        // List of service in the system
        // Service 1: Home screen
        // Service 2: Drink management
        // Service 3: Table
        // Service 4: Order
        // Service 5: Event
        // Service 6: Import
        // Service 7: Employee
        // Service 8: Report
        // Service 9: Rule
        // Service 10: Setting
        private C_USER user;
        private static List<int> services;
        public HomeManager(C_USER user)
        {
            InitializeComponent();
            this.user = user;
            BUSUser.Instance.SetUserLoginInfo(user.id);
            services = new List<int>();
            foreach (var service in BUSUser.Instance.GetUserById(user.id).GROUPUSER.SERVICEs)
            {
                services.Add(service.id);
            }
            // Update state of event in the system
            BUSEvent.Instance.UpdateStatusEvent();
        }

        private Guna2Button CurrentBtn;

        private void CheckedBtnState(object button)
        {
            var btn = (Guna2Button)button;
            btn.BackColor = Color.Transparent;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.FromArgb(127, 81, 26);
            //btn.CustomImages.Image = btn.CustomImages.HoveredImage;

            if (CurrentBtn != null && CurrentBtn != btn)
            {
                CurrentBtn.FillColor = Color.Transparent;
                CurrentBtn.ForeColor = Color.White;
            }
            CurrentBtn = btn;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Your revenue is {BUSOrder.Instance.revenue} VND. Are you sure to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }    
        }

        bool menuExpand = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            //if (!guna2Transition1.IsCompleted) return;
            //if (Menu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            //{
            //    if (!menuExpand)
            //    {
            //        menuExpand = true;
            //        Menu.Visible = false;
            //        Menu.Width = 200;
            //        guna2Transition1.Show(Menu);
            //    }
            //}
            //else
            //{
            //    if (menuExpand)
            //    {
            //        menuExpand = false;
            //        Menu.Visible = false;
            //        Menu.Width = 75;
            //        guna2Transition1.Show(Menu);
            //    }
            //}
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //ucHome = new UCHome();
            //ucHome.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucHome);
            CheckPermissionAndOpenControl(1, new UCHome());
            CheckedBtnState(sender);
        }
        private void CheckPermissionAndOpenControl(int service, UserControl userControl)
        {
            try
            {
                if (services.Contains(service))
                {
                    userControl.Dock = DockStyle.Fill;
                    this.TabUC.Controls.Clear();
                    this.TabUC.Controls.Add(userControl);
                    //CheckedBtnState(sender);
                }
                else
                {
                    // Add ucBlock
                }
            }
            catch
            {

            }
        }
        private void Products_Click(object sender, EventArgs e)
        {
            //ucProducts = new UCProducts();
            //ucProducts.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucProducts);
            CheckPermissionAndOpenControl(2, new UCProducts());
            CheckedBtnState(sender);
        }

        private void Tables_Click(object sender, EventArgs e)
        {
            //ucTables = new UCTables();
            //ucTables.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucTables);
            CheckPermissionAndOpenControl(3, new UCTables());
            CheckedBtnState(sender);
        }

        private void Bills_Click(object sender, EventArgs e)
        {
            //ucBills = new UCBill(user);
            //ucBills.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucBills);
            CheckPermissionAndOpenControl(4, new UCBill(user));
            CheckedBtnState(sender);
        }

        private void Events_Click(object sender, EventArgs e)
        {
            //ucEvents = new UCEvents();
            //ucEvents.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucEvents);
            CheckPermissionAndOpenControl(5, new UCEvents());
            CheckedBtnState(sender);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            //ucImport = new UCImport();
            //ucImport.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucImport);
            CheckPermissionAndOpenControl(6, new UCImport());
            CheckedBtnState(sender);
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            //ucEmployees = new UCEmployees();
            //ucEmployees.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucEmployees);
            CheckPermissionAndOpenControl(7, new UCEmployees());
            CheckedBtnState(sender);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            //var ucSetting = new UCSettings(user);
            //ucSetting.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucSetting);
            CheckPermissionAndOpenControl(10, new UCSettings());
            CheckedBtnState(sender);
        }

        private void btnChangeRegulation_Click(object sender, EventArgs e)
        {
            //ucChangeRegulations = new UCChangeRegulations();
            //ucChangeRegulations.Dock = DockStyle.Fill;
            //this.TabUC.Controls.Clear();
            //this.TabUC.Controls.Add(ucChangeRegulations);
            CheckPermissionAndOpenControl(9, new UCChangeRegulations());
            CheckedBtnState(sender);
        }

        private void HomeManager_Load(object sender, EventArgs e)
        {
            ucWelcome = new UCWelcome();
            ucWelcome.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucWelcome);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            CheckPermissionAndOpenControl(8, new UCReports());
            CheckedBtnState(sender);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Your revenue is {BUSOrder.Instance.revenue} VND. Are you sure to exit ?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
               Environment.Exit(0);
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            ucWelcome = new UCWelcome();
            ucWelcome.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucWelcome);
        }
    }
}
