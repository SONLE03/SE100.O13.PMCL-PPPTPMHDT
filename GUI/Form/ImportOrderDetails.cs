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
    public partial class ImportOrderDetails : Form
    {
        public ImportOrderDetails(int id)
        {
            InitializeComponent();
            Binding(id);
        }

        private void Binding(int id)
        {
            IMPORT_BILL importBill = BUSImportBill.Instance.GetImportBillById(id);
            lbImportOrderDate.Text = importBill.ImportDate.ToString();
            lbImportOrderID.Text = importBill.ImportID.ToString();
            lbImportOrderName.Text = importBill.ImportName;
            lbImportOrderSupplier.Text = importBill.SUPPLIER.SupplierName;
            lbImportOrderUser.Text = importBill.C_USER.UserFullName;
            lbTotal.Text = importBill.Total.ToString();
            foreach(var importBillDetail in  importBill.IMPORT_BILL_DETAIL)
            {
                ImportedProducts.Rows.Add(importBillDetail.No, importBillDetail.ImportMName, importBillDetail.Unit, importBillDetail.Quantity, importBillDetail.Rate, importBillDetail.Amount);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
