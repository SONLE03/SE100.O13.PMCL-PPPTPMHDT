﻿namespace GUI
{
    partial class UCMiniSizeForBill
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
            this.txtSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.White;
            this.txtSize.Location = new System.Drawing.Point(0, 2);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(29, 28);
            this.txtSize.TabIndex = 0;
            this.txtSize.Text = "L";
            this.txtSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSize.Click += new System.EventHandler(this.txtSize_Click);
            // 
            // UCMiniSizeForBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.txtSize);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCMiniSizeForBill";
            this.Size = new System.Drawing.Size(29, 32);
            this.Click += new System.EventHandler(this.UCMiniSizeForBill_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtSize;
    }
}
