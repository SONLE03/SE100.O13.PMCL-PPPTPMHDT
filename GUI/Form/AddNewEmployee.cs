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
    public partial class AddNewEmployee : Form
    {
        private string fileImageAvatar;
        public AddNewEmployee()
        {
            InitializeComponent();
            getUserGroup();
        }
        private void getUserGroup()
        {
            combobox_usergroup.DataSource = null;
            var userGroup = BUSGroupUser.Instance.GetAllGroupUser();
            combobox_usergroup.DataSource = userGroup;
            combobox_usergroup.ValueMember = "id";
            combobox_usergroup.DisplayMember = "GroupUserName";
        }
        private void Clear()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtUserFullName.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            txtRetypePass.Clear();
            txtUsername.Clear();
            fileImageAvatar = null;
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileImageAvatar = openFileDialog.FileName;

                if (!String.IsNullOrEmpty(fileImageAvatar))
                {
                    avatar.Image = new Bitmap(fileImageAvatar);
                }
                else
                {
                    MessageBox.Show("Error: maybe it can't load this type of image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to add?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtUserFullName.Text)
                    && !String.IsNullOrEmpty(txtPass.Text) && !String.IsNullOrEmpty(txtPhone.Text) && !String.IsNullOrEmpty(txtRetypePass.Text)
                    && !String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(cbStatus.Text) && !String.IsNullOrEmpty(combobox_usergroup.Text) && !String.IsNullOrEmpty(fileImageAvatar))
                    {
                        var isSuccess = BUSUser.Instance.AddUser(txtUserFullName.Text, DateOfBirth.Value, txtAddress.Text, txtPhone.Text, txtUsername.Text
                            , txtPass.Text, txtRetypePass.Text, txtEmail.Text, Convert.ToInt32(combobox_usergroup.SelectedValue), fileImageAvatar, cbStatus.Text);
                        if (isSuccess)
                        {
                            Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
