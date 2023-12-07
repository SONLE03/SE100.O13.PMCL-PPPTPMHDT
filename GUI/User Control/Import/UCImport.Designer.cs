namespace GUI
{
    partial class UCImport
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
            this.btnImportOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelImport = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // btnImportOrder
            // 
            this.btnImportOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnImportOrder.BorderRadius = 15;
            this.btnImportOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImportOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImportOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImportOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImportOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImportOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnImportOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnImportOrder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnImportOrder.ForeColor = System.Drawing.Color.White;
            this.btnImportOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnImportOrder.Location = new System.Drawing.Point(661, 29);
            this.btnImportOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportOrder.Name = "btnImportOrder";
            this.btnImportOrder.Size = new System.Drawing.Size(170, 41);
            this.btnImportOrder.TabIndex = 40;
            this.btnImportOrder.Text = "Import order";
            this.btnImportOrder.Click += new System.EventHandler(this.btnImportOrder_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplier.BorderRadius = 15;
            this.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnSupplier.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSupplier.Location = new System.Drawing.Point(287, 29);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(171, 41);
            this.btnSupplier.TabIndex = 39;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // PanelImport
            // 
            this.PanelImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelImport.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelImport.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelImport.BorderRadius = 40;
            this.PanelImport.BorderThickness = 1;
            this.PanelImport.FillColor = System.Drawing.Color.White;
            this.PanelImport.Location = new System.Drawing.Point(59, 98);
            this.PanelImport.Name = "PanelImport";
            this.PanelImport.Size = new System.Drawing.Size(1010, 655);
            this.PanelImport.TabIndex = 38;
            // 
            // UCImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnImportOrder);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.PanelImport);
            this.DoubleBuffered = true;
            this.Name = "UCImport";
            this.Size = new System.Drawing.Size(1124, 800);
            this.Load += new System.EventHandler(this.UCImport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnImportOrder;
        private Guna.UI2.WinForms.Guna2GradientButton btnSupplier;
        private Guna.UI2.WinForms.Guna2Panel PanelImport;
        private UCImport_TabSupplier ucSuppliers;
        private UCImport_TabImportOrder ucIO;
    }
}
