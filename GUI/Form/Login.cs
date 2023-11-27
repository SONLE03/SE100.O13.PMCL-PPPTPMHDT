using BUS;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.ToString();
            string passWord = txtPass.Text.ToString();

            if (BUSUser.Instance.GetUserByUsername(userName) != null)
            {
                MessageBox.Show("Hello " + userName + ".");
            }
            else
            {
                MessageBox.Show("Failed to authenticate, please check your username and password");
            }
        }
    }
}
