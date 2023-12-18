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
        private List<UCProductMiniItem> listMiniItem;

        public UCProducts_TabCategory()
        {
            InitializeComponent();
            LoadCategory(BUSCategory.Instance.GetAllCategory());
        }

        private void LoadCategory(List<CATEGORY> listCategory)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewTable.Rows.Clear();
            gridviewTable.Refresh();
            foreach (var category in listCategory)
            {
                gridviewTable.Rows.Add(category.id, category.CategoryID, category.CategoryName, edit_img);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            if (addCategory.anyAdded())
            {
                LoadCategory(BUSCategory.Instance.GetAllCategory());
            }
        }

        private void txtFindCategory_TextChanged(object sender, EventArgs e)
        {
            var listCategories = new List<CATEGORY>();
            BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                if (p.CategoryName.ToLower().Contains(txtFindCategory.Text.ToLower()))
                {
                    listCategories.Add(p);
                }
            });
            LoadCategory(listCategories);
        }

        private void gridviewTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == gridviewTable.Columns["ID"].Index || e.ColumnIndex == gridviewTable.Columns["CategoryID"].Index || e.ColumnIndex == gridviewTable.Columns["Category_name"].Index)
            {
                AddCategory addCategory = new AddCategory((Convert.ToInt32(gridviewTable.Rows[e.RowIndex].Cells["id"].Value)));
                addCategory.ShowDialog();
                if (addCategory.anyDeleted() || addCategory.anyUpdated())
                {
                    LoadCategory(BUS.BUSCategory.Instance.GetAllCategory());
                }
            }
            else
            {
                MessageBox.Show("Please double click at rows to update or delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
