using BUS;
using DTO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class UCReportDrink : UserControl
    {
        List<DrinkReportDTO> drinkReportsForChart = new List<DrinkReportDTO>();
        DateTime reportDate;
        public UCReportDrink()
        {
            InitializeComponent();
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MMMM yyyy";
         
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadData(dtpDate.Value);
            reportDate = dtpDate.Value;
        }
        private void ExportToExcel(DateTime date)
        {
            try
            {
                // Data
                List<DrinkReportDTO> drinkReports = drinkReportsForChart;
                if (drinkReports.Count == 0)
                {
                    MessageBox.Show("No data available this month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                string filePath = "";

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = dialog.FileName;
                    }
                }

                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Invalid report path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Author = "Reporter";
                    p.Workbook.Properties.Title = "Drink Report";
                    ExcelWorksheet ws = p.Workbook.Worksheets.Add("Sheet1");

                    // Title
                    ws.Cells["A1"].Value = $"Sales of {date.ToString("MMMM")} {date.Year}";
                    ws.Cells["A1"].Style.Font.Bold = true;
                    ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells["A1:C1"].Merge = true;

                    var user = BUSUser.Instance.GetUserById(BUSUser.Instance.idUserLogin);
                    // Report Date and Reporter
                    ws.Cells["A3"].Value = "Reporter: " + user.UserID + " | " + user.UserFullName;
                    ws.Cells["A3"].Style.Font.Bold = true;
                    ws.Cells["A3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["A3:C3"].Merge = true;

                    ws.Cells["A4"].Value = "Report date: " + DateTime.Now.ToString("dd/MM/yyyy");
                    ws.Cells["A4"].Style.Font.Bold = true;
                    ws.Cells["A4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["A4:C4"].Merge = true;

                    // Headers
                    string[] arrColumnHeader = { "Drink Name", "Quantity", "Total Price (VNĐ)" };
                    ws.Cells["A6:C6"].LoadFromArrays(new List<string[]> { arrColumnHeader });

                    using (var headerRange = ws.Cells["A6:C6"])
                    {
                        headerRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Center align
                        headerRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Center vertically
                        headerRange.Style.Font.Bold = true; // Make text bold
                    }

                    //Data
                    var modifiedDrinkReports = drinkReports.Select(report => new
                    {
                        drinkName = report.drinkName,
                        drinkQuantity = report.drinkQuantity,
                        drinkTotalPrice = report.drinkTotalPrice
                    }).ToList();

                    ws.Cells["A7"].LoadFromCollection(modifiedDrinkReports, false);

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }

                MessageBox.Show("Export excel successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadData(DateTime date)
        {
            drinkReportsForChart = BUSAnalysis.Instance.drinkReportDTOs(date);
            chartDrinkColumn.DataSource = drinkReportsForChart;
            chartDrinkColumn.Series[0].XValueMember = "drinkName";
            chartDrinkColumn.Series[0].YValueMembers = "drinkTotalPrice";
            chartDrinkColumn.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartDrinkColumn.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartDrinkColumn.Series[0].ToolTip = "#VALY";
            chartDrinkColumn.Series[0].IsValueShownAsLabel = true;
            chartDrinkColumn.ChartAreas[0].AxisY.Title = "Total Revenue (VND)";
            chartDrinkColumn.DataBind();

            chartDrinkDoughnut.DataSource = drinkReportsForChart;
            chartDrinkDoughnut.Series[0].Points.DataBind((System.Collections.IEnumerable)chartDrinkDoughnut.DataSource, "drinkName", "drinkQuantity", "LegendText=drinkName,Label=drinkQuantity");
            chartDrinkDoughnut.Series[0].ToolTip = "#VALY";
            chartDrinkDoughnut.Series[0].LegendText = "#PERCENT{P0}";

            // Load data for DataGridView without drinkId
            gridDrinkReport.Rows.Clear(); // Clear existing rows

            foreach (var report in drinkReportsForChart)
            {
                // Add data to DataGridView
                gridDrinkReport.Rows.Add(
                    report.drinkName,
                    report.drinkQuantity,
                    report.drinkTotalPrice
                // Add other fields as needed
                );
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(reportDate);
        }

        private void chartDrinkColumn_MouseMove(object sender, MouseEventArgs e)
        {
            //Code tooltip
            //var chart = sender as Chart;
            //if (chart != null)
            //{
            //    var result = chart.HitTest(e.X, e.Y);
            //    if (result.ChartElementType == ChartElementType.DataPoint)
            //    {
            //        var dataPoint = result.Series.Points[result.PointIndex];
            //        var xValue = dataPoint.XValue;
            //        var yValue = dataPoint.YValues[0]; // Assuming single Y value per point

            //        // Show tooltip with point values
            //        ToolTip tooltip = new ToolTip();
            //        tooltip.SetToolTip(chart, $"Point ({xValue}, {yValue})");
            //    }
            //}
        }
    }
}
