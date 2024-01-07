using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class UCSettings : UserControl
    {
        private C_USER user;
        private string fileImageAvatar;
        public UCSettings(C_USER user)
        {
            InitializeComponent();
            this.user = user;
            Bind();
        }
        private void Bind()
        {
            try
            {
                lbRole.Text = user.GROUPUSER.GroupUserName;
                txtUserFullName.Text = user.UserFullName;
                txtEmail.Text = user.Email;
                txtAddress.Text = user.Address;
                txtPhone.Text = user.Phone;
                DateOfBirth.Value = (DateTime)user.DateOfBirth;
                fileImageAvatar = user.Image;
                avatar.Image = Image.FromFile(user.Image);
                lbUserName.Text = user.UserName;
                lbPassword.Text = "********";
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

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtUserFullName.Text)
                    && !String.IsNullOrEmpty(txtPhone.Text)  && !String.IsNullOrEmpty(fileImageAvatar))
                {
                    var isSuccess = BUSUser.Instance.UpdUser(user.id, txtUserFullName.Text, DateOfBirth.Value, txtAddress.Text, txtEmail.Text, txtPhone.Text
                        , user.GroupUserID, user.Status, fileImageAvatar);
                }
                else
                {
                    MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
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

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(user);
            changePassword.ShowDialog();
            Bind();
        }
    }
}
