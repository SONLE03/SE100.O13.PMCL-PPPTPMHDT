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
                if (!String.IsNullOrEmpty(txtUserGroupName.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                {
                    if (BUSGroupUser.Instance.GetGroupUserByName(txtUserGroupName.Text))
                    {
                        MessageBox.Show("User group already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int isSucces = BUSGroupUser.Instance.AddGroupUser(txtUserGroupName.Text, cbStatus.Text);
                    if (isSucces == -1)
                    {
                        MessageBox.Show("Added failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(!BUSGroupUser.Instance.AddGroupService(isSucces, listService()))
                    {
                        MessageBox.Show("Added failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Added successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Added failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }
    }
}
