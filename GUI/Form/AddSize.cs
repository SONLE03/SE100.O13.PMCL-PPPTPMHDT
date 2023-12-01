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
    public partial class AddSize : Form
    {
        public AddSize()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtSizename.Text.ToString()))
                {
                    BUS.BUSSize.Instance.AddSize(getSizeName());
                    MessageBox.Show("Added successful", "Add new size for product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter the size name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Added failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
            }
        }

        public string getSizeName()
        {
            return txtSizename.Text.ToString();
        }
    }
}
