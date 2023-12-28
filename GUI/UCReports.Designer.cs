namespace GUI
{
    partial class UCReports
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
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chartTotalRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).BeginInit();
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
            this.btnOK.Location = new System.Drawing.Point(921, 14);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 47);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbEndDate
            // 
            this.lbEndDate.BackColor = System.Drawing.Color.GhostWhite;
            this.lbEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbEndDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbEndDate.Location = new System.Drawing.Point(189, 73);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(197, 34);
            this.lbEndDate.TabIndex = 42;
            this.lbEndDate.Text = "29 Nov 2023";
            this.lbEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.dtpStartDate);
            this.guna2Panel5.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2Panel5.Location = new System.Drawing.Point(437, 14);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(224, 47);
            this.guna2Panel5.TabIndex = 22;
            // 
            // lbStartDate
            // 
            this.lbStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStartDate.BackColor = System.Drawing.Color.GhostWhite;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbStartDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbStartDate.Location = new System.Drawing.Point(160, 27);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(197, 34);
            this.lbStartDate.TabIndex = 28;
            this.lbStartDate.Text = "29 Nov 2023";
            this.lbStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.dtpStartDate.BorderRadius = 10;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(12, 5);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(197, 34);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.Value = new System.DateTime(2023, 11, 28, 20, 41, 51, 410);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.dtpEndDate);
            this.guna2Panel4.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2Panel4.Location = new System.Drawing.Point(677, 14);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(224, 47);
            this.guna2Panel4.TabIndex = 21;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BackColor = System.Drawing.Color.GhostWhite;
            this.dtpEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(26)))));
            this.dtpEndDate.BorderRadius = 10;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.GhostWhite;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(16, 5);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(195, 34);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.Value = new System.DateTime(2023, 11, 28, 20, 41, 51, 410);
            // 
            // chartTotalRevenue
            // 
            this.chartTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTotalRevenue.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea3.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
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
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.chartTotalRevenue.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.White;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.White;
            legend3.Title = "Revenue";
            legend3.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend3.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend3.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartTotalRevenue.Legends.Add(legend3);
            this.chartTotalRevenue.Location = new System.Drawing.Point(83, 186);
            this.chartTotalRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTotalRevenue.Name = "chartTotalRevenue";
            series3.BackSecondaryColor = System.Drawing.Color.MediumTurquoise;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(91)))), ((int)(((byte)(170)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(91)))), ((int)(((byte)(170)))));
            series3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.LegendText = "Over time";
            series3.MarkerColor = System.Drawing.Color.LavenderBlush;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series1";
            this.chartTotalRevenue.Series.Add(series3);
            this.chartTotalRevenue.Size = new System.Drawing.Size(1290, 613);
            this.chartTotalRevenue.TabIndex = 28;
            this.chartTotalRevenue.Text = "chart2";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            title3.Name = "Title1";
            title3.Text = "Total Revenue";
            this.chartTotalRevenue.Titles.Add(title3);
            // 
            // UCReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.chartTotalRevenue);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCReports";
            this.Size = new System.Drawing.Size(1499, 985);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOK;
        private System.Windows.Forms.Label lbEndDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label lbStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalRevenue;
    }
}
