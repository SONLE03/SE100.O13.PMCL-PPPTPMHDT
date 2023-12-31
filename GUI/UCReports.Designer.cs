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
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRevenue.Location = new System.Drawing.Point(350, 11);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(228, 50);
            this.btnRevenue.TabIndex = 40;
            this.btnRevenue.Text = "Revenue Report";
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.Transparent;
            this.btnDrink.BorderRadius = 15;
            this.btnDrink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrink.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDrink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnDrink.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnDrink.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnDrink.ForeColor = System.Drawing.Color.White;
            this.btnDrink.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDrink.Location = new System.Drawing.Point(832, 11);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(228, 50);
            this.btnDrink.TabIndex = 41;
            this.btnDrink.Text = "Drink Report";
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
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
            this.PanelImport.Location = new System.Drawing.Point(78, 100);
            this.PanelImport.Margin = new System.Windows.Forms.Padding(4);
            this.PanelImport.Name = "PanelImport";
            this.PanelImport.Size = new System.Drawing.Size(1347, 806);
            this.PanelImport.TabIndex = 42;
            // 
            // UCReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelImport);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnRevenue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCReports";
            this.Size = new System.Drawing.Size(1499, 985);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnRevenue;
        private Guna.UI2.WinForms.Guna2GradientButton btnDrink;
        private Guna.UI2.WinForms.Guna2Panel PanelImport;
    }
}
