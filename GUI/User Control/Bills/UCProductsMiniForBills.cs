using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCProductsMiniForBills : UserControl
    {
        private UCBills_TabOrder ucBill;
        public UCProductsMiniForBills(UCBills_TabOrder ucBill)
        {
            InitializeComponent();
            this.ucBill = ucBill;
        }
        public void updatePrice(string price)
        {
            lbPrice.Text = price + " VND";
        }
        public void loadData(DRINK drink, List<int> sizes)
        {
            try
            {
                lbName.Text = drink.DrinksName;
                lbPrice.Text = "0 VND";
                labelID.Text = drink.id.ToString();
                drinkPicture.Image = new System.Drawing.Bitmap(drink.Image);

                foreach (var p in sizes)
                {
                    UCMiniSizeForBill uCMiniSize = new UCMiniSizeForBill(BUS.BUSSize.Instance.GetSizeById(p), this, drink.id);
                    flowLayoutSize.Controls.Add(uCMiniSize);
                }
            }
            catch (Exception ex)
            {
                string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                string imagePathError = Path.Combine(resourcesFolder, "NotFoundImage.png");
                drinkPicture.Image = new System.Drawing.Bitmap(imagePathError);
                BUS.BUSDrink.Instance.UpdateImageErrorNotFound(drink.id, imagePathError);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (ucBill != null)
            {
                var drink = BUS.BUSDrink.Instance.GetDrinkById(int.Parse(labelID.Text.ToString()));
                UCMiniProductChoosen ucMiniProductChoosen = new UCMiniProductChoosen(ucBill, drink.Image, lbName.Text, lbPrice.Text, int.Parse(labelID.Text));
                ucBill.addMiniItemProduct(ucMiniProductChoosen);
                ucBill.Show();
            }
        }
    }
}
