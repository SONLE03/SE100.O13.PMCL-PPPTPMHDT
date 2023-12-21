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
    public partial class EditSupplier : Form
    {
        private SUPPLIER supplier;
        public EditSupplier(int id)
        {
            InitializeComponent();
            supplier = BUSSupplier.Instance.GetSupplierById(id);
            txtSupname.Text = supplier.SupplierName;
            txtAddress.Text = supplier.Address;
            txtPhone.Text = supplier.Phone;
            txtAddress.Text = supplier.Address;
            cbStatus.Text = supplier.Status;
            lbSupplierID.Text = supplier.SupplierID;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupname.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string status = cbStatus.Text;
            try
            {
                if (!String.IsNullOrEmpty(supplierName) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(address) && !String.IsNullOrEmpty(status))
                {
                    BUSSupplier.Instance.UpdSupplier(supplier.id, supplierName, address, phone, status);
                }
                else
                {
                    MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
