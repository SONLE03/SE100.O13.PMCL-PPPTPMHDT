using BUS;
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
    public partial class ProductDetail : Form
    {
        private DRINK drink;
        public ProductDetail(int id)
        {
            InitializeComponent();
            drink = BUSDrink.Instance.GetDrinkById(id);
            LoadData(drink);
        }
        private void LoadData(DRINK drink)
        {
            try
            {
                lb_productname.Text = drink.DrinksName;
                lbDescribe.Text = drink.Description;
                lbStatus.Text = drink.Status;
                lbCategory.Text = drink.CATEGORY.CategoryName;
                foreach (var drink_size in drink.DRINKS_SIZE)
                {
                    SizeGrid.Rows.Add(drink_size.C_SIZE.SizeName, drink_size.OriginalPrice, drink_size.Discount);
                }
                picture_product.Image = Image.FromFile(drink.Image);
            }
            catch
            {
                string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                string imagePathError = Path.Combine(resourcesFolder, "NotFoundImage.png");
                picture_product.Image = new System.Drawing.Bitmap(imagePathError);
                BUS.BUSDrink.Instance.UpdateImageErrorNotFound(drink.id, imagePathError);
            }
           
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
