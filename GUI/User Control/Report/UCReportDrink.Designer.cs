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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chartDrinkColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridDrinkReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Drink_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDrinkDoughnut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportToExcel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrinkReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkDoughnut)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AnimatedGIF = true;
            this.btnOK.AutoRoundedCorners = true;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = 22;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnOK.Location = new System.Drawing.Point(428, 41);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.BorderRadius = 15;
            this.btnOK.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnOK.ShadowDecoration.Enabled = true;
            this.btnOK.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnOK.Size = new System.Drawing.Size(79, 47);
            this.btnOK.TabIndex = 99;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.dtpDate.BorderRadius = 10;
            this.dtpDate.BorderThickness = 1;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(63, 41);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(336, 47);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2023, 11, 28, 20, 41, 51, 410);
            // 
            // chartDrinkColumn
            // 
            this.chartDrinkColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDrinkColumn.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartDrinkColumn.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            legend1.Title = "Revenue";
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            legend1.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartDrinkColumn.Legends.Add(legend1);
            this.chartDrinkColumn.Location = new System.Drawing.Point(19, 12);
            this.chartDrinkColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDrinkColumn.Name = "chartDrinkColumn";
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.LegendText = "Drinks";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chartDrinkColumn.Series.Add(series1);
            this.chartDrinkColumn.Size = new System.Drawing.Size(733, 596);
            this.chartDrinkColumn.TabIndex = 102;
            this.chartDrinkColumn.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Revenue of drinks";
            this.chartDrinkColumn.Titles.Add(title1);
            this.chartDrinkColumn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartDrinkColumn_MouseMove);
            // 
            // gridDrinkReport
            // 
            this.gridDrinkReport.AllowUserToAddRows = false;
            this.gridDrinkReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDrinkReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDrinkReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDrinkReport.ColumnHeadersHeight = 18;
            this.gridDrinkReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDrinkReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drink_Name,
            this.Quantity,
            this.Total_Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDrinkReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDrinkReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDrinkReport.Location = new System.Drawing.Point(931, 185);
            this.gridDrinkReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridDrinkReport.Name = "gridDrinkReport";
            this.gridDrinkReport.ReadOnly = true;
            this.gridDrinkReport.RowHeadersVisible = false;
            this.gridDrinkReport.RowHeadersWidth = 51;
            this.gridDrinkReport.RowTemplate.Height = 24;
            this.gridDrinkReport.Size = new System.Drawing.Size(397, 175);
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
            this.gridDrinkReport.Visible = false;
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
            this.chartDrinkDoughnut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDrinkDoughnut.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chartDrinkDoughnut.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea2.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.chartDrinkDoughnut.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.ShadowColor = System.Drawing.Color.White;
            legend2.Title = "Revenue percent (%)";
            legend2.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            legend2.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartDrinkDoughnut.Legends.Add(legend2);
            this.chartDrinkDoughnut.Location = new System.Drawing.Point(16, 12);
            this.chartDrinkDoughnut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDrinkDoughnut.Name = "chartDrinkDoughnut";
            this.chartDrinkDoughnut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartDrinkDoughnut.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Tomato,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.DeepSkyBlue};
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.LegendText = "Drink name";
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartDrinkDoughnut.Series.Add(series2);
            this.chartDrinkDoughnut.Size = new System.Drawing.Size(412, 596);
            this.chartDrinkDoughnut.TabIndex = 104;
            this.chartDrinkDoughnut.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Top best selling";
            this.chartDrinkDoughnut.Titles.Add(title2);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.AnimatedGIF = true;
            this.btnExportToExcel.AutoRoundedCorners = true;
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.BorderRadius = 22;
            this.btnExportToExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportToExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportToExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportToExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnExportToExcel.Location = new System.Drawing.Point(1021, 41);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.ShadowDecoration.BorderRadius = 15;
            this.btnExportToExcel.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnExportToExcel.ShadowDecoration.Enabled = true;
            this.btnExportToExcel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnExportToExcel.Size = new System.Drawing.Size(269, 47);
            this.btnExportToExcel.TabIndex = 105;
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
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.chartDrinkColumn);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(56, 135);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(764, 628);
            this.guna2Panel1.TabIndex = 106;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.chartDrinkDoughnut);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(844, 135);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.guna2Panel2.Size = new System.Drawing.Size(447, 628);
            this.guna2Panel2.TabIndex = 107;
            // 
            // UCReportDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gridDrinkReport);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCReportDrink";
            this.Size = new System.Drawing.Size(1347, 806);
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrinkReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinkDoughnut)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDrinkColumn;
        private Guna.UI2.WinForms.Guna2DataGridView gridDrinkReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drink_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDrinkDoughnut;
        private Guna.UI2.WinForms.Guna2Button btnExportToExcel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
