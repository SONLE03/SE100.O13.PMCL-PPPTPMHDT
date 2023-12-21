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
    public partial class UCMiniSizeForBill : UserControl
    {
        private UCProductsMiniForBills productMiniItem;
        private int id;
        public UCMiniSizeForBill()
        {
            InitializeComponent();
        }
        public UCMiniSizeForBill(C_SIZE size, UCProductsMiniForBills productMiniItem, int id)
        {
            InitializeComponent();
            this.productMiniItem = productMiniItem;
            this.id = id;
            txtSize.Text = size.SizeName;
            showOriginalPriceOfSize();
        }
        private void showOriginalPriceOfSize()
        {
            var drinkSize = BUSDrink_Size.Instance.FindDrinkSize(txtSize.Text, id);
            productMiniItem.updatePrice(drinkSize.OriginalPrice.ToString());
            productMiniItem.Show();
        }

        private void txtSize_Click(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }

        private void UCMiniSizeForBill_Click(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }
    }
}
