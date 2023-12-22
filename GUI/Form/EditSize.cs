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
    public partial class EditSize : Form
    {
        private int sizeId;
        public EditSize(int sizeId)
        {
            InitializeComponent();
            Binding(sizeId);
            this.sizeId = sizeId;
        }

        private void Binding(int sizeId)
        {
            txtSizename.Text = BUSSize.Instance.GetSizeById(sizeId).SizeName;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtSizename.Text.ToString()))
                {
                    var isSuccess = BUSSize.Instance.UpdSize(sizeId, txtSizename.Text);
                    if (isSuccess)
                    {
                        MessageBox.Show("Modify Size Information Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSizename.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the size name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modify Failure Size", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
