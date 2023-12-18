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
            lbAreaID.Text = (BUS.BUSEvent.Instance.GetAllEvent().Count + 1).ToString();

            combobox_category.Items.Add("All");
            BUS.BUSCategory.Instance.GetAllCategory().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });

            combobox_category.Items.Add("All");
            BUS.BUSDrink.Instance.GetAllDrink().ForEach(p =>
            {
                comboboxProduct.Items.Add(p.DrinksName);
            });

            i = 1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var drink = (from p in BUS.BUSDrink.Instance.GetAllDrink() where p.DrinksName.Equals(comboboxProduct.SelectedItem.ToString()) select p).FirstOrDefault();

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
