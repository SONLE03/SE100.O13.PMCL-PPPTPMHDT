namespace GUI
{
    partial class UCTables
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
            this.btnArea = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelTables = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArea.BackColor = System.Drawing.Color.Transparent;
            this.btnArea.BorderRadius = 15;
            this.btnArea.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnArea.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnArea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArea.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnArea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnArea.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnArea.ForeColor = System.Drawing.Color.White;
            this.btnArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnArea.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnArea.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnArea.Location = new System.Drawing.Point(908, 36);
            this.btnArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArea.Name = "btnArea";
            this.btnArea.ShadowDecoration.BorderRadius = 15;
            this.btnArea.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnArea.ShadowDecoration.Enabled = true;
            this.btnArea.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnArea.Size = new System.Drawing.Size(156, 50);
            this.btnArea.TabIndex = 36;
            this.btnArea.Text = "Area";
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.BorderRadius = 15;
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnTable.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnTable.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnTable.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnTable.Location = new System.Drawing.Point(424, 36);
            this.btnTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTable.Name = "btnTable";
            this.btnTable.ShadowDecoration.BorderRadius = 15;
            this.btnTable.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnTable.ShadowDecoration.Enabled = true;
            this.btnTable.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnTable.Size = new System.Drawing.Size(172, 50);
            this.btnTable.TabIndex = 35;
            this.btnTable.Text = "Tables";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // PanelTables
            // 
            this.PanelTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTables.Location = new System.Drawing.Point(77, 122);
            this.PanelTables.Name = "PanelTables";
            this.PanelTables.Size = new System.Drawing.Size(1347, 806);
            this.PanelTables.TabIndex = 37;
            this.PanelTables.Text = "guna2ContainerControl1";
            // 
            // UCTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PanelTables);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnTable);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTables";
            this.Size = new System.Drawing.Size(1499, 985);
            this.Load += new System.EventHandler(this.UCTables_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnArea;
        private Guna.UI2.WinForms.Guna2GradientButton btnTable;
        private UCTables_TabTables ucTables_Tables;
        private UCTables_TabAreas ucTables_Areas;
        private Guna.UI2.WinForms.Guna2ContainerControl PanelTables;
    }
}
