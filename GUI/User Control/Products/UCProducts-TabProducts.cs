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
            setProductStatus();
        }
        private void LoadProduct()
        {
            LoadProductInFlowLayoutPanel(BUSDrink.Instance.GetAllDrink(), BUSDrink_Size.Instance.GetAllDrinkSize(), BUSSize.Instance.GetAllSize());
        }
        private void setProductStatus()
        {
            cbStatus.Items.AddRange(new string[] { "All", "Active", "InActive" });
            cbStatus.SelectedIndex = 0;
        }
        private void LoadCategory()
        {
            combobox_category.Items.Add("All");
            BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });
            combobox_category.SelectedItem = "All";
        }
        public void LoadProductInFlowLayoutPanel(List<DRINK> listDrink, List<DRINKS_SIZE> listDrinkSize, List<C_SIZE> listSize)
        {
            try
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
            catch
            {

            } 
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addNewProduct = new AddNewProduct();
            addNewProduct.ShowDialog();
            LoadProduct();
        } 

        public void deleteMiniItem(UCProductMiniItem uc)
        {
            flowLayoutPanel.Controls.Remove(uc);
        }

        public void updateMiniItem(UCProductMiniItem uc)
        {
            LoadProduct();
        }

        private void Search()
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                string selectedCategory = combobox_category.SelectedItem?.ToString();
                string selectedStatus = cbStatus.Text;
                List<DRINK> listDrinks = BUSDrink.Instance.SearchDrinks(searchText, selectedCategory, selectedStatus);
                LoadProductInFlowLayoutPanel(listDrinks, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            catch
            {

            }     
        }

        private void combobox_category_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
