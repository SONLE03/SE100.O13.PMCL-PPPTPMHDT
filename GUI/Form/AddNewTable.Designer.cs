﻿namespace GUI
{
    partial class AddNewTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTable));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTableID = new Guna.UI2.WinForms.Guna2Panel();
            this.lbAreaID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bthCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboboxArea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelTableID.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label6.Location = new System.Drawing.Point(140, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 142;
            this.label6.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label3.Location = new System.Drawing.Point(140, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 141;
            this.label3.Text = "Table Name";
            // 
            // panelTableID
            // 
            this.panelTableID.BackColor = System.Drawing.Color.Transparent;
            this.panelTableID.BorderColor = System.Drawing.Color.Silver;
            this.panelTableID.BorderRadius = 10;
            this.panelTableID.BorderThickness = 2;
            this.panelTableID.Controls.Add(this.lbAreaID);
            this.panelTableID.FillColor = System.Drawing.Color.White;
            this.panelTableID.Location = new System.Drawing.Point(139, 89);
            this.panelTableID.Margin = new System.Windows.Forms.Padding(2);
            this.panelTableID.Name = "panelTableID";
            this.panelTableID.Size = new System.Drawing.Size(223, 32);
            this.panelTableID.TabIndex = 140;
            // 
            // lbAreaID
            // 
            this.lbAreaID.AutoSize = true;
            this.lbAreaID.BackColor = System.Drawing.Color.Transparent;
            this.lbAreaID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAreaID.ForeColor = System.Drawing.Color.Gray;
            this.lbAreaID.Location = new System.Drawing.Point(4, 7);
            this.lbAreaID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAreaID.Name = "lbAreaID";
            this.lbAreaID.Size = new System.Drawing.Size(60, 19);
            this.lbAreaID.TabIndex = 49;
            this.lbAreaID.Text = "Table ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(140, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 139;
            this.label2.Text = "Table ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(187, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 138;
            this.label1.Text = "Add new Table";
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAdd.Location = new System.Drawing.Point(285, 468);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 30);
            this.btnAdd.TabIndex = 145;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.bthCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bthCancel.ForeColor = System.Drawing.Color.White;
            this.bthCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bthCancel.Location = new System.Drawing.Point(139, 468);
            this.bthCancel.Margin = new System.Windows.Forms.Padding(2);
            this.bthCancel.Name = "bthCancel";
            this.bthCancel.Size = new System.Drawing.Size(74, 30);
            this.bthCancel.TabIndex = 146;
            this.bthCancel.Text = "Cancel";
            this.bthCancel.Click += new System.EventHandler(this.bthCancel_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Animated = true;
            this.txtTableName.BackColor = System.Drawing.Color.Transparent;
            this.txtTableName.BorderColor = System.Drawing.Color.Gray;
            this.txtTableName.BorderRadius = 13;
            this.txtTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableName.DefaultText = "";
            this.txtTableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTableName.ForeColor = System.Drawing.Color.DimGray;
            this.txtTableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.Location = new System.Drawing.Point(139, 160);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTableName.PlaceholderText = "Enter table name";
            this.txtTableName.SelectedText = "";
            this.txtTableName.Size = new System.Drawing.Size(223, 32);
            this.txtTableName.TabIndex = 147;
            // 
            // comboboxArea
            // 
            this.comboboxArea.BackColor = System.Drawing.Color.Transparent;
            this.comboboxArea.BorderColor = System.Drawing.Color.Black;
            this.comboboxArea.BorderRadius = 10;
            this.comboboxArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.comboboxArea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxArea.ForeColor = System.Drawing.Color.White;
            this.comboboxArea.ItemHeight = 30;
            this.comboboxArea.Location = new System.Drawing.Point(249, 228);
            this.comboboxArea.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxArea.Name = "comboboxArea";
            this.comboboxArea.Size = new System.Drawing.Size(113, 36);
            this.comboboxArea.TabIndex = 148;
            // 
            // AddNewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 539);
            this.Controls.Add(this.comboboxArea);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTableID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bthCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNewTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewTable";
            this.panelTableID.ResumeLayout(false);
            this.panelTableID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelTableID;
        private System.Windows.Forms.Label lbAreaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton bthCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtTableName;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxArea;
    }
}