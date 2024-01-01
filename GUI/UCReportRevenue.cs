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
    }
}
