namespace GUI
{
    partial class UCMiniProductChoosen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbSizeName = new System.Windows.Forms.Label();
            this.lbDrinkID = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbBasePrice = new System.Windows.Forms.Label();
            this.deleteDrink = new System.Windows.Forms.PictureBox();
            this.drinkQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.drinkImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.BorderRadius = 25;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.lbSizeName);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbDrinkID);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbSize);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbBasePrice);
            this.guna2CustomGradientPanel1.Controls.Add(this.deleteDrink);
            this.guna2CustomGradientPanel1.Controls.Add(this.drinkQuantity);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbPrice);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbName);
            this.guna2CustomGradientPanel1.Controls.Add(this.drinkImage);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(16, 7);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(528, 100);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // lbSizeName
            // 
            this.lbSizeName.AllowDrop = true;
            this.lbSizeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSizeName.AutoSize = true;
            this.lbSizeName.BackColor = System.Drawing.Color.White;
            this.lbSizeName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbSizeName.ForeColor = System.Drawing.Color.Gray;
            this.lbSizeName.Location = new System.Drawing.Point(280, 48);
            this.lbSizeName.Name = "lbSizeName";
            this.lbSizeName.Size = new System.Drawing.Size(89, 23);
            this.lbSizeName.TabIndex = 9;
            this.lbSizeName.Text = "SizeName";
            // 
            // lbDrinkID
            // 
            this.lbDrinkID.AllowDrop = true;
            this.lbDrinkID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDrinkID.AutoSize = true;
            this.lbDrinkID.BackColor = System.Drawing.Color.White;
            this.lbDrinkID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDrinkID.ForeColor = System.Drawing.Color.Gray;
            this.lbDrinkID.Location = new System.Drawing.Point(343, 7);
            this.lbDrinkID.Name = "lbDrinkID";
            this.lbDrinkID.Size = new System.Drawing.Size(71, 23);
            this.lbDrinkID.TabIndex = 8;
            this.lbDrinkID.Text = "drinkID";
            this.lbDrinkID.Visible = false;
            // 
            // lbSize
            // 
            this.lbSize.AllowDrop = true;
            this.lbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.White;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbSize.ForeColor = System.Drawing.Color.Gray;
            this.lbSize.Location = new System.Drawing.Point(280, 7);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(57, 23);
            this.lbSize.TabIndex = 7;
            this.lbSize.Text = "sizeID";
            this.lbSize.Visible = false;
            // 
            // lbBasePrice
            // 
            this.lbBasePrice.AllowDrop = true;
            this.lbBasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBasePrice.AutoSize = true;
            this.lbBasePrice.BackColor = System.Drawing.Color.White;
            this.lbBasePrice.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbBasePrice.ForeColor = System.Drawing.Color.IndianRed;
            this.lbBasePrice.Location = new System.Drawing.Point(152, 71);
            this.lbBasePrice.Name = "lbBasePrice";
            this.lbBasePrice.Size = new System.Drawing.Size(90, 23);
            this.lbBasePrice.TabIndex = 6;
            this.lbBasePrice.Text = "$ 000.000";
            // 
            // deleteDrink
            // 
            this.deleteDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteDrink.BackColor = System.Drawing.Color.Transparent;
            this.deleteDrink.Image = global::GUI.Properties.Resources.icons8_clear_symbol_100px_3;
            this.deleteDrink.Location = new System.Drawing.Point(467, -7);
            this.deleteDrink.Margin = new System.Windows.Forms.Padding(4);
            this.deleteDrink.Name = "deleteDrink";
            this.deleteDrink.Size = new System.Drawing.Size(40, 32);
            this.deleteDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteDrink.TabIndex = 5;
            this.deleteDrink.TabStop = false;
            this.deleteDrink.Click += new System.EventHandler(this.deleteDrink_Click);
            // 
            // drinkQuantity
            // 
            this.drinkQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drinkQuantity.BackColor = System.Drawing.Color.Transparent;
            this.drinkQuantity.BorderRadius = 10;
            this.drinkQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drinkQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.drinkQuantity.Location = new System.Drawing.Point(336, 42);
            this.drinkQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.drinkQuantity.Name = "drinkQuantity";
            this.drinkQuantity.Size = new System.Drawing.Size(167, 37);
            this.drinkQuantity.TabIndex = 4;
            this.drinkQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.drinkQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.drinkQuantity.ValueChanged += new System.EventHandler(this.drinkQuantity_ValueChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AllowDrop = true;
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.White;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbPrice.ForeColor = System.Drawing.Color.Gray;
            this.lbPrice.Location = new System.Drawing.Point(152, 48);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(90, 23);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "$ 000.000";
            // 
            // lbName
            // 
            this.lbName.AllowDrop = true;
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(152, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(122, 23);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Product name";
            // 
            // drinkImage
            // 
            this.drinkImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drinkImage.Image = global::GUI.Properties.Resources.milkco1;
            this.drinkImage.ImageRotate = 0F;
            this.drinkImage.Location = new System.Drawing.Point(21, 7);
            this.drinkImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drinkImage.Name = "drinkImage";
            this.drinkImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.drinkImage.Size = new System.Drawing.Size(93, 86);
            this.drinkImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drinkImage.TabIndex = 1;
            this.drinkImage.TabStop = false;
            // 
            // UCMiniProductChoosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCMiniProductChoosen";
            this.Size = new System.Drawing.Size(560, 114);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox drinkImage;
        private Guna.UI2.WinForms.Guna2NumericUpDown drinkQuantity;
        private System.Windows.Forms.PictureBox deleteDrink;
        private System.Windows.Forms.Label lbBasePrice;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbDrinkID;
        private System.Windows.Forms.Label lbSizeName;
    }
}
