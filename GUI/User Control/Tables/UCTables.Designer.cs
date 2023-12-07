﻿namespace GUI
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
            this.PanelTables = new Guna.UI2.WinForms.Guna2Panel();
            this.btnArea = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // PanelTables
            // 
            this.PanelTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTables.BackColor = System.Drawing.Color.Transparent;
            this.PanelTables.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelTables.BorderRadius = 40;
            this.PanelTables.BorderThickness = 1;
            this.PanelTables.FillColor = System.Drawing.Color.White;
            this.PanelTables.Location = new System.Drawing.Point(58, 99);
            this.PanelTables.Name = "PanelTables";
            this.PanelTables.Size = new System.Drawing.Size(1010, 655);
            this.PanelTables.TabIndex = 23;
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
            this.btnArea.Location = new System.Drawing.Point(681, 29);
            this.btnArea.Margin = new System.Windows.Forms.Padding(2);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(117, 41);
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
            this.btnTable.Location = new System.Drawing.Point(318, 29);
            this.btnTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(129, 41);
            this.btnTable.TabIndex = 35;
            this.btnTable.Text = "Tables";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // UCTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.PanelTables);
            this.DoubleBuffered = true;
            this.Name = "UCTables";
            this.Size = new System.Drawing.Size(1124, 800);
            this.Load += new System.EventHandler(this.UCTables_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel PanelTables;
        private Guna.UI2.WinForms.Guna2GradientButton btnArea;
        private Guna.UI2.WinForms.Guna2GradientButton btnTable;
        private UCTables_TabTables ucTables_Tables;
        private UCTables_TabAreas ucTables_Areas;

    }
}
