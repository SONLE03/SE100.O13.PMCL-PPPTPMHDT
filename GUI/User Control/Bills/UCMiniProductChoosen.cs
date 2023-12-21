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

        public UCMiniProductChoosen(UCBills_TabOrder ucBill, string image, string productName, string price)
        {
            InitializeComponent();
            guna2CirclePictureBox1.Image = new System.Drawing.Bitmap(image);
            lbName.Text = productName;
            lbPrice.Text = price;
            this.ucBill = ucBill;
            quantity = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ucBill.deleteMiniItemProduct(this);
            ucBill.Show();
        }

        public double getPrice()
        {
            return double.Parse(lbPrice.Text.Replace("VND", "")) * ((int)guna2NumericUpDown1.Value);
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
                ucBill.deleteQuantity(double.Parse(lbPrice.Text.Replace("VND", "")));
            }    
            else
            {
                ucBill.addQuantity(double.Parse(lbPrice.Text.Replace("VND", "")));
            }
            quantity = ((int)guna2NumericUpDown1.Value);
        }
    }
}
