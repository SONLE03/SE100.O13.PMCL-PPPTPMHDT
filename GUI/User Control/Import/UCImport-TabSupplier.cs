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
    public partial class UCImport_TabImportOrder : UserControl
    {
        public UCImport_TabImportOrder()
        {
            InitializeComponent();
            Binding(BUSSupplier.Instance.GetAllSupplier());
        }
         public void Binding(List<SUPPLIER> supplier)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewSupplier.Rows.Clear();
            foreach(SUPPLIER s in supplier)
            {
                gridviewSupplier.Rows.Add(s.id, s.SupplierName, s.Address, s.Phone, edit_img);
            }
        }

        private void btnAddsupplier_Click(object sender, EventArgs e)
        {
            AddNewSupplier addNewSupplier = new AddNewSupplier();
            addNewSupplier.Show();
            Binding(BUSSupplier.Instance.GetAllSupplier());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<SUPPLIER> list = new List<SUPPLIER>();
            foreach (var p in BUSSupplier.Instance.GetAllSupplier())
            {
                if (p.SupplierName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    list.Add(p);
                }
            }
            Binding(list);
        }

        private void gridviewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == gridviewSupplier.Columns["Edit"].Index)
            {
                EditSupplier editSupplier = new EditSupplier(Convert.ToInt32(gridviewSupplier.Rows[idx].Cells["Supplier_ID"].Value));
                editSupplier.ShowDialog();
                Binding(BUSSupplier.Instance.GetAllSupplier());
            }
        }
    }
}
