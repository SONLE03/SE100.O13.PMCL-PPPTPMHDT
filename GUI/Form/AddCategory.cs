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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
         
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCategoryname.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                {
                    bool isSucces = BUSCategory.Instance.AddCategory(txtCategoryname.Text, cbStatus.Text);
                    if (isSucces)
                    {
                        MessageBox.Show("Added successfully", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Added failed", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Added failed", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            } 
        }
    }
}
