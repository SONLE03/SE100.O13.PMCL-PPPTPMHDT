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
        private List<string> size = new List<string>();

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
                    picture_product.Image = new System.Drawing.Bitmap(filePath);
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

        private void btn_AddSize_Click(object sender, EventArgs e)
        {
            AddSize addSize = new AddSize();
            addSize.ShowDialog();
            string newSize = addSize.getSizeName();
            if (!String.IsNullOrEmpty(newSize))
            {
                size.Add(newSize);
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
                string destinationPath = Path.Combine(resourcesFolder, fileName);

                File.Copy(filePath, destinationPath, true);

                if (!String.IsNullOrEmpty(txtPrice.Text.ToString()) && combobox_category.SelectedItem != null && combobox_size.SelectedItem != null)
                {
                    CATEGORY category = (from p in BUS.BUSCategory.Instance.GetAllCategory()
                                         where p.CategoryName.Equals(combobox_category.SelectedItem.ToString())
                                         select p).FirstOrDefault();

                    DTO.C_SIZE size = (from p in BUS.BUSDrink_Size.Instance.GetAllSize()
                                       where p.SizeName.Equals(combobox_size.SelectedItem.ToString())
                                       select p).FirstOrDefault();


                    var id = BUS.BUSDrink.Instance.AddDrink(txtProductname.Text.ToString(), category, "none", txtDescibe.Text.ToString(), destinationPath, null, null);

                    if (id == -1)
                    {
                        MessageBox.Show("Added failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (BUS.BUSDrink_Size.Instance.AddDrink_Size(id, size.id, double.Parse(txtPrice.Text)))
                        {
                            MessageBox.Show("Added successful", "Add new size for product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult result = MessageBox.Show("Do you want to add for other size ?", "Add other size", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Added failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

