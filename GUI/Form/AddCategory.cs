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
    public partial class AddCategory : Form
    {
        private bool isAdded = false;
        public AddCategory()
        {
            InitializeComponent();
        }

        public bool anyAdded()
        {
            return isAdded;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }   

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (BUS.BUSCategory.Instance.AddCategory(txtCategoryname.Text))
            {
                isAdded = true;
                MessageBox.Show("Added successfully", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Added failed", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
