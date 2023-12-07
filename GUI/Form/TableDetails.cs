using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class TableDetails : Form
    {
        private C_TABLE table;
        private bool anyChanged = false;

        public bool getAnyChanged()
        {
            return anyChanged;
        }

        public TableDetails(string codeTable)
        {
            InitializeComponent();
            table = (from p in BUS.BUSTable.Instance.GetAllTable() where p.TableID.Equals(codeTable) select p).FirstOrDefault();
            BUS.BUSArea.Instance.GetAllArea().ToList().ForEach(p =>
            {
                comboboxArea.Items.Add(p.AreaName);
            });
            txtTableName.Text = table.TableName;
            lbAreaID.Text = table.TableID;
            comboboxArea.SelectedItem = table.AREA.AreaName;
            //bthCancel.Visible = false;
            // Status
        }

        private void bthCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var area = (from p in BUS.BUSArea.Instance.GetAllArea() where p.AreaName.Equals(comboboxArea.SelectedItem.ToString()) select p).FirstOrDefault();
            if (area == null)
            {
                MessageBox.Show("Can't find area. please start your application again", "Add table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BUS.BUSTable.Instance.UpdTable(table.id, txtTableName.Text, area, null))
            {
                MessageBox.Show("Updated successfully", "Update table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anyChanged = true;
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Deleted successfully", "Delete table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
