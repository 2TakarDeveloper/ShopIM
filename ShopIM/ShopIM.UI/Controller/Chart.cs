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
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class Chart : UserControl
    {
        public Chart(List<ProductStatisticInfo> productStatisticInfos)
        {
            InitializeComponent();
            DrawPriceVsMonthChart(productStatisticInfos);
            DrawPriceVsMonthPie(productStatisticInfos);
        }
        public void DrawPriceVsMonthChart(List<ProductStatisticInfo> productStatisticInfos)
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
            columns.Title = "Monthly Prices";

            //Addming columns to Series
            SeriesCollection Seriesx = new SeriesCollection();
            Seriesx.Add(columns);

            //Creating X axis using name list
            Axis xAxis = new Axis();
            xAxis.Title = "Sales";
            xAxis.Labels = NameList;
            

            //Creating Y axis 
            Axis yAxis = new Axis();
            yAxis.Title = "Prices";
            yAxis.LabelFormatter = value => value.ToString("N");

            //adding series , axis x and y to pricechart(Column chart)
            ColumnChart.Series = Seriesx;
            ColumnChart.AxisX.Add(xAxis);
            ColumnChart.AxisY.Add(yAxis);
        }

        public void DrawPriceVsMonthPie(List<ProductStatisticInfo> productStatisticInfos)
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

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
    }
 }



    

