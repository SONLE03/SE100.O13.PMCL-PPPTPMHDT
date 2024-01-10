using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public partial class EnterCode : Form
    {
        private C_USER user;
        private string otp;

        public EnterCode(C_USER user, string otp)
        {
            InitializeComponent();
            this.user = user;
            this.otp = otp;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string inputOTP = txtEmailCode.Text.ToString();
            if (otp.Equals(inputOTP))
            {
                this.Hide();
                ChangePassword changePassword = new ChangePassword(user);
                changePassword.Show();
            }   
            else
            {
                MessageBox.Show("Wrong OTP recovery code");
            }    
        }

        private void link_get_again_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GetEmailCode getEmailCode = new GetEmailCode(user.UserName);
            getEmailCode.ShowDialog();
        }
    }
}
