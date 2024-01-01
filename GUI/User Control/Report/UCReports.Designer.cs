namespace GUI
{
    partial class UCReports
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
            this.btnRevenue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDrink = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelImport = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenue.BorderRadius = 15;
            this.btnRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnRevenue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRevenue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnRevenue.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnRevenue.Location = new System.Drawing.Point(316, 26);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.ShadowDecoration.BorderRadius = 15;
            this.btnRevenue.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnRevenue.ShadowDecoration.Enabled = true;
            this.btnRevenue.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnRevenue.Size = new System.Drawing.Size(154, 40);
            this.btnRevenue.TabIndex = 40;
            this.btnRevenue.Text = "Revenue Report";
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrink.BackColor = System.Drawing.Color.Transparent;
            this.btnDrink.BorderRadius = 15;
            this.btnDrink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrink.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDrink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnDrink.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnDrink.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDrink.ForeColor = System.Drawing.Color.White;
            this.btnDrink.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDrink.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnDrink.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnDrink.Location = new System.Drawing.Point(679, 26);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.ShadowDecoration.BorderRadius = 15;
            this.btnDrink.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnDrink.ShadowDecoration.Enabled = true;
            this.btnDrink.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnDrink.Size = new System.Drawing.Size(154, 40);
            this.btnDrink.TabIndex = 41;
            this.btnDrink.Text = "Drink Report";
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // PanelImport
            // 
            this.PanelImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelImport.BackColor = System.Drawing.Color.Transparent;
            this.PanelImport.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelImport.BorderRadius = 40;
            this.PanelImport.BorderThickness = 1;
            this.PanelImport.FillColor = System.Drawing.Color.White;
            this.PanelImport.Location = new System.Drawing.Point(58, 98);
            this.PanelImport.Name = "PanelImport";
            this.PanelImport.ShadowDecoration.BorderRadius = 40;
            this.PanelImport.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.PanelImport.ShadowDecoration.Enabled = true;
            this.PanelImport.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.PanelImport.Size = new System.Drawing.Size(1010, 655);
            this.PanelImport.TabIndex = 42;
            // 
            // UCReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PanelImport);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnRevenue);
            this.DoubleBuffered = true;
            this.Name = "UCReports";
            this.Size = new System.Drawing.Size(1124, 800);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnRevenue;
        private Guna.UI2.WinForms.Guna2GradientButton btnDrink;
        private Guna.UI2.WinForms.Guna2Panel PanelImport;
    }
}
