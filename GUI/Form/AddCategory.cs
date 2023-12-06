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
        private bool isUpdated = false;
        private bool isDeleted = false;
        private int id;
        public AddCategory(int i)
        {
            InitializeComponent();
            id = i;
            txtCategoryname.Text = BUS.BUSCategory.Instance.GetCategoryById(id).CategoryName;

            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btn_Add.Visible = false;
            btn_Cancel.Visible = false;
        }

        public AddCategory()
        {
            InitializeComponent();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btn_Add.Visible = true;
            btn_Cancel.Visible = true;
        }

        public bool anyAdded()
        {
            return isAdded;
        }

        public bool anyUpdated()
        {
            return isUpdated;
        }

        public bool anyDeleted()
        {
            return isDeleted;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BUS.BUSCategory.Instance.DelCategory(id))
            {
                MessageBox.Show("Deleted successfully", "Delete category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isDeleted = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Deleted failed", "Delete category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BUS.BUSCategory.Instance.UpdCategory(id, txtCategoryname.Text))
            {
                MessageBox.Show("Updated successfully", "Update category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isUpdated = true;
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Updated failed", "Update category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
