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
using System.Windows.Media.Imaging;

namespace GUI
{
    public partial class AddNewProduct : Form
    {
        public string filePath { get; set; }
        private List<string> categories = new List<string>();
        private List<string> sizes = new List<string>();
        private bool isDeleted = false;
        private bool isUpdated = false;
        private bool isAdded = false;
        private DRINK drink = new DRINK();
        private DRINKS_SIZE drinkSize = new DRINKS_SIZE();
        private C_SIZE size = new C_SIZE();
        private bool canUpdate = false;
        private bool isChangedImage = false;
        private static int index = 1;
        private int i;

        public AddNewProduct()
        {
            InitializeComponent();

            BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });
            BUS.BUSSize.Instance.GetAllSize().ToList().ForEach(p =>
            {
                combobox_size.Items.Add(p.SizeName);
            });

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btn_Add.Visible = true;
            isChangedImage = false;
            canUpdate = false;
            i = 1;
        }

        public AddNewProduct(DRINK drink, C_SIZE size, DRINKS_SIZE drinkSize)
        {
            InitializeComponent();

            this.drink = drink;
            this.drinkSize = drinkSize;
            this.size = size;

            BUS.BUSCategory.Instance.GetAllCategory().ToList().ForEach(p =>
            {
                combobox_category.Items.Add(p.CategoryName);
            });
            BUS.BUSSize.Instance.GetAllSize().ToList().ForEach(p =>
            {
                combobox_size.Items.Add(p.SizeName);
            });

            combobox_category.SelectedItem = BUS.BUSCategory.Instance.GetCategoryById(drink.CategoryID).CategoryName;
            combobox_size.SelectedItem = size.SizeName;
            txtProductname.Text = drink.DrinksName;
            txtDescibe.Text = drink.Description;
            txtPrice.Text = drinkSize.OriginalPrice.ToString();
            picture_product.Image = new System.Drawing.Bitmap(drink.Image);

            btn_Add.Visible = false;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            canUpdate = true;
            isChangedImage = false;
            isDeleted = false;
            isUpdated = false;
            isAdded = false;

            foreach(var p in BUS.BUSDrink_Size.Instance.GetAllDrinkSize())
            {
                if (p.DRINK.id == drink.id)
                {
                    guna2DataGridView1.Rows.Add(p.C_SIZE.SizeName, p.OriginalPrice);
                }    
            }
            i = 2;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                if (!String.IsNullOrEmpty(filePath))
                {
                    picture_product.Image = new Bitmap(filePath);
                    if (canUpdate == true)
                    {
                        isChangedImage = true;
                    }    
                }
                else
                {
                    MessageBox.Show("Error: maybe it can't load this type of image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }   
        }



        private void combobox_category_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        public bool anyDeleted()
        {
            return isDeleted;
        }

        public bool anyUpdated()
        {
            return isUpdated;
        }

        public bool anyAdded()
        {
            return isAdded;
        }

        private void btn_AddSize_Click(object sender, EventArgs e)
        {
            AddSize addSize = new AddSize();
            addSize.ShowDialog();
            string newSize = addSize.getSizeName();
            if (!String.IsNullOrEmpty(newSize))
            {
                //size.Add(newSize);
                combobox_size.Items.Add(newSize);
            }    
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filePath))
            {
                string fileName = Path.GetFileName(filePath);
                string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                string destinationPath = Path.Combine(resourcesFolder, index + fileName);

                File.Copy(filePath, destinationPath, true);

                if (!String.IsNullOrEmpty(txtPrice.Text.ToString()) && combobox_category.SelectedItem != null && combobox_size.SelectedItem != null)
                {
                    CATEGORY category = (from p in BUS.BUSCategory.Instance.GetAllCategory()
                                         where p.CategoryName.Equals(combobox_category.SelectedItem.ToString())
                                         select p).FirstOrDefault();

                    DTO.C_SIZE size = (from p in BUS.BUSSize.Instance.GetAllSize()
                                       where p.SizeName.Equals(combobox_size.SelectedItem.ToString())
                                       select p).FirstOrDefault();


                    var drink = BUS.BUSDrink.Instance.AddDrink(txtProductname.Text.ToString(), category, "none", txtDescibe.Text.ToString(), destinationPath, null, null);

                    if (drink == null)
                    {
                        MessageBox.Show("Added failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string nameValue = row.Cells["Size_name"].Value.ToString();
                                string price = row.Cells["Price"].Value.ToString();
                                var sz = (from p in BUS.BUSSize.Instance.GetAllSize() where p.SizeName.Equals(nameValue) select p).FirstOrDefault();

                                if (BUS.BUSDrink_Size.Instance.AddDrink_Size(drink, sz, double.Parse(price)))
                                {
                                    MessageBox.Show("Added successful", "Add new size for product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    index++;
                                    isAdded = true;
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Can't found this product in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose category, choose size and edit price for this product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("Choose image for drink before adding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to delete this product ?", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (BUS.BUSDrink_Size.Instance.delDrinkSize(drinkSize, drink, size))
                {
                    if (BUS.BUSDrink.Instance.DelDrink(drink.id))
                    {
                        deleteFile(drink.Image);
                        MessageBox.Show("Deleted successfully", "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isDeleted = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Deleted failed", "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Deleted failed", "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void copyFile(string source, string destination, bool mode)
        {
            File.Copy(source, destination, mode);
        }

        private static void deleteFile(string path)
        {
            try
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(path);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var newSize = (from p in BUS.BUSSize.Instance.GetAllSize() where p.SizeName.Equals(combobox_size.SelectedItem.ToString()) select p).FirstOrDefault();
            if (combobox_category.SelectedItem.ToString().Equals(BUS.BUSCategory.Instance.GetCategoryById(drink.CategoryID).CategoryName))
            {
                if (canUpdate == true && isChangedImage == true)
                {
                    string fileName = Path.GetFileName(filePath);
                    string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                    resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                    string destinationPath = Path.Combine(resourcesFolder, BUS.BUSDrink.Instance.GetAllDrink().Count + fileName);

                    copyFile(filePath, destinationPath, true);

                    string lastPathofImage = drink.Image;

                    if (BUS.BUSDrink.Instance.UpdDrink(drink.id, txtProductname.Text, BUS.BUSCategory.Instance.GetCategoryById(drink.CategoryID), "none", txtDescibe.Text, destinationPath, null, null, "active"))
                    {
                        MessageBox.Show("Update Successfully", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deleteFile(lastPathofImage);
                        if (BUS.BUSDrink_Size.Instance.UpdDrinkSize(drink.id, newSize.id, double.Parse(txtPrice.Text.ToString())))
                        {
                            index++;
                            isUpdated = true;
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update Failed", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //if (BUS.BUSDrink.Instance.UpdDrink(drink.id, txtProductname.Text, BUS.BUSCategory.Instance.GetCategoryById(drink.CategoryID), "none", txtDescibe.Text, drink.Image, null, null, true))
                    //{
                    //    MessageBox.Show("Update Successfully", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    if (BUS.BUSDrink_Size.Instance.UpdDrinkSize(drink.id, newSize.id, double.Parse(txtPrice.Text.ToString())))
                    //    {
                    //        index++;
                    //        isUpdated = true;
                    //        this.Hide();
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Update Failed", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
            else
            {
                //var category = (from p in BUS.BUSCategory.Instance.GetAllCategory() where p.CategoryName.Equals(combobox_category.SelectedItem.ToString()) select p).FirstOrDefault();
                //if (category != null)
                //{
                //    if (canUpdate == true && isChangedImage == true)
                //    {
                //        string fileName = Path.GetFileName(filePath);
                //        string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                //        resourcesFolder = resourcesFolder.Replace("\\bin\\Debug", "");
                //        string destinationPath = Path.Combine(resourcesFolder, BUS.BUSDrink.Instance.GetAllDrink().Count + fileName);

                //        File.Copy(filePath, destinationPath, true);

                //        string lastPathofImage = drink.Image;

                //        if (BUS.BUSDrink.Instance.UpdDrink(drink.id, txtProductname.Text, category, "none", txtDescibe.Text, destinationPath, null, null, true))
                //        {
                //            MessageBox.Show("Update Successfully", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            File.Delete(lastPathofImage);

                //            if (BUS.BUSDrink_Size.Instance.UpdDrinkSize(drink.id, newSize.id, double.Parse(txtPrice.Text.ToString())))
                //            {
                //                index++;
                //                isUpdated = true;
                //                this.Hide();
                //            }
                //        }
                //        else
                //        {
                //            MessageBox.Show("Update Failed", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //    else
                //    {
                //        if (BUS.BUSDrink.Instance.UpdDrink(drink.id, txtProductname.Text, category, "none", txtDescibe.Text, drink.Image, null, null, true))
                //        {
                //            MessageBox.Show("Update Successfully", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            if (BUS.BUSDrink_Size.Instance.UpdDrinkSize(drink.id, newSize.id, double.Parse(txtPrice.Text.ToString())))
                //            {
                //                index++;
                //                isUpdated = true;
                //                this.Hide();
                //            }
                //        }
                //        else
                //        {
                //            MessageBox.Show("Update Failed", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Can't found category", "Update product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }    
        }

        private void btnAddDrinkSize_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(combobox_size.SelectedItem, txtPrice.Text);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == guna2DataGridView1.Columns["Delete"].Index)
            {
                if (i == 1)
                {
                    guna2DataGridView1.Rows.Remove(guna2DataGridView1.Rows[e.RowIndex]);
                }
                else
                {
                    string SizeName = guna2DataGridView1.Rows[e.RowIndex].Cells["Size_name"].Value.ToString();
                    var size = (from p in BUS.BUSSize.Instance.GetAllSize() where p.SizeName.Equals(SizeName) select p).FirstOrDefault();
                    var drinkSize = (from p in BUS.BUSDrink_Size.Instance.GetAllDrinkSize() where p.DrinksID == drink.id && p.C_SIZE.SizeName.Equals(SizeName) select p).FirstOrDefault();
                    if (BUS.BUSDrink_Size.Instance.delDrinkSize(drinkSize, drink, size))
                    {
                        DialogResult dialog = MessageBox.Show("are you sure ?", "Info Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            guna2DataGridView1.Rows.Remove(guna2DataGridView1.Rows[e.RowIndex]);
                        }
                    }    
                }    
            }
            else
            {
                //MessageBox.Show("Please double click at rows to update or delete", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

