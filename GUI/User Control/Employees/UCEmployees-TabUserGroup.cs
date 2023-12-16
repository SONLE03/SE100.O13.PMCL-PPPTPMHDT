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
            Binding(BUSGroupUser.Instance.GetAllGroupUser());
        }
        public void Binding(List<GROUPUSER> groupUser)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewUserGroup.Rows.Clear();
            foreach (GROUPUSER us in groupUser)
            {
                gridviewUserGroup.Rows.Add(us.id, us.GroupUserName, edit_img, edit_img);
            }
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
            if (e.ColumnIndex == gridviewUserGroup.Columns["Edit"].Index)
            {

            }
            //EmployeeDetails details = new EmployeeDetails(Convert.ToInt32(gridviewUserGroup.Rows[idx].Cells["UG_name"].Value));
            //details.ShowDialog();
            Binding(BUSGroupUser.Instance.GetAllGroupUser());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<GROUPUSER> list = new List<GROUPUSER>();
            foreach (var us in BUSGroupUser.Instance.GetAllGroupUser())
            {
                if (us.GroupUserName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    list.Add(us);
                }
            }
            Binding(list);
        }
    }
}
