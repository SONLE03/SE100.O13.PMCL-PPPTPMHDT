namespace GUI
{
    partial class UCProductMiniItem
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
            this.panelProduct = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.drinkPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic_edit = new System.Windows.Forms.PictureBox();
            this.pic_AddToCart = new System.Windows.Forms.PictureBox();
            this.panelProduct.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AddToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.BorderColor = System.Drawing.Color.DimGray;
            this.panelProduct.BorderRadius = 25;
            this.panelProduct.BorderThickness = 1;
            this.panelProduct.Controls.Add(this.guna2Panel2);
            this.panelProduct.Controls.Add(this.labelID);
            this.panelProduct.Controls.Add(this.label1);
            this.panelProduct.Controls.Add(this.lbPrice);
            this.panelProduct.Controls.Add(this.lbName);
            this.panelProduct.Controls.Add(this.drinkPicture);
            this.panelProduct.Controls.Add(this.pic_edit);
            this.panelProduct.Controls.Add(this.pic_AddToCart);
            this.panelProduct.Location = new System.Drawing.Point(12, 9);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(280, 239);
            this.panelProduct.TabIndex = 1;
            this.panelProduct.Click += new System.EventHandler(this.panelProduct_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(69, 178);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(140, 43);
            this.guna2Panel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 38);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(122, 8);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 25);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Size";
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbPrice.Location = new System.Drawing.Point(131, 110);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(81, 21);
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
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(131, 71);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Product name";
            // 
            // drinkPicture
            // 
            this.drinkPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drinkPicture.Image = global::GUI.Properties.Resources.milkco1;
            this.drinkPicture.ImageRotate = 0F;
            this.drinkPicture.Location = new System.Drawing.Point(15, 31);
            this.drinkPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drinkPicture.Name = "drinkPicture";
            this.drinkPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.drinkPicture.Size = new System.Drawing.Size(110, 110);
            this.drinkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drinkPicture.TabIndex = 1;
            this.drinkPicture.TabStop = false;
            // 
            // pic_edit
            // 
            this.pic_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_edit.Image = global::GUI.Properties.Resources.info;
            this.pic_edit.Location = new System.Drawing.Point(227, 12);
            this.pic_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_edit.Name = "pic_edit";
            this.pic_edit.Size = new System.Drawing.Size(40, 40);
            this.pic_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_edit.TabIndex = 7;
            this.pic_edit.TabStop = false;
            this.pic_edit.Click += new System.EventHandler(this.pic_edit_Click);
            // 
            // pic_AddToCart
            // 
            this.pic_AddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_AddToCart.Image = global::GUI.Properties.Resources.icons8_add_shopping_cart_100px;
            this.pic_AddToCart.Location = new System.Drawing.Point(225, 12);
            this.pic_AddToCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_AddToCart.Name = "pic_AddToCart";
            this.pic_AddToCart.Size = new System.Drawing.Size(40, 40);
            this.pic_AddToCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_AddToCart.TabIndex = 9;
            this.pic_AddToCart.TabStop = false;
            this.pic_AddToCart.Click += new System.EventHandler(this.pic_AddToCart_Click);
            // 
            // UCProductMiniItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCProductMiniItem";
            this.Size = new System.Drawing.Size(305, 258);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drinkPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AddToCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelProduct;
        private Guna.UI2.WinForms.Guna2CirclePictureBox drinkPicture;
        private System.Windows.Forms.PictureBox pic_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.PictureBox pic_AddToCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
