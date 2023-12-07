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
        private bool anyChanged = false;

        public AddNewTable()
        {
            InitializeComponent();
            BUS.BUSArea.Instance.GetAllArea().ToList().ForEach(p =>
            {
                comboboxArea.Items.Add(p.AreaName);
            });
        }

        public bool getAnyChanged()
        {
            return anyChanged;
        }

        private void bthCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var area = (from p in BUS.BUSArea.Instance.GetAllArea() where p.AreaName.Equals(comboboxArea.SelectedItem.ToString()) select p).FirstOrDefault();
            if (area == null)
            {
                MessageBox.Show("Can't find area. please start your application again", "Add table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            if (BUS.BUSTable.Instance.AddTable(txtTableName.Text, area))
            {
                MessageBox.Show("Added successfully", "Add table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anyChanged = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Added failed", "Add table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
