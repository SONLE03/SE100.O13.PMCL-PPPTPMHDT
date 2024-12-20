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
    public partial class EditEvent : Form
    {
        private EVENT Event;
        private List<DRINK> drinkListToAdd = new List<DRINK>();
        private List<int> listDrinkID = new List<int>();
        private List<DRINK> drinkList = new List<DRINK>();
        public EditEvent(int id)
        {
            InitializeComponent();
            Bind(id);
            addEventForCheckBox();
            getCategory();
        }

        private void Bind(int id)
        {
            Event = BUSEvent.Instance.GetEventById(id);
            lbEventID.Text = Event.EventID;
            txtEventname.Text = Event.EventName;
            dtpStartDate.Value = Event.StartDate.Value.Date;
            dtpEndDate.Value = Event.DueDate.Value.Date;
            if (Event.EventType)
            {
                cbSalePercentage.Checked = true;
            }
            else
            {
                cbSaleSamePrice.Checked = true;
            }
            txtSaleValue.Text = Event.Discount.ToString();
            foreach (var ev in Event.DRINKS)
            {
                gridviewEventAppliedProduct.Rows.Add(ev.id, ev.DrinksID, ev.DrinksName, ev.CATEGORY.CategoryName);
                listDrinkID.Add(ev.id);
            }
            cbStatus.Text = Event.Status;
            lbUnit.Text = Event.Unit;
        }
        private void addEventForCheckBox()
        {
            cbSalePercentage.CheckedChanged += CheckBox_CheckedChanged;
            cbSaleSamePrice.CheckedChanged += CheckBox_CheckedChanged;
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSaleSamePrice.Checked)
            {
                lbUnit.Text = "VND";
            }
            else if (cbSalePercentage.Checked)
            {
                lbUnit.Text = "%";
            }
            else
            {
                lbUnit.Text = "Unit";
            }
        }
        private void getCategory()
        {
            var categories = BUSCategory.Instance.GetAllCategoryActive();
            if (categories == null) return;
            var allCategory = new CATEGORY { id = 0, CategoryID = "CT0000", CategoryName = "All" };
            categories.Insert(0, allCategory);
            cbcategory.DataSource = null;
            cbcategory.DataSource = categories;
            cbcategory.ValueMember = "id";
            cbcategory.DisplayMember = "CategoryName";
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                bool Checked = false;
                if (String.IsNullOrEmpty(cbcategory.Text) || (!String.IsNullOrEmpty(cbcategory.Text) && String.IsNullOrEmpty(cbProduct.Text)))
                {
                    MessageBox.Show("Lack of information. Please check again", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!String.IsNullOrEmpty(txtSaleValue.Text) && Convert.ToInt32(txtSaleValue.Text) <= 0)
                {
                    MessageBox.Show("Sale value must be greater than zero", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                drinkListToAdd.Clear();
                int catId = Convert.ToInt32(cbcategory.SelectedValue);
                int drinkId = Convert.ToInt32(cbProduct.SelectedValue);
                if (catId == 0 && drinkId == 0)
                {
                    drinkListToAdd = drinkList.Skip(1).ToList();

                }
                else if (catId != 0 && drinkId == 0)
                {
                    drinkListToAdd = drinkList.Skip(1).ToList();

                }
                else
                {
                    drinkListToAdd.Add(BUSDrink.Instance.GetDrinkById(drinkId));
                }
                foreach (var drink in drinkListToAdd)
                {
                    if (BUSEvent.Instance.CheckDrinkEvent(drink, dtpStartDate.Value, dtpEndDate.Value))
                    {
                        if (!Checked)
                        {
                            if (MessageBox.Show("Another event that existed the selected drink. Do you want to continue.? ", "Confirm to continue", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                Checked = true;
                                continue;
                            }
                            break;
                        }
                        else
                        { 
                            continue;
                        }
                    }
                    // Khởi tạo
                    if (!listDrinkID.Contains(drink.id))
                    {
                        gridviewEventAppliedProduct.Rows.Add(drink.id, drink.DrinksID, drink.DrinksName, drink.CATEGORY.CategoryName);
                        listDrinkID.Add(drink.id);
                    }
                }
            }
            catch
            {

            }
        }
        private void cbcategory_SelectedValueChanged(object sender, EventArgs e)
        {
            var allDrink = new DRINK { id = 0, DrinksID = "DK0000", DrinksName = "All", CategoryID = 0, Description = null, Image = "", Status = "Active" };
            cbProduct.DataSource = null;
            if (cbcategory.SelectedValue != null && cbcategory.SelectedValue is int catId)
            {
                if (Convert.ToInt32(cbcategory.SelectedValue) == 0)
                {
                    drinkList = BUSDrink.Instance.GetAllDrinkActive();
                }
                else
                {
                    drinkList = BUSDrink.Instance.GetAllDrinkForEvent(catId);
                }
            }
            if (drinkList.Count != 0)
            {
                drinkList.Insert(0, allDrink);
            }
            cbProduct.DataSource = drinkList;
            cbProduct.ValueMember = "id";
            cbProduct.DisplayMember = "DrinksName";
        }

        private void txtSaleValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gridviewEventAppliedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                if (e.ColumnIndex == gridviewEventAppliedProduct.Columns["Delete"].Index)
                {
                    int idx = Convert.ToInt32(gridviewEventAppliedProduct.Rows[e.RowIndex].Cells["ID"].Value);
                    gridviewEventAppliedProduct.Rows.RemoveAt(e.RowIndex);
                    listDrinkID.Remove(idx);
                }
                else
                {
                    MessageBox.Show("Please click at rows to delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
                    if (String.IsNullOrEmpty(txtEventname.Text) || gridviewEventAppliedProduct.Rows == null || String.IsNullOrEmpty(txtSaleValue.Text)
                    || !(cbSalePercentage.Checked || cbSaleSamePrice.Checked) || String.IsNullOrEmpty(cbStatus.Text))
                    {
                        MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var drinks = new List<DRINK>();
                    foreach (var p in listDrinkID)
                    {
                        drinks.Add(BUSDrink.Instance.GetDrinkById(p));
                    }

                    if (BUSEvent.Instance.UpdEvent(Event.id, txtEventname.Text, cbSalePercentage.Checked, lbUnit.Text, dtpStartDate.Value, dtpEndDate.Value, float.Parse(txtSaleValue.Text), drinks, cbStatus.Text, BUSUser.Instance.idUserLogin))
                    {
                        MessageBox.Show("Modify event successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
