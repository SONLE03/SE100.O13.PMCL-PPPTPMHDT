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


        //public event EventHandler UserControlClicked;
        private void UCMiniSize_Click(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }


        private void showOriginalPriceOfSize()
        {
            var drinkSize = BUSDrink_Size.Instance.FindDrinkSize(txtSize.Text, id);
            productMiniItem.updatePrice(drinkSize.OriginalPrice.ToString(), drinkSize.C_SIZE.SizeName);
            productMiniItem.Show();
        }

        private void txtSize_Click_1(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }

        private void UCMiniSize_MouseEnter(object sender, EventArgs e)
        {
            //this.BackColor = Color.Red;
        }

        private void UCMiniSize_MouseLeave(object sender, EventArgs e)
        {
            //this.BackColor = Color.White;
        }

        private void UCMiniSize_MouseClick(object sender, MouseEventArgs e)
        {
            //this.BackColor = Color.Blue;
            //showOriginalPriceOfSize();
        }
    }
}
