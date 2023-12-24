using BUS;
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
    public partial class AddNewEvent : Form
    {
        private int i;
        private List<string> listDrinks = new List<string>();
        private bool anyChanged = false;
        private List<DRINK> drinks = new List<DRINK>();
        private EVENT existingEvent;
        public AddNewEvent()
        {
            InitializeComponent();
            getCategory();
            addEventForCheckBox();
            i = 1;
            //lbAreaID.Text = (BUS.BUSEvent.Instance.GetAllEvent().Count + 1).ToString();

            //cbcategory.Items.Add("All");
            //BUS.BUSCategory.Instance.GetAllCategory().ForEach(p =>
            //{
            //    cbcategory.Items.Add(p.CategoryName);
            //});

            //cbcategory.Items.Add("All");
            //BUS.BUSDrink.Instance.GetAllDrink().ForEach(p =>
            //{
            //    cbProduct.Items.Add(p.DrinksName);
            //});
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            //i = 1;
        }

        public AddNewEvent(string id)
        {
            InitializeComponent();
            existingEvent = BUS.BUSEvent.Instance.GetEventByCode(id);
            txtEventname.Text = existingEvent.EventName;
            dtpStartDate.Value = existingEvent.StartDate.Value;
            dtpEndDate.Value = existingEvent.DueDate.Value;
            lbAreaID.Text = id;
            if (existingEvent.EventType == true)
            {
                cbSalePercentage.Checked = true;
            }
            else
            {
                cbSaleSamePrice.Checked = true;
            }
            txtSaleValue.Text = existingEvent.Discount.ToString();
            getCategory();

            foreach (var drink in existingEvent.DRINKS)
            {
                listDrinks.Add(drink.DrinksName);
                //drinks.Add(drink);
                gridviewEventAppliedProduct.Rows.Add(drink.DrinksID, drink.DrinksName, drink.CATEGORY.CategoryName, "VND");
            }
            btnCreate.Visible = false;
            i = 2;
        }

        public bool getAnyChanged()
        {
            return anyChanged;
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
            }else if (cbSalePercentage.Checked)
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
            cbcategory.DataSource = null;
            cbcategory.DataSource = BUSCategory.Instance.GetAllCategoryActive();
            cbcategory.ValueMember = "id";
            cbcategory.DisplayMember = "CategoryName";
        }
        private void cbcategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbcategory.SelectedValue != null && cbcategory.SelectedValue is int catId)
            {
                cbProduct.Items.Clear();
                BUSDrink.Instance.GetAllDrinkActive(catId).ToList().ForEach(p =>
                {
                    cbProduct.Items.Add(p.DrinksName);
                });
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var drink = (from p in BUS.BUSDrink.Instance.GetAllDrink() where p.DrinksName.Equals(cbProduct.SelectedItem.ToString()) select p).FirstOrDefault();
            gridviewEventAppliedProduct.Rows.Add(drink.DrinksID, drink.DrinksName, drink.CATEGORY.CategoryName, "VND");
            listDrinks.Add(drink.DrinksName);
            drinks.Add(drink);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gridviewEventAppliedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == gridviewEventAppliedProduct.Columns["Delete"].Index)
            {
                if (i == 1)
                {
                    gridviewEventAppliedProduct.Rows.Remove(gridviewEventAppliedProduct.Rows[e.RowIndex]);
                    string nameProduct = gridviewEventAppliedProduct.Rows[e.RowIndex].Cells["Product_name"].Value.ToString();
                    var drink = (from p in BUS.BUSDrink.Instance.GetAllDrink() where p.DrinksName.Equals(nameProduct) select p).FirstOrDefault();
                    listDrinks.Remove(drink.DrinksName);
                    drinks.Remove(drink);
                }
                else
                {
                    /*string SizeName = gridviewEventAppliedProduct.Rows[e.RowIndex].Cells["Size_name"].Value.ToString();
                    var size = (from p in BUS.BUSSize.Instance.GetAllSize() where p.SizeName.Equals(SizeName) select p).FirstOrDefault();
                    var drinkSize = (from p in BUS.BUSDrink_Size.Instance.GetAllDrinkSize() where p.DrinksID == drink.id && p.C_SIZE.SizeName.Equals(SizeName) select p).FirstOrDefault();
                    if (BUS.BUSDrink_Size.Instance.delDrinkSize(drinkSize, drink, size))
                    {
                        DialogResult dialog = MessageBox.Show("are you sure ?", "Info Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            guna2DataGridView1.Rows.Remove(guna2DataGridView1.Rows[e.RowIndex]);
                        }
                    }*/
                }
            }
            else
            {
                MessageBox.Show("Please click at rows to update or delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var drinks = new List<DRINK>();
            foreach (var p in listDrinks)
            {
                var drink = (from s in BUS.BUSDrink.Instance.GetAllDrink() where s.DrinksName.Equals(p) select s).FirstOrDefault();
                drinks.Add(drink);
            }

            if (BUS.BUSEvent.Instance.AddEvent(txtEventname.Text, cbSalePercentage.Checked, lbUnit.Text, dtpStartDate.Value, dtpEndDate.Value, float.Parse(txtSaleValue.Text), drinks) > 0)
            {
                if (true)
                {
                    MessageBox.Show("Add event successfully", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anyChanged = true;
                    listDrinks.Clear();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("There are some errors while trying to add event", "Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (BUS.BUSEvent.Instance.UpdEvent(existingEvent.id, dtpEndDate.Value, float.Parse(txtSaleValue.Text), drinks, "Active"))
            {
                MessageBox.Show("Update successfully", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anyChanged = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("There are some errors while trying to update event", "Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BUS.BUSEvent.Instance.DelEvent(existingEvent.id))
            {
                MessageBox.Show("Delete successfully", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anyChanged = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("There are some errors while trying to update event", "Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
