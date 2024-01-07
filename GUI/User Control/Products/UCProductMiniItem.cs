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
using BUS;
using DTO;
using static System.Windows.Forms.LinkLabel;

namespace GUI
{
    public partial class UCProductMiniItem : UserControl
    {
        private UCProducts_TabProducts ucProduct;
        public UCProductMiniItem(UCProducts_TabProducts ucProduct)
        {
            InitializeComponent();
            this.ucProduct = ucProduct;
        }

        public void updatePrice(string price, string size)
        {
            lbPrice.Text = price + " VND" + $" ({size})";
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
                    UCMiniSize uCMiniSize = new UCMiniSize(BUS.BUSSize.Instance.GetSizeById(p), this, drink.id);
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

        private void panelProduct_Click(object sender, EventArgs e)
        {
            ProductDetail productDetail = new ProductDetail(Convert.ToInt32(labelID.Text.ToString()));
            productDetail.ShowDialog();
        }

        private void pic_edit_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct(Convert.ToInt32(labelID.Text.ToString()));
            editProduct.ShowDialog();
            ucProduct.updateMiniItem(this);
            ucProduct.Show();
        }

        private void UCProductMiniItem_Load(object sender, EventArgs e)
        {
            //foreach (var p in ucProduct.S)
            //{
            //    UCMiniSize uCMiniSize = new UCMiniSize(BUSSize.Instance.GetSizeById(p), this, drink.id);
            //    flowLayoutSize.Controls.Add(uCMiniSize);
            //    uCMiniSize.UCMiniSizeClicked += UCMiniSize_UcMiniSizeClicked;
            //}
        }
    }
}
