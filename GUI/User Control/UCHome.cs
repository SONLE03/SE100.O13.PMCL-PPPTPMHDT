using BUS;
using DTO;
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
    public partial class UCHome : UserControl
    {
        private DBLogic model;
        private Guna.UI2.WinForms.Guna2Button CurrentBtn;
        public UCHome()
        {
            InitializeComponent();
            //dtpStartDate.Value = DateTime.Today.AddDays(-7);
            //dtpEndDate.Value = DateTime.Now;
            //btnThisweek.Select();
            //model = new DBLogic();
            //LoadData();
            //DisableCustomDatesAndBtUI(btnThisweek);
            loadTopSelling();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void loadTopSelling()
        {
            chartTopSell.DataSource = BUSAnalysis.Instance.TopSellingDrinks();
            chartTopSell.Series[0].XValueMember = "DrinkId";
            chartTopSell.Series[0].YValueMembers = "TotalQuantity";
            chartTopSell.Series[0].ToolTip = "#DrinkName: #VALY";
            chartTopSell.DataBind();
        }

        private void LoadData()
        {

            var Refresh = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (Refresh == true)
            {
                // 3 first panel
                lbDailyOrder.Text = model.NumOrder.ToString();
                lbTotalRevenue.Text = "$" + model.TotalRevenue.ToString();
                lbTotalCustomers.Text = model.NumCustomer.ToString();
                // 3 label at Overview
                lbTotalEmployees.Text = model.NumEmployee.ToString();
                lbTotalSuppliers.Text = model.NumSupplier.ToString();
                lbTotalProducts.Text = model.NumProduct.ToString();
                //Area chart of Revenue
                chartTotalRevenue.DataSource = model.TotalRevenues;
                chartTotalRevenue.Series[1].XValueMember = "Date";
                chartTotalRevenue.Series[1].YValueMembers = "TotalAmount";
                chartTotalRevenue.DataBind();
                //Dounut chart of Top 5 best selling
                //chartTop5.DataSource = model.TopProduct;
                //chartTop5.Series[0].XValueMember = "Key";
                //chartTop5.Series[1].YValueMembers = "Value";
                //chartTop5.DataBind();

                Console.WriteLine("Loaded!!!");
            }
            else Console.WriteLine("Fail to load!!!");
        }
        //Dùng để ẩn các datetimepicker và button OK khi nút Tùy chỉnh ngày (custom) chưa được bấm
        //private void DisableCustomDatesAndBtUI(object button)
        //{
        //    var btn = (Button)button;

        //    CurrentBtn = btn;

        //    dtpStartDate.Enabled = false;
        //    dtpEndDate.Enabled = false;
        //    btnOK.Visible = false;
        //}
        ////ngược lại
        //private void EnableCustomDatesAndBtUI(object button)
        //{
        //    var btn = (Button)button;

        //    CurrentBtn = btn;

        //    dtpStartDate.Enabled = true;
        //    dtpEndDate.Enabled = true;
        //    btnOk.Visible = true;
        //    lbStartDate.Cursor = Cursors.Hand;
        //    lbEndDate.Cursor = Cursors.Hand;
        //}

        private void btnCustom_Click(object sender, EventArgs e)
        {
            //EnableCustomDatesAndBtUI(sender);
        }

        //private void btnToday_Click(object sender, EventArgs e)
        //{
        //    dtpStartDate.Value = DateTime.Today;
        //    dtpEndDate.Value = DateTime.Now;
        //    LoadData();
        //    DisableCustomDatesAndBtUI(sender);
        //}

        //private void btnThisWeek_Click(object sender, EventArgs e)
        //{
        //    dtpStartDate.Value = DateTime.Today.AddDays(-7);
        //    dtpEndDate.Value = DateTime.Now;
        //    LoadData();
        //    DisableCustomDatesAndBtUI(sender);
        //}

        //private void btnThisQuarter_Click(object sender, EventArgs e)
        //{

        //    dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 3);
        //    dtpEndDate.Value = DateTime.Now;
        //    LoadData();
        //    DisableCustomDatesAndBtUI(sender);
        //}

        //private void btnThisMonth_Click(object sender, EventArgs e)
        //{
        //    dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        //    dtpEndDate.Value = DateTime.Now;
        //    LoadData();
        //    DisableCustomDatesAndBtUI(sender);
        //}

        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    LoadData();
        //}
        //private void lbStartDate_Click(object sender, EventArgs e)
        //{
        //    if (CurrentBtn == btnCustom)
        //    {
        //        dtpStartDate.Select();
        //        SendKeys.Send("%{DOWN}");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Chỉ được chọn ngày sau khi bấm [Tùy chỉnh] !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void lbEndDate_Click(object sender, EventArgs e)
        //{
        //    if (CurrentBtn == btnCustom)
        //    {
        //        dtpEndDate.Select();
        //        SendKeys.Send("%{DOWN}");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Chỉ được chọn ngày sau khi bấm [Tùy chỉnh] !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        //{
        //    lbStartDate.Text = dtpStartDate.Text;
        //}

        //private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        //{
        //    lbEndDate.Text = dtpEndDate.Text;
        //}

    }

}
