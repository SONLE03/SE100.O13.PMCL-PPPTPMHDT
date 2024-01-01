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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.btnOK.BorderRadius = 18;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnOK.Location = new System.Drawing.Point(321, 33);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.BorderRadius = 15;
            this.btnOK.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnOK.ShadowDecoration.Enabled = true;
            this.btnOK.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnOK.Size = new System.Drawing.Size(59, 38);
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
            this.dtpDate.Location = new System.Drawing.Point(47, 33);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(252, 38);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2023, 11, 28, 20, 41, 51, 410);
            // 
            // chartDrinkColumn
            // 
            this.chartDrinkColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDrinkColumn.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea3.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.chartDrinkColumn.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.White;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            legend3.Title = "Revenue";
            legend3.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            legend3.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartDrinkColumn.Legends.Add(legend3);
            this.chartDrinkColumn.Location = new System.Drawing.Point(14, 10);
            this.chartDrinkColumn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDrinkColumn.Name = "chartDrinkColumn";
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            series3.BorderColor = System.Drawing.Color.White;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            series3.LabelBackColor = System.Drawing.Color.Black;
            series3.LabelBorderColor = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.LegendText = "Drinks";
            series3.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series1";
            this.chartDrinkColumn.Series.Add(series3);
            this.chartDrinkColumn.Size = new System.Drawing.Size(550, 484);
            this.chartDrinkColumn.TabIndex = 102;
            this.chartDrinkColumn.Text = "chart2";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Revenue of drinks";
            this.chartDrinkColumn.Titles.Add(title3);
            this.chartDrinkColumn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartDrinkColumn_MouseMove);
            // 
            // gridDrinkReport
            // 
            this.gridDrinkReport.AllowUserToAddRows = false;
            this.gridDrinkReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridDrinkReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDrinkReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDrinkReport.ColumnHeadersHeight = 18;
            this.gridDrinkReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDrinkReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drink_Name,
            this.Quantity,
            this.Total_Price});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDrinkReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridDrinkReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDrinkReport.Location = new System.Drawing.Point(698, 150);
            this.gridDrinkReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridDrinkReport.Name = "gridDrinkReport";
            this.gridDrinkReport.ReadOnly = true;
            this.gridDrinkReport.RowHeadersVisible = false;
            this.gridDrinkReport.RowHeadersWidth = 51;
            this.gridDrinkReport.RowTemplate.Height = 24;
            this.gridDrinkReport.Size = new System.Drawing.Size(298, 142);
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
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea4.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineWidth = 0;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineWidth = 0;
            chartArea4.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea4.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea4.Name = "ChartArea1";
            this.chartDrinkDoughnut.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.BackColor = System.Drawing.Color.White;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.ShadowColor = System.Drawing.Color.White;
            legend4.Title = "Revenue percent (%)";
            legend4.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            legend4.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartDrinkDoughnut.Legends.Add(legend4);
            this.chartDrinkDoughnut.Location = new System.Drawing.Point(12, 10);
            this.chartDrinkDoughnut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDrinkDoughnut.Name = "chartDrinkDoughnut";
            this.chartDrinkDoughnut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartDrinkDoughnut.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Tomato,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.DeepSkyBlue};
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.LegendText = "Drink name";
            series4.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartDrinkDoughnut.Series.Add(series4);
            this.chartDrinkDoughnut.Size = new System.Drawing.Size(309, 484);
            this.chartDrinkDoughnut.TabIndex = 104;
            this.chartDrinkDoughnut.Text = "chart2";
            title4.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Top best selling";
            this.chartDrinkDoughnut.Titles.Add(title4);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.AnimatedGIF = true;
            this.btnExportToExcel.AutoRoundedCorners = true;
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.BorderRadius = 18;
            this.btnExportToExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportToExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportToExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(128)))), ((int)(((byte)(76)))));
            this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportToExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.btnExportToExcel.Location = new System.Drawing.Point(766, 33);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.ShadowDecoration.BorderRadius = 15;
            this.btnExportToExcel.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnExportToExcel.ShadowDecoration.Enabled = true;
            this.btnExportToExcel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 8, 8);
            this.btnExportToExcel.Size = new System.Drawing.Size(202, 38);
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
            this.guna2Panel1.Location = new System.Drawing.Point(42, 110);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(573, 510);
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
            this.guna2Panel2.Location = new System.Drawing.Point(633, 110);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.guna2Panel2.Size = new System.Drawing.Size(335, 510);
            this.guna2Panel2.TabIndex = 107;
            // 
            // UCReportDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCReportDrink";
            this.Size = new System.Drawing.Size(1010, 655);
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
