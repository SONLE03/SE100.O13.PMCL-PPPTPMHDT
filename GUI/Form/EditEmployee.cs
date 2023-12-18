using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditEmployee : Form
    {
        private C_USER user;
        public EditEmployee(int id)
        {
            InitializeComponent();
            user = BUSUser.Instance.GetUserById(id);
            getUserGroup();
            Binding(user);
        }
        private void Binding(C_USER user)
        {
            lbEmployeeID.Text = user.id.ToString();
            txtAddress.Text = user.Address;
            dateOfBirth.Text = user.DateOfBirth.ToString();
            txtEmail.Text = user.Email;
            txtEmployeeName.Text = user.UserFullName;
            txtPhone.Text = user.Phone;
            txtUsername.Text = user.UserName;
            combobox_usergroup.Text = user.GROUPUSER.GroupUserName;
        }
        private void getUserGroup()
        {
            var ug = BUSGroupUser.Instance.GetAllGroupUser();
            combobox_usergroup.DataSource = ug;
            combobox_usergroup.ValueMember = "id";
            combobox_usergroup.DisplayMember = "GroupUserName";
        }
    }
}
