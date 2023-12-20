using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class UCProducts_TabCategory : UserControl
    {
        public UCProducts_TabCategory()
        {
            InitializeComponent();
            setCategoryStatus();
            LoadCategory(BUSCategory.Instance.GetAllCategory());
        }

        private void LoadCategory(List<CATEGORY> listCategory)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewCategory.Rows.Clear();
            gridviewCategory.Refresh();
            foreach (var category in listCategory)
            {
                gridviewCategory.Rows.Add(category.id, category.CategoryID, category.CategoryName, category.Status, edit_img);
            }
        }
        private void setCategoryStatus()
        {
            cbStatus.Items.AddRange(new string[] { "All", "Active", "InActive" });
            cbStatus.SelectedIndex = 0;
        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            LoadCategory(BUSCategory.Instance.GetAllCategory());
        }
        private void Search()
        {
            List<CATEGORY> listCategories;
            if (string.Equals(cbStatus.Text, "All", StringComparison.OrdinalIgnoreCase))
            {
                listCategories = BUSCategory.Instance.GetAllCategory();
            }
            else if (string.Equals(cbStatus.Text, "Active", StringComparison.OrdinalIgnoreCase))
            {
                listCategories = BUSCategory.Instance.GetAllCategoryActive();
            }
            else
            {
                listCategories = BUSCategory.Instance.GetAllCategoryInActive();
            }
            List<CATEGORY> filteredList = listCategories.Where(p => p.CategoryName.ToLower().Contains(txtFindCategory.Text.ToLower())).ToList();
            LoadCategory(filteredList);
        }

        private void txtFindCategory_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void gridviewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == gridviewCategory.Columns["Edit"].Index)
            {
                EditCategory editCategory = new EditCategory(Convert.ToInt32(gridviewCategory.Rows[idx].Cells["ID"].Value));
                editCategory.ShowDialog();
                LoadCategory(BUSCategory.Instance.GetAllCategory());
            }
        }
    }
}
