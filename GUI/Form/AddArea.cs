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
        private bool anyChanged = false;
        private int id;

        public AddArea()
        {
            InitializeComponent();
            btnDelete.Visible = false;
            bntUpdate.Visible = false;
        }

        public AddArea(int i)
        {
            InitializeComponent();
            id = i;
            var area = BUS.BUSArea.Instance.GetAreaById(id);
            txtAreaname.Text = area.AreaName;
            txtSurcharge.Text = area.ExtraFee.ToString();
            lbAreaID.Text = area.AreaID;
            btn_Add.Visible = false;
            btn_Cancel.Visible = false;
        }

        public bool getAnyChanged()
        {
            return anyChanged;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (BUS.BUSArea.Instance.AddArea(txtAreaname.Text, double.Parse(txtSurcharge.Text)))
            {
                MessageBox.Show("Added successfully", "Add area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anyChanged = true;
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Added failed", "Add area", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BUS.BUSArea.Instance.DelArea(id))
            {
                MessageBox.Show("Deleted successfully", "Delete area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anyChanged = true;
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Deleted failed", "Delete area", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (BUS.BUSArea.Instance.UpdArea(id, txtAreaname.Text, double.Parse(txtSurcharge.Text), "active"))
            {
                MessageBox.Show("Updated successfully", "Update area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anyChanged = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Updated failed", "Update area", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
