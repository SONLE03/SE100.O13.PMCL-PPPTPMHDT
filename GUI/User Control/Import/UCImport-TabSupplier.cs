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
            Binding(BUSSupplier.Instance.GetAllSupplier());
            setSupplierStatus();
        }
        private void setSupplierStatus()
        {
            cbStatus.Items.AddRange(new string[] { "All", "Active", "InActive" });
            cbStatus.SelectedIndex = 0;
        }

        public void Binding(List<SUPPLIER> supplier)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewSupplier.Rows.Clear();
            foreach (SUPPLIER s in supplier)
            {
                gridviewSupplier.Rows.Add(s.id, s.SupplierID, s.SupplierName, s.Phone, s.Address, s.Status, edit_img);
            }
        }

        private void btnAddsupplier_Click(object sender, EventArgs e)
        {
            AddNewSupplier addNewSupplier = new AddNewSupplier();
            addNewSupplier.ShowDialog();
            Binding(BUSSupplier.Instance.GetAllSupplier());
        }
        private void Search()
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                string selectedStatus = cbStatus.Text;
                List<SUPPLIER> listSupplier = BUSSupplier.Instance.SearchSupplier(searchText, selectedStatus);
                Binding(listSupplier);
            }
            catch
            {

            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void gridviewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            int supplierId = Convert.ToInt32(gridviewSupplier.Rows[idx].Cells["ID"].Value);
            if (e.ColumnIndex == gridviewSupplier.Columns["Edit"].Index)
            {
                EditSupplier editSupplier = new EditSupplier(supplierId);
                editSupplier.ShowDialog();
                Binding(BUSSupplier.Instance.GetAllSupplier());
            }
            else
            {
                SupplierDetails supplierDetails = new SupplierDetails(supplierId);
                supplierDetails.Show();
            }
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
