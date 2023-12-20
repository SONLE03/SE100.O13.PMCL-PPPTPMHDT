namespace GUI
{
    partial class UserGroupDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGroupDetails));
            this.label10 = new System.Windows.Forms.Label();
            this.lbGUID = new System.Windows.Forms.Label();
            this.panelUserGroupID = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gridService = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MF_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Screen_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCanel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelUserGroupName = new Guna.UI2.WinForms.Guna2Panel();
            this.lbGUName = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panelUserGroupID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridService)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.panelUserGroupName.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label10.Location = new System.Drawing.Point(124, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 178;
            this.label10.Text = "User Group Name";
            // 
            // lbGUID
            // 
            this.lbGUID.AutoSize = true;
            this.lbGUID.BackColor = System.Drawing.Color.Transparent;
            this.lbGUID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGUID.ForeColor = System.Drawing.Color.Gray;
            this.lbGUID.Location = new System.Drawing.Point(5, 9);
            this.lbGUID.Name = "lbGUID";
            this.lbGUID.Size = new System.Drawing.Size(59, 23);
            this.lbGUID.TabIndex = 49;
            this.lbGUID.Text = "UG001";
            // 
            // panelUserGroupID
            // 
            this.panelUserGroupID.BackColor = System.Drawing.Color.Transparent;
            this.panelUserGroupID.BorderColor = System.Drawing.Color.Silver;
            this.panelUserGroupID.BorderRadius = 10;
            this.panelUserGroupID.BorderThickness = 2;
            this.panelUserGroupID.Controls.Add(this.lbGUID);
            this.panelUserGroupID.FillColor = System.Drawing.Color.White;
            this.panelUserGroupID.Location = new System.Drawing.Point(123, 118);
            this.panelUserGroupID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserGroupID.Name = "panelUserGroupID";
            this.panelUserGroupID.Size = new System.Drawing.Size(461, 39);
            this.panelUserGroupID.TabIndex = 177;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(240, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 172;
            this.label1.Text = "User group Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(23, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "List of managed functions";
            // 
            // gridService
            // 
            this.gridService.AllowUserToAddRows = false;
            this.gridService.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridService.ColumnHeadersHeight = 30;
            this.gridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MF_ID,
            this.Function_Name,
            this.Screen_Name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridService.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridService.Location = new System.Drawing.Point(4, 33);
            this.gridService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridService.Name = "gridService";
            this.gridService.ReadOnly = true;
            this.gridService.RowHeadersVisible = false;
            this.gridService.RowHeadersWidth = 50;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridService.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridService.Size = new System.Drawing.Size(453, 222);
            this.gridService.TabIndex = 40;
            this.gridService.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridService.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridService.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridService.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridService.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridService.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridService.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridService.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridService.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridService.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridService.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridService.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridService.ThemeStyle.HeaderStyle.Height = 30;
            this.gridService.ThemeStyle.ReadOnly = true;
            this.gridService.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridService.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridService.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridService.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridService.ThemeStyle.RowsStyle.Height = 22;
            this.gridService.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridService.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MF_ID
            // 
            this.MF_ID.FillWeight = 15F;
            this.MF_ID.HeaderText = "MF ID";
            this.MF_ID.MinimumWidth = 6;
            this.MF_ID.Name = "MF_ID";
            this.MF_ID.ReadOnly = true;
            // 
            // Function_Name
            // 
            this.Function_Name.FillWeight = 30F;
            this.Function_Name.HeaderText = "Function Name";
            this.Function_Name.MinimumWidth = 6;
            this.Function_Name.Name = "Function_Name";
            this.Function_Name.ReadOnly = true;
            // 
            // Screen_Name
            // 
            this.Screen_Name.FillWeight = 20F;
            this.Screen_Name.HeaderText = "Screen Name";
            this.Screen_Name.MinimumWidth = 6;
            this.Screen_Name.Name = "Screen_Name";
            this.Screen_Name.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(125, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 173;
            this.label2.Text = "User Group ID";
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.Transparent;
            this.btnCanel.BorderRadius = 10;
            this.btnCanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnCanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(90)))), ((int)(((byte)(21)))));
            this.btnCanel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnCanel.ForeColor = System.Drawing.Color.White;
            this.btnCanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCanel.Location = new System.Drawing.Point(227, 601);
            this.btnCanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(247, 37);
            this.btnCanel.TabIndex = 176;
            this.btnCanel.Text = "Cancel";
            this.btnCanel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderRadius = 35;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label14);
            this.guna2Panel2.Controls.Add(this.gridService);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(123, 283);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(461, 281);
            this.guna2Panel2.TabIndex = 174;
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
            // panelUserGroupName
            // 
            this.panelUserGroupName.BackColor = System.Drawing.Color.Transparent;
            this.panelUserGroupName.BorderColor = System.Drawing.Color.Silver;
            this.panelUserGroupName.BorderRadius = 10;
            this.panelUserGroupName.BorderThickness = 2;
            this.panelUserGroupName.Controls.Add(this.lbGUName);
            this.panelUserGroupName.FillColor = System.Drawing.Color.White;
            this.panelUserGroupName.Location = new System.Drawing.Point(123, 199);
            this.panelUserGroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserGroupName.Name = "panelUserGroupName";
            this.panelUserGroupName.Size = new System.Drawing.Size(461, 39);
            this.panelUserGroupName.TabIndex = 179;
            // 
            // lbGUName
            // 
            this.lbGUName.AutoSize = true;
            this.lbGUName.BackColor = System.Drawing.Color.Transparent;
            this.lbGUName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGUName.ForeColor = System.Drawing.Color.Gray;
            this.lbGUName.Location = new System.Drawing.Point(5, 9);
            this.lbGUName.Name = "lbGUName";
            this.lbGUName.Size = new System.Drawing.Size(79, 23);
            this.lbGUName.TabIndex = 49;
            this.lbGUName.Text = "Manager";
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(595, 14);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 181;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(640, 14);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label4.Location = new System.Drawing.Point(30, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 182;
            this.label4.Text = "Status";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lbStatus);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(33, 71);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(461, 39);
            this.guna2Panel1.TabIndex = 180;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lbStatus.Location = new System.Drawing.Point(5, 9);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 23);
            this.lbStatus.TabIndex = 49;
            this.lbStatus.Text = "Status";
            // 
            // UserGroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 666);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panelUserGroupName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelUserGroupID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.guna2Panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserGroupDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserGroupDetails";
            this.panelUserGroupID.ResumeLayout(false);
            this.panelUserGroupID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridService)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panelUserGroupName.ResumeLayout(false);
            this.panelUserGroupName.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbGUID;
        private Guna.UI2.WinForms.Guna2Panel panelUserGroupID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView gridService;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnCanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelUserGroupName;
        private System.Windows.Forms.Label lbGUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MF_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Screen_Name;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label4;
    }
}