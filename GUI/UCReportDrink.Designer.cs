namespace GUI
{
    partial class UCReportDrink
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chartDrinkColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridDrinkReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Drink_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDrinkDoughnut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportToExcel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrinkReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkDoughnut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 15;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(817, 36);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 47);
            this.btnOK.TabIndex = 99;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.dtpDate);
            this.guna2Panel5.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2Panel5.Location = new System.Drawing.Point(545, 36);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(224, 47);
            this.guna2Panel5.TabIndex = 101;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.dtpDate.BorderRadius = 10;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(12, 5);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(197, 34);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2023, 11, 28, 20, 41, 51, 410);
            // 
            // chartDrinkColumn
            // 
            this.chartDrinkColumn.BackColor = System.Drawing.Color.DarkViolet;
            this.chartDrinkColumn.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chartDrinkColumn.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea7.AxisX.IsMarginVisible = false;
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea7.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineWidth = 0;
            chartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineWidth = 0;
            chartArea7.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.DarkViolet;
            chartArea7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea7.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea7.Name = "ChartArea1";
            this.chartDrinkColumn.ChartAreas.Add(chartArea7);
            legend7.BackColor = System.Drawing.Color.DarkViolet;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.Name = "Legend1";
            legend7.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            legend7.Title = "Doanh thu";
            legend7.TitleForeColor = System.Drawing.Color.Aqua;
            legend7.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartDrinkColumn.Legends.Add(legend7);
            this.chartDrinkColumn.Location = new System.Drawing.Point(75, 127);
            this.chartDrinkColumn.Name = "chartDrinkColumn";
            series7.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series7.Legend = "Legend1";
            series7.LegendText = "Theo thời gian";
            series7.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Series1";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartDrinkColumn.Series.Add(series7);
            this.chartDrinkColumn.Size = new System.Drawing.Size(637, 496);
            this.chartDrinkColumn.TabIndex = 102;
            this.chartDrinkColumn.Text = "chart2";
            title7.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title7.ForeColor = System.Drawing.Color.White;
            title7.Name = "Title1";
            title7.Text = "Tổng Nguyên liệu";
            this.chartDrinkColumn.Titles.Add(title7);
            // 
            // gridDrinkReport
            // 
            this.gridDrinkReport.AllowUserToAddRows = false;
            this.gridDrinkReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridDrinkReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDrinkReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridDrinkReport.ColumnHeadersHeight = 18;
            this.gridDrinkReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDrinkReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drink_Name,
            this.Quantity,
            this.Total_Price});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDrinkReport.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridDrinkReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDrinkReport.Location = new System.Drawing.Point(947, 3);
            this.gridDrinkReport.Name = "gridDrinkReport";
            this.gridDrinkReport.ReadOnly = true;
            this.gridDrinkReport.RowHeadersVisible = false;
            this.gridDrinkReport.RowHeadersWidth = 51;
            this.gridDrinkReport.RowTemplate.Height = 24;
            this.gridDrinkReport.Size = new System.Drawing.Size(422, 236);
            this.gridDrinkReport.TabIndex = 103;
            this.gridDrinkReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDrinkReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDrinkReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDrinkReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDrinkReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDrinkReport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDrinkReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDrinkReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridDrinkReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridDrinkReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gridDrinkReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridDrinkReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDrinkReport.ThemeStyle.HeaderStyle.Height = 18;
            this.gridDrinkReport.ThemeStyle.ReadOnly = true;
            this.gridDrinkReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDrinkReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDrinkReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gridDrinkReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridDrinkReport.ThemeStyle.RowsStyle.Height = 24;
            this.gridDrinkReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDrinkReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Drink_Name
            // 
            this.Drink_Name.HeaderText = "Drink Name";
            this.Drink_Name.MinimumWidth = 6;
            this.Drink_Name.Name = "Drink_Name";
            this.Drink_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.MinimumWidth = 6;
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            // 
            // chartDrinkDoughnut
            // 
            this.chartDrinkDoughnut.BackColor = System.Drawing.Color.DarkViolet;
            this.chartDrinkDoughnut.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chartDrinkDoughnut.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea8.AxisX.IsMarginVisible = false;
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea8.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.LineWidth = 0;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineWidth = 0;
            chartArea8.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.DarkViolet;
            chartArea8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea8.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea8.Name = "ChartArea1";
            this.chartDrinkDoughnut.ChartAreas.Add(chartArea8);
            legend8.BackColor = System.Drawing.Color.DarkViolet;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.ForeColor = System.Drawing.Color.White;
            legend8.Name = "Legend1";
            legend8.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            legend8.Title = "Doanh thu";
            legend8.TitleForeColor = System.Drawing.Color.Aqua;
            legend8.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartDrinkDoughnut.Legends.Add(legend8);
            this.chartDrinkDoughnut.Location = new System.Drawing.Point(817, 267);
            this.chartDrinkDoughnut.Name = "chartDrinkDoughnut";
            series8.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series8.Legend = "Legend1";
            series8.LegendText = "Theo thời gian";
            series8.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Series1";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartDrinkDoughnut.Series.Add(series8);
            this.chartDrinkDoughnut.Size = new System.Drawing.Size(503, 426);
            this.chartDrinkDoughnut.TabIndex = 104;
            this.chartDrinkDoughnut.Text = "chart2";
            title8.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title8.ForeColor = System.Drawing.Color.White;
            title8.Name = "Title1";
            title8.Text = "Tổng Nguyên liệu";
            this.chartDrinkDoughnut.Titles.Add(title8);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BorderRadius = 15;
            this.btnExportToExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportToExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportToExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportToExcel.Location = new System.Drawing.Point(190, 28);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(270, 47);
            this.btnExportToExcel.TabIndex = 105;
            this.btnExportToExcel.Text = "Export to excel";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // UCReportDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.chartDrinkDoughnut);
            this.Controls.Add(this.gridDrinkReport);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.chartDrinkColumn);
            this.Name = "UCReportDrink";
            this.Size = new System.Drawing.Size(1856, 752);
            this.guna2Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrinkReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkDoughnut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDrinkColumn;
        private Guna.UI2.WinForms.Guna2DataGridView gridDrinkReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drink_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDrinkDoughnut;
        private Guna.UI2.WinForms.Guna2Button btnExportToExcel;
    }
}
