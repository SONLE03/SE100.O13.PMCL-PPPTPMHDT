﻿namespace GUI
{
    partial class HomeManager
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeManager));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Menu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Report = new Guna.UI2.WinForms.Guna2Button();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.Employees = new Guna.UI2.WinForms.Guna2Button();
            this.Import = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnHide = new Guna.UI2.WinForms.Guna2Button();
            this.lbRole = new System.Windows.Forms.Label();
            this.Log_out = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Events = new Guna.UI2.WinForms.Guna2Button();
            this.Tables = new Guna.UI2.WinForms.Guna2Button();
            this.Bills = new Guna.UI2.WinForms.Guna2Button();
            this.Products = new Guna.UI2.WinForms.Guna2Button();
            this.Home = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderRadius = 5;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.CustomIconSize = 20F;
            this.guna2Transition1.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.FillColor = System.Drawing.Color.White;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.IconColor = System.Drawing.Color.Brown;
            this.btnMinimize.Location = new System.Drawing.Point(953, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 21);
            this.btnMinimize.TabIndex = 58;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 5;
            this.btnClose.CustomIconSize = 20F;
            this.guna2Transition1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconColor = System.Drawing.Color.Brown;
            this.btnClose.Location = new System.Drawing.Point(1042, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 21);
            this.btnClose.TabIndex = 57;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Animated = true;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BorderRadius = 5;
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.CustomIconSize = 20F;
            this.guna2Transition1.SetDecoration(this.btnMaximize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMaximize.FillColor = System.Drawing.Color.White;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.IconColor = System.Drawing.Color.Brown;
            this.btnMaximize.Location = new System.Drawing.Point(997, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 21);
            this.btnMaximize.TabIndex = 59;
            // 
            // Menu
            // 
            this.Menu.BorderRadius = 20;
            this.Menu.Controls.Add(this.Report);
            this.Menu.Controls.Add(this.btnShow);
            this.Menu.Controls.Add(this.Employees);
            this.Menu.Controls.Add(this.Import);
            this.Menu.Controls.Add(this.guna2CirclePictureBox1);
            this.Menu.Controls.Add(this.btnHide);
            this.Menu.Controls.Add(this.lbRole);
            this.Menu.Controls.Add(this.Log_out);
            this.Menu.Controls.Add(this.guna2CirclePictureBox2);
            this.Menu.Controls.Add(this.Settings);
            this.Menu.Controls.Add(this.Events);
            this.Menu.Controls.Add(this.Tables);
            this.Menu.Controls.Add(this.Bills);
            this.Menu.Controls.Add(this.Products);
            this.Menu.Controls.Add(this.Home);
            this.Menu.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.Menu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.Menu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Menu.Location = new System.Drawing.Point(-1, -1);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(264, 741);
            this.Menu.TabIndex = 60;
            // 
            // Report
            // 
            this.Report.Animated = true;
            this.Report.AnimatedGIF = true;
            this.Report.BackColor = System.Drawing.Color.Transparent;
            this.Report.BorderRadius = 10;
            this.Report.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__page_edit;
            this.Report.CustomImages.Image = global::GUI.Properties.Resources.icon__page_edit___1_;
            this.Report.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Report.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Report.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Report, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Report.FillColor = System.Drawing.Color.Transparent;
            this.Report.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Report.ForeColor = System.Drawing.Color.White;
            this.Report.HoverState.FillColor = System.Drawing.Color.White;
            this.Report.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Report.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Report.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Report.Location = new System.Drawing.Point(0, 473);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(265, 44);
            this.Report.TabIndex = 16;
            this.Report.Text = "Report";
            this.Report.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Report.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // btnShow
            // 
            this.btnShow.Animated = true;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BorderRadius = 10;
            this.btnShow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShow.CustomImages.Image = global::GUI.Properties.Resources.icon__menu_scale_2;
            this.guna2Transition1.SetDecoration(this.btnShow, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(24, 14);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(45, 45);
            this.btnShow.TabIndex = 15;
            this.btnShow.UseTransparentBackground = true;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Employees
            // 
            this.Employees.Animated = true;
            this.Employees.AnimatedGIF = true;
            this.Employees.BackColor = System.Drawing.Color.Transparent;
            this.Employees.BorderRadius = 10;
            this.Employees.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__user_bag_hover;
            this.Employees.CustomImages.Image = global::GUI.Properties.Resources.icon__user_bag;
            this.Employees.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Employees.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Employees.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Employees, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Employees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Employees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Employees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Employees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Employees.FillColor = System.Drawing.Color.Transparent;
            this.Employees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Employees.ForeColor = System.Drawing.Color.White;
            this.Employees.HoverState.FillColor = System.Drawing.Color.White;
            this.Employees.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Employees.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Employees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Employees.Location = new System.Drawing.Point(0, 418);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(265, 44);
            this.Employees.TabIndex = 14;
            this.Employees.Text = "Employees";
            this.Employees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Employees.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // Import
            // 
            this.Import.Animated = true;
            this.Import.AnimatedGIF = true;
            this.Import.BackColor = System.Drawing.Color.Transparent;
            this.Import.BorderRadius = 10;
            this.Import.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__truck_hover;
            this.Import.CustomImages.Image = global::GUI.Properties.Resources.icon__truck_;
            this.Import.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Import.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Import.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Import, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Import.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Import.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Import.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Import.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Import.FillColor = System.Drawing.Color.Transparent;
            this.Import.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Import.ForeColor = System.Drawing.Color.White;
            this.Import.HoverState.FillColor = System.Drawing.Color.White;
            this.Import.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Import.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Import.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Import.Location = new System.Drawing.Point(0, 362);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(265, 44);
            this.Import.TabIndex = 13;
            this.Import.Text = "Import";
            this.Import.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Import.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.Image = global::GUI.Properties.Resources.coffee_bean__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(24, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // btnHide
            // 
            this.btnHide.Animated = true;
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BorderRadius = 10;
            this.btnHide.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHide.CustomImages.Image = global::GUI.Properties.Resources.icon__menu_scale;
            this.guna2Transition1.SetDecoration(this.btnHide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(210, 16);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(45, 45);
            this.btnHide.TabIndex = 3;
            this.btnHide.UseTransparentBackground = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(105, 631);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(96, 28);
            this.lbRole.TabIndex = 3;
            this.lbRole.Text = "Manager";
            // 
            // Log_out
            // 
            this.Log_out.BackColor = System.Drawing.Color.Transparent;
            this.Log_out.BorderRadius = 10;
            this.Log_out.CustomImages.Image = global::GUI.Properties.Resources.icon__log_out;
            this.Log_out.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Log_out.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Log_out.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Log_out, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Log_out.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Log_out.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Log_out.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Log_out.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Log_out.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.Log_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Log_out.ForeColor = System.Drawing.Color.White;
            this.Log_out.HoverState.FillColor = System.Drawing.Color.White;
            this.Log_out.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Log_out.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Log_out.Location = new System.Drawing.Point(8, 680);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(241, 44);
            this.Log_out.TabIndex = 9;
            this.Log_out.Text = "Log out";
            this.Log_out.TextOffset = new System.Drawing.Point(27, 0);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2CirclePictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox2.Image = global::GUI.Properties.Resources.Ellipse_5;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(24, 624);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(54, 50);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 8;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.Animated = true;
            this.Settings.AnimatedGIF = true;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BorderRadius = 10;
            this.Settings.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__settings_hover;
            this.Settings.CustomImages.Image = global::GUI.Properties.Resources.icon__settings;
            this.Settings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Settings.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Settings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.FillColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.HoverState.FillColor = System.Drawing.Color.White;
            this.Settings.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Settings.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.Location = new System.Drawing.Point(0, 528);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(265, 44);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // Events
            // 
            this.Events.Animated = true;
            this.Events.AnimatedGIF = true;
            this.Events.BackColor = System.Drawing.Color.Transparent;
            this.Events.BorderRadius = 10;
            this.Events.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__event_hover;
            this.Events.CustomImages.Image = global::GUI.Properties.Resources.icon__event;
            this.Events.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Events.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Events.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Events, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Events.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Events.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Events.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Events.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Events.FillColor = System.Drawing.Color.Transparent;
            this.Events.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Events.ForeColor = System.Drawing.Color.White;
            this.Events.HoverState.FillColor = System.Drawing.Color.White;
            this.Events.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Events.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Events.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Events.Location = new System.Drawing.Point(0, 307);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(265, 44);
            this.Events.TabIndex = 6;
            this.Events.Text = "Events";
            this.Events.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Events.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // Tables
            // 
            this.Tables.Animated = true;
            this.Tables.AnimatedGIF = true;
            this.Tables.BackColor = System.Drawing.Color.Transparent;
            this.Tables.BorderRadius = 10;
            this.Tables.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__table_hover;
            this.Tables.CustomImages.Image = global::GUI.Properties.Resources.icon__table_;
            this.Tables.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tables.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Tables.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Tables, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Tables.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Tables.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Tables.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Tables.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Tables.FillColor = System.Drawing.Color.Transparent;
            this.Tables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Tables.ForeColor = System.Drawing.Color.White;
            this.Tables.HoverState.FillColor = System.Drawing.Color.White;
            this.Tables.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Tables.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Tables.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tables.Location = new System.Drawing.Point(0, 197);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(265, 44);
            this.Tables.TabIndex = 5;
            this.Tables.Text = "Tables";
            this.Tables.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tables.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // Bills
            // 
            this.Bills.Animated = true;
            this.Bills.AnimatedGIF = true;
            this.Bills.BackColor = System.Drawing.Color.Transparent;
            this.Bills.BorderRadius = 10;
            this.Bills.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__google_docs_hover;
            this.Bills.CustomImages.Image = global::GUI.Properties.Resources.icon_Bill;
            this.Bills.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Bills.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Bills.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Bills, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Bills.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Bills.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Bills.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Bills.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Bills.FillColor = System.Drawing.Color.Transparent;
            this.Bills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Bills.ForeColor = System.Drawing.Color.White;
            this.Bills.HoverState.FillColor = System.Drawing.Color.White;
            this.Bills.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Bills.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Bills.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Bills.Location = new System.Drawing.Point(0, 252);
            this.Bills.Name = "Bills";
            this.Bills.Size = new System.Drawing.Size(265, 44);
            this.Bills.TabIndex = 5;
            this.Bills.Text = "Bills";
            this.Bills.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Bills.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // Products
            // 
            this.Products.Animated = true;
            this.Products.AnimatedGIF = true;
            this.Products.BackColor = System.Drawing.Color.Transparent;
            this.Products.BorderRadius = 10;
            this.Products.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__coffee_cup_hover;
            this.Products.CustomImages.Image = global::GUI.Properties.Resources.icon__coffee_cup_;
            this.Products.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Products.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Products.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Products, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Products.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Products.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Products.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Products.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Products.FillColor = System.Drawing.Color.Transparent;
            this.Products.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.HoverState.FillColor = System.Drawing.Color.White;
            this.Products.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Products.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Products.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Products.Location = new System.Drawing.Point(0, 142);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(265, 44);
            this.Products.TabIndex = 3;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Products.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // Home
            // 
            this.Home.Animated = true;
            this.Home.AnimatedGIF = true;
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BorderRadius = 10;
            this.Home.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__home_simple_door_hover;
            this.Home.CustomImages.Image = global::GUI.Properties.Resources.home_simple_door;
            this.Home.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Home.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Home, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Home.FillColor = System.Drawing.Color.Transparent;
            this.Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.HoverState.FillColor = System.Drawing.Color.White;
            this.Home.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Home.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.Location = new System.Drawing.Point(0, 87);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(265, 44);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::GUI.Properties.Resources.CafeStore;
            this.pictureBox1.Location = new System.Drawing.Point(85, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(270, 39);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(813, 686);
            this.guna2Panel1.TabIndex = 61;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // HomeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 737);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeManager";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel Menu;
        private Guna.UI2.WinForms.Guna2Button Employees;
        private Guna.UI2.WinForms.Guna2Button Import;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnHide;
        private System.Windows.Forms.Label lbRole;
        private Guna.UI2.WinForms.Guna2Button Log_out;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2Button Events;
        private Guna.UI2.WinForms.Guna2Button Tables;
        private Guna.UI2.WinForms.Guna2Button Bills;
        private Guna.UI2.WinForms.Guna2Button Products;
        private Guna.UI2.WinForms.Guna2Button Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Report;
    }
}