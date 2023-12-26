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
    public partial class UCEmployees_TabEmployees : UserControl
    {
        public UCEmployees_TabEmployees()
        {
            InitializeComponent();
            Binding(BUSUser.Instance.GetAllUser());
            setUserStatus();
        }

        public void Binding(List<C_USER> users)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewEmployee.Rows.Clear();
            foreach (C_USER us in users)
            {
                gridviewEmployee.Rows.Add(us.id, us.UserID, us.UserFullName, us.Phone, us.GROUPUSER.GroupUserName, us.Status, edit_img);
            }
        }
        private void setUserStatus()
        {
            cbStatus.Items.AddRange(new string[] { "All", "Active", "InActive" });
            cbStatus.SelectedIndex = 0;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee add_employees = new AddNewEmployee();
            add_employees.ShowDialog();
            Binding(BUSUser.Instance.GetAllUser());
        }
        private void Search()
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                string selectedStatus = cbStatus.Text;
                List<C_USER> listUser = BUSUser.Instance.SearchUser(searchText, selectedStatus);
                Binding(listUser);
            }
            catch
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void gridviewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            int idUser = Convert.ToInt32(gridviewEmployee.Rows[idx].Cells["ID"].Value);
            if (e.ColumnIndex == gridviewEmployee.Columns["Edit"].Index)
            {
                if(BUSUser.Instance.GetUserById(idUser).UserName.Equals("admin") && idUser == BUSUser.Instance.idUserLogin)
                {
                    MessageBox.Show("This user cannot be modified", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                EditEmployee edit_em = new EditEmployee(idUser);
                edit_em.ShowDialog();
            }
            else
            {
                EmployeeDetails details = new EmployeeDetails(idUser);
                details.ShowDialog();
            }
            Binding(BUSUser.Instance.GetAllUser());
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
