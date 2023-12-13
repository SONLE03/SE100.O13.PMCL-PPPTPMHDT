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
    public partial class AddNewEvent : Form
    {
        private int figure = 1;
        public AddNewEvent()
        {
            InitializeComponent();
            lbAreaID.Text = (BUS.BUSEvent.Instance.GetAllEvent().Count + 1).ToString();

            combobox_category.Items.Add("All");
            BUS.BUSCategory.Instance.GetAllCategory().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });

            combobox_category.Items.Add("All");
            BUS.BUSDrink.Instance.GetAllDrink().ForEach(p =>
            {
                comboboxProduct.Items.Add(p.DrinksName);
            });


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var drink = (from p in BUS.BUSDrink.Instance.GetAllDrink() where p.DrinksName.Equals(comboboxProduct.SelectedItem.ToString()) select p).FirstOrDefault();

            gridviewEventAppliedProduct.Rows.Add(drink.DrinksID, drink.DrinksName, drink.CATEGORY.CategoryName, "VND");
        }
    }
}
