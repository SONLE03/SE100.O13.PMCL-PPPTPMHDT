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
        private double sum = 0;
        private double? extraFee = 0;
        private C_USER user;
        private List<BillDetail> nameProductInBill = new List<BillDetail>();
        public UCBill(C_USER user)
        {
            InitializeComponent();

            this.user = user;

            lbOrderID.Text = "#" + (BUS.BUSOrder.Instance.GetAllBill().Count + 1).ToString();
            lbSubTotal.Text = "0 VND";

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
                //listMiniItem.Add(productMiniItem);
                flowLayoutPanelProducts.Controls.Add(productMiniItem);
            }
        }

        public void addMiniItemProduct(UCMiniProductChoosen product)
        {
            flowLayoutPanel.Controls.Add(product);
            nameProductInBill.Add(new BillDetail(product.getProductName(), product.getQuantity()));
            sum += product.getPrice();
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + extraFee).ToString() + " VND";

        }

        public void addQuantity(double price)
        {
            sum += price;
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + extraFee).ToString() + " VND";
        }

        public void deleteQuantity(double price)
        {
            sum -= price;
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + extraFee).ToString() + " VND";
        }

        public void deleteMiniItemProduct(UCMiniProductChoosen product)
        {
            flowLayoutPanel.Controls.Remove(product);
            BillDetail billDetail = new BillDetail();
            foreach (var p in nameProductInBill)
            {
                if (p.productName.Equals(product.getProductName()) && p.quantity.Equals(product.getQuantity()))
                {
                    billDetail = p;
                    break;
                }    
            }
            nameProductInBill.Remove(billDetail);
            sum -= product.getPrice();
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + extraFee).ToString() + " VND";

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
            //DialogResult dialog = MessageBox.Show("Are you sure ?", "Create bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialog == DialogResult.Yes)
            //{
            //    try
            //    {
            //        string total = LbTotal.Text.Replace(" VND", "");
            //        var table = (from p in BUS.BUSTable.Instance.GetAllTable() where p.TableName.Equals(combobox_SelectTable.SelectedItem.ToString()) select p).FirstOrDefault();
            //        if (table != null)
            //        {
            //            int id = BUS.BUSOrder.Instance.AddBill(DateTime.Now, 0, user.id, table.id, "None", double.Parse(total));
            //            if (id > 0)
            //            {
            //                foreach (var p in nameProductInBill)
            //                {
            //                    var product = (from s in BUS.BUSDrink.Instance.GetAllDrink() where s.DrinksName.Equals(p.productName) select s).FirstOrDefault();
            //                    if (BUS.BUSOrderDetail.Instance.AddBillDetail(id, product.id, "none", p.quantity, 0))
            //                    {
            //                        continue;
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("There are some errors when trying to create bill detail !", "Create bill detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                        break;
            //                    }
            //                }
            //                MessageBox.Show("Created bill successfully", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                flowLayoutPanel.Controls.Clear();
            //                flowLayoutPanel.Refresh();
            //                combobox_SelectArea.SelectedItem = "All";
            //                combobox_SelectTable.SelectedItem = "All";
            //                combobox_category.SelectedItem = "All";
            //                lbSubTotal.Text = "0 VND";
            //                lbSurcharge.Text = "0 VND";
            //                LbTotal.Text = "0 VND";
            //                lbOrderID.Text = "#" + (BUS.BUSOrder.Instance.GetAllBill().Count + 1).ToString();
            //            }
            //            else
            //            {
            //                MessageBox.Show("There are some errors when trying to create bill !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please choose table !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Please choose all information of bill like table, area , product !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            nameProductInBill = new List<BillDetail>();
            sum = 0;
            lbSubTotal.Text = sum.ToString() + " VND";
            lbSurcharge.Text = extraFee.ToString() + " VND";
            LbTotal.Text = (sum + extraFee).ToString() + " VND";

        }

        //public void LoadTotalPrice()
        //{
        //    for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
        //    {
        //        UCMiniProductChoosen ucProduct = (UCMiniProductChoosen)flowLayoutPanel.Controls[i];
        //        sum += ucProduct.getPrice();
        //    }
        //    lbSubTotal.Text = sum.ToString() + " VND";
        //}

        private void combobox_SelectArea_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (!combobox_SelectArea.SelectedItem.ToString().Equals("All"))
            //{
            //    var area = (from p in BUS.BUSArea.Instance.GetAllArea() where p.AreaName.Equals(combobox_SelectArea.SelectedItem.ToString()) select p).FirstOrDefault();
            //    lbSurcharge.Text = area.ExtraFee.ToString() + " VND";
            //    extraFee = area.ExtraFee;
            //    LbTotal.Text = (sum + extraFee).ToString() + " VND";
            //}
            //else
            //{
            //    lbSurcharge.Text = "0 VND";
            //    extraFee = 0;
            //    LbTotal.Text = (sum + extraFee).ToString() + " VND";
            //}    
        }
    }
}
