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
            getTable(table);
           
        }
        private void getTable(C_TABLE table)
        {
            lbTableID.Text = table.TableID;
            lbArea.Text = table.AREA.AreaName;
            cbStatus.Text = table.Status;
        }
        private void bthCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to modify?", "Confirm modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (!BUSTable.Instance.checkAreaStatus(table.AreaID, cbStatus.Text))
                        {
                            MessageBox.Show("Add failure table, area is blocked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (BUSTable.Instance.UpdTable(table.id, cbStatus.Text))
                        {
                            MessageBox.Show("Modify table successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Modify failure table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
