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
    public partial class UCProductMiniItem : UserControl
    {
        private bool anyChanged = false;
        private UCProducts ucProduct;
        private UCBill ucBill;
        public UCProductMiniItem(UCProducts ucProduct)
        {
            InitializeComponent();
            this.ucProduct = ucProduct;
            pictureBox2.Visible = false;
        }

        public UCProductMiniItem(UCBill uCBill)
        {
            InitializeComponent();
            this.ucBill = uCBill;
            pictureBox1.Visible = false;
        }

        public void loadData(int idProduct, string pathImage, string productName, double price, string sizeName, string description)
        {
            try
            {
                lbName.Text = productName;
                lbPrice.Text = price.ToString() + " VND";
                lbDescribe.Text = description;
                textBox1.Text = sizeName;
                labelID.Text = idProduct.ToString();
                labelID.Visible = false;
                guna2CirclePictureBox1.Image = new System.Drawing.Bitmap(pathImage);
            }
            catch (Exception ex)
            {
                string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                string imagePathError = Path.Combine(resourcesFolder, "NotFoundImage.png");
                guna2CirclePictureBox1.Image = new System.Drawing.Bitmap(imagePathError);

                BUS.BUSDrink.Instance.UpdateImageErrorNotFound(idProduct, imagePathError);
            }
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    var drink = BUS.BUSDrink.Instance.GetDrinkById(int.Parse(labelID.Text.ToString()));
        //    var size = (from p in BUS.BUSSize.Instance.GetAllSize() where p.SizeName.Equals(textBox1.Text.ToString()) select p).FirstOrDefault();
        //    var drinkSize = (from p in BUS.BUSDrink_Size.Instance.GetAllDrinkSize() where p.SizeID.Equals(size.id) && p.DrinksID.Equals(drink.id) select p).FirstOrDefault();

        //    AddNewProduct addNewProduct = new AddNewProduct(drink, size, drinkSize);
        //    addNewProduct.ShowDialog();

        //    anyChanged = true;

        //    if (addNewProduct.getAnyChanged())
        //    {
        //        ucProduct.deleteMiniItem(this);
        //        ucProduct.Show();
        //    }
        //}

        public bool getAnyChanged()
        {
            return anyChanged;
        }

        public void setAnyChanged(bool anyChanged)
        {
            this.anyChanged = anyChanged;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var drink = BUS.BUSDrink.Instance.GetDrinkById(int.Parse(labelID.Text.ToString()));
            var size = (from p in BUS.BUSSize.Instance.GetAllSize() where p.SizeName.Equals(textBox1.Text.ToString()) select p).FirstOrDefault();
            DTO.DRINKS_SIZE drinkSize = new DTO.DRINKS_SIZE();
            foreach (var p in BUS.BUSDrink_Size.Instance.GetAllDrinkSize())
            {
                if (p.SizeID == size.id && p.DrinksID == drink.id)
                {
                    drinkSize = p;
                }
            }    

            AddNewProduct addNewProduct = new AddNewProduct(drink, size, drinkSize);
            addNewProduct.ShowDialog();

            anyChanged = true;

            if (addNewProduct.anyDeleted())
            {
                ucProduct.deleteMiniItem(this);
                ucProduct.Show();
            }
            if (addNewProduct.anyUpdated())
            {
                ucProduct.updateMiniItem(this);
                ucProduct.Show();
            }    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ucBill != null)
            {
                var drink = BUS.BUSDrink.Instance.GetDrinkById(int.Parse(labelID.Text.ToString()));
                UCMiniProductChoosen ucMiniProductChoosen = new UCMiniProductChoosen(ucBill, drink.Image, lbName.Text, lbPrice.Text);
                ucBill.addMiniItemProduct(ucMiniProductChoosen);
                ucBill.Show();
            }    
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
