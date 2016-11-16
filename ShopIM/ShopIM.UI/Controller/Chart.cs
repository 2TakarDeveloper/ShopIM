using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
            ProductBox.DataSource=new ProductRepo().GetProducts();
           // UpdateCharts();
        }




        public void DrawColumnChart(List<ProductStatisticInfo> productStatisticInfos)
        {
          
            List<double> PriceList=new List<double>();
            List<string> NameList=new List<string>();
            foreach (var productStat in productStatisticInfos)
            {
                PriceList.Add(productStat.Value);
                NameList.Add(productStat.Key);
            }


            //Creating columns using price list
            ColumnSeries columns = new ColumnSeries();
            ChartValues<double> chartVal = new ChartValues<double>(PriceList);
            columns.Values = chartVal;
            columns.Title = "Net Profit Over Time";

            //Addming columns to Series
            SeriesCollection Seriesx = new SeriesCollection();
            Seriesx.Add(columns);

            //Creating X axis using name list
            Axis xAxis = new Axis();
            xAxis.Title = "Time";
            xAxis.Labels = NameList;
            

            //Creating Y axis 
            Axis yAxis = new Axis();
            yAxis.Title = "Profit";
            yAxis.LabelFormatter = value => value.ToString("N");

            //Refresh

            ColumnChart.Series.Clear();
            ColumnChart.AxisX.Clear();
            ColumnChart.AxisY.Clear();

            //adding series , axis x and y to pricechart(Column chart)
            ColumnChart.Series = Seriesx;

            ColumnChart.AxisX.Clear();
            ColumnChart.AxisY.Clear();
            ColumnChart.AxisX.Add(xAxis);
            ColumnChart.AxisY.Add(yAxis);
        }

        private void UpdateCharts()
        {
            if (SelectionBox.Text == @"Overall")
            {
                DrawColumnChart(Log(TimeBox.Text));
                DrawPieChart(Log(TimeBox.Text));
            }
            else
            {
                if (ProductBox.SelectedItem == null) return;
                DrawColumnChart(Log(TimeBox.Text, ProductBox.SelectedItem.ToString()));
                DrawPieChart(Log(TimeBox.Text, ProductBox.SelectedItem.ToString()));
            }
        }


        public void DrawPieChart(List<ProductStatisticInfo> productStatisticInfos)
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                    $"{chartPoint.Y} ({chartPoint.Participation:P})";

            SeriesCollection seriesCollection = new SeriesCollection();

            foreach (var productInfo in productStatisticInfos)
            {
                seriesCollection.Add(new PieSeries
                {
                    Title = productInfo.Key,
                    Values = new ChartValues<double> { productInfo.Value },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
          

            pieChart.Series = seriesCollection;
          
            pieChart.LegendLocation = LegendLocation.Bottom;
        }

        private List<ProductStatisticInfo> Log(string groupby)
        {
            List<ProductStatisticInfo> Log=new List<ProductStatisticInfo>();

            switch (groupby)
            {
                case "Monthly":

                    var monthlyLog = new LogRepo().GetSalesLog().GroupBy(x => x.SoldDate.Month).Select(g =>
                        new
                        {
                            Month = g.Key.ToString(),
                            MonthlyProfit = g.Sum(x => x.NetProfit)
                        });
                    Log = monthlyLog.Select(log => new ProductStatisticInfo(log.Month, log.MonthlyProfit)).ToList();
                    break;
                case "Yearly":

                    var yearlyLog = new LogRepo().GetSalesLog().GroupBy(x => x.SoldDate.Year).Select(g =>
                        new
                        {
                            Month = g.Key.ToString(),
                            MonthlyProfit = g.Sum(x => x.NetProfit)
                        });
                    Log = yearlyLog.Select(log => new ProductStatisticInfo(log.Month, log.MonthlyProfit)).ToList();
                    break;
                case "Weekly":

                    var weeklyLog = new LogRepo().GetSalesLog().GroupBy(x => x.SoldDate.DayOfWeek).Select(g =>
                        new
                        {
                            Month = g.Key.ToString(),
                            MonthlyProfit = g.Sum(x => x.NetProfit)
                        });
                    Log = weeklyLog.Select(log => new ProductStatisticInfo(log.Month, log.MonthlyProfit)).ToList();
                    break;
            }


            return Log;
        }


        private List<ProductStatisticInfo> Log(string groupby,string productName)
        {    
            List<ProductStatisticInfo> Log = new List<ProductStatisticInfo>();

            switch (groupby)
            {
                case "Monthly":
                    var monthlyLog = new LogRepo().GetSalesLog().Where(x => x.ProductName == productName).GroupBy(x => x.SoldDate.Month).Select(g =>
                        new
                        {
                            Month = g.Key.ToString(),
                            MonthlyProfit = g.Sum(x => x.NetProfit)
                        });
                    Log = monthlyLog.Select(log => new ProductStatisticInfo(log.Month, log.MonthlyProfit)).ToList();
                    break;

                case "Yearly":
                    var yearlyLog = new LogRepo().GetSalesLog().Where(x => x.ProductName == productName).GroupBy(x => x.SoldDate.Year).Select(g =>
                        new
                        {
                            Month = g.Key.ToString(),
                            MonthlyProfit = g.Sum(x => x.NetProfit)
                        });
                    Log = yearlyLog.Select(log => new ProductStatisticInfo(log.Month, log.MonthlyProfit)).ToList();
                    break;

                case "Weekly":
                    var weeklyLog = new LogRepo().GetSalesLog().Where(x => x.ProductName == productName).GroupBy(x => x.SoldDate.DayOfWeek).Select(g =>
                        new
                        {
                            Month = g.Key.ToString(),
                            MonthlyProfit = g.Sum(x => x.NetProfit)
                        });
                    Log = weeklyLog.Select(log => new ProductStatisticInfo(log.Month, log.MonthlyProfit)).ToList();
                    break;
            }


            return Log;
        }

        private void TimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCharts();
             
        }


       
      

        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCharts();
        }

        private void SelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBox.Visible = SelectionBox.Text != @"Overall";
            UpdateCharts();
        }
    }
 }



    

