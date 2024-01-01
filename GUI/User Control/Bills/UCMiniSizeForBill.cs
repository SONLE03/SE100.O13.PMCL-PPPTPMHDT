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
    public partial class UCMiniSizeForBill : UserControl
    {
        private UCProductsMiniForBills productMiniItem;
        private int id;
        public UCMiniSizeForBill()
        {
            InitializeComponent();
        }
        public UCMiniSizeForBill(C_SIZE size, UCProductsMiniForBills productMiniItem, int drinkId)
        {
            InitializeComponent();
            this.productMiniItem = productMiniItem;
            this.id = drinkId;
            txtSize.Text = size.SizeName;
            showOriginalPriceOfSize();
        }
        private void showOriginalPriceOfSize()
        {
            var drinkSize = BUSDrink_Size.Instance.FindDrinkSize(txtSize.Text, id);
            productMiniItem.updatePriceAndSize(drinkSize.OriginalPrice.ToString(), drinkSize.SizeID);
            productMiniItem.Show();
        }

        private void txtSize_Click(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }

        public event EventHandler UserControlClicked;
        private void UCMiniSizeForBill_Click(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();

            UserControlClicked?.Invoke(this, EventArgs.Empty);
            ////Code đổi màu
            //foreach (Control control in Parent.Controls)
            //{
            //    if (control is UserControl)
            //    {
            //        control.BackColor = Color.White;
            //    }
            //}

            //this.BackColor = Color.FromArgb(127,81,26);
            //txtSize.ForeColor = Color.White;
        }
    }
}
