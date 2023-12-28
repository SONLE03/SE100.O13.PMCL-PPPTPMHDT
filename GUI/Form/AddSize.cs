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
    public partial class AddSize : Form
    {
        public AddSize()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to add?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtSizename.Text.ToString()))
                    {
                        var isSuccess = BUSSize.Instance.AddSize(getSizeName());
                        if (isSuccess)
                        {
                            MessageBox.Show("Add New Size Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSizename.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the size name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Failure Size", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getSizeName()
        {
            return txtSizename.Text.ToString();
        }
    }
}
