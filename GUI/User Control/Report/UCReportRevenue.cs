using BUS;
using DTO;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace GUI
{
    public partial class UCReportRevenue : UserControl
    {
        List<CustomRevenueDTO> revenueReports = new List<CustomRevenueDTO>();
        List<ImportDTO> importReports = new List<ImportDTO>();
        public UCReportRevenue()
        {
            InitializeComponent();
        }
        private void LoadData(Object dataSourceRevenue, Object dataSourceCost)
        {
            chartTotalCostAndRevenue.Series[0].XValueMember = "Date";
            chartTotalCostAndRevenue.Series[0].YValueMembers = "TotalRevenue";
            chartTotalCostAndRevenue.Series[0].ToolTip = "#VALY";
            chartTotalCostAndRevenue.Series[0].IsValueShownAsLabel = true;

            chartTotalCostAndRevenue.Series[1].XValueMember = "Date";
            chartTotalCostAndRevenue.Series[1].YValueMembers = "TotalCost";
            chartTotalCostAndRevenue.Series[1].ToolTip = "#VALY";
            chartTotalCostAndRevenue.Series[1].IsValueShownAsLabel = true;
            chartTotalCostAndRevenue.Series[0].Points.DataBindXY((System.Collections.IEnumerable)dataSourceRevenue, "Date", (System.Collections.IEnumerable)dataSourceRevenue, "TotalRevenue");
            chartTotalCostAndRevenue.Series[1].Points.DataBindXY((System.Collections.IEnumerable)dataSourceCost, "Date", (System.Collections.IEnumerable)dataSourceCost, "TotalCost");
            chartTotalCostAndRevenue.DataBind();

            chartTotalCostAndRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartTotalCostAndRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartTotalCostAndRevenue.ChartAreas[0].AxisY.Title = "Total (VND)";

            revenueReports = (List<CustomRevenueDTO>)dataSourceRevenue;
            importReports = (List<ImportDTO>)dataSourceCost;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Object dataSourceRevenue = null;
                Object dataSourceCost = null;
                if (cbType.SelectedIndex == 0)
                {
                    if(String.IsNullOrEmpty(cbDate1.Text) || String.IsNullOrEmpty(cbDate2.Text))
                    {
                        MessageBox.Show("Lack of information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataSourceRevenue = BUSAnalysis.Instance.dayOfMonthRevenueDTOs(int.Parse(cbDate1.Text), int.Parse(cbDate2.Text));
                    dataSourceCost = BUSAnalysis.Instance.dayOfMonthCostDTOs(int.Parse(cbDate1.Text), int.Parse(cbDate2.Text));

                }
                else if (cbType.SelectedIndex == 1)
                {
                    if (String.IsNullOrEmpty(cbDate1.Text))
                    {
                        MessageBox.Show("Lack of information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataSourceRevenue = BUSAnalysis.Instance.monthOfYearRevenueDTOs(Convert.ToInt32(cbDate1.Text));
                    dataSourceCost = BUSAnalysis.Instance.monthOfYearCostDTOs(Convert.ToInt32(cbDate1.Text));
                }
                else
                {
                    if (String.IsNullOrEmpty(cbDate1.Text) || String.IsNullOrEmpty(cbDate2.Text))
                    {
                        MessageBox.Show("Lack of information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Convert.ToInt32(cbDate1.Text) > Convert.ToInt32(cbDate2.Text))
                    {
                        MessageBox.Show("The starting year cannot be greater than the ending year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataSourceRevenue = BUSAnalysis.Instance.yearsRevenueDTOs(Convert.ToInt32(cbDate1.Text), Convert.ToInt32(cbDate2.Text));
                    dataSourceCost = BUSAnalysis.Instance.yearsCostDTOs(Convert.ToInt32(cbDate1.Text), Convert.ToInt32(cbDate2.Text));
                }
                LoadData(dataSourceRevenue, dataSourceCost);
            }
            catch 
            {

            }

        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                filterDayOfMonth();
            }else if(cbType.SelectedIndex == 1)
            {
                filterMonthOfYear();
            }
            else
            {
                filterYears();
            }
        }
        private void filterDayOfMonth()
        {
            cbDate1.Items.Clear();
            cbDate2.Items.Clear();
            for (int monthNumber = 1; monthNumber <= 12; monthNumber++)
            {
                cbDate1.Items.Add(monthNumber);
            }
            int currentYear = DateTime.Now.Year;
            int numberOfYears = 10;
            for (int i = 0; i < numberOfYears; i++)
            {
                int year = currentYear - i;
                cbDate2.Items.Add(year);
            }
            cbDate2.Visible = true;
            lbEd.Visible = true;
            lbSd.Text = "Month";
        }
        private void filterMonthOfYear()
        {
            cbDate1.Items.Clear();
            int currentYear = DateTime.Now.Year;
            int numberOfYears = 10;
            for (int i = 0; i < numberOfYears; i++)
            {
                int year = currentYear - i;
                cbDate1.Items.Add(year);
            }
            cbDate2.Visible = false;
            lbEd.Visible = false;
            lbSd.Text = "Year";

        }
        private void filterYears()
        {
            cbDate1.Items.Clear();
            cbDate2.Items.Clear();
            int currentYear = DateTime.Now.Year;
            int numberOfYears = 10;
            for (int i = 0; i < numberOfYears; i++)
            {
                int year = currentYear - i;
                cbDate1.Items.Add(year);
                cbDate2.Items.Add(year);
            }
            cbDate2.Visible = true;
            lbEd.Visible = true;
            lbSd.Text = "Year";
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            try
            {
                if(revenueReports.Count == 0 && importReports.Count == 0)
                {
                    MessageBox.Show("No data available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    p.Workbook.Properties.Title = "Revenue Report";
                    ExcelWorksheet ws = p.Workbook.Worksheets.Add("Sheet1");

                    // Title Revenue
                    ws.Cells["A1"].Value = "Revenue Report";
                    ws.Cells["A1"].Style.Font.Bold = true;
                    ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells["A1:B1"].Merge = true;

                    // Title Cost
                    ws.Cells["D1"].Value = "Cost Report";
                    ws.Cells["D1"].Style.Font.Bold = true;
                    ws.Cells["D1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells["D1:E1"].Merge = true;


                    var user = BUSUser.Instance.GetUserById(BUSUser.Instance.idUserLogin);
                    // Report Date and Reporter Revenue
                    ws.Cells["A3"].Value = "Reporter: " + user.UserID + " | " + user.UserFullName;
                    ws.Cells["A3"].Style.Font.Bold = true;
                    ws.Cells["A3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["A3:B3"].Merge = true;

                    ws.Cells["A4"].Value = "Report Date: " + DateTime.Now.ToString("dd/MM/yyyy");
                    ws.Cells["A4"].Style.Font.Bold = true;
                    ws.Cells["A4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["A4:B4"].Merge = true;

                    // Report Date and Reporter Cost
                    ws.Cells["D3"].Value = "Reporter: " + user.UserID + " | " + user.UserFullName;
                    ws.Cells["D3"].Style.Font.Bold = true;
                    ws.Cells["D3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["D3:E3"].Merge = true;

                    ws.Cells["D4"].Value = "Report Date: " + DateTime.Now.ToString("dd/MM/yyyy");
                    ws.Cells["D4"].Style.Font.Bold = true;
                    ws.Cells["D4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["D4:E4"].Merge = true;

                    // Headers Revenue
                    string[] arrColumnHeaderRevenue = { "Date", "Total Revenue (VNĐ)" };
                    ws.Cells["A6:B6"].LoadFromArrays(new List<string[]> { arrColumnHeaderRevenue });

                    using (var headerRange = ws.Cells["A6:B6"])
                    {
                        headerRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Center align
                        headerRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Center vertically
                        headerRange.Style.Font.Bold = true; // Make text bold
                    }

                    // Headers Cost
                    string[] arrColumnHeaderCost = { "Date", "Total Cost (VNĐ)" };
                    ws.Cells["D6:E6"].LoadFromArrays(new List<string[]> { arrColumnHeaderCost });

                    using (var headerRange = ws.Cells["D6:E6"])
                    {
                        headerRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Center align
                        headerRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Center vertically
                        headerRange.Style.Font.Bold = true; // Make text bold
                    }

                    // Load data revenue
                    var modifiedRevenueReports = revenueReports.Select(report => new
                    {
                       date = report.Date,
                       chartTotalRevenue = report.TotalRevenue,
                    }).ToList();

                    // Load data cost
                    var modifiedCostReports = importReports.Select(report => new
                    {
                        date = report.Date,
                        chartTotalCost = report.TotalCost,
                    }).ToList();

                    ws.Cells["A7"].LoadFromCollection(modifiedRevenueReports, false);

                    ws.Cells["D7"].LoadFromCollection(modifiedCostReports, false);

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
    }
}
