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
        public HomeManager()//C_USER user)
        {
            InitializeComponent();
            this.user = user;
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
                    Menu.Width = 72;
                    guna2Transition1.Show(Menu);
                }
            }
        }
    }
}
