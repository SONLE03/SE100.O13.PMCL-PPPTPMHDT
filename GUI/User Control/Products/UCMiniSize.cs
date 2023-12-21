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
    public partial class UCMiniSize : UserControl
    {
        private UCProductMiniItem productMiniItem;
        private int id;
        public UCMiniSize(C_SIZE size, UCProductMiniItem productMiniItem, int id)
        {
            InitializeComponent();
            this.productMiniItem = productMiniItem;
            this.id = id;
            txtSize.Text = size.SizeName;
            showOriginalPriceOfSize();
        }

        private void UCMiniSize_Click(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }
        private void showOriginalPriceOfSize()
        {
            var drinkSize = BUSDrink_Size.Instance.FindDrinkSize(txtSize.Text, id);
            productMiniItem.updatePrice(drinkSize.OriginalPrice.ToString());
            productMiniItem.Show();
        }

        private void txtSize_Click_1(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }
    }
}
