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
    public partial class UserGroupDetails : Form
    {
        private int id;
        public UserGroupDetails(int _id)
        {
            InitializeComponent();
            id = _id;
            LoadData(id);
        }
        private void LoadData(int id)
        {
            GROUPUSER groupUser = BUSGroupUser.Instance.GetGroupUserById(id);
            lbGUID.Text = groupUser.GroupUserID;
            lbGUName.Text = groupUser.GroupUserName;
            lbStatus.Text = groupUser.Status;
            foreach(var sv in groupUser.SERVICEs)
            {
                gridService.Rows.Add(sv.ServiceID, sv.ServiceName, sv.ScreenName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
