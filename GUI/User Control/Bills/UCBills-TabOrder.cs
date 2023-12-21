﻿using BUS;
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
        public UCBills_TabOrder(C_USER user)
        {
            InitializeComponent();
            listMiniItem = new List<UCProductsMiniForBills> ();
            this.user = user;
            LoadProduct();

            //lbOrderID.Text = "#" + (BUS.BUSOrder.Instance.GetAllBill().Count + 1).ToString();
            //lbSubTotal.Text = "0 VND";

            //combobox_SelectArea.Items.Add("All");
            //BUS.BUSArea.Instance.GetAllArea().ToList().ForEach(p =>
            //{
            //    combobox_SelectArea.Items.Add(p.AreaName);
            //});
            //combobox_SelectArea.SelectedItem = "All";

            //combobox_SelectTable.Items.Add("All");
            //BUS.BUSTable.Instance.GetAllTable().ToList().ForEach(p =>
            //{
            //    combobox_SelectTable.Items.Add(p.TableName);
            //});
            //combobox_SelectTable.SelectedItem = "All";

            //combobox_category.Items.Add("All");
            //BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            //{
            //    combobox_category.Items.Add(p.CategoryName);
            //});
            //combobox_category.SelectedItem = "All";

            //LoadProductInFlowLayoutPanel(BUS.BUSDrink.Instance.GetAllDrink(),
            //                                                  BUS.BUSDrink_Size.Instance.GetAllDrinkSize(),
            //                                                  BUS.BUSSize.Instance.GetAllSize());

            //flowLayoutPanel.Refresh();
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
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = sum.ToString() + " VND";

        }
        public void addQuantity(double price)
        {
            sum += price;
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = sum.ToString() + " VND";
        }

        public void deleteQuantity(double price)
        {
            sum -= price;
            lbSubTotal.Text = sum.ToString() + " VND";
            LbTotal.Text = sum.ToString() + " VND";
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
            LbTotal.Text = sum.ToString() + " VND";

        }
    }
}
