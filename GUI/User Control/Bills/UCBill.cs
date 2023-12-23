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
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class UCBill : UserControl
    {
        private C_USER user;
        private Guna2GradientButton CurrentBtn;
        public UCBill(C_USER user)
        {
            InitializeComponent();
            this.user = user;
            CheckedBtnState(btnOrder);
        }
        private void CheckedBtnState(object button)
        {
            var btn = (Guna2GradientButton)button;
            btn.BackColor = Color.Transparent;
            btn.FillColor = Color.FromArgb(147, 90, 21);
            btn.FillColor2 = Color.FromArgb(147, 90, 21);
            btn.ForeColor = Color.White;

            if (CurrentBtn != null && CurrentBtn != btn)
            {
                CurrentBtn.FillColor = Color.FromArgb(234, 182, 134);
                CurrentBtn.FillColor2 = Color.FromArgb(234, 182, 134);
                CurrentBtn.ForeColor = Color.White;
            }
            CurrentBtn = btn;
        }

        private void UCBill_Load(object sender, EventArgs e)
        {

            ucBills_TabOrder = new UCBills_TabOrder(user);
            ucBills_TabOrder.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(ucBills_TabOrder);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ucBills_TabOrder = new UCBills_TabOrder(user);
            ucBills_TabOrder.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(ucBills_TabOrder);
            CheckedBtnState(sender);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ucBills_TabInvoices = new UCBills_TabInvoices();
            ucBills_TabInvoices.Dock = DockStyle.Fill;
            this.PanelDisplayTabs.Controls.Clear();
            this.PanelDisplayTabs.Controls.Add(ucBills_TabInvoices);
            CheckedBtnState(sender);
        }
        private void txtEmailCode_TextChanged(object sender, EventArgs e)
        {
            //if (!combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            //{
            //    List<DRINK> listDrinkbyCategoryAndSearching = new List<DRINK>();
            //    foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
            //    {
            //        if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()) && p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
            //        {
            //            listDrinkbyCategoryAndSearching.Add(p);
            //        }
            //    }
            //    LoadProductInFlowLayoutPanel(listDrinkbyCategoryAndSearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            //}
            //else if (!combobox_category.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            //{
            //    List<DRINK> listDrinkbyCategory = new List<DRINK>();
            //    foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
            //    {
            //        if (p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
            //        {
            //            listDrinkbyCategory.Add(p);
            //        }
            //    }
            //    LoadProductInFlowLayoutPanel(listDrinkbyCategory, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            //}
            //else if (combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            //{
            //    List<DRINK> listDrinkbySearching = new List<DRINK>();
            //    foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
            //    {
            //        if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()))
            //        {
            //            listDrinkbySearching.Add(p);
            //        }
            //    }
            //    LoadProductInFlowLayoutPanel(listDrinkbySearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            //}
            //else
            //{
            //    LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(),
            //                                      BUS.BUSDrink_Size.Instance.GetAllDrinkSize(),
            //                                      BUS.BUSSize.Instance.GetAllSize());
            //}
        }

        private void combobox_category_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (!combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            //{
            //    List<DRINK> listDrinkbyCategoryAndSearching = new List<DRINK>();
            //    foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
            //    {
            //        if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()) && p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
            //        {
            //            listDrinkbyCategoryAndSearching.Add(p);
            //        }
            //    }
            //    LoadProductInFlowLayoutPanel(listDrinkbyCategoryAndSearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            //}
            //else if (!combobox_category.SelectedItem.ToString().Equals("All") && String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            //{
            //    List<DRINK> listDrinkbyCategory = new List<DRINK>();
            //    foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
            //    {
            //        if (p.CATEGORY.CategoryName.Equals(combobox_category.SelectedItem.ToString()))
            //        {
            //            listDrinkbyCategory.Add(p);
            //        }
            //    }
            //    LoadProductInFlowLayoutPanel(listDrinkbyCategory, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            //}
            //else if (combobox_category.SelectedItem.ToString().Equals("All") && !String.IsNullOrEmpty(txtEmailCode.Text.ToString()))
            //{
            //    List<DRINK> listDrinkbySearching = new List<DRINK>();
            //    foreach (var p in BUS.BUSDrink.Instance.GetAllDrink())
            //    {
            //        if (p.DrinksName.ToLower().Contains(txtEmailCode.Text.ToString().ToLower()))
            //        {
            //            listDrinkbySearching.Add(p);
            //        }
            //    }
            //    LoadProductInFlowLayoutPanel(listDrinkbySearching, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            //}
            //else
            //{
            //    LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(),
            //                                      BUS.BUSDrink_Size.Instance.GetAllDrinkSize(),
            //                                      BUS.BUSSize.Instance.GetAllSize());
            //}
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
            //flowLayoutPanel.Controls.Clear();
            //nameProductInBill = new List<BillDetail>();
            //sum = 0;
            //lbSubTotal.Text = sum.ToString() + " VND";
            //lbSurcharge.Text = extraFee.ToString() + " VND";
            //LbTotal.Text = (sum + extraFee).ToString() + " VND";

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
