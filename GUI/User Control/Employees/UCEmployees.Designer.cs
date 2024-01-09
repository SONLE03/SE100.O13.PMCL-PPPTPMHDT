using System.Web.UI;

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
            this.panelControl = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.SuspendLayout();
            // 
            // btnUsergroup
            // 
            this.btnUsergroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnUsergroup.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnUsergroup.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnUsergroup.Location = new System.Drawing.Point(675, 29);
            this.btnUsergroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsergroup.Name = "btnUsergroup";
            this.btnUsergroup.ShadowDecoration.BorderRadius = 15;
            this.btnUsergroup.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnUsergroup.ShadowDecoration.Enabled = true;
            this.btnUsergroup.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnUsergroup.Size = new System.Drawing.Size(150, 40);
            this.btnUsergroup.TabIndex = 44;
            this.btnUsergroup.Text = "User group";
            this.btnUsergroup.Click += new System.EventHandler(this.btnUsergroup_Click);
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
            this.btnEmployees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnEmployees.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnEmployees.Location = new System.Drawing.Point(282, 29);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.ShadowDecoration.BorderRadius = 15;
            this.btnEmployees.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnEmployees.ShadowDecoration.Enabled = true;
            this.btnEmployees.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnEmployees.Size = new System.Drawing.Size(150, 40);
            this.btnEmployees.TabIndex = 43;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.BorderColor = System.Drawing.Color.Silver;
            this.panelControl.BorderRadius = 35;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Location = new System.Drawing.Point(57, 100);
            this.panelControl.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl.Name = "panelControl";
            this.panelControl.ShadowDecoration.BorderRadius = 35;
            this.panelControl.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.panelControl.ShadowDecoration.Enabled = true;
            this.panelControl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.panelControl.Size = new System.Drawing.Size(1010, 655);
            this.panelControl.TabIndex = 45;
            this.panelControl.Text = "guna2ContainerControl1";
            // 
            // UCEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnUsergroup);
            this.Controls.Add(this.btnEmployees);
            this.DoubleBuffered = true;
            this.Name = "UCEmployees";
            this.Size = new System.Drawing.Size(1124, 800);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnUsergroup;
        private Guna.UI2.WinForms.Guna2GradientButton btnEmployees;
        private UCEmployees_TabEmployees tabEmployee;
        private UCEmployees_TabUserGroup tabUserGroup;
        private Guna.UI2.WinForms.Guna2ContainerControl panelControl;
    }
}
