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
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupname.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Boolean err = BUSSupplier.Instance.UpdSupplier(supplier.id, txtSupname.Text, txtAddress.Text, txtPhone.Text);
                if (err == true) MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch
            {

            }
           
        }
    }
}
