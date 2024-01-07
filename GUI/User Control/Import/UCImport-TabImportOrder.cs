using BUS;
using BUS.BUSPrint;
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
        private BUSPrintImportOrder printImport;
        public UCImport_TabImportOrder()
        {
            InitializeComponent();
            Binding(BUSImportBill.Instance.GetAllImportBill());
        }

        public void Binding(List<IMPORT_BILL> import)
        {
            Image print_img = Properties.Resources.printer;
            print_img = (Image)(new Bitmap(print_img, new Size(25, 25)));
            gridviewImportOrder.Rows.Clear();
            foreach (IMPORT_BILL im in import)
            {
                gridviewImportOrder.Rows.Add(im.id, im.ImportID, im.ImportName, im.ImportDate.ToString("dd/MM/yyyy HH:mm:ss"), im.SUPPLIER.SupplierName, im.IMPORT_BILL_DETAIL.Count, im.Total, print_img);
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
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                Binding(BUSImportBill.Instance.SearchImportBill(searchText));
            }
            catch
            {

            }
          
        }

        private void gridviewImportOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idx = e.RowIndex;
                if (idx < 0) return;
                int impId = Convert.ToInt32(gridviewImportOrder.Rows[idx].Cells["ID"].Value);
                if(e.ColumnIndex == gridviewImportOrder.Columns["Print"].Index)
                {
                    print(impId);
                }
                else
                {
                    ImportOrderDetails importOrderDetail = new ImportOrderDetails(impId);
                    importOrderDetail.Show();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void print(int importID)
        {
            dataGridViewPrint.Rows.Clear();
            var importBill = BUSImportBill.Instance.GetImportBillById(importID);
            var importBillDetail = importBill.IMPORT_BILL_DETAIL.ToList();
            foreach (var im in importBillDetail)
            {
                dataGridViewPrint.Rows.Add(im.No, im.ImportMName, im.Unit, im.Quantity, im.Rate, im.Amount);
            }
            printImport = new BUSPrintImportOrder(dataGridViewPrint, importBill);
            printImport.PrintReport();
        }
    }
}
