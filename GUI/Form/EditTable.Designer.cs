namespace GUI
{
    partial class EditTable
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTable));
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbTableID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTableID = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bthCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbArea = new System.Windows.Forms.Label();
            this.panelTableID.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnUpdate.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnUpdate.Location = new System.Drawing.Point(229, 381);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.BorderRadius = 15;
            this.btnUpdate.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.btnUpdate.ShadowDecoration.Enabled = true;
            this.btnUpdate.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 7, 7);
            this.btnUpdate.Size = new System.Drawing.Size(85, 35);
            this.btnUpdate.TabIndex = 157;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 250;
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lbTableID
            // 
            this.lbTableID.AutoSize = true;
            this.lbTableID.BackColor = System.Drawing.Color.Transparent;
            this.lbTableID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableID.ForeColor = System.Drawing.Color.Gray;
            this.lbTableID.Location = new System.Drawing.Point(6, 10);
            this.lbTableID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTableID.Name = "lbTableID";
            this.lbTableID.Size = new System.Drawing.Size(60, 19);
            this.lbTableID.TabIndex = 49;
            this.lbTableID.Text = "Table ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label6.Location = new System.Drawing.Point(60, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 155;
            this.label6.Text = "Area";
            // 
            // panelTableID
            // 
            this.panelTableID.BackColor = System.Drawing.Color.Transparent;
            this.panelTableID.BorderColor = System.Drawing.Color.Silver;
            this.panelTableID.BorderRadius = 10;
            this.panelTableID.BorderThickness = 2;
            this.panelTableID.Controls.Add(this.lbTableID);
            this.panelTableID.FillColor = System.Drawing.Color.White;
            this.panelTableID.Location = new System.Drawing.Point(63, 90);
            this.panelTableID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTableID.Name = "panelTableID";
            this.panelTableID.Size = new System.Drawing.Size(270, 40);
            this.panelTableID.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(60, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 152;
            this.label2.Text = "Table ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(148, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 151;
            this.label1.Text = "Edit Table ";
            // 
            // bthCancel
            // 
            this.bthCancel.BackColor = System.Drawing.Color.Transparent;
            this.bthCancel.BorderRadius = 10;
            this.bthCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bthCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bthCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bthCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bthCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bthCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.bthCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.bthCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.bthCancel.ForeColor = System.Drawing.Color.White;
            this.bthCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bthCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.bthCancel.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.bthCancel.Location = new System.Drawing.Point(80, 381);
            this.bthCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bthCancel.Name = "bthCancel";
            this.bthCancel.ShadowDecoration.BorderRadius = 15;
            this.bthCancel.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.bthCancel.ShadowDecoration.Enabled = true;
            this.bthCancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 7, 7);
            this.bthCancel.Size = new System.Drawing.Size(85, 35);
            this.bthCancel.TabIndex = 158;
            this.bthCancel.Text = "Cancel";
            this.bthCancel.Click += new System.EventHandler(this.bthCancel_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderRadius = 5;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.CustomIconSize = 20F;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Brown;
            this.guna2ControlBox3.Location = new System.Drawing.Point(318, 11);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox3.TabIndex = 162;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1.Location = new System.Drawing.Point(350, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label4.Location = new System.Drawing.Point(64, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 164;
            this.label4.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.Gray;
            this.cbStatus.BorderRadius = 15;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 34;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cbStatus.Location = new System.Drawing.Point(63, 293);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(270, 40);
            this.cbStatus.TabIndex = 163;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.lbArea);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(63, 189);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(270, 40);
            this.guna2Panel3.TabIndex = 165;
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.BackColor = System.Drawing.Color.Transparent;
            this.lbArea.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArea.ForeColor = System.Drawing.Color.Gray;
            this.lbArea.Location = new System.Drawing.Point(10, 10);
            this.lbArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(37, 19);
            this.lbArea.TabIndex = 49;
            this.lbArea.Text = "Area";
            // 
            // EditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 459);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTableID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bthCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTable";
            this.panelTableID.ResumeLayout(false);
            this.panelTableID.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel panelTableID;
        private System.Windows.Forms.Label lbTableID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton bthCancel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbArea;
    }
}