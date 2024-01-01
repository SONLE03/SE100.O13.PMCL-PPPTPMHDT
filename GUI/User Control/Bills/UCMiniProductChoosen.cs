using BUS;
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
    public partial class UCMiniProductChoosen : UserControl
    {
        private UCBills_TabOrder ucBill;
        private int quantity;
        private double salePrice = 0;

        public UCMiniProductChoosen(UCBills_TabOrder ucBill, string image, string productName, string originalPrice, int idDrink, int idSize)
        {
            InitializeComponent();
            drinkImage.Image = new System.Drawing.Bitmap(image);
            lbName.Text = productName;
            lbPrice.Text = originalPrice;
            this.ucBill = ucBill;
            quantity = 1;
            lbSize.Text = idSize.ToString(); 
            lbDrinkID.Text = idDrink.ToString();
            lbSizeName.Text = BUSSize.Instance.GetSizeById(idSize).SizeName;

            foreach (var p in BUS.BUSEvent.Instance.GetAllEvent())
            {
                if (p.Status == "Active" && p.StartDate <= DateTime.Now && DateTime.Now <= p.DueDate)
                {
                    foreach (var d in p.DRINKS)
                    {
                        if (d.id == idDrink)
                        {
                            if (p.Unit.Contains("VND"))
                            {
                                if (salePrice < p.Discount)
                                {
                                    salePrice = (double)p.Discount;
                                }
                            }
                            else if (p.Unit.Contains("%"))
                            {
                                double discount = double.Parse(lbPrice.Text.Replace(" VND", "")) * ((100 - (double)p.Discount) / 100);
                                if (salePrice < discount)
                                {
                                    salePrice = discount;
                                }
                            }   
                            else
                            {

                            }    
                        }    
                    }    
                }    
            }

            if (salePrice > double.Parse(lbPrice.Text.Replace(" VND", "")))
            {
                lbBasePrice.Text = "Bigger than original price".ToString();
                salePrice = 0;
            }
            else
            {
                lbBasePrice.Text = lbPrice.Text;
                lbPrice.Text = salePrice.ToString() + " VND";
            }

        }

        public int getDrinkID()
        {
            return Convert.ToInt32(lbDrinkID.Text);
        }
        public double getPrice()
        {
            return double.Parse(lbPrice.Text.Replace(" VND", "")) * ((int)drinkQuantity.Value); /*- salePrice * ((int)drinkQuantity.Value);*/
        }
        public double getUnitPrice()
        {
            return double.Parse(lbPrice.Text.Replace(" VND", ""));
        }

        public int getQuantity()
        {
            return ((int)drinkQuantity.Value);
        }

        public int getSizeID()
        {
            return Convert.ToInt32(lbSize.Text);
        }
        private void drinkQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (quantity > ((int)drinkQuantity.Value))
            {
                ucBill.deleteQuantity(double.Parse(lbPrice.Text.Replace(" VND", "")), this);
            }
            else
            {
                ucBill.addQuantity(double.Parse(lbPrice.Text.Replace(" VND", "")), this);
            }
            quantity = ((int)drinkQuantity.Value);
        }

        private void deleteDrink_Click(object sender, EventArgs e)
        {
            ucBill.deleteMiniItemProduct(this);
            ucBill.Show();
        }
    }
}
