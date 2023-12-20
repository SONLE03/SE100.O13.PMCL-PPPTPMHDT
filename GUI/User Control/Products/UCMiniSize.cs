using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class UCMiniSize : UserControl
    {
        private UCProductMiniItem productMiniItem;
        private string id;
        public UCMiniSize(C_SIZE size, UCProductMiniItem productMiniItem, string id)
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
            var drinkSize = (from p in BUS.BUSDrink_Size.Instance.GetAllDrinkSize() where p.C_SIZE.SizeName.Equals(txtSize.Text) && p.DRINK.id.ToString().Equals(id) select p).FirstOrDefault();
            productMiniItem.updatePrice(drinkSize.OriginalPrice.ToString());
            productMiniItem.Show();
        }

        private void txtSize_Click_1(object sender, EventArgs e)
        {
            showOriginalPriceOfSize();
        }
    }
}
