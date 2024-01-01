﻿using BUS;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
            LoadData();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            // load Top Selling
            chartTopSell.DataSource = BUSAnalysis.Instance.TopSellingDrinks();
            chartTopSell.Series[0].XValueMember = "DrinkId";
            chartTopSell.Series[0].YValueMembers = "TotalQuantity";
            chartTopSell.Series[0].ToolTip = "#DrinkName: #VALY";
            chartTopSell.DataBind();

            // load Total User
            lbTotalUsers.Text = BUSUser.Instance.GetAllUserActive().Count.ToString();

            // load Total Drink
            lbTotalProducts.Text = BUSDrink.Instance.GetAllDrinkActive().Count.ToString();

            // load Total Supplier
            lbTotalSupplier.Text = BUSSupplier.Instance.GetAllSupplierActive().Count.ToString();

            // load Total Order
            lbDailyOrder.Text = BUSOrder.Instance.GetAllBill().Count.ToString();

            // load Total Revenue This Year
            chartTotalRevenue.DataSource = BUSAnalysis.Instance.monthlyRevenueDTOs();
            chartTotalRevenue.Series[0].XValueMember = "Month";
            chartTotalRevenue.Series[0].YValueMembers = "TotalRevenue";
            chartTotalRevenue.DataBind();
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