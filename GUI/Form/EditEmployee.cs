using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace GUI
{
    public partial class EditEmployee : Form
    {
        private C_USER user;
        private string fileImageAvatar;
        public EditEmployee(int id)
        {
            InitializeComponent();
            user = BUSUser.Instance.GetUserById(id);
            getUserGroup();
            Binding(user);
        }
        private void Binding(C_USER user)
        {
            try
            {
                lbUserID.Text = user.UserID;
                txtAddress.Text = user.Address;
                DateOfBirth.Text = user.DateOfBirth.ToString();
                txtEmail.Text = user.Email;
                txtUserFullName.Text = user.UserFullName;
                txtPhone.Text = user.Phone;
                combobox_usergroup.Text = user.GROUPUSER.GroupUserName;
                cbStatus.Text = user.Status;
                avatar.Image = Image.FromFile(user.Image);
                fileImageAvatar = user.Image;
            }
            catch
            {
                string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                string imagePathError = Path.Combine(resourcesFolder, "NotFoundImage.png");
                avatar.Image = new System.Drawing.Bitmap(imagePathError);
                BUSUser.Instance.UpdateImageErrorNotFound(user.id, imagePathError);
            }
        }
        private void getUserGroup()
        {
            var ug = BUSGroupUser.Instance.GetAllGroupUser();
            combobox_usergroup.DataSource = ug;
            combobox_usergroup.ValueMember = "id";
            combobox_usergroup.DisplayMember = "GroupUserName";
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to modify?", "Confirm modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtUserFullName.Text)
                    && !String.IsNullOrEmpty(txtPhone.Text) && !String.IsNullOrEmpty(cbStatus.Text) && !String.IsNullOrEmpty(combobox_usergroup.Text) && !String.IsNullOrEmpty(fileImageAvatar))
                    {
                        var isSuccess = BUSUser.Instance.UpdUser(user.id, txtUserFullName.Text, DateOfBirth.Value, txtAddress.Text
                            , txtEmail.Text, txtPhone.Text, Convert.ToInt32(combobox_usergroup.SelectedValue), cbStatus.Text, fileImageAvatar, user.Password);
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
    }
}
