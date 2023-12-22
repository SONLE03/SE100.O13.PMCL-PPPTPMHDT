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

namespace GUI
{
    public partial class AddNewEvent : Form
    {
        private int i;
        public AddNewEvent()
        {
            InitializeComponent();
            getCategory();
            addEventForCheckBox();
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

            //i = 1;
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
                cbProduct.DataSource = null;
                cbProduct.DataSource = BUSDrink.Instance.GetAllDrinkActive(catId);
                cbProduct.ValueMember = "id";
                cbProduct.DisplayMember = "DrinksName";
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var drink = (from p in BUS.BUSDrink.Instance.GetAllDrink() where p.DrinksName.Equals(cbProduct.SelectedItem.ToString()) select p).FirstOrDefault();

            gridviewEventAppliedProduct.Rows.Add(drink.DrinksID, drink.DrinksName, drink.CATEGORY.CategoryName, "VND");
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
                //MessageBox.Show("Please double click at rows to update or delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

      
    }
}
