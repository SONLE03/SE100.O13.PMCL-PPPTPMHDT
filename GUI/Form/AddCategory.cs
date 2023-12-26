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
                DialogResult result = MessageBox.Show("Are you sure want to add?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtCategoryname.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                    {
                        bool isSuccess = BUSCategory.Instance.AddCategory(txtCategoryname.Text, cbStatus.Text);
                        if (isSuccess)
                        {
                            MessageBox.Show("Add category successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
