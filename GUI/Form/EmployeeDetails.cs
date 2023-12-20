using BUS;
using DTO;
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

namespace GUI
{
    public partial class EmployeeDetails : Form
    {
        private C_USER user;
        public EmployeeDetails(int id)
        {
            InitializeComponent();
            user = BUSUser.Instance.GetUserById(id);
            Binding(user);
        }
        private void Binding(C_USER user)
        {
            try
            {
                lbUserID.Text = user.UserID;
                lbAddress.Text = user.Address;
                lbBirthday.Text = user.DateOfBirth.ToString();
                lbEmail.Text = user.Email;
                lbUserName.Text = user.UserFullName;
                lbPhone.Text = user.Phone;
                lbUserGroup.Text = user.GROUPUSER.GroupUserName;
                lbStatus.Text = user.Status;
                avatar.Image = Image.FromFile(user.Image);
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
