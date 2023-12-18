using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class UCSettings : UserControl
    {
        private C_USER user;

        public UCSettings(C_USER user)
        {
            InitializeComponent();
            this.user = user;
            tbAddress.Text = user.Address;
            tbDoB.Text = user.DateOfBirth.ToString();
            tbEmail.Text = user.Email;
            tbName.Text = user.UserFullName;
            tbPhone.Text = user.Phone.ToString();
            tbUsername.Text = user.UserName;

            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
