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
        public HomeManager()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Visible = true;
            pictureBox1.Visible = true;
            btnShow.Visible = false;
            btnHide.Visible = true;
            Menu.Visible = false;
            Menu.Width = 245;
            guna2Transition1.ShowSync(Menu);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Visible = false;
            pictureBox1.Visible = false;
            Menu.Visible = false;
            btnHide.Visible = false;
            btnShow.Visible = true;
            Menu.Width = 80;
            guna2Transition1.ShowSync(Menu);
        }
    }
}
