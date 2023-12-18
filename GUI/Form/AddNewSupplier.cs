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
            try
            {
                if (!String.IsNullOrEmpty(supplierName))
                {
                    if(BUSSupplier.Instance.AddSupplier(supplierName, address, phone))
                    {
                        MessageBox.Show("Added successfully");
                        Clear();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Added failed");
                    }
                }
                else
                {
                    MessageBox.Show("You must fill all the information");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
