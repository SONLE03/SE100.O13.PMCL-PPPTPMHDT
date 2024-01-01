namespace GUI
{
    partial class UCMiniSize
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
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.txtSize.Location = new System.Drawing.Point(0, 7);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(30, 23);
            this.txtSize.TabIndex = 0;
            this.txtSize.Text = "L";
            this.txtSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSize.Click += new System.EventHandler(this.txtSize_Click_1);
            // 
            // UCMiniSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSize);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.Name = "UCMiniSize";
            this.Size = new System.Drawing.Size(30, 36);
            this.Click += new System.EventHandler(this.UCMiniSize_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtSize;
    }
}
