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
    public partial class SupplierDetails : Form
    {
        SUPPLIER supplier;
        public SupplierDetails(int id)
        {
            InitializeComponent();
            supplier = BUSSupplier.Instance.GetSupplierById(id);
            lbAddress.Text = supplier.Address;
            lbSupplierID.Text = supplier.SupplierID;
            lbSupName.Text = supplier.SupplierName;
            lbPhone.Text = supplier.Phone;
            lbStatus.Text = supplier.Status;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
