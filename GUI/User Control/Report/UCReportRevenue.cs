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
        List<CustomRevenueDTO> revenueReportsForChart = new List<CustomRevenueDTO>();
        public UCReportRevenue()
        {
            InitializeComponent();
        }
        private void LoadData(Object dataSource)
        {
            chartTotalRevenue.DataSource = dataSource;
            chartTotalRevenue.Series[0].XValueMember = "Date";
            chartTotalRevenue.Series[0].YValueMembers = "TotalRevenue";
            chartTotalRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartTotalRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartTotalRevenue.Series[0].ToolTip = "#VALY";
            chartTotalRevenue.Series[0].IsValueShownAsLabel = true;
            chartTotalRevenue.ChartAreas[0].AxisY.Title = "Total Revenue (VND)";
            chartTotalRevenue.DataBind();
            gridRevenue.DataSource = dataSource;
            revenueReportsForChart = (List<CustomRevenueDTO>)dataSource;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Object dataSource = null;
                if (cbType.SelectedIndex == 0)
                {
                    if(String.IsNullOrEmpty(cbDate1.Text) || String.IsNullOrEmpty(cbDate2.Text))
                    {
                        MessageBox.Show("Lack of information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataSource = BUSAnalysis.Instance.dayOfMonthRevenueDTOs(int.Parse(cbDate1.Text), int.Parse(cbDate2.Text));

                }
                else if (cbType.SelectedIndex == 1)
                {
                    if (String.IsNullOrEmpty(cbDate1.Text))
                    {
                        MessageBox.Show("Lack of information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dataSource = BUSAnalysis.Instance.monthOfYearRevenueDTOs(Convert.ToInt32(cbDate1.Text));
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
                    dataSource = BUSAnalysis.Instance.yearsRevenueDTOs(Convert.ToInt32(cbDate1.Text), Convert.ToInt32(cbDate2.Text));
                }
                LoadData(dataSource);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            lbSd.Text = "Start date";
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
            lbSd.Text = "Start date";
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            try
            {
                if(gridRevenue.Rows.Count <= 0)
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

                    // Title
                    ws.Cells["A1"].Value = "Revenue Report";
                    ws.Cells["A1"].Style.Font.Bold = true;
                    ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells["A1:B1"].Merge = true;

                    var user = BUSUser.Instance.GetUserById(BUSUser.Instance.idUserLogin);
                    // Report Date and Reporter
                    ws.Cells["A3"].Value = "Reporter: " + user.UserID + " | " + user.UserFullName;
                    ws.Cells["A3"].Style.Font.Bold = true;
                    ws.Cells["A3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["A3:B3"].Merge = true;

                    ws.Cells["A4"].Value = "Report Date: " + DateTime.Now.ToString("dd/MM/yyyy");
                    ws.Cells["A4"].Style.Font.Bold = true;
                    ws.Cells["A4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells["A4:B4"].Merge = true;

                    // Headers
                    string[] arrColumnHeader = { "Date", "Total Revenue (VNĐ)" };
                    ws.Cells["A6:B6"].LoadFromArrays(new List<string[]> { arrColumnHeader });

                    using (var headerRange = ws.Cells["A6:B6"])
                    {
                        headerRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Center align
                        headerRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Center vertically
                        headerRange.Style.Font.Bold = true; // Make text bold
                    }

                    var modifiedReports = revenueReportsForChart.Select(report => new
                    {
                       date = report.Date,
                       chartTotalRevenue = report.TotalRevenue,
                    }).ToList();

                    ws.Cells["A7"].LoadFromCollection(modifiedReports, false);

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
