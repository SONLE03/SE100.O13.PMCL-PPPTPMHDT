using BUS;
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
    public partial class UCBills_TabOrder : UserControl
    {
        private double sum = 0;
        private C_USER user;
        private List<UCProductsMiniForBills> listMiniItem;
        private List<BillDetail> nameProductInBill = new List<BillDetail>();
        private double tax;
        public UCBills_TabOrder(C_USER user)
        {
            InitializeComponent();
            tax = (double) BUS.BUSRule.Instance.GetAllRule().Tax / 100;
            sum = 0;
            lbSurcharge.Text = "0 VND".ToString();
            listMiniItem = new List<UCProductsMiniForBills> ();
            this.user = user;
            LoadProduct();
            LoadArea();
            combobox_category.Items.Add("All");
            combobox_category.Text = "All";
            BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });
            lbOrderID.Text = "#" + (BUS.BUSOrder.Instance.GetAllBill().Count + 1).ToString();
        }

        private void LoadArea()
        {
            cbArea.DataSource = null;
            cbArea.DataSource = BUSArea.Instance.GetAllAreaActive();
            cbArea.DisplayMember = "AreaName";
            cbArea.ValueMember = "id";
        }
        private void cbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbArea.SelectedValue != null && cbArea.SelectedValue is int areaId)
            {
                //cbTable.DataSource = null;
                //cbTable.DataSource = BUSTable.Instance.GetAllTableByAreaID(areaId);
                //cbTable.ValueMember = "id";
                //cbTable.DisplayMember = "TableNameAndStatus";

                cbTable.Items.Clear();
                BUSTable.Instance.GetAllTableByAreaID(areaId).ToList().ForEach(p =>
                {
                    cbTable.Items.Add(p.TableName + " | " + p.Status);
                });
            }
        }

        private void LoadProduct()
        {
            LoadProductInFlowLayoutPanel(BUSDrink.Instance.GetAllDrink(), BUSDrink_Size.Instance.GetAllDrinkSize(), BUSSize.Instance.GetAllSize());
        }
        public void LoadProductInFlowLayoutPanel(List<DRINK> listDrink, List<DRINKS_SIZE> listDrinkSize, List<C_SIZE> listSize)
        {
            try
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
                    UCProductsMiniForBills productMiniItem = new UCProductsMiniForBills(this);
                    productMiniItem.loadData(drink, list);
                    listMiniItem.Add(productMiniItem);
                    flowLayoutPanelProducts.Controls.Add(productMiniItem);
                }
            }
            catch
            {

            }
        }
        public void addMiniItemProduct(UCMiniProductChoosen product)
        {
            flowLayoutPanel.Controls.Add(product);
            nameProductInBill.Add(new BillDetail(product.getProductName(), product.getQuantity()));
            sum += product.getPrice();
            double taxFee = sum * tax;
            lbSurcharge.Text = taxFee.ToString() + " VND";
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + taxFee).ToString() + " VND";

        }
        public void addQuantity(double price, double salePrice, UCMiniProductChoosen product)
        {
            nameProductInBill.Add(new BillDetail(product.getProductName(), product.getQuantity()));
            sum += (price - salePrice);
            double taxFee = sum * tax;
            lbSurcharge.Text = taxFee.ToString() + " VND";
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + taxFee).ToString() + " VND";
        }

        public void deleteQuantity(double price, double salePrice, string productName)
        {
            BillDetail billDetail = new BillDetail();
            foreach(var p in nameProductInBill)
            {
                if (p.productName.Equals(productName))
                {
                    billDetail = p;
                }    
            }    
            if (billDetail.productName.Equals(productName))
            {
                nameProductInBill.Remove(billDetail);
            }    
            sum -= (price - salePrice);
            double taxFee = sum * tax;
            lbSurcharge.Text = taxFee.ToString() + " VND";
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + taxFee).ToString() + " VND";
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
            if (int.Parse(LbTotal.Text.Replace(" VND", "")) <= 0)
            {
                lbSubTotal.Text = "0 VND";
                lbSurcharge.Text = "0 VND";
                LbTotal.Text = "0 VND";
            }    
            else
            {
                lbSubTotal.Text = sum.ToString() + " VND";
                lbSurcharge.Text = (sum * tax).ToString() + " VND";
                LbTotal.Text = (sum + (sum * tax)).ToString() + " VND";
            }    
        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            string[] parts = cbTable.SelectedItem.ToString().Split(new[] { " | " }, StringSplitOptions.None);
            if (parts[1].Contains("InActive"))
            {
                MessageBox.Show("This table is in used", "Create Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            DialogResult dialog = MessageBox.Show("Are you sure ?", "Create bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    string total = LbTotal.Text.Replace(" VND", "");

                    if (true)
                    {
                        var tax = BUS.BUSRule.Instance.GetAllRule();
                        int id = -1;
                        if (radioTakeAway.Checked == true)
                        {
                            id = BUS.BUSOrder.Instance.AddBill(DateTime.Now, 0, user.id, null, "None", double.Parse(total), float.Parse(lbSurcharge.Text.Replace(" VND", "")));
                        }
                        else
                        {
                            var separatorIndex = cbTable.SelectedItem.ToString().IndexOf(" | ");
                            string tableName = cbTable.SelectedItem.ToString().Substring(0, separatorIndex);

                            var table = (from p in BUS.BUSTable.Instance.GetAllTable() where p.TableName.Equals(tableName) select p).FirstOrDefault();
                            BUS.BUSTable.Instance.UpdTable(table.id, tableName, table.AreaID, "InActive");
                            id = BUS.BUSOrder.Instance.AddBill(DateTime.Now, 0, user.id, table.id, "None", double.Parse(total), float.Parse(lbSurcharge.Text.Replace(" VND", ""))) ;
                        }
                        if (id > 0)
                        {
                            var listProduct = new List<string>();
                            foreach (var p in nameProductInBill)
                            {
                                bool check = false;
                                var product = (from s in BUS.BUSDrink.Instance.GetAllDrink() where s.DrinksName.Equals(p.productName) select s).FirstOrDefault();
                                foreach(var s in listProduct)
                                {
                                    if (s.Equals(p.productName))
                                    {
                                        check = true;
                                        break;
                                    }    
                                }
                                if (check == false)
                                {
                                    int i = 0;
                                    foreach (var pd in nameProductInBill)
                                    {
                                        if (pd.productName.Equals(p.productName))
                                        {
                                            i++;
                                        }
                                    }
                                    if (BUS.BUSOrderDetail.Instance.AddBillDetail(id, product.id, "none", i, 0))
                                    {
                                        listProduct.Add(product.DrinksName);
                                        continue;
                                    }
                                }
                            }
                            MessageBox.Show("Created bill successfully", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadArea();
                            flowLayoutPanel.Controls.Clear();
                            flowLayoutPanel.Refresh();
                            cbArea.SelectedItem = "All";
                            cbTable.SelectedItem = "All";
                            combobox_category.SelectedItem = "All";
                            lbSubTotal.Text = "0 VND";
                            lbSurcharge.Text = "0 VND";
                            LbTotal.Text = "0 VND";
                            sum = 0;
                            nameProductInBill = new List<BillDetail>();
                            lbOrderID.Text = "#" + (BUS.BUSOrder.Instance.GetAllBill().Count + 1).ToString();
                        }
                        else
                        {
                            MessageBox.Show("There are some errors when trying to create bill !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose table !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please choose all information of bill like table, area , product !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            sum = 0;
            lbSubTotal.Text = "0 VND";
            lbSurcharge.Text = "0 VND";
            LbTotal.Text = "0 VND";
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

        private void txtEmailCode_TextChanged_1(object sender, EventArgs e)
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

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            string[] parts = cbTable.SelectedItem.ToString().Split(new[] { " | " }, StringSplitOptions.None);
            if (parts[1].Contains("InActive"))
            {
                var tableName = parts[0];
                var tb = (from p in BUS.BUSTable.Instance.GetAllTable() where p.TableName.Equals(tableName) select p).FirstOrDefault();
                if (BUS.BUSTable.Instance.UpdTable(tb.id, tb.TableName, tb.AreaID, "Active"))
                {
                    LoadArea();
                    MessageBox.Show("This table is clear", "Clear table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There are some error orcurred while trying to clear table", "Clear table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
            else if (parts[1].Contains("Active"))
            {
                MessageBox.Show("This table was cleared", "Clear table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else
            {

            }    
        }
    }
}
