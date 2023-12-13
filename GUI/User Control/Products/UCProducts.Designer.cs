namespace GUI
{
    partial class UCProducts
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
            this.btnProductList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCategory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PanelDisplayTabs = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.Transparent;
            this.btnProductList.BorderRadius = 15;
            this.btnProductList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductList.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnProductList.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnProductList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductList.ForeColor = System.Drawing.Color.White;
            this.btnProductList.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnProductList.Location = new System.Drawing.Point(281, 27);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(135, 37);
            this.btnProductList.TabIndex = 33;
            this.btnProductList.Text = "Product list";
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.BorderRadius = 15;
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCategory.Location = new System.Drawing.Point(698, 27);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(135, 37);
            this.btnCategory.TabIndex = 34;
            this.btnCategory.Text = "Category";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.raucu;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(0, 0);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // PanelDisplayTabs
            // 
            this.PanelDisplayTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDisplayTabs.BackColor = System.Drawing.Color.Transparent;
            this.PanelDisplayTabs.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelDisplayTabs.BorderRadius = 40;
            this.PanelDisplayTabs.BorderThickness = 1;
            this.PanelDisplayTabs.Location = new System.Drawing.Point(52, 91);
            this.PanelDisplayTabs.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDisplayTabs.Name = "PanelDisplayTabs";
            this.PanelDisplayTabs.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.PanelDisplayTabs.Size = new System.Drawing.Size(1017, 665);
            this.PanelDisplayTabs.TabIndex = 23;
            // 
            // UCProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.PanelDisplayTabs);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCProducts";
            this.Size = new System.Drawing.Size(1124, 800);
            this.Load += new System.EventHandler(this.UCProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2GradientButton btnProductList;
        private Guna.UI2.WinForms.Guna2GradientButton btnCategory;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelDisplayTabs;
        private UCProducts_TabProducts uCProducts_TabProducts;
        private UCProducts_TabCategory uCProducts_TabCategory; 

    }
}
