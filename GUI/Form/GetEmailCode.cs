using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using GUI;

namespace GUI
{
    public partial class GetEmailCode : Form
    {
        public GetEmailCode()
        {
            InitializeComponent();
        }

        public GetEmailCode(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
            MessageBox.Show("Maybe your input username isn't correct, check and input again");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string GenerateOTP()
        {
            Random random = new Random();
            int otpValue = random.Next(100000, 999999);
            return otpValue.ToString();
        }

        private void btn_sendcode_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.ToString();
            string OTP = GenerateOTP();
            
            var user = BUSUser.Instance.GetUserByUsername(userName);

            if (!String.IsNullOrEmpty(userName))
            {
                if (SendEmail(user.Email, OTP) == true)
                {
                    this.Hide();
                    EnterCode enterCode = new EnterCode(user, OTP);
                    enterCode.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not found username: " + userName);
                }
            }
            else
            {
                MessageBox.Show("You must enter your username and email");
            }

        }

        private bool SendEmail(string toEmail, object otp)
        {
            string fromEmail = "sonle102003@gmail.com";
            string password = "ykzqjdquybpdbzkt";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, password),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage(fromEmail, toEmail, "Your OTP Code", $"Your OTP code is: {otp}");

            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}");
                return false;
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
