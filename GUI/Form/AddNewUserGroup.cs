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
    public partial class AddNewUserGroup : Form
    {
        public AddNewUserGroup()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            var service = BUSService.Instance.GetService();
            foreach(var item in service)
            {
                gridviewService.Rows.Add("0", item.id, item.ServiceID, item.ServiceName, item.ScreenName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<SERVICE> listService()
        {
            List<SERVICE> list = new List<SERVICE>();
            foreach (DataGridViewRow row in this.gridviewService.Rows)
            {
                if (row.Cells["isChoosen"].Value.ToString() == "1")
                {
                    list.Add(BUSService.Instance.GetServiceById(Convert.ToInt32(row.Cells["id"].Value)));
                }
            }
            list.Add(BUSService.Instance.GetServiceById(11));
            return list;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to add?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtUserGroupName.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (BUSGroupUser.Instance.GetGroupUserByName(txtUserGroupName.Text))
                        {
                            MessageBox.Show("User group already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        int isSuccess = BUSGroupUser.Instance.AddGroupUser(txtUserGroupName.Text, cbStatus.Text);
                        if (isSuccess == -1)
                        {
                            MessageBox.Show("Add Failure User Group", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!BUSGroupUser.Instance.AddGroupService(isSuccess, listService()))
                        {
                            MessageBox.Show("Add Failure User Group", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        MessageBox.Show("Add User Group successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
