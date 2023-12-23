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

        public UCMiniProductChoosen(UCBills_TabOrder ucBill, string image, string productName, string price, int idDrink)
        {
            InitializeComponent();
            guna2CirclePictureBox1.Image = new System.Drawing.Bitmap(image);
            lbName.Text = productName;
            lbPrice.Text = price;
            this.ucBill = ucBill;
            quantity = 1;
            foreach (var p in BUS.BUSEvent.Instance.GetAllEvent())
            {
                if (p.StartDate <= DateTime.Now && DateTime.Now <= p.DueDate)
                {
                    foreach (var d in p.DRINKS)
                    {
                        if (d.id == idDrink)
                        {
                            if (salePrice < p.Discount)
                            {
                                salePrice = (double)p.Discount;
                            }    
                        }    
                    }    
                }    
            }
            lbBasePrice.Text = salePrice.ToString();


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ucBill.deleteMiniItemProduct(this);
            ucBill.Show();
        }

        public double getPrice()
        {
            return double.Parse(lbPrice.Text.Replace("VND", "")) * ((int)guna2NumericUpDown1.Value) - salePrice * ((int)guna2NumericUpDown1.Value);
        }

        public int getQuantity()
        {
            return ((int)guna2NumericUpDown1.Value);
        }

        public string getProductName()
        {
            return lbName.Text;
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (quantity > ((int)guna2NumericUpDown1.Value))
            {
                ucBill.deleteQuantity(double.Parse(lbPrice.Text.Replace("VND", "")), salePrice, getProductName());
            }    
            else
            {
                ucBill.addQuantity(double.Parse(lbPrice.Text.Replace("VND", "")), salePrice, this);
            }
            quantity = ((int)guna2NumericUpDown1.Value);
        }
    }
}
