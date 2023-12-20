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
    public partial class UCEmployees_TabUserGroup : UserControl
    {
        public UCEmployees_TabUserGroup()
        {
            InitializeComponent();
            setUserGroupStatus();
            Binding(BUSGroupUser.Instance.GetAllGroupUser());
        }
        public void Binding(List<GROUPUSER> groupUser)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewUserGroup.Rows.Clear();
            foreach (GROUPUSER us in groupUser)
            {
                gridviewUserGroup.Rows.Add(us.id, us.GroupUserID, us.GroupUserName, us.Status, edit_img);
            }
        }
        private void setUserGroupStatus()
        {
            cbStatus.Items.AddRange(new string[] { "All", "Active", "InActive" });
            cbStatus.SelectedIndex = 0;
        }

        private void btnAddUsergroup_Click(object sender, EventArgs e)
        {
            AddNewUserGroup addNewUserGroup = new AddNewUserGroup();
            addNewUserGroup.ShowDialog();
            Binding(BUSGroupUser.Instance.GetAllGroupUser());
        }

        private void gridviewUserGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            int userGroupId = Convert.ToInt32(gridviewUserGroup.Rows[idx].Cells["ID"].Value);
            if (e.ColumnIndex == gridviewUserGroup.Columns["Edit"].Index)
            {
                if (userGroupId == 1 || userGroupId == 2)
                {
                    MessageBox.Show("This user group cannot be modified", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }else if (BUSUser.Instance.checkUserInUserGroupLogin(userGroupId))
                {
                    MessageBox.Show("This user group cannot be modified, Account is logged in", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                EditUserGroup editUserGroup = new EditUserGroup(userGroupId);
                editUserGroup.ShowDialog();
                Binding(BUSGroupUser.Instance.GetAllGroupUser());
            }
            else
            {
                UserGroupDetails userGroupDetails = new UserGroupDetails(userGroupId);
                userGroupDetails.ShowDialog();
            }
            

        }
        private void Search()
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                string selectedStatus = cbStatus.Text;
                List<GROUPUSER> listGroupUser = BUSGroupUser.Instance.SearchGroupUser(searchText, selectedStatus);
                Binding(listGroupUser);
            }
            catch
            {

            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
