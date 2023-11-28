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
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Visible = true;
            pictureBox1.Visible = true;
            btnShow.Visible = false;
            btnHide.Visible = true;
            Menu.Visible = false;
            Menu.Width = 199;
            guna2Transition1.ShowSync(Menu);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Visible = false;
            pictureBox1.Visible = false;
            Menu.Visible = false;
            btnHide.Visible = false;
            btnShow.Visible = true;
            Menu.Width = 75;
            guna2Transition1.ShowSync(Menu);
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
    }
}
