using BUS;
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
    public partial class AddNewSupplier : Form
    {
        public AddNewSupplier()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtSupname.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupname.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string status = cbStatus.Text;
            try
            {
                if (!String.IsNullOrEmpty(supplierName) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(address) && !String.IsNullOrEmpty(status))
                {
                    if(BUSSupplier.Instance.AddSupplier(supplierName, address, phone, status))
                    {
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
