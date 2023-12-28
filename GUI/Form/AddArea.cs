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
    public partial class AddArea : Form
    {
        public AddArea()
        {
            InitializeComponent();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to add?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtAreaname.Text) && !String.IsNullOrEmpty(cbStatus.Text) && !String.IsNullOrEmpty(txtCapacity.Text))
                    {
                        bool isSuccess = BUSArea.Instance.AddArea(txtAreaname.Text, Convert.ToInt32(txtCapacity.Text), cbStatus.Text);
                        if (isSuccess)
                        {
                            MessageBox.Show("Add area successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
            
        }
        private void Clear()
        {
            txtAreaname.Clear();
            txtCapacity.Clear();    
        }
        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
