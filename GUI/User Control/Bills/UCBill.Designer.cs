namespace GUI
{
    partial class UCBill
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
            this.PanelDisplayTabs = new System.Windows.Forms.Panel();
            this.btnInvoice = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // PanelDisplayTabs
            // 
            this.PanelDisplayTabs.BackColor = System.Drawing.Color.Transparent;
            this.PanelDisplayTabs.Location = new System.Drawing.Point(4, 90);
            this.PanelDisplayTabs.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDisplayTabs.Name = "PanelDisplayTabs";
            this.PanelDisplayTabs.Size = new System.Drawing.Size(1492, 891);
            this.PanelDisplayTabs.TabIndex = 0;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.BorderRadius = 15;
            this.btnInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoice.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnInvoice.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnInvoice.Location = new System.Drawing.Point(845, 30);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(180, 46);
            this.btnInvoice.TabIndex = 37;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BorderRadius = 15;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnOrder.Location = new System.Drawing.Point(456, 30);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 46);
            this.btnOrder.TabIndex = 36;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // UCBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.PanelDisplayTabs);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCBill";
            this.Size = new System.Drawing.Size(1499, 985);
            this.Load += new System.EventHandler(this.UCBill_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UCProductMiniItem ucProductMiniItem1;
        private UCProductMiniItem ucProductMiniItem2;
        private UCProductMiniItem ucProductMiniItem3;
        private UCProductMiniItem ucProductMiniItem4;
        private UCMiniProductChoosen ucMiniProductChoosen1;
        private UCMiniProductChoosen ucMiniProductChoosen2;
        private UCMiniProductChoosen ucMiniProductChoosen3;
        private UCMiniProductChoosen ucMiniProductChoosen4;
        private System.Windows.Forms.Panel PanelDisplayTabs;
        private Guna.UI2.WinForms.Guna2GradientButton btnInvoice;
        private Guna.UI2.WinForms.Guna2GradientButton btnOrder;
        private UCBills_TabInvoices ucBills_TabInvoices;
        private UCBills_TabOrder ucBills_TabOrder;
    }
}
