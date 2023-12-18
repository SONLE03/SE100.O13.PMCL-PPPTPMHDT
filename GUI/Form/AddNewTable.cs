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
                    bool isSuccess = BUSTable.Instance.AddTable(txtTableName.Text, Convert.ToInt32(comboboxArea.SelectedValue), cbStatus.Text);
                    if (isSuccess)
                    {
                        MessageBox.Show("Add Table Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Add Failure Table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
    }
}
