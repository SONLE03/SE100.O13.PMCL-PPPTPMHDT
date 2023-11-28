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
    public partial class ChangePassword : Form
    {
        private C_USER user;
        public ChangePassword(C_USER user)
        {
            InitializeComponent();
            this.user = user;  
        }

        private void btn_SaveChange_Click(object sender, EventArgs e)
        {
            string newPassword = txtPass.Text.ToString();
            string retypePassword = txtRetypePass.Text.ToString();

            if (String.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("You must enter your new password");
            }
            else
            {
                if (newPassword.Equals(retypePassword))
                {
                    if (BUSUser.Instance.UpdPassword(user.id, newPassword))
                    {
                        MessageBox.Show("Change password successfully");
                        this.Hide();

                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Change password failed, please check again your password");
                    }
                }
                else
                {
                    MessageBox.Show("New password and retype password are not same");
                }
            }
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }
    }
}
