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
    public partial class UCProducts : UserControl
    {
        private List<UCProductMiniItem> listMiniItem;
        private List<DRINK> listDrink;
        private List<DRINKS_SIZE> listDrinkSize;
        private List<C_SIZE> listSize;
        private List<CATEGORY> listCategories;
        public UCProducts()
        {
            InitializeComponent();
            listMiniItem = new List<UCProductMiniItem>();
            listDrink = BUS.BUSDrink.Instance.GetAllDrink();
            listDrinkSize = BUS.BUSDrink_Size.Instance.GetAllDrinkSize();
            listSize = BUS.BUSSize.Instance.GetAllSize();
            listCategories = BUS.BUSCategory.Instance.GetAllCategory();
            LoadCategory(BUS.BUSCategory.Instance.GetAllCategory());
            combobox_category.Items.Add("All");
            combobox_category.SelectedItem = "All";
            BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });
        }

        private void LoadCategory(List<CATEGORY> listCategory)
        {
            gridviewTable.Rows.Clear();
            gridviewTable.Refresh();
            foreach (var category in listCategory)
            {
                gridviewTable.Rows.Add(category.id, category.CategoryID, category.CategoryName);
            }
        }

        public void LoadProductInFlowLayoutPanel(List<DRINK> listDrink, List<DRINKS_SIZE> listDrinkSize, List<C_SIZE> listSize)
        {
            flowLayoutPanel.Controls.Clear();

            // Load data for user control
            foreach (var drink in listDrink)
            {
                foreach (var drinkSize in listDrinkSize)
                {
                    if (drink.id == drinkSize.DrinksID)
                    {
                        foreach (var size in listSize)
                        {
                            if (size.id == drinkSize.SizeID)
                            {
                                UCProductMiniItem productMiniItem = new UCProductMiniItem(this);
                                productMiniItem.loadData(drink.id, drink.Image, drink.DrinksName, drinkSize.OriginalPrice, size.SizeName, drink.Description);
                                listMiniItem.Add(productMiniItem);
                                flowLayoutPanel.Controls.Add(productMiniItem);
                            }
                        }
                    }
                }
            }

        }

        public void deleteMiniItem(UCProductMiniItem uc)
        {
            flowLayoutPanel.Controls.Remove(uc);
        }

        public void updateMiniItem(UCProductMiniItem uc)
        {
            LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(), BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
        }

        private void ucProductMiniItem2_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addNewProduct = new AddNewProduct();
            addNewProduct.ShowDialog();
            if (addNewProduct.anyAdded())
            {
                LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(), BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }    
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            PanelProductlist.Visible = true;
            PanelCategory.Visible = false;

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            PanelProductlist.Visible = false;
            PanelCategory.Visible = true;
        }

        private void combobox_category_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            {
                List<DRINK> listDrinkbyCategoryAndSearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()) && p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
                    {
                        listDrinkbyCategoryAndSearching.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbyCategoryAndSearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else if (!combobox_category.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            {
                List<DRINK> listDrinkbyCategory = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
                    {
                        listDrinkbyCategory.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbyCategory, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else if (combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            {
                List<DRINK> listDrinkbySearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()))
                    {
                        listDrinkbySearching.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbySearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else
            {
                LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(),
                                                  BUS.BUSDrink_Size.Instance.GetAllDrinkSize(),
                                                  BUS.BUSSize.Instance.GetAllSize());
            }
        }

        private void txtEmailCode_TextChanged(object sender, EventArgs e)
        {
            if (!combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            {
                List<DRINK> listDrinkbyCategoryAndSearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()) && p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
                    {
                        listDrinkbyCategoryAndSearching.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbyCategoryAndSearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else if (!combobox_category.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            {
                List<DRINK> listDrinkbyCategory = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
                    {
                        listDrinkbyCategory.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbyCategory, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else if (combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            {
                List<DRINK> listDrinkbySearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()))
                    {
                        listDrinkbySearching.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbySearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else
            {
                LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(),
                                                  BUS.BUSDrink_Size.Instance.GetAllDrinkSize(),
                                                  BUS.BUSSize.Instance.GetAllSize());
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            if (addCategory.anyAdded())
            {
                LoadCategory(BUS.BUSCategory.Instance.GetAllCategory());
            }    
        }

        private void gridviewTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == gridviewTable.Columns["ID"].Index || e.ColumnIndex == gridviewTable.Columns["CategoryID"].Index || e.ColumnIndex == gridviewTable.Columns["Category_name"].Index)
            {
                AddCategory addCategory = new AddCategory((Convert.ToInt32(gridviewTable.Rows[e.RowIndex].Cells["id"].Value)));
                addCategory.ShowDialog();
                if (addCategory.anyDeleted() || addCategory.anyUpdated())
                {
                    LoadCategory(BUS.BUSCategory.Instance.GetAllCategory());
                }
            }
            else
            {
                MessageBox.Show("Please double click at rows to update or delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            var listCategories = new List<CATEGORY>();
            BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                if (p.CategoryName.Contains(txtFindCategory.Text))
                {
                    listCategories.Add(p);
                }    
            });
            LoadCategory(listCategories);
        }
    }
}
