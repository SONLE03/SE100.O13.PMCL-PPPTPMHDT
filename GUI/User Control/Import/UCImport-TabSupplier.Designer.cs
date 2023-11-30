namespace GUI
{
    partial class UCImport_TabSupplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gridviewImportOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddIO = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IO_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_expense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewImportOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(331, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "These are list of all IOs in our store up to now ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Import order information";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 35;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.gridviewImportOrder);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(69, 145);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1539, 670);
            this.guna2Panel1.TabIndex = 59;
            // 
            // gridviewImportOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridviewImportOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewImportOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewImportOrder.ColumnHeadersHeight = 40;
            this.gridviewImportOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewImportOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IO_ID,
            this.IO_name,
            this.ImDate,
            this.Supplier_name,
            this.Quantity,
            this.Total_expense,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewImportOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewImportOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewImportOrder.Location = new System.Drawing.Point(3, 81);
            this.gridviewImportOrder.Name = "gridviewImportOrder";
            this.gridviewImportOrder.RowHeadersVisible = false;
            this.gridviewImportOrder.RowHeadersWidth = 50;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewImportOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewImportOrder.Size = new System.Drawing.Size(1533, 546);
            this.gridviewImportOrder.TabIndex = 43;
            this.gridviewImportOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewImportOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewImportOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewImportOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewImportOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewImportOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewImportOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewImportOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewImportOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewImportOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewImportOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewImportOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewImportOrder.ThemeStyle.HeaderStyle.Height = 40;
            this.gridviewImportOrder.ThemeStyle.ReadOnly = false;
            this.gridviewImportOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewImportOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewImportOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewImportOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewImportOrder.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewImportOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewImportOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddIO
            // 
            this.btnAddIO.BackColor = System.Drawing.Color.Transparent;
            this.btnAddIO.BorderRadius = 15;
            this.btnAddIO.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddIO.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddIO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddIO.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnAddIO.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIO.ForeColor = System.Drawing.Color.White;
            this.btnAddIO.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddIO.Location = new System.Drawing.Point(1439, 44);
            this.btnAddIO.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIO.Name = "btnAddIO";
            this.btnAddIO.Size = new System.Drawing.Size(169, 47);
            this.btnAddIO.TabIndex = 57;
            this.btnAddIO.Text = "Add IO";
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
            this.guna2Button1.Location = new System.Drawing.Point(72, 44);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(155, 47);
            this.guna2Button1.TabIndex = 56;
            this.guna2Button1.Text = "Search IO";
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
            this.txtSearch.Location = new System.Drawing.Point(223, 45);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search Import order";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(350, 47);
            this.txtSearch.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI.Properties.Resources.searches;
            this.pictureBox1.Location = new System.Drawing.Point(516, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // IO_ID
            // 
            this.IO_ID.FillWeight = 200F;
            this.IO_ID.HeaderText = "Import order ID";
            this.IO_ID.Name = "IO_ID";
            // 
            // IO_name
            // 
            this.IO_name.FillWeight = 200F;
            this.IO_name.HeaderText = "Import order name";
            this.IO_name.Name = "IO_name";
            // 
            // ImDate
            // 
            this.ImDate.FillWeight = 200F;
            this.ImDate.HeaderText = "Import date";
            this.ImDate.Name = "ImDate";
            // 
            // Supplier_name
            // 
            this.Supplier_name.FillWeight = 200F;
            this.Supplier_name.HeaderText = "Supplier name";
            this.Supplier_name.Name = "Supplier_name";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 150F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total_expense
            // 
            this.Total_expense.FillWeight = 200F;
            this.Total_expense.HeaderText = "Total expense";
            this.Total_expense.Name = "Total_expense";
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
            // UCImport_TabSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddIO);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtSearch);
            this.Name = "UCImport_TabSupplier";
            this.Size = new System.Drawing.Size(1677, 858);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewImportOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewImportOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddIO;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IO_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_expense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}
