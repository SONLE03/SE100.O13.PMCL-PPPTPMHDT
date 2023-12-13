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
            this.btnCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbAreaID = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTableID = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboboxArea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bthDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.radioBtnEmpty = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.radioBtnInUse = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.radioBtnRepair = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            this.panelTableID.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCreate.Location = new System.Drawing.Point(288, 449);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 30);
            this.btnCreate.TabIndex = 157;
            this.btnCreate.Text = "Update";
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
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.radioBtnRepair);
            this.guna2Panel2.Controls.Add(this.radioBtnInUse);
            this.guna2Panel2.Controls.Add(this.radioBtnEmpty);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(139, 279);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(223, 140);
            this.guna2Panel2.TabIndex = 156;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(128, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "In use";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label6.Location = new System.Drawing.Point(140, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 155;
            this.label6.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label3.Location = new System.Drawing.Point(141, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 154;
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
            this.panelTableID.Location = new System.Drawing.Point(139, 90);
            this.panelTableID.Margin = new System.Windows.Forms.Padding(2);
            this.panelTableID.Name = "panelTableID";
            this.panelTableID.Size = new System.Drawing.Size(223, 32);
            this.panelTableID.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(141, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 152;
            this.label2.Text = "Table ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 151;
            this.label1.Text = "Edit Table ";
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
            this.txtTableName.Location = new System.Drawing.Point(138, 161);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTableName.PlaceholderText = "Enter table name";
            this.txtTableName.SelectedText = "";
            this.txtTableName.Size = new System.Drawing.Size(223, 32);
            this.txtTableName.TabIndex = 160;
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
            this.comboboxArea.Location = new System.Drawing.Point(249, 219);
            this.comboboxArea.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxArea.Name = "comboboxArea";
            this.comboboxArea.Size = new System.Drawing.Size(113, 36);
            this.comboboxArea.TabIndex = 159;
            // 
            // bthDelete
            // 
            this.bthDelete.BackColor = System.Drawing.Color.Transparent;
            this.bthDelete.BorderRadius = 10;
            this.bthDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bthDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bthDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bthDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bthDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bthDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.bthDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.bthDelete.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bthDelete.ForeColor = System.Drawing.Color.White;
            this.bthDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bthDelete.Location = new System.Drawing.Point(138, 449);
            this.bthDelete.Margin = new System.Windows.Forms.Padding(2);
            this.bthDelete.Name = "bthDelete";
            this.bthDelete.Size = new System.Drawing.Size(74, 30);
            this.bthDelete.TabIndex = 158;
            this.bthDelete.Text = "Delete";
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(423, 11);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(455, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 161;
            // 
            // radioBtnEmpty
            // 
            this.radioBtnEmpty.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnEmpty.CheckedState.BorderThickness = 0;
            this.radioBtnEmpty.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnEmpty.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnEmpty.Location = new System.Drawing.Point(47, 32);
            this.radioBtnEmpty.Name = "radioBtnEmpty";
            this.radioBtnEmpty.Size = new System.Drawing.Size(28, 28);
            this.radioBtnEmpty.TabIndex = 52;
            this.radioBtnEmpty.Text = "guna2CustomRadioButton1";
            this.radioBtnEmpty.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnEmpty.UncheckedState.BorderThickness = 2;
            this.radioBtnEmpty.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnEmpty.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioBtnInUse
            // 
            this.radioBtnInUse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnInUse.CheckedState.BorderThickness = 0;
            this.radioBtnInUse.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnInUse.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnInUse.Location = new System.Drawing.Point(47, 66);
            this.radioBtnInUse.Name = "radioBtnInUse";
            this.radioBtnInUse.Size = new System.Drawing.Size(28, 28);
            this.radioBtnInUse.TabIndex = 53;
            this.radioBtnInUse.Text = "guna2CustomRadioButton2";
            this.radioBtnInUse.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnInUse.UncheckedState.BorderThickness = 2;
            this.radioBtnInUse.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnInUse.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioBtnRepair
            // 
            this.radioBtnRepair.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnRepair.CheckedState.BorderThickness = 0;
            this.radioBtnRepair.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnRepair.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnRepair.Location = new System.Drawing.Point(47, 100);
            this.radioBtnRepair.Name = "radioBtnRepair";
            this.radioBtnRepair.Size = new System.Drawing.Size(28, 28);
            this.radioBtnRepair.TabIndex = 54;
            this.radioBtnRepair.Text = "guna2CustomRadioButton3";
            this.radioBtnRepair.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnRepair.UncheckedState.BorderThickness = 2;
            this.radioBtnRepair.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnRepair.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(122)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(125, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Empty";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(128, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Repair";
            // 
            // EditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 515);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTableID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.comboboxArea);
            this.Controls.Add(this.bthDelete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTable";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panelTableID.ResumeLayout(false);
            this.panelTableID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnCreate;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelTableID;
        private System.Windows.Forms.Label lbAreaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTableName;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxArea;
        private Guna.UI2.WinForms.Guna2GradientButton bthDelete;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioBtnRepair;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioBtnInUse;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioBtnEmpty;
    }
}