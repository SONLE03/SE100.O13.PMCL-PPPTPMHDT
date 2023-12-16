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
    public partial class EmployeeDetails : Form
    {
        private C_USER user;
        public EmployeeDetails(int id)
        {
            InitializeComponent();
            user = BUSUser.Instance.GetUserById(id);
            lbAddress.Text = user.Address;
            lbBirthday.Text = user.DateOfBirth.ToString();
            lbEmail.Text = user.Email;
            lbEmployeeID.Text = id.ToString();
            lbEmployeeName.Text = user.UserFullName;
            lbPhone.Text = user.Phone;
            lbUsername.Text = user.UserName;
            lbUserGroup.Text = user.GROUPUSER.GroupUserName;
        }
    }
}
