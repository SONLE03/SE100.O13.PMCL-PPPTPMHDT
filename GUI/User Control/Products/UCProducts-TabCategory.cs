using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class UCProducts_TabCategory : UserControl
    {
        private List<UCProductMiniItem> listMiniItem;
        private List<CATEGORY> listCategories;

        public UCProducts_TabCategory()
        {
            InitializeComponent();
            listCategories = BUS.BUSCategory.Instance.GetAllCategory();
            LoadCategory(BUS.BUSCategory.Instance.GetAllCategory());
        }

        private void LoadCategory(List<CATEGORY> listCategory)
        {
            gridviewTable.Rows.Clear();
            gridviewTable.Refresh();
            foreach (var category in listCategory)
            {
                gridviewTable.Rows.Add(category.id, category.CategoryID, category.CategoryName);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            if (addCategory.anyAdded())
            {
                LoadCategory(BUS.BUSCategory.Instance.GetAllCategory());
            }
        }

        private void txtFindCategory_TextChanged(object sender, EventArgs e)
        {
            var listCategories = new List<CATEGORY>();
            BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                if (p.CategoryName.Contains(txtFindCategory.Text))
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
