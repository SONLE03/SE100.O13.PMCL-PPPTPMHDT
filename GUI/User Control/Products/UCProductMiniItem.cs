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
    public partial class UCProductMiniItem : UserControl
    {
        private bool anyChanged = false;
        private UCProducts ucProduct;
        public UCProductMiniItem(UCProducts ucProduct)
        {
            InitializeComponent();
            this.ucProduct = ucProduct;
        }

        public void loadData(int idProduct, string pathImage, string productName, double price, string sizeName, string description)
        {
            guna2CirclePictureBox1.Image = new System.Drawing.Bitmap(pathImage);
            lbName.Text = productName;
            lbPrice.Text = price.ToString() + " VND";
            lbDescribe.Text = description;
            textBox1.Text = sizeName;
            labelID.Text = idProduct.ToString();
            labelID.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var drink = BUS.BUSDrink.Instance.GetDrinkById(int.Parse(labelID.Text.ToString()));
            var size = (from p in BUS.BUSSize.Instance.GetAllSize() where p.SizeName.Equals(textBox1.Text.ToString()) select p).FirstOrDefault();
            var drinkSize = (from p in BUS.BUSDrink_Size.Instance.GetAllSize() where p.SizeID.Equals(size.id) && p.DrinksID.Equals(drink.id) select p).FirstOrDefault();

            AddNewProduct addNewProduct = new AddNewProduct(drink, size, drinkSize);
            addNewProduct.ShowDialog();

            anyChanged = true;

            if (addNewProduct.getAnyChanged())
            {
                ucProduct.deleteMiniItem(this);
                ucProduct.Show();
            }    
        }

        public bool getAnyChanged()
        {
            return anyChanged;
        }

        public void setAnyChanged(bool anyChanged)
        {
            this.anyChanged = anyChanged;
        }
    }
}
