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
    public partial class EditTable : Form
    {
        private C_TABLE table;
        public EditTable(int id)
        {
            InitializeComponent();
            table = BUSTable.Instance.GetTableById(id);
            getArea();
            getTable(table);
           
        }
        private void getTable(C_TABLE table)
        {
            lbTableID.Text = table.TableID;
            txtTableName.Text = table.TableName;
            comboboxArea.SelectedValue = table.AREA.id;
            cbStatus.Text = table.Status;
        }
        private void getArea()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtTableName.Text) && !String.IsNullOrEmpty(comboboxArea.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                {
                    bool isSuccess = BUSTable.Instance.UpdTable(table.id, txtTableName.Text, Convert.ToInt32(comboboxArea.SelectedValue), cbStatus.Text);
                    if (isSuccess)
                    {
                        MessageBox.Show("Update Table Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Failure Table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Update Failure Table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }
    }
}
