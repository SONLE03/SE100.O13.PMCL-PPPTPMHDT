using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCBill : UserControl
    {
        public UCBill()
        {
            InitializeComponent();

            combobox_SelectArea.Items.Add("All");
            BUS.BUSArea.Instance.GetAllArea().ToList().ForEach(p =>
            {
                combobox_SelectArea.Items.Add(p.AreaName);
            });
            combobox_SelectArea.SelectedItem = "All";

            combobox_SelectTable.Items.Add("All");
            BUS.BUSTable.Instance.GetAllTable().ToList().ForEach(p =>
            {
                combobox_SelectTable.Items.Add(p.TableName);
            });
            combobox_SelectTable.SelectedItem = "All";

            combobox_category.Items.Add("All");
            BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });
            combobox_category.SelectedItem = "All";

            LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(),
                                                              BUS.BUSDrink_Size.Instance.GetAllDrinkSize(),
                                                              BUS.BUSSize.Instance.GetAllSize());

            flowLayoutPanel.Refresh();
        }

        public void LoadProductInFlowLayoutPanel(List<DRINK> listDrink, List<DRINKS_SIZE> listDrinkSize, List<C_SIZE> listSize)
        {
            flowLayoutPanelProducts.Controls.Clear();

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
                                //listMiniItem.Add(productMiniItem);
                                flowLayoutPanelProducts.Controls.Add(productMiniItem);
                            }
                        }
                    }
                }
            }

        }

        public void addMiniItemProduct(UCMiniProductChoosen product)
        {
            flowLayoutPanel.Controls.Add(product);
        }

        public void deleteMiniItemProduct(UCMiniProductChoosen product)
        {
            flowLayoutPanel.Controls.Remove(product);
        }

        private void UCBill_Load(object sender, EventArgs e)
        {

        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {

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

        private void btnAddtocart_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
        }
    }
}
