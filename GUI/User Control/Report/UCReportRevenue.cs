using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class UCReportRevenue : UserControl
    {
        public UCReportRevenue()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            LoadData(dtpStartDate.Value, dtpEndDate.Value);
        }
        private void LoadData(DateTime startDate, DateTime endDate)
        {
            var customRevenue = BUSAnalysis.Instance.customRevenueDTOs(startDate, endDate);
            // load Total Revenue This Year
            chartTotalRevenue.DataSource = customRevenue;
            chartTotalRevenue.Series[0].XValueMember = "Day";
            chartTotalRevenue.Series[0].YValueMembers = "TotalAmount";
            chartTotalRevenue.DataBind();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData(dtpStartDate.Value, dtpEndDate.Value);
        }

        private void chartTotalRevenue_MouseMove(object sender, MouseEventArgs e)
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
