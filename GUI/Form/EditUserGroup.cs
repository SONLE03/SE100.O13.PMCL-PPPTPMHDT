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
    public partial class EditUserGroup : Form
    {
        private static int id;
        private string groupUserName;
        public EditUserGroup(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }
        private void Bind() 
        {
            var userGroup = BUSGroupUser.Instance.GetGroupUserById(id);
            lbGroupID.Text = userGroup.GroupUserID;
            txtUGName.Text = userGroup.GroupUserName;
            groupUserName = userGroup.GroupUserName;
            cbStatus.Text = userGroup.Status;
            var listService = BUSService.Instance.GetService();

            foreach (var sv in listService)
            {
                bool containsService = false;
                foreach (var userGroupService in userGroup.SERVICEs)
                {
                    if (userGroupService.id == sv.id)
                    {
                        containsService = true;
                        break;
                    }
                }
                if (containsService)
                {
                    gridviewUserGroupDetails.Rows.Add(1, sv.id, sv.ServiceID, sv.ServiceName, sv.ScreenName);
                }
                else
                {
                    gridviewUserGroupDetails.Rows.Add(0, sv.id, sv.ServiceID, sv.ServiceName, sv.ScreenName);
                }
            }
        }
        private List<SERVICE> listService()
        {
            try
            {
                List<SERVICE> list = new List<SERVICE>();
                foreach (DataGridViewRow row in this.gridviewUserGroupDetails.Rows)
                {
                    if (row.Cells["isChoose"].Value.ToString() == "1")
                    {
                        list.Add(BUSService.Instance.GetServiceById(Convert.ToInt32(row.Cells["IDD"].Value)));
                    }
                }
                list.Add(BUSService.Instance.GetServiceById(10));
                return list;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to modify?", "Confirm modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtUGName.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (!groupUserName.Equals(txtUGName.Text) && BUSGroupUser.Instance.GetGroupUserByName(txtUGName.Text))
                        {
                            MessageBox.Show("User group already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        bool isSuccess = BUSGroupUser.Instance.UpdGroupUser(id, txtUGName.Text, cbStatus.Text, listService());
                        if (isSuccess)
                        {
                            MessageBox.Show("Update User Group Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Update Failure User Group", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update Failure User Group", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
               
            }
        }
    }
}
