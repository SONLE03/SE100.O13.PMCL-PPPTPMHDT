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
            this.AcceptButton = btn_login;
        }

        private void resetTextboxs()
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtUsername.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.ToString();
            string passWord = txtPass.Text.ToString();
            var user = BUSLogin.Instance.checkValidLogin(userName, passWord);

            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Login information is missing!", "Notification", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.resetTextboxs();
                return;
            }
            if (user != null)
            {
                if (!BUSLogin.Instance.checkStatus(user))
                {
                    MessageBox.Show("Failed to authenticate, The account is inactive", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Logged in successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var f = new HomeManager(user);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed to authenticate, please check your username and password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetTextboxs();
            }
        }

        private void checkbox_show_Click(object sender, EventArgs e)
        {
            if (checkbox_show.Checked == true)
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
            //checkbox_male.Checked = !checkbox_male.Checked;
            //if (checkbox_male.Checked == true)
            //{
            //    txtPass.PasswordChar = '\0';
            //}
            //else
            //{
            //    txtPass.PasswordChar = '*';
            //}
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
