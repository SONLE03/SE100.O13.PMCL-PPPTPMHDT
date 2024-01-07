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
    public partial class EditProduct : Form
    {
        public string filePath { get; set; }
        private DRINK drink;
        public EditProduct(int id)
        {
            InitializeComponent();
            drink = BUSDrink.Instance.GetDrinkById(id);
            LoadData(drink);
        }
        private void GetAllCategory()
        {
            combobox_category.DataSource = null;
            List<CATEGORY> categories = BUSCategory.Instance.GetAllCategory();
            combobox_category.DataSource = categories;
            combobox_category.DisplayMember = "CategoryName";
            combobox_category.ValueMember = "id";
        }
        private void GetAllSize()
        {
            combobox_size.DataSource = null;
            List<C_SIZE> sizes = BUSSize.Instance.GetAllSize();
            combobox_size.DataSource = sizes;
            combobox_size.DisplayMember = "SizeName";
            combobox_size.ValueMember = "id";
        }
        private void LoadData(DRINK drink)
        {
            try
            {
                GetAllCategory();
                GetAllSize();
                txtProductname.Text = drink.DrinksName;
                txtDescibe.Text = drink.Description;
                cbStatus.Text = drink.Status;
                combobox_category.Text = drink.CATEGORY.CategoryName;
                foreach (var drink_size in drink.DRINKS_SIZE)
                {
                    SizeGrid.Rows.Add(drink_size.C_SIZE.id, drink_size.C_SIZE.SizeName, drink_size.OriginalPrice);
                }
                drinkPicture.Image = Image.FromFile(drink.Image);
                filePath = drink.Image.ToString();
            }
            catch
            {
                string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                string imagePathError = Path.Combine(resourcesFolder, "NotFoundImage.png");
                drinkPicture.Image = new System.Drawing.Bitmap(imagePathError);
                BUSDrink.Instance.UpdateImageErrorNotFound(drink.id, imagePathError);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to modify?", "Confirm modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string drinkName = txtProductname.Text;
                    int idCategory = Convert.ToInt32(combobox_category.SelectedValue);
                    string category = combobox_category.Text;
                    string description = txtDescibe.Text;
                    if (String.IsNullOrEmpty(drinkName) || SizeGrid.Rows.Count == 0 || String.IsNullOrEmpty(category) || String.IsNullOrEmpty(filePath) || String.IsNullOrEmpty(cbStatus.Text))
                    {
                        MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!BUSDrink.Instance.checkCategoryStatus(idCategory, cbStatus.Text))
                    {
                        MessageBox.Show("Add failure drink. Category is blocked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    updateDrinkt(drink.id, drinkName, idCategory, description);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failure Product", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateDrinkt(int drinkId, string drinkName, int idCategory, string description)
        {
            try
            {
                List<DRINKS_SIZE> dRINKS_SIZEs = new List<DRINKS_SIZE>();
                foreach (DataGridViewRow rows in SizeGrid.Rows)
                {
                    DRINKS_SIZE drink_size = new DRINKS_SIZE
                    {
                        SizeID = Convert.ToInt32(rows.Cells[0].Value),
                        DrinksID = drinkId,
                        OriginalPrice = Convert.ToDouble(rows.Cells[2].Value)
                    };
                    dRINKS_SIZEs.Add(drink_size);
                }
                bool isSuccess = BUSDrink.Instance.UpdDrink(drinkId, drinkName, idCategory, description, filePath, dRINKS_SIZEs, cbStatus.Text);
                if (isSuccess)
                {
                    MessageBox.Show("Modify Product Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void btn_AddSize_Click(object sender, EventArgs e)
        {
            AddSize addSize = new AddSize();
            addSize.ShowDialog();
            GetAllSize();
        }

        private void btnAddDrinkSize_Click(object sender, EventArgs e)
        {
            try
            {
                bool existenceCheck = false;
                if (String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(combobox_size.Text))
                {
                    MessageBox.Show("Lack of information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.Parse(txtPrice.Text) <= 0)
                {
                    MessageBox.Show("Price must be greater than zero", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = Convert.ToInt32(combobox_size.SelectedValue);
                string sizeName = combobox_size.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                foreach (DataGridViewRow row in SizeGrid.Rows)
                {
                    if (id == Convert.ToInt32(row.Cells[0].Value))
                    {
                        existenceCheck = true;
                        MessageBox.Show("Drink sizes already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (!existenceCheck)
                {
                    SizeGrid.Rows.Add(id, sizeName, price);
                }
            }
            catch
            {
                  
            }          
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void SizeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idx = e.RowIndex;
                if (idx < 0) return;
                if (e.ColumnIndex == SizeGrid.Columns["Delete"].Index)
                {
                    SizeGrid.Rows.RemoveAt(idx);
                }
            }
            catch
            {

            } 
        }

        private void drinkPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                if (!String.IsNullOrEmpty(filePath))
                {
                    drinkPicture.Image = new Bitmap(filePath);
                }
                else
                {
                    MessageBox.Show("Error: maybe it can't load this type of image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
