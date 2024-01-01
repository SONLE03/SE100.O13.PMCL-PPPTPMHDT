using BUS;
using BUS.BUSPrint;
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
using static System.Windows.Forms.AxHost;

namespace GUI
{
    public partial class UCBills_TabOrder : UserControl
    {
        private BUSPrintInvoice printInvoice;
        private double sum = 0;
        private C_USER user;
        public List<(int, int)> Drink_Size = new List<(int, int)>();
        private List<UCProductsMiniForBills> listMiniItem;
        public List<BillDetail> billDetails = new List<BillDetail>();
        private double tax;
        public UCBills_TabOrder(C_USER user)
        {
            InitializeComponent();
            tax = (double)BUS.BUSRule.Instance.GetAllRule().Tax / 100;
            sum = 0;
            lbSurcharge.Text = "0 VND".ToString();
            listMiniItem = new List<UCProductsMiniForBills>();
            this.user = user;
            LoadArea();
            LoadProduct();
            LoadCategory();
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

        private void LoadArea()
        {
            try
            {
                cbArea.DataSource = null;
                cbArea.DataSource = BUSArea.Instance.GetAllAreaActive();
                cbArea.DisplayMember = "AreaName";
                cbArea.ValueMember = "id";
            }
            catch
            {

            }
          
        }
        private void cbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbArea.SelectedValue != null && cbArea.SelectedValue is int areaId)
            {
                cbTable.DataSource = null;
                cbTable.DataSource = BUSTable.Instance.GetAllTableByAreaID(areaId);
                cbTable.ValueMember = "id";
                cbTable.DisplayMember = "TableNameAndStatus";
            }
        }

        private void Search()
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                string selectedCategory = combobox_category.SelectedItem?.ToString();
                string status = "Active";
                List<DRINK> listDrinks = BUSDrink.Instance.SearchDrinks(searchText, selectedCategory, status);
                LoadProductInFlowLayoutPanel(listDrinks, BUS.BUSDrink_Size.Instance.GetAllDrinkSize(), BUS.BUSSize.Instance.GetAllSize());
            }
            catch
            {

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
        public bool listDrinkSize(int drinkID, int sizeID)
        {
            try
            {
                if (billDetails.Exists(pair => pair.drinkID == drinkID && pair.sizeID == sizeID)) return true;
                //Drink_Size.Add((drinkID, sizeID));
                return false;
            }
            catch
            {
                return true;
            }
        }
        private void Clear()
        {
            flowLayoutPanel.Controls.Clear();
            sum = 0;
            lbSubTotal.Text = "0 VND";
            lbSurcharge.Text = "0 VND";
            LbTotal.Text = "0 VND";
            billDetails.Clear();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void addMiniItemProduct(UCMiniProductChoosen drink)
        {
            flowLayoutPanel.Controls.Add(drink);
            billDetails.Add(new BillDetail(drink.getDrinkID(), drink.getQuantity(), drink.getSizeID(), drink.getUnitPrice()));
            sum += drink.getPrice();
            double taxFee = sum * tax;
            lbSurcharge.Text = taxFee.ToString() + " VND";
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + taxFee).ToString() + " VND";
        }

        public void addQuantity(double salePrice, UCMiniProductChoosen drink)
        {
            int oldQuantity = 0;
            int newQuantity = 0;
            foreach(var bill in billDetails)
            {
                if (bill.drinkID == drink.getDrinkID() && bill.sizeID == drink.getSizeID())
                {
                    oldQuantity = bill.quantity;
                    newQuantity = drink.getQuantity();
                    bill.quantity = drink.getQuantity();
                    break;
                }
            }
            sum = sum + (newQuantity -  oldQuantity) * salePrice;
            double taxFee = sum * tax;
            lbSurcharge.Text = taxFee.ToString() + " VND";
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + taxFee).ToString() + " VND";
        }

        public void deleteQuantity(double salePrice, UCMiniProductChoosen drink)
        {
            int oldQuantity = 0;
            int newQuantity = 0;
            foreach (var p in billDetails)
            {
                if (p.drinkID == drink.getDrinkID() && p.sizeID == drink.getSizeID())
                {
                    oldQuantity = p.quantity;
                    newQuantity = drink.getQuantity();
                    p.quantity = drink.getQuantity();
                    break;
                }
            }
            sum = sum - (oldQuantity - newQuantity) * salePrice;
            double taxFee = sum * tax;
            lbSurcharge.Text = taxFee.ToString() + " VND";
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = (sum + taxFee).ToString() + " VND";
        }

        public void deleteMiniItemProduct(UCMiniProductChoosen drink)
        {
            flowLayoutPanel.Controls.Remove(drink);
            for (int i = billDetails.Count - 1; i >= 0; i--)
            {
                if (billDetails[i].drinkID == drink.getDrinkID() && billDetails[i].sizeID == drink.getSizeID())
                {
                    billDetails.RemoveAt(i);
                }
            }

            //BillDetail billDetail = new BillDetail();
            //foreach (var p in nameProductInBill)
            //{
            //    if (p.drinkID == drink.getDrinkID() && p.quantity.Equals(drink.getQuantity()))
            //    {
            //        billDetail = p;
            //        break;
            //    }
            //}
            //nameProductInBill.Remove(billDetail);
            sum -= drink.getPrice();
            if (float.Parse(LbTotal.Text.Replace(" VND", "")) <= 0)
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
            if (flowLayoutPanel.Controls.Count == 0)
            {
                MessageBox.Show("There aren't drinks in the cart", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioTakeAway.Checked == false && radioOntheSpot.Checked == false)
            {
                MessageBox.Show("Please choose form of sale !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (radioTakeAway.Checked == false)
            {
                if (cbTable.SelectedItem == null)
                {
                    MessageBox.Show("Please choose table !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                            id = BUS.BUSOrder.Instance.AddBill(DateTime.Now, user.id, null, "None", double.Parse(total), float.Parse(lbSurcharge.Text.Replace(" VND", "")), double.Parse(lbSubTotal.Text.Replace(" VND", "")));
                        }
                        else
                        {
                            int tableID = BUSTable.Instance.GetTableById((int)cbTable.SelectedValue).id;
                            BUS.BUSTable.Instance.UpdTable(tableID, "InUse");
                            id = BUS.BUSOrder.Instance.AddBill(DateTime.Now, user.id, tableID, "None", double.Parse(total), float.Parse(lbSurcharge.Text.Replace(" VND", "")), double.Parse(lbSubTotal.Text.Replace(" VND", "")));
                        }
                        if (id > 0)
                        {
                            foreach (var billDetail in billDetails)
                            {
                                if (BUS.BUSOrderDetail.Instance.AddBillDetail(id, billDetail.drinkID, billDetail.sizeID, billDetail.quantity, (float)billDetail.unitPrice))
                                {
                                    continue;
                                }
                            }
                        }
                        MessageBox.Show("Created bill successfully", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        print(id);
                        LoadArea();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("There are some errors when trying to create bill !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please choose all information of bill like table, area , product !", "Create bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            try
            {
                var table = BUSTable.Instance.GetTableById((int)cbTable.SelectedValue);
                if (!table.Status.Equals("Active"))
                {
                    if(BUSTable.Instance.UpdTable((int)cbTable.SelectedValue, "Active")){
                        LoadArea();
                        MessageBox.Show("The table has just been cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("There are some error orcurred while trying to clear table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The table is in a clean state", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
            catch
            {

            }
        }
        private void print(int billID)
        {
            dataGridViewPrint.Rows.Clear();
            var invoice = BUSOrder.Instance.GetBillById(billID);
            var invoiceDetail = invoice.BILL_DETAIL.ToList();
            foreach (var ind in invoiceDetail)
            {
                dataGridViewPrint.Rows.Add(ind.DRINK.DrinksName, ind.C_SIZE.SizeName, ind.Quantity, ind.Rate, ind.Amount);
            }
            printInvoice = new BUSPrintInvoice(dataGridViewPrint, invoice);
            printInvoice.PrintReport();
        }

        private void UCBills_TabOrder_Load(object sender, EventArgs e)
        {
            
        }
    }
}
