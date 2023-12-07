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
        private UCBill ucBill;

        public UCMiniProductChoosen(UCBill ucBill, string image, string productName, string price)
        {
            InitializeComponent();
            guna2CirclePictureBox1.Image = new System.Drawing.Bitmap(image);
            lbName.Text = productName;
            lbPrice.Text = price;
            this.ucBill = ucBill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ucBill.deleteMiniItemProduct(this);
            ucBill.Show();
        }
    }
}
