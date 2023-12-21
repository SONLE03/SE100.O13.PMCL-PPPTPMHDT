using BUS;
using DTO;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddImportOrder : Form
    {
        public AddImportOrder()
        {
            InitializeComponent();
            GetAllSupplierActive();
            lbTotal.Text = "0";
        }

        private void GetAllSupplierActive()
        {
            cbSupplier.DataSource = null;
            List<SUPPLIER> suppliers = BUSSupplier.Instance.GetAllSupplierActive();
            cbSupplier.DataSource = suppliers;
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "id";
        }
        private void Clear()
        {
            lbTotal.Text = "0";
            txtImportOrderName.Text = null;
            txtProductName.Text = null;
            txtQuantity.Text = null;
            txtUnit.Text = null;
            txtUnitPrice.Text = null;
            gridviewSelectedProducts.Rows.Clear();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gridviewSelectedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idx = e.RowIndex;
                if (idx < 0) return;
                double totalPriceofProductDelete = Convert.ToDouble(lbTotal.Text) - Convert.ToDouble(gridviewSelectedProducts.Rows[idx].Cells[4].Value);
                lbTotal.Text = totalPriceofProductDelete.ToString();
                if (e.ColumnIndex == gridviewSelectedProducts.Columns["Delete"].Index)
                {
                    gridviewSelectedProducts.Rows.RemoveAt(idx);
                }
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addNewImportOrder(string importName, int supplierId)
        {
            try
            {
                int idx = 1;
                var addImportOrder = BUSImportBill.Instance.AddImportBill(importName, DateTime.Now, supplierId, BUSUser.Instance.idUserLogin);
                if (addImportOrder == -1)
                {
                    MessageBox.Show("Add Failure Import Order", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach(DataGridViewRow rows in gridviewSelectedProducts.Rows)
                {
                    var addImportOrderDetail = BUSImportBillDetail.Instance.AddImportBillDetail(idx, addImportOrder, rows.Cells[0].Value.ToString()
                        , rows.Cells[1].Value.ToString(), Convert.ToInt32(rows.Cells[2].Value), Convert.ToDouble(rows.Cells[3].Value));
                    if (!addImportOrderDetail)
                    {
                        BUSImportBill.Instance.DelImportBill(addImportOrder);
                        MessageBox.Show("Add Failure Import Order", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    idx++;
                }
                MessageBox.Show("Add New Import Order Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch
            {

            }
        }
        private void btnAddImportOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtImportOrderName.Text) || gridviewSelectedProducts.Rows.Count == 0 || String.IsNullOrEmpty(cbSupplier.Text))
                {
                    MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    addNewImportOrder(txtImportOrderName.Text, Convert.ToInt32(cbSupplier.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Failure Product", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                bool existenceCheck = false;
                if (String.IsNullOrEmpty(txtProductName.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(txtUnit.Text) || String.IsNullOrEmpty(txtUnitPrice.Text))
                {
                    MessageBox.Show("Lack of information in import detail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataGridViewRow row in gridviewSelectedProducts.Rows)
                {
                    if (txtProductName.Text.ToLower().Equals(row.Cells[0].Value.ToString().ToLower()))
                    {
                        existenceCheck = true;
                        MessageBox.Show("The product already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (!existenceCheck)
                {
                    double totalPriceofProduct = Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtUnitPrice.Text);
                    gridviewSelectedProducts.Rows.Add(txtProductName.Text, txtUnit.Text, txtQuantity.Text, txtUnitPrice.Text, totalPriceofProduct);
                    totalPriceofProduct += Convert.ToDouble(lbTotal.Text);
                    lbTotal.Text = totalPriceofProduct.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
