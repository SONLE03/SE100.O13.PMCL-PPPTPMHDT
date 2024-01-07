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
using static System.Windows.Forms.LinkLabel;

namespace GUI
{
    public partial class UCProductsMiniForBills : UserControl
    {
        private UCBills_TabOrder ucBill;
        public static List<(int,int)> Drink_Size = new List<(int,int)> ();
        public UCProductsMiniForBills(UCBills_TabOrder ucBill)
        {
            InitializeComponent();
            this.ucBill = ucBill;
        }
        public void updatePriceAndSize(string price, int sizeID)
        {
            lbSizeID.Text = sizeID.ToString();
            lbPrice.Text = $"{price} VND";
            lbSizeName.Text = $"({BUSSize.Instance.GetSizeById(sizeID).SizeName})";
        }
        public void loadSize(DRINK drink, List<int> sizes)
        {
            foreach (var p in sizes)
            {
                UCMiniSizeForBill uCMiniSize = new UCMiniSizeForBill(BUS.BUSSize.Instance.GetSizeById(p), this, drink.id);
                flowLayoutSize.Controls.Add(uCMiniSize);
                //uCMiniSize.Click += new EventHandler(UCMiniSizeForBill_Click);
            }
        }
        public void loadData(DRINK drink, List<int> sizes)
        {
            try
            {
                lbName.Text = drink.DrinksName;
                lbPrice.Text = "0 VND";
                labelID.Text = drink.id.ToString();
                drinkPicture.Image = new System.Drawing.Bitmap(drink.Image);
                loadSize(drink, sizes);
                
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
                if(ucBill.listDrinkSize(int.Parse(labelID.Text), int.Parse(lbSizeID.Text))){
                    return;
                }
                var drink = BUS.BUSDrink.Instance.GetDrinkById(int.Parse(labelID.Text.ToString()));
                UCMiniProductChoosen ucMiniProductChoosen = new UCMiniProductChoosen(ucBill, drink.Image, lbName.Text, lbPrice.Text, int.Parse(labelID.Text), int.Parse(lbSizeID.Text));
                ucBill.addMiniItemProduct(ucMiniProductChoosen);
                ucBill.Show();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void UCMiniSizeForBill_Click(object sender, EventArgs e)
        //{
        //    UserControl clickedControl = sender as UserControl;
        //    if (clickedControl != null)
        //    {
        //        // Trở về màu nền trắng cho tất cả UserControl
        //        foreach (Control control in flowLayoutSize.Controls)
        //        {
        //            if (control is UserControl)
        //            {
        //                control.BackColor = Color.White;
        //            }
        //        }

        //        // Chuyển màu đỏ cho UserControl được click
        //        clickedControl.BackColor = Color.WhiteSmoke;
        //    }

        //}
    }
}
