namespace GUI
{
    partial class ProductDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetail));
            this.btn_Edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_OK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_quantity = new Guna.UI2.WinForms.Guna2Panel();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.panel_size = new Guna.UI2.WinForms.Guna2Panel();
            this.lbSize = new System.Windows.Forms.Label();
            this.panel_price = new Guna.UI2.WinForms.Guna2Panel();
            this.lbUPrice = new System.Windows.Forms.Label();
            this.panel_productname = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_productname = new System.Windows.Forms.Label();
            this.panel_unit = new Guna.UI2.WinForms.Guna2Panel();
            this.lbUnit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_describe = new Guna.UI2.WinForms.Guna2Panel();
            this.lbDescribe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.picture_product = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            this.panel_quantity.SuspendLayout();
            this.panel_size.SuspendLayout();
            this.panel_price.SuspendLayout();
            this.panel_productname.SuspendLayout();
            this.panel_unit.SuspendLayout();
            this.panel_describe.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BorderRadius = 15;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btn_Edit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Edit.Location = new System.Drawing.Point(541, 586);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(125, 41);
            this.btn_Edit.TabIndex = 46;
            this.btn_Edit.Text = "Edit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(522, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(199, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Unit price (VNĐ)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 36);
            this.panel1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Size";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.BorderRadius = 15;
            this.btn_OK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_OK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_OK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_OK.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_OK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_OK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btn_OK.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_OK.Location = new System.Drawing.Point(264, 586);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(125, 41);
            this.btn_OK.TabIndex = 45;
            this.btn_OK.Text = "OK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label4.Location = new System.Drawing.Point(504, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(503, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Product name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(379, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Product Detail";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 200;
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.panel_quantity);
            this.guna2Panel1.Controls.Add(this.panel_size);
            this.guna2Panel1.Controls.Add(this.panel_price);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Location = new System.Drawing.Point(61, 443);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(810, 94);
            this.guna2Panel1.TabIndex = 43;
            // 
            // panel_quantity
            // 
            this.panel_quantity.BackColor = System.Drawing.Color.Transparent;
            this.panel_quantity.BorderColor = System.Drawing.Color.Silver;
            this.panel_quantity.BorderRadius = 10;
            this.panel_quantity.BorderThickness = 2;
            this.panel_quantity.Controls.Add(this.lbQuantity);
            this.panel_quantity.Location = new System.Drawing.Point(630, 28);
            this.panel_quantity.Name = "panel_quantity";
            this.panel_quantity.Size = new System.Drawing.Size(139, 40);
            this.panel_quantity.TabIndex = 54;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.Gray;
            this.lbQuantity.Location = new System.Drawing.Point(16, 9);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(46, 23);
            this.lbQuantity.TabIndex = 49;
            this.lbQuantity.Text = "0000";
            // 
            // panel_size
            // 
            this.panel_size.BackColor = System.Drawing.Color.Transparent;
            this.panel_size.BorderColor = System.Drawing.Color.Silver;
            this.panel_size.BorderRadius = 10;
            this.panel_size.BorderThickness = 1;
            this.panel_size.Controls.Add(this.lbSize);
            this.panel_size.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_size.Location = new System.Drawing.Point(80, 28);
            this.panel_size.Name = "panel_size";
            this.panel_size.Size = new System.Drawing.Size(94, 40);
            this.panel_size.TabIndex = 53;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(16, 9);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(21, 23);
            this.lbSize.TabIndex = 49;
            this.lbSize.Text = "A";
            // 
            // panel_price
            // 
            this.panel_price.BackColor = System.Drawing.Color.Transparent;
            this.panel_price.BorderColor = System.Drawing.Color.Silver;
            this.panel_price.BorderRadius = 10;
            this.panel_price.BorderThickness = 2;
            this.panel_price.Controls.Add(this.lbUPrice);
            this.panel_price.Location = new System.Drawing.Point(356, 28);
            this.panel_price.Name = "panel_price";
            this.panel_price.Size = new System.Drawing.Size(139, 40);
            this.panel_price.TabIndex = 52;
            // 
            // lbUPrice
            // 
            this.lbUPrice.AutoSize = true;
            this.lbUPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbUPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUPrice.ForeColor = System.Drawing.Color.Gray;
            this.lbUPrice.Location = new System.Drawing.Point(16, 9);
            this.lbUPrice.Name = "lbUPrice";
            this.lbUPrice.Size = new System.Drawing.Size(99, 23);
            this.lbUPrice.TabIndex = 49;
            this.lbUPrice.Text = "000.000.000";
            // 
            // panel_productname
            // 
            this.panel_productname.BackColor = System.Drawing.Color.Transparent;
            this.panel_productname.BorderColor = System.Drawing.Color.Silver;
            this.panel_productname.BorderRadius = 10;
            this.panel_productname.BorderThickness = 2;
            this.panel_productname.Controls.Add(this.lb_productname);
            this.panel_productname.Location = new System.Drawing.Point(506, 118);
            this.panel_productname.Name = "panel_productname";
            this.panel_productname.Size = new System.Drawing.Size(358, 40);
            this.panel_productname.TabIndex = 48;
            // 
            // lb_productname
            // 
            this.lb_productname.AutoSize = true;
            this.lb_productname.BackColor = System.Drawing.Color.Transparent;
            this.lb_productname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productname.ForeColor = System.Drawing.Color.Gray;
            this.lb_productname.Location = new System.Drawing.Point(13, 8);
            this.lb_productname.Name = "lb_productname";
            this.lb_productname.Size = new System.Drawing.Size(118, 23);
            this.lb_productname.TabIndex = 49;
            this.lb_productname.Text = "Product name";
            // 
            // panel_unit
            // 
            this.panel_unit.BackColor = System.Drawing.Color.Transparent;
            this.panel_unit.BorderColor = System.Drawing.Color.Silver;
            this.panel_unit.BorderRadius = 10;
            this.panel_unit.BorderThickness = 2;
            this.panel_unit.Controls.Add(this.lbUnit);
            this.panel_unit.Location = new System.Drawing.Point(506, 252);
            this.panel_unit.Name = "panel_unit";
            this.panel_unit.Size = new System.Drawing.Size(358, 40);
            this.panel_unit.TabIndex = 51;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.BackColor = System.Drawing.Color.Transparent;
            this.lbUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.ForeColor = System.Drawing.Color.Gray;
            this.lbUnit.Location = new System.Drawing.Point(16, 9);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(42, 23);
            this.lbUnit.TabIndex = 49;
            this.lbUnit.Text = "Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label5.Location = new System.Drawing.Point(503, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Unit";
            // 
            // panel_describe
            // 
            this.panel_describe.BackColor = System.Drawing.Color.Transparent;
            this.panel_describe.BorderColor = System.Drawing.Color.Silver;
            this.panel_describe.BorderRadius = 10;
            this.panel_describe.BorderThickness = 2;
            this.panel_describe.Controls.Add(this.lbDescribe);
            this.panel_describe.Location = new System.Drawing.Point(506, 327);
            this.panel_describe.Name = "panel_describe";
            this.panel_describe.Size = new System.Drawing.Size(358, 70);
            this.panel_describe.TabIndex = 51;
            // 
            // lbDescribe
            // 
            this.lbDescribe.AutoSize = true;
            this.lbDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lbDescribe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescribe.ForeColor = System.Drawing.Color.Gray;
            this.lbDescribe.Location = new System.Drawing.Point(13, 8);
            this.lbDescribe.Name = "lbDescribe";
            this.lbDescribe.Size = new System.Drawing.Size(90, 23);
            this.lbDescribe.TabIndex = 49;
            this.lbDescribe.Text = "Desciption";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label9.Location = new System.Drawing.Point(502, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = "Description";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.label10);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.guna2Panel5.Location = new System.Drawing.Point(691, 185);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(173, 40);
            this.guna2Panel5.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 49;
            this.label10.Text = "Category";
            // 
            // picture_product
            // 
            this.picture_product.BackColor = System.Drawing.Color.Transparent;
            this.picture_product.BorderRadius = 20;
            this.picture_product.Image = global::GUI.Properties.Resources.milkco;
            this.picture_product.ImageRotate = 0F;
            this.picture_product.Location = new System.Drawing.Point(68, 100);
            this.picture_product.Name = "picture_product";
            this.picture_product.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.picture_product.Size = new System.Drawing.Size(328, 297);
            this.picture_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_product.TabIndex = 34;
            this.picture_product.TabStop = false;
            this.picture_product.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.raucu;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 703);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderRadius = 10;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.CustomIconSize = 20F;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Brown;
            this.guna2ControlBox3.Location = new System.Drawing.Point(821, 16);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 56;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1.Location = new System.Drawing.Point(866, 16);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 55;
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 670);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.panel_describe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_unit);
            this.Controls.Add(this.panel_productname);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.picture_product);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetail";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel_quantity.ResumeLayout(false);
            this.panel_quantity.PerformLayout();
            this.panel_size.ResumeLayout(false);
            this.panel_size.PerformLayout();
            this.panel_price.ResumeLayout(false);
            this.panel_price.PerformLayout();
            this.panel_productname.ResumeLayout(false);
            this.panel_productname.PerformLayout();
            this.panel_unit.ResumeLayout(false);
            this.panel_unit.PerformLayout();
            this.panel_describe.ResumeLayout(false);
            this.panel_describe.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_Edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton btn_OK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picture_product;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel panel_unit;
        private System.Windows.Forms.Label lbUnit;
        private Guna.UI2.WinForms.Guna2Panel panel_productname;
        private System.Windows.Forms.Label lb_productname;
        private Guna.UI2.WinForms.Guna2Panel panel_describe;
        private System.Windows.Forms.Label lbDescribe;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel panel_quantity;
        private System.Windows.Forms.Label lbQuantity;
        private Guna.UI2.WinForms.Guna2Panel panel_size;
        private System.Windows.Forms.Label lbSize;
        private Guna.UI2.WinForms.Guna2Panel panel_price;
        private System.Windows.Forms.Label lbUPrice;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}