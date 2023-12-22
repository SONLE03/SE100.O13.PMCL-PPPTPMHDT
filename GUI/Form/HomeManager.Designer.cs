namespace GUI
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeManager));
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Menu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnChangeRegulation = new Guna.UI2.WinForms.Guna2Button();
            this.Report = new Guna.UI2.WinForms.Guna2Button();
            this.Employees = new Guna.UI2.WinForms.Guna2Button();
            this.Import = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.Log_out = new Guna.UI2.WinForms.Guna2Button();
            this.Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Events = new Guna.UI2.WinForms.Guna2Button();
            this.Tables = new Guna.UI2.WinForms.Guna2Button();
            this.Bills = new Guna.UI2.WinForms.Guna2Button();
            this.Products = new Guna.UI2.WinForms.Guna2Button();
            this.Home = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.TabUC = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.IconColor = System.Drawing.Color.Brown;
            this.btnMaximize.Location = new System.Drawing.Point(1122, 11);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(31, 17);
            this.btnMaximize.TabIndex = 58;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 5;
            this.btnClose.CustomIconSize = 20F;
            this.guna2Transition1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconColor = System.Drawing.Color.Brown;
            this.btnClose.Location = new System.Drawing.Point(1158, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 17);
            this.btnClose.TabIndex = 57;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Menu
            // 
            this.Menu.BorderRadius = 20;
            this.Menu.Controls.Add(this.btnChangeRegulation);
            this.Menu.Controls.Add(this.Report);
            this.Menu.Controls.Add(this.Employees);
            this.Menu.Controls.Add(this.Import);
            this.Menu.Controls.Add(this.guna2CirclePictureBox1);
            this.Menu.Controls.Add(this.lbRole);
            this.Menu.Controls.Add(this.Log_out);
            this.Menu.Controls.Add(this.Avatar);
            this.Menu.Controls.Add(this.Settings);
            this.Menu.Controls.Add(this.Events);
            this.Menu.Controls.Add(this.Tables);
            this.Menu.Controls.Add(this.Bills);
            this.Menu.Controls.Add(this.Products);
            this.Menu.Controls.Add(this.Home);
            this.Menu.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.Menu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.Menu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(72, 800);
            this.Menu.TabIndex = 60;
            // 
            // btnChangeRegulation
            // 
            this.btnChangeRegulation.Animated = true;
            this.btnChangeRegulation.AnimatedGIF = true;
            this.btnChangeRegulation.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeRegulation.BorderRadius = 10;
            this.btnChangeRegulation.CustomImages.HoveredImage = global::GUI.Properties.Resources.icon__settings_hover;
            this.btnChangeRegulation.CustomImages.Image = global::GUI.Properties.Resources.icon__settings;
            this.btnChangeRegulation.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangeRegulation.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
            this.btnChangeRegulation.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.btnChangeRegulation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChangeRegulation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeRegulation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeRegulation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeRegulation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeRegulation.FillColor = System.Drawing.Color.Transparent;
            this.btnChangeRegulation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeRegulation.ForeColor = System.Drawing.Color.White;
            this.btnChangeRegulation.HoverState.FillColor = System.Drawing.Color.White;
            this.btnChangeRegulation.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnChangeRegulation.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.btnChangeRegulation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangeRegulation.Location = new System.Drawing.Point(0, 474);
            this.btnChangeRegulation.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeRegulation.Name = "btnChangeRegulation";
            this.btnChangeRegulation.Size = new System.Drawing.Size(199, 36);
            this.btnChangeRegulation.TabIndex = 17;
            this.btnChangeRegulation.Text = "Change rules";
            this.btnChangeRegulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangeRegulation.TextFormatNoPrefix = true;
            this.btnChangeRegulation.TextOffset = new System.Drawing.Point(77, 0);
            this.btnChangeRegulation.Click += new System.EventHandler(this.btnChangeRegulation_Click);
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
            this.Report.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Report.Location = new System.Drawing.Point(0, 384);
            this.Report.Margin = new System.Windows.Forms.Padding(2);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(199, 36);
            this.Report.TabIndex = 16;
            this.Report.Text = "Report";
            this.Report.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Report.TextOffset = new System.Drawing.Point(77, 0);
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
            this.Employees.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Employees.Location = new System.Drawing.Point(0, 340);
            this.Employees.Margin = new System.Windows.Forms.Padding(2);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(199, 36);
            this.Employees.TabIndex = 14;
            this.Employees.Text = "Employees";
            this.Employees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Employees.TextOffset = new System.Drawing.Point(77, 0);
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
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
            this.Import.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Import.Location = new System.Drawing.Point(0, 294);
            this.Import.Margin = new System.Windows.Forms.Padding(2);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(199, 36);
            this.Import.TabIndex = 13;
            this.Import.Text = "Import";
            this.Import.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Import.TextOffset = new System.Drawing.Point(77, 0);
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.Image = global::GUI.Properties.Resources.coffee_bean__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(19, 11);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(34, 37);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // lbRole
            // 
            this.lbRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(72, 691);
            this.lbRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(78, 21);
            this.lbRole.TabIndex = 3;
            this.lbRole.Text = "Manager";
            // 
            // Log_out
            // 
            this.Log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Log_out.FillColor = System.Drawing.Color.Transparent;
            this.Log_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Log_out.ForeColor = System.Drawing.Color.White;
            this.Log_out.HoverState.FillColor = System.Drawing.Color.White;
            this.Log_out.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Log_out.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.Log_out.Location = new System.Drawing.Point(0, 744);
            this.Log_out.Margin = new System.Windows.Forms.Padding(2);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(198, 36);
            this.Log_out.TabIndex = 9;
            this.Log_out.Text = "Log out";
            this.Log_out.TextOffset = new System.Drawing.Point(15, 0);
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click);
            // 
            // Avatar
            // 
            this.Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Avatar.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Avatar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Avatar.Image = global::GUI.Properties.Resources.Ellipse_5;
            this.Avatar.ImageRotate = 0F;
            this.Avatar.Location = new System.Drawing.Point(16, 679);
            this.Avatar.Margin = new System.Windows.Forms.Padding(2);
            this.Avatar.Name = "Avatar";
            this.Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Avatar.Size = new System.Drawing.Size(40, 43);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avatar.TabIndex = 8;
            this.Avatar.TabStop = false;
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
            this.Settings.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Settings.Location = new System.Drawing.Point(0, 429);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(199, 36);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.TextOffset = new System.Drawing.Point(77, 0);
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
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
            this.Events.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Events.Location = new System.Drawing.Point(0, 249);
            this.Events.Margin = new System.Windows.Forms.Padding(2);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(199, 36);
            this.Events.TabIndex = 6;
            this.Events.Text = "Events";
            this.Events.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Events.TextOffset = new System.Drawing.Point(77, 0);
            this.Events.Click += new System.EventHandler(this.Events_Click);
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
            this.Tables.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Tables.Location = new System.Drawing.Point(0, 160);
            this.Tables.Margin = new System.Windows.Forms.Padding(2);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(199, 36);
            this.Tables.TabIndex = 5;
            this.Tables.Text = "Tables";
            this.Tables.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tables.TextOffset = new System.Drawing.Point(77, 0);
            this.Tables.Click += new System.EventHandler(this.Tables_Click);
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
            this.Bills.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Bills.Location = new System.Drawing.Point(0, 205);
            this.Bills.Margin = new System.Windows.Forms.Padding(2);
            this.Bills.Name = "Bills";
            this.Bills.Size = new System.Drawing.Size(199, 36);
            this.Bills.TabIndex = 5;
            this.Bills.Text = "Bills";
            this.Bills.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Bills.TextOffset = new System.Drawing.Point(77, 0);
            this.Bills.Click += new System.EventHandler(this.Bills_Click);
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
            this.Products.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Products.Location = new System.Drawing.Point(0, 115);
            this.Products.Margin = new System.Windows.Forms.Padding(2);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(199, 36);
            this.Products.TabIndex = 3;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Products.TextOffset = new System.Drawing.Point(77, 0);
            this.Products.Click += new System.EventHandler(this.Products_Click);
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
            this.Home.CustomImages.ImageOffset = new System.Drawing.Point(13, 0);
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
            this.Home.Location = new System.Drawing.Point(0, 71);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(199, 36);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.TextOffset = new System.Drawing.Point(77, 0);
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::GUI.Properties.Resources.CafeStore;
            this.pictureBox1.Location = new System.Drawing.Point(76, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // TabUC
            // 
            this.TabUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabUC.BackColor = System.Drawing.Color.Transparent;
            this.TabUC.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.TabUC, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TabUC.Location = new System.Drawing.Point(76, 0);
            this.TabUC.Margin = new System.Windows.Forms.Padding(2);
            this.TabUC.Name = "TabUC";
            this.TabUC.Size = new System.Drawing.Size(1124, 800);
            this.TabUC.TabIndex = 61;
            this.TabUC.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1272, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 17);
            this.guna2ControlBox1.TabIndex = 62;
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
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.IconColor = System.Drawing.Color.Brown;
            this.btnMinimize.Location = new System.Drawing.Point(1087, 11);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 17);
            this.btnMinimize.TabIndex = 63;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 200;
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // HomeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.TabUC);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeManager";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel Menu;
        private Guna.UI2.WinForms.Guna2Button Employees;
        private Guna.UI2.WinForms.Guna2Button Import;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lbRole;
        private Guna.UI2.WinForms.Guna2Button Log_out;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Avatar;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2Button Events;
        private Guna.UI2.WinForms.Guna2Button Tables;
        private Guna.UI2.WinForms.Guna2Button Bills;
        private Guna.UI2.WinForms.Guna2Button Products;
        private Guna.UI2.WinForms.Guna2Button Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel TabUC;
        private Guna.UI2.WinForms.Guna2Button Report;
        private System.Windows.Forms.Timer MouseDetect;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private static UCHome ucHome;
        private static UCProducts ucProducts;
        private static UCTables ucTables;
        private static UCBill ucBills;
        private static UCEvents ucEvents;
        private static UCImport ucImport;
        private static UCEmployees ucEmployees;
        private static UCChangeRegulations ucChangeRegulations;
        private Guna.UI2.WinForms.Guna2Button btnChangeRegulation;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        
    }
}