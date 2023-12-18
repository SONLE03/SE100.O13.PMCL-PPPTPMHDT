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
        }

        public void Binding(List<C_USER> users)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewEmployee.Rows.Clear();
            foreach (C_USER us in users)
            {
                gridviewEmployee.Rows.Add(us.id, us.UserFullName, us.Phone, us.UserName, us.GROUPUSER.GroupUserName, edit_img, edit_img);
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee add_employees = new AddNewEmployee();
            add_employees.ShowDialog();
            Binding(BUSUser.Instance.GetAllUser());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<C_USER> list = new List<C_USER>();
            foreach (var us in BUSUser.Instance.GetAllUser())
            {
                if (us.UserFullName.ToLower().Contains(txtSearch.Text.ToLower()) || us.UserName.ToLower().Contains(txtSearch.Text.ToLower()) || us.GROUPUSER.GroupUserName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    list.Add(us);
                }
            }
            Binding(list);
        }

        private void gridviewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == gridviewEmployee.Columns["Edit"].Index)
            {
                EditEmployee edit_em = new EditEmployee(Convert.ToInt32(gridviewEmployee.Rows[idx].Cells["Employee_ID"].Value));
                edit_em.ShowDialog();
            }
            else
            {
                EmployeeDetails details = new EmployeeDetails(Convert.ToInt32(gridviewEmployee.Rows[idx].Cells["Employee_ID"].Value));
                details.ShowDialog();
            }
            Binding(BUSUser.Instance.GetAllUser());
        }
    }
}
