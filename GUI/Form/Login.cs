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

            var user = BUSUser.Instance.GetUserByUsername(userName);

            if (user != null)
            {
                if (user.GROUPUSER.GroupUserName.Equals("Manager"))
                {
                    HomeManager home = new HomeManager(user);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    // Staff screen
                }
            }
            else
            {
                MessageBox.Show("Failed to authenticate, please check your username and password");
            }
        }

        private void checkbox_male_Click(object sender, EventArgs e)
        {
            if (checkbox_male.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            checkbox_male.Checked = !checkbox_male.Checked;
            if (checkbox_male.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void link_forgot_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetEmailCode getEmailCode = new GetEmailCode();
            this.Hide();
            getEmailCode.Show();
        }
    }
}
