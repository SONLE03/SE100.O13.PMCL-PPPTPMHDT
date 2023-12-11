namespace GUI
{
    partial class UCProducts_TabProducts
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
            this.PanelProductlist = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.combobox_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmailCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.PanelProductlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelProductlist
            // 
            this.PanelProductlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelProductlist.BackColor = System.Drawing.Color.Transparent;
            this.PanelProductlist.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelProductlist.BorderRadius = 40;
            this.PanelProductlist.BorderThickness = 1;
            this.PanelProductlist.Controls.Add(this.btnSearch);
            this.PanelProductlist.Controls.Add(this.btnAddProduct);
            this.PanelProductlist.Controls.Add(this.label4);
            this.PanelProductlist.Controls.Add(this.combobox_category);
            this.PanelProductlist.Controls.Add(this.panel1);
            this.PanelProductlist.Controls.Add(this.txtEmailCode);
            this.PanelProductlist.Controls.Add(this.flowLayoutPanel);
            this.PanelProductlist.Location = new System.Drawing.Point(0, 2);
            this.PanelProductlist.Margin = new System.Windows.Forms.Padding(2);
            this.PanelProductlist.Name = "PanelProductlist";
            this.PanelProductlist.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.PanelProductlist.Size = new System.Drawing.Size(1017, 653);
            this.PanelProductlist.TabIndex = 24;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BorderRadius = 15;
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddProduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddProduct.Location = new System.Drawing.Point(855, 67);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(133, 41);
            this.btnAddProduct.TabIndex = 32;
            this.btnAddProduct.Text = "Add product";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(582, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Category";
            // 
            // combobox_category
            // 
            this.combobox_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_category.BackColor = System.Drawing.Color.Transparent;
            this.combobox_category.BorderColor = System.Drawing.Color.Black;
            this.combobox_category.BorderRadius = 10;
            this.combobox_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_category.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.combobox_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_category.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.combobox_category.ForeColor = System.Drawing.Color.White;
            this.combobox_category.ItemHeight = 30;
            this.combobox_category.Location = new System.Drawing.Point(765, 19);
            this.combobox_category.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_category.Name = "combobox_category";
            this.combobox_category.Size = new System.Drawing.Size(223, 36);
            this.combobox_category.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.panel1.Location = new System.Drawing.Point(572, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 36);
            this.panel1.TabIndex = 10;
            // 
            // txtEmailCode
            // 
            this.txtEmailCode.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailCode.BorderColor = System.Drawing.Color.Gray;
            this.txtEmailCode.BorderRadius = 10;
            this.txtEmailCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailCode.DefaultText = "";
            this.txtEmailCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailCode.Location = new System.Drawing.Point(16, 21);
            this.txtEmailCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmailCode.Name = "txtEmailCode";
            this.txtEmailCode.PasswordChar = '\0';
            this.txtEmailCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmailCode.PlaceholderText = "Search products";
            this.txtEmailCode.SelectedText = "";
            this.txtEmailCode.Size = new System.Drawing.Size(377, 36);
            this.txtEmailCode.TabIndex = 8;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Location = new System.Drawing.Point(28, 121);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(960, 514);
            this.flowLayoutPanel.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GUI.Properties.Resources.searches;
            this.btnSearch.Location = new System.Drawing.Point(353, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 49;
            this.btnSearch.TabStop = false;
            // 
            // UCProducts_TabProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelProductlist);
            this.Name = "UCProducts_TabProducts";
            this.Size = new System.Drawing.Size(1017, 655);
            this.PanelProductlist.ResumeLayout(false);
            this.PanelProductlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelProductlist;
        private System.Windows.Forms.PictureBox btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddProduct;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_category;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
