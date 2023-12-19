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
    public partial class AddNewTable : Form
    {
        public AddNewTable()
        {
            InitializeComponent();
            getAreas();
        }

        private void getAreas()
        {
            var listAreas = BUSArea.Instance.GetAllArea();
            comboboxArea.DataSource = listAreas;
            comboboxArea.ValueMember = "id";
            comboboxArea.DisplayMember = "AreaName";
        }

        private void bthCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(txtTableName.Text) || !String.IsNullOrEmpty(comboboxArea.Text) || !String.IsNullOrEmpty(cbStatus.Text))
                {
                    addNewTable();
                }
                else
                {
                    MessageBox.Show("Add Failure Table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }
        private void addNewTable()
        {
            try
            {
                int quantity = 1;
                int i = 1;
                if (!String.IsNullOrEmpty(txtQuantity.Text))
                {
                    quantity = Convert.ToInt32(txtQuantity.Text);
                }
                for (i = 1; i <= quantity; i++)
                {
                    BUSTable.Instance.AddTable(txtTableName.Text + i.ToString(), Convert.ToInt32(comboboxArea.SelectedValue), cbStatus.Text);
                }
                if (i == quantity + 1)
                {
                    MessageBox.Show("Add Table Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Failure Table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
