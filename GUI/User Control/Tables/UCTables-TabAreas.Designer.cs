namespace GUI
{
    partial class UCTables_TabAreas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gridviewArea = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Area_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddArea = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Area information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "These are list of all areas in our store up to now ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 35;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.gridviewArea);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(73, 144);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1539, 670);
            this.guna2Panel1.TabIndex = 49;
            // 
            // gridviewArea
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridviewArea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewArea.ColumnHeadersHeight = 40;
            this.gridviewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Area_ID,
            this.Area_name,
            this.Surcharge,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewArea.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewArea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewArea.Location = new System.Drawing.Point(3, 81);
            this.gridviewArea.Name = "gridviewArea";
            this.gridviewArea.RowHeadersVisible = false;
            this.gridviewArea.RowHeadersWidth = 50;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewArea.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewArea.Size = new System.Drawing.Size(1533, 546);
            this.gridviewArea.TabIndex = 43;
            this.gridviewArea.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewArea.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewArea.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewArea.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewArea.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewArea.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewArea.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewArea.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewArea.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewArea.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewArea.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewArea.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewArea.ThemeStyle.HeaderStyle.Height = 40;
            this.gridviewArea.ThemeStyle.ReadOnly = false;
            this.gridviewArea.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewArea.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewArea.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewArea.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewArea.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewArea.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewArea.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Area_ID
            // 
            this.Area_ID.FillWeight = 150F;
            this.Area_ID.HeaderText = "Area ID";
            this.Area_ID.Name = "Area_ID";
            // 
            // Area_name
            // 
            this.Area_name.FillWeight = 150F;
            this.Area_name.HeaderText = "Area name";
            this.Area_name.Name = "Area_name";
            // 
            // Surcharge
            // 
            this.Surcharge.HeaderText = "Surcharge";
            this.Surcharge.Name = "Surcharge";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // btnAddArea
            // 
            this.btnAddArea.BackColor = System.Drawing.Color.Transparent;
            this.btnAddArea.BorderRadius = 15;
            this.btnAddArea.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddArea.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddArea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddArea.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddArea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddArea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddArea.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArea.ForeColor = System.Drawing.Color.White;
            this.btnAddArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddArea.Location = new System.Drawing.Point(1443, 43);
            this.btnAddArea.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(169, 47);
            this.btnAddArea.TabIndex = 47;
            this.btnAddArea.Text = "Add area";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(75, 43);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(97, 47);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "All area";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.Gray;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(168, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search area";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(350, 47);
            this.txtSearch.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI.Properties.Resources.searches;
            this.pictureBox1.Location = new System.Drawing.Point(458, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // UCTables_TabAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtSearch);
            this.Name = "UCTables_TabAreas";
            this.Size = new System.Drawing.Size(1677, 858);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddArea;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}
