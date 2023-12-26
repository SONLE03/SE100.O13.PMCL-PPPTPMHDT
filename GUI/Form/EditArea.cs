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
    public partial class EditArea : Form
    {
        private AREA area;
        public EditArea(int id)
        {
            InitializeComponent();
            area = BUSArea.Instance.GetAreaById(id);
            LoadData(area);
        }
        private void LoadData(AREA area)
        {
            lbAreaID.Text = area.AreaID;
            txtAreaname.Text = area.AreaName;
            cbStatus.Text = area.Status;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to modify?", "Confirm modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtAreaname.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                    {
                        bool isSuccess = BUSArea.Instance.UpdArea(area.id, txtAreaname.Text, cbStatus.Text);
                        if (isSuccess)
                        {
                            MessageBox.Show("Update Area Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

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
    }
}
