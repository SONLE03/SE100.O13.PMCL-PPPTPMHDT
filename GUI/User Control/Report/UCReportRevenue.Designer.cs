namespace GUI
{
    partial class UCReportRevenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.chartTotalRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridRevenue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExportToExcel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDate1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDate2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbSd = new System.Windows.Forms.Label();
            this.lbEd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRevenue)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = 15;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(700, 42);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.BorderRadius = 15;
            this.btnOK.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnOK.ShadowDecoration.Enabled = true;
            this.btnOK.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnOK.Size = new System.Drawing.Size(255, 47);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "Create report";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chartTotalRevenue
            // 
            this.chartTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTotalRevenue.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chartTotalRevenue.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea16.AxisX.IsMarginVisible = false;
            chartArea16.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea16.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea16.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MajorGrid.LineWidth = 0;
            chartArea16.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea16.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartArea16.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea16.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.InterlacedColor = System.Drawing.Color.Black;
            chartArea16.AxisY.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.LineWidth = 0;
            chartArea16.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea16.BackColor = System.Drawing.Color.White;
            chartArea16.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea16.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea16.Name = "ChartArea1";
            this.chartTotalRevenue.ChartAreas.Add(chartArea16);
            legend16.BackColor = System.Drawing.Color.White;
            legend16.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend16.IsTextAutoFit = false;
            legend16.Name = "Legend1";
            legend16.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            legend16.Title = "Revenue";
            legend16.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend16.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            legend16.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartTotalRevenue.Legends.Add(legend16);
            this.chartTotalRevenue.Location = new System.Drawing.Point(15, 12);
            this.chartTotalRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTotalRevenue.Name = "chartTotalRevenue";
            series16.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            series16.Legend = "Legend1";
            series16.LegendText = "By date";
            series16.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            series16.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series16.Name = "Series1";
            this.chartTotalRevenue.Series.Add(series16);
            this.chartTotalRevenue.Size = new System.Drawing.Size(1188, 596);
            this.chartTotalRevenue.TabIndex = 98;
            this.chartTotalRevenue.Text = "chart2";
            title16.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title16.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title16.Name = "Title1";
            title16.Text = "Total revenue";
            this.chartTotalRevenue.Titles.Add(title16);
            // 
            // gridRevenue
            // 
            this.gridRevenue.AllowUserToAddRows = false;
            this.gridRevenue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            this.gridRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.gridRevenue.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.gridRevenue.ColumnHeadersHeight = 4;
            this.gridRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRevenue.DefaultCellStyle = dataGridViewCellStyle48;
            this.gridRevenue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridRevenue.Location = new System.Drawing.Point(1107, 111);
            this.gridRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridRevenue.Name = "gridRevenue";
            this.gridRevenue.ReadOnly = true;
            this.gridRevenue.RowHeadersVisible = false;
            this.gridRevenue.RowHeadersWidth = 51;
            this.gridRevenue.RowTemplate.Height = 24;
            this.gridRevenue.Size = new System.Drawing.Size(240, 150);
            this.gridRevenue.TabIndex = 99;
            this.gridRevenue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridRevenue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridRevenue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridRevenue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridRevenue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridRevenue.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.gridRevenue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridRevenue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridRevenue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridRevenue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gridRevenue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridRevenue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridRevenue.ThemeStyle.HeaderStyle.Height = 4;
            this.gridRevenue.ThemeStyle.ReadOnly = true;
            this.gridRevenue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridRevenue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridRevenue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gridRevenue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridRevenue.ThemeStyle.RowsStyle.Height = 24;
            this.gridRevenue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridRevenue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridRevenue.Visible = false;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.BorderRadius = 15;
            this.btnExportToExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportToExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportToExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportToExcel.Location = new System.Drawing.Point(1024, 42);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.ShadowDecoration.BorderRadius = 15;
            this.btnExportToExcel.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnExportToExcel.ShadowDecoration.Enabled = true;
            this.btnExportToExcel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnExportToExcel.Size = new System.Drawing.Size(255, 47);
            this.btnExportToExcel.TabIndex = 106;
            this.btnExportToExcel.Text = "Export to excel";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.chartTotalRevenue);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(60, 142);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(1219, 614);
            this.guna2Panel1.TabIndex = 107;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderRadius = 15;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "DayOfMonth",
            "MonthOfYear",
            "Years"});
            this.cbType.Location = new System.Drawing.Point(60, 53);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(189, 36);
            this.cbType.TabIndex = 108;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbDate1
            // 
            this.cbDate1.BackColor = System.Drawing.Color.Transparent;
            this.cbDate1.BorderRadius = 15;
            this.cbDate1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDate1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDate1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDate1.ItemHeight = 30;
            this.cbDate1.Location = new System.Drawing.Point(285, 53);
            this.cbDate1.Name = "cbDate1";
            this.cbDate1.Size = new System.Drawing.Size(159, 36);
            this.cbDate1.TabIndex = 109;
            // 
            // cbDate2
            // 
            this.cbDate2.BackColor = System.Drawing.Color.Transparent;
            this.cbDate2.BorderRadius = 15;
            this.cbDate2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDate2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDate2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDate2.ItemHeight = 30;
            this.cbDate2.Location = new System.Drawing.Point(481, 53);
            this.cbDate2.Name = "cbDate2";
            this.cbDate2.Size = new System.Drawing.Size(159, 36);
            this.cbDate2.TabIndex = 110;
            // 
            // lbSd
            // 
            this.lbSd.AutoSize = true;
            this.lbSd.BackColor = System.Drawing.Color.Transparent;
            this.lbSd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbSd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.lbSd.Location = new System.Drawing.Point(281, 30);
            this.lbSd.Name = "lbSd";
            this.lbSd.Size = new System.Drawing.Size(78, 20);
            this.lbSd.TabIndex = 111;
            this.lbSd.Text = "Start date";
            // 
            // lbEd
            // 
            this.lbEd.AutoSize = true;
            this.lbEd.BackColor = System.Drawing.Color.Transparent;
            this.lbEd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.lbEd.Location = new System.Drawing.Point(477, 30);
            this.lbEd.Name = "lbEd";
            this.lbEd.Size = new System.Drawing.Size(70, 20);
            this.lbEd.TabIndex = 112;
            this.lbEd.Text = "End date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Type";
            // 
            // UCReportRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEd);
            this.Controls.Add(this.lbSd);
            this.Controls.Add(this.cbDate2);
            this.Controls.Add(this.cbDate1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gridRevenue);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCReportRevenue";
            this.Size = new System.Drawing.Size(1347, 806);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRevenue)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalRevenue;
        private Guna.UI2.WinForms.Guna2DataGridView gridRevenue;
        private Guna.UI2.WinForms.Guna2Button btnExportToExcel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private Guna.UI2.WinForms.Guna2ComboBox cbDate1;
        private Guna.UI2.WinForms.Guna2ComboBox cbDate2;
        private System.Windows.Forms.Label lbSd;
        private System.Windows.Forms.Label lbEd;
        private System.Windows.Forms.Label label1;
    }
}
