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
    public partial class UCReports : UserControl
    {
        public UCReports()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            LoadData(dtpStartDate.Value, dtpEndDate.Value);
        }
        private void LoadData(DateTime startDate, DateTime endDate)
        {
            // load Total Revenue This Year
            chartTotalRevenue.DataSource = BUSAnalysis.Instance.customRevenueDTOs(startDate, endDate);
            chartTotalRevenue.Series[0].XValueMember = "Day";
            chartTotalRevenue.Series[0].YValueMembers = "TotalRevenue";
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
