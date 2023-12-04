namespace GUI
{
    partial class UCEmployees
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
            this.btnUsergroup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEmployees = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // btnUsergroup
            // 
            this.btnUsergroup.BackColor = System.Drawing.Color.Transparent;
            this.btnUsergroup.BorderRadius = 15;
            this.btnUsergroup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsergroup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsergroup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsergroup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsergroup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsergroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnUsergroup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnUsergroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsergroup.ForeColor = System.Drawing.Color.White;
            this.btnUsergroup.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnUsergroup.Location = new System.Drawing.Point(675, 29);
            this.btnUsergroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsergroup.Name = "btnUsergroup";
            this.btnUsergroup.Size = new System.Drawing.Size(141, 41);
            this.btnUsergroup.TabIndex = 44;
            this.btnUsergroup.Text = "User group";
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.BorderRadius = 15;
            this.btnEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployees.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnEmployees.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEmployees.Location = new System.Drawing.Point(282, 29);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(140, 41);
            this.btnEmployees.TabIndex = 43;
            this.btnEmployees.Text = "Employees";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderRadius = 40;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(57, 100);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1010, 655);
            this.guna2Panel1.TabIndex = 42;
            // 
            // UCEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnUsergroup);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.Name = "UCEmployees";
            this.Size = new System.Drawing.Size(1124, 800);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnUsergroup;
        private Guna.UI2.WinForms.Guna2GradientButton btnEmployees;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
