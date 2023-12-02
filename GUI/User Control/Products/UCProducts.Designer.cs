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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelProductlist = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProductMiniItem1 = new GUI.UCProductMiniItem();
            this.ucProductMiniItem2 = new GUI.UCProductMiniItem();
            this.ucProductMiniItem3 = new GUI.UCProductMiniItem();
            this.ucProductMiniItem4 = new GUI.UCProductMiniItem();
            this.ucProductMiniItem5 = new GUI.UCProductMiniItem();
            this.ucProductMiniItem6 = new GUI.UCProductMiniItem();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.combobox_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmailCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnProductList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCategory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PanelCategory = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridviewTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Avatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelProductlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PanelCategory.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelProductlist
            // 
            this.PanelProductlist.BackColor = System.Drawing.Color.Transparent;
            this.PanelProductlist.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelProductlist.BorderRadius = 40;
            this.PanelProductlist.BorderThickness = 1;
            this.PanelProductlist.Controls.Add(this.pictureBox1);
            this.PanelProductlist.Controls.Add(this.flowLayoutPanel);
            this.PanelProductlist.Controls.Add(this.btnAddProduct);
            this.PanelProductlist.Controls.Add(this.label4);
            this.PanelProductlist.Controls.Add(this.combobox_category);
            this.PanelProductlist.Controls.Add(this.panel1);
            this.PanelProductlist.Controls.Add(this.guna2Button1);
            this.PanelProductlist.Controls.Add(this.txtEmailCode);
            this.PanelProductlist.Location = new System.Drawing.Point(52, 91);
            this.PanelProductlist.Margin = new System.Windows.Forms.Padding(2);
            this.PanelProductlist.Name = "PanelProductlist";
            this.PanelProductlist.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.PanelProductlist.Size = new System.Drawing.Size(1017, 665);
            this.PanelProductlist.TabIndex = 23;
            this.PanelProductlist.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI.Properties.Resources.searches;
            this.pictureBox1.Location = new System.Drawing.Point(380, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Controls.Add(this.ucProductMiniItem1);
            this.flowLayoutPanel.Controls.Add(this.ucProductMiniItem2);
            this.flowLayoutPanel.Controls.Add(this.ucProductMiniItem3);
            this.flowLayoutPanel.Controls.Add(this.ucProductMiniItem4);
            this.flowLayoutPanel.Controls.Add(this.ucProductMiniItem5);
            this.flowLayoutPanel.Controls.Add(this.ucProductMiniItem6);
            this.flowLayoutPanel.Location = new System.Drawing.Point(40, 133);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(948, 514);
            this.flowLayoutPanel.TabIndex = 33;
            // 
            // ucProductMiniItem1
            // 
            this.ucProductMiniItem1.BackColor = System.Drawing.Color.Transparent;
            this.ucProductMiniItem1.Location = new System.Drawing.Point(2, 2);
            this.ucProductMiniItem1.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductMiniItem1.Name = "ucProductMiniItem1";
            this.ucProductMiniItem1.Size = new System.Drawing.Size(305, 258);
            this.ucProductMiniItem1.TabIndex = 0;
            // 
            // ucProductMiniItem2
            // 
            this.ucProductMiniItem2.BackColor = System.Drawing.Color.Transparent;
            this.ucProductMiniItem2.Location = new System.Drawing.Point(311, 2);
            this.ucProductMiniItem2.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductMiniItem2.Name = "ucProductMiniItem2";
            this.ucProductMiniItem2.Size = new System.Drawing.Size(305, 258);
            this.ucProductMiniItem2.TabIndex = 1;
            // 
            // ucProductMiniItem3
            // 
            this.ucProductMiniItem3.BackColor = System.Drawing.Color.Transparent;
            this.ucProductMiniItem3.Location = new System.Drawing.Point(620, 2);
            this.ucProductMiniItem3.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductMiniItem3.Name = "ucProductMiniItem3";
            this.ucProductMiniItem3.Size = new System.Drawing.Size(305, 258);
            this.ucProductMiniItem3.TabIndex = 2;
            // 
            // ucProductMiniItem4
            // 
            this.ucProductMiniItem4.BackColor = System.Drawing.Color.Transparent;
            this.ucProductMiniItem4.Location = new System.Drawing.Point(2, 264);
            this.ucProductMiniItem4.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductMiniItem4.Name = "ucProductMiniItem4";
            this.ucProductMiniItem4.Size = new System.Drawing.Size(305, 258);
            this.ucProductMiniItem4.TabIndex = 3;
            // 
            // ucProductMiniItem5
            // 
            this.ucProductMiniItem5.BackColor = System.Drawing.Color.Transparent;
            this.ucProductMiniItem5.Location = new System.Drawing.Point(311, 264);
            this.ucProductMiniItem5.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductMiniItem5.Name = "ucProductMiniItem5";
            this.ucProductMiniItem5.Size = new System.Drawing.Size(305, 258);
            this.ucProductMiniItem5.TabIndex = 4;
            // 
            // ucProductMiniItem6
            // 
            this.ucProductMiniItem6.BackColor = System.Drawing.Color.Transparent;
            this.ucProductMiniItem6.Location = new System.Drawing.Point(620, 264);
            this.ucProductMiniItem6.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductMiniItem6.Name = "ucProductMiniItem6";
            this.ucProductMiniItem6.Size = new System.Drawing.Size(305, 258);
            this.ucProductMiniItem6.TabIndex = 5;
            // 
            // btnAddProduct
            // 
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
            this.btnAddProduct.Location = new System.Drawing.Point(855, 69);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(133, 41);
            this.btnAddProduct.TabIndex = 32;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label4
            // 
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
            this.combobox_category.Location = new System.Drawing.Point(765, 21);
            this.combobox_category.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_category.Name = "combobox_category";
            this.combobox_category.Size = new System.Drawing.Size(223, 36);
            this.combobox_category.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.panel1.Location = new System.Drawing.Point(572, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 36);
            this.panel1.TabIndex = 10;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(44, 21);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(99, 36);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "All category";
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
            this.txtEmailCode.Location = new System.Drawing.Point(142, 21);
            this.txtEmailCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmailCode.Name = "txtEmailCode";
            this.txtEmailCode.PasswordChar = '\0';
            this.txtEmailCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmailCode.PlaceholderText = "Search products";
            this.txtEmailCode.SelectedText = "";
            this.txtEmailCode.Size = new System.Drawing.Size(279, 36);
            this.txtEmailCode.TabIndex = 8;
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
            // PanelCategory
            // 
            this.PanelCategory.BackColor = System.Drawing.Color.Transparent;
            this.PanelCategory.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelCategory.BorderRadius = 40;
            this.PanelCategory.BorderThickness = 1;
            this.PanelCategory.Controls.Add(this.guna2Panel1);
            this.PanelCategory.Controls.Add(this.pictureBox2);
            this.PanelCategory.Controls.Add(this.btnAddCategory);
            this.PanelCategory.Controls.Add(this.guna2Button2);
            this.PanelCategory.Controls.Add(this.guna2TextBox1);
            this.PanelCategory.Location = new System.Drawing.Point(51, 91);
            this.PanelCategory.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCategory.Name = "PanelCategory";
            this.PanelCategory.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.PanelCategory.Size = new System.Drawing.Size(1017, 665);
            this.PanelCategory.TabIndex = 35;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 35;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.gridviewTable);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(45, 128);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(924, 492);
            this.guna2Panel1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "These are list of all categories in our store up to now ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Category information";
            // 
            // gridviewTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridviewTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewTable.ColumnHeadersHeight = 40;
            this.gridviewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Avatar,
            this.Category_ID,
            this.Category_name,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewTable.Location = new System.Drawing.Point(2, 74);
            this.gridviewTable.Name = "gridviewTable";
            this.gridviewTable.RowHeadersVisible = false;
            this.gridviewTable.RowHeadersWidth = 50;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewTable.Size = new System.Drawing.Size(920, 389);
            this.gridviewTable.TabIndex = 40;
            this.gridviewTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewTable.ThemeStyle.HeaderStyle.Height = 40;
            this.gridviewTable.ThemeStyle.ReadOnly = false;
            this.gridviewTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewTable.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Avatar
            // 
            this.Avatar.FillWeight = 200F;
            this.Avatar.HeaderText = "Avatar";
            this.Avatar.Name = "Avatar";
            this.Avatar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Avatar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Category_ID
            // 
            this.Category_ID.FillWeight = 150F;
            this.Category_ID.HeaderText = "Category ID";
            this.Category_ID.Name = "Category_ID";
            // 
            // Category_name
            // 
            this.Category_name.FillWeight = 200F;
            this.Category_name.HeaderText = "Category name";
            this.Category_name.Name = "Category_name";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::GUI.Properties.Resources.searches;
            this.pictureBox2.Location = new System.Drawing.Point(380, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BorderRadius = 15;
            this.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddCategory.Location = new System.Drawing.Point(835, 26);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(133, 41);
            this.btnAddCategory.TabIndex = 32;
            this.btnAddCategory.Text = "Add category";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(44, 31);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(99, 36);
            this.guna2Button2.TabIndex = 9;
            this.guna2Button2.Text = "All category";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(142, 31);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Search categories";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(279, 36);
            this.guna2TextBox1.TabIndex = 8;
            // 
            // UCProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.PanelProductlist);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.PanelCategory);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCProducts";
            this.Size = new System.Drawing.Size(1124, 800);
            this.PanelProductlist.ResumeLayout(false);
            this.PanelProductlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PanelCategory.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelProductlist;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_category;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btnProductList;
        private Guna.UI2.WinForms.Guna2GradientButton btnCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private UCProductMiniItem ucProductMiniItem1;
        private UCProductMiniItem ucProductMiniItem2;
        private UCProductMiniItem ucProductMiniItem3;
        private UCProductMiniItem ucProductMiniItem4;
        private UCProductMiniItem ucProductMiniItem5;
        private UCProductMiniItem ucProductMiniItem6;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddCategory;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewTable;
        private System.Windows.Forms.DataGridViewImageColumn Avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}
