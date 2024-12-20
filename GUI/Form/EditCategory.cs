﻿using BUS;
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
    public partial class EditCategory : Form
    {
        private CATEGORY cat;
        public EditCategory(int id)
        {
            InitializeComponent();
            cat = BUSCategory.Instance.GetCategoryById(id);
            LoadData(cat);
        }
        private void LoadData(CATEGORY cat)
        {
            lbCategoryID.Text = cat.CategoryID;
            txtCategoryname.Text = cat.CategoryName;
            cbStatus.Text = cat.Status;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to modify?", "Confirm modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(txtCategoryname.Text) && !String.IsNullOrEmpty(cbStatus.Text))
                    {
                        bool isSuccess = BUSCategory.Instance.UpdCategory(cat.id, txtCategoryname.Text, cbStatus.Text);
                        if (isSuccess)
                        {
                            MessageBox.Show("Update category successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update failure category", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
