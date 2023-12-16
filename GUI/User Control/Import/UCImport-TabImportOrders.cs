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
    public partial class UCImport_TabSupplier : UserControl
    {
        public UCImport_TabSupplier()
        {
            InitializeComponent();
            Binding(BUSImportBill.Instance.GetAllImportBill());
        }

        public void Binding(List<IMPORT_BILL> import)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewImportOrder.Rows.Clear();
            foreach(IMPORT_BILL im in import)
            {
                gridviewImportOrder.Rows.Add(im.id, im.ImportName, im.ImportDate, im.SUPPLIER.SupplierName, im.IMPORT_BILL_DETAIL.Count, im.Total, edit_img);
            }
        }

        private void btnAddIO_Click(object sender, EventArgs e)
        {
            AddImportOrder addImportOrder = new AddImportOrder();
            addImportOrder.ShowDialog();
            Binding(BUSImportBill.Instance.GetAllImportBill());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<IMPORT_BILL> list = new List<IMPORT_BILL>();
            foreach (var p in BUSImportBill.Instance.GetAllImportBill())
            {
                if (p.ImportName.ToLower().Contains(txtSearch.Text.ToLower()) || p.SUPPLIER.SupplierName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    list.Add(p);
                }
            }
            Binding(list);
        }

        private void gridviewImportOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int idx = e.RowIndex;
            //if (idx < 0) return;
            //if (e.ColumnIndex == gridviewImportOrder.Columns["Edit"].Index)
            //{
            //    EditSupplier editSupplier = new EditSupplier(Convert.ToInt32(gridviewImportOrder.Rows[idx].Cells["Supplier_ID"].Value));
            //    editSupplier.ShowDialog();
            //    Binding(BUSImportBill.Instance.GetAllImportBill());
            //}
        }
    }
}
