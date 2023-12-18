using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class UCProducts_TabProducts : UserControl
    {
        private List<UCProductMiniItem> listMiniItem;
        public UCProducts_TabProducts()
        {
            InitializeComponent();
            listMiniItem = new List<UCProductMiniItem>();
            LoadCategory();
            LoadProduct();
        }
        private void LoadProduct()
        {
            LoadProductInFlowLayoutPanel(BUSDrink.Instance.GetAllDrink(), BUSDrink_Size.Instance.GetAllDrinkSize(), BUSSize.Instance.GetAllSize());
        }
        private void LoadCategory()
        {        
            //CATEGORY cat = new CATEGORY(0,"0","All");
            //var listCategories = new List<CATEGORY>();
            //listCategories.Add(cat);
            //listCategories.AddRange(BUSCategory.Instance.GetAllCategory());
            //combobox_category.DataSource = listCategories;
            //combobox_category.ValueMember = "id";
            //combobox_category.DisplayMember = "CategoryName";
        }
        public void LoadProductInFlowLayoutPanel(List<DRINK> listDrink, List<DRINKS_SIZE> listDrinkSize, List<C_SIZE> listSize)
        {
            flowLayoutPanel.Controls.Clear();

            var list = new List<int>();
            // Load data for user control
            foreach (var drink in listDrink)
            {
                list = new List<int>();
                
                foreach (var drinkSize in listDrinkSize)
                {
                    if (drink.id == drinkSize.DrinksID)
                    {
                        list.Add(drinkSize.SizeID);
                    }
                }
                UCProductMiniItem productMiniItem = new UCProductMiniItem(this);
                productMiniItem.loadData(drink, list);
                listMiniItem.Add(productMiniItem);
                flowLayoutPanel.Controls.Add(productMiniItem);
            }
        }


        public void deleteMiniItem(UCProductMiniItem uc)
        {
            flowLayoutPanel.Controls.Remove(uc);
        }

        public void updateMiniItem(UCProductMiniItem uc)
        {
            LoadProduct();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addNewProduct = new AddNewProduct();
            addNewProduct.ShowDialog();
            if (addNewProduct.anyAdded())
            {
                LoadProduct();
            }
        }

        private void combobox_category_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<DRINK> listDrinkbyCategoryAndSearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtSearch.Text.ToString().ToLower()) && p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
                    {
                        listDrinkbyCategoryAndSearching.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbyCategoryAndSearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else if (!combobox_category.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtSearch.Text.ToString()))
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
            else if (combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<DRINK> listDrinkbySearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtSearch.Text.ToString().ToLower()))
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<DRINK> listDrinkbyCategoryAndSearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtSearch.Text.ToString().ToLower()) && p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
                    {
                        listDrinkbyCategoryAndSearching.Add(p);
                    }
                }
                LoadProductInFlowLayoutPanel(listDrinkbyCategoryAndSearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            else if (!combobox_category.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtSearch.Text.ToString()))
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
            else if (combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtSearch.Text.ToString()))
            {
                List<DRINK> listDrinkbySearching = new List<DRINK>();
                foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
                {
                    if (p.DrinksName.ToLower().Contains(txtSearch.Text.ToString().ToLower()))
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
    }
}
