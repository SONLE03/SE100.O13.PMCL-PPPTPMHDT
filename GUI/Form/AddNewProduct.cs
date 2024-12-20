﻿using BUS;
using DTO;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace GUI
{
    public partial class AddNewProduct : Form
    {
        private string filePath { get; set; }
         public AddNewProduct()
        {
            InitializeComponent();
            LoadData();
        }

        private void GetAllCategory()
        {
            combobox_category.DataSource = null;
            List<CATEGORY> categories = BUSCategory.Instance.GetAllCategory();
            combobox_category.DataSource = categories;
            combobox_category.DisplayMember = "CategoryName";
            combobox_category.ValueMember = "id";
        }
        private void GetAllSize()
        {
            combobox_size.DataSource = null;
            List<C_SIZE> sizes = BUSSize.Instance.GetAllSize();
            combobox_size.DataSource = sizes;
            combobox_size.DisplayMember = "SizeName";
            combobox_size.ValueMember = "id";
        }

        private void LoadData()
        {
            GetAllCategory();
            GetAllSize();
        }
        private void Clear()
        {
            txtDescibe.Clear();
            txtPrice.Clear();
            txtProductname.Clear();
            SizeGrid.Rows.Clear();
            picture_product.Image = null;
        }

        private void btn_AddSize_Click(object sender, EventArgs e)
        {
            AddSize addSize = new AddSize();
            addSize.ShowDialog();
            GetAllSize();
        }
        private void picture_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                if (!String.IsNullOrEmpty(filePath))
                {
                    picture_product.Image = new Bitmap(filePath);
                }
                else
                {
                    MessageBox.Show("Error: maybe it can't load this type of image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnAddDrinkSize_Click(object sender, EventArgs e)
        {
            try
            {
                bool existenceCheck = false;
                if (String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(combobox_size.Text))
                {
                    MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.Parse(txtPrice.Text) <= 0)
                {
                    MessageBox.Show("Price must be greater than zero", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = Convert.ToInt32(combobox_size.SelectedValue);
                string sizeName = combobox_size.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                foreach (DataGridViewRow row in SizeGrid.Rows)
                {
                    if (id == Convert.ToInt32(row.Cells[0].Value))
                    {
                        existenceCheck = true;
                        MessageBox.Show("Drink sizes already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (!existenceCheck)
                {
                    SizeGrid.Rows.Add(id, sizeName, price);
                }
            }
            catch
            {

            }
        }

        private void SizeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idx = e.RowIndex;
                if (idx < 0) return;
                if (e.ColumnIndex == SizeGrid.Columns["Delete"].Index)
                {
                    SizeGrid.Rows.RemoveAt(idx);
                }
            }
            catch
            {

            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to add?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string productName = txtProductname.Text;
                    int idCategory = Convert.ToInt32(combobox_category.SelectedValue);
                    string category = combobox_category.Text;
                    string description = txtDescibe.Text;
                    if (String.IsNullOrEmpty(productName) || SizeGrid.Rows.Count == 0 || String.IsNullOrEmpty(category) || String.IsNullOrEmpty(filePath) || String.IsNullOrEmpty(cbStatus.Text))
                    {
                        MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!BUSDrink.Instance.checkCategoryStatus(idCategory, cbStatus.Text))
                    {
                        MessageBox.Show("Add failure drink. Category is blocked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    addNewProduct(productName, idCategory, category, description);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failure drink", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewProduct(string productName, int idCategory, string category, string description)
        {
            try
            {
                DRINK drink = BUSDrink.Instance.AddDrink(productName, idCategory, description, filePath, cbStatus.Text);
                if(drink == null)
                {
                    return;
                }
                foreach (DataGridViewRow rows in SizeGrid.Rows)
                {
                    BUSDrink_Size.Instance.AddDrink_Size(drink, Convert.ToInt32(rows.Cells[0].Value), Convert.ToDouble(rows.Cells[2].Value));
                }
                MessageBox.Show("Add drink successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch
            {

            }            
        }
    }
}

