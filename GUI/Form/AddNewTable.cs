using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private void Clear()
        {
            txtQuantity.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to add?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(comboboxArea.Text) && !String.IsNullOrEmpty(cbStatus.Text) && !String.IsNullOrEmpty(txtQuantity.Text))
                    {
                        addNewTable();
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
        private int getLastOfTableNumber()
        {
            int index = 0;
            string tableName = BUSTable.Instance.GetAllTableByAreaID(Convert.ToInt32(comboboxArea.SelectedValue)).LastOrDefault()?.TableName;
            if (tableName == null)
            {
                return index;
            }
            string pattern = @"Table\s*(\S+)";
            Match match = Regex.Match(tableName, pattern);
            if (match.Success)
            {
                index = Convert.ToInt32(match.Groups[1].Value.Trim());
            }
            //MessageBox.Show(getLastOfTableNumber().ToString());
            return index;
        }
        private void addNewTable()
        {
            try
            {
                // Check capacity
                if (!BUSTable.Instance.checkAreaStatus(Convert.ToInt32(comboboxArea.SelectedValue), cbStatus.Text))
                {
                    MessageBox.Show("Add Failure Table, Area Is Blocked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int i = getLastOfTableNumber() + 1;
                int quantity = Convert.ToInt32(txtQuantity.Text) + i;
                for (; i < quantity; i++)
                {
                    BUSTable.Instance.AddTable("Table " + i.ToString(), Convert.ToInt32(comboboxArea.SelectedValue), cbStatus.Text);
                }
                if (i == quantity)
                {
                    MessageBox.Show("Add Table Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Add Failure Table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
