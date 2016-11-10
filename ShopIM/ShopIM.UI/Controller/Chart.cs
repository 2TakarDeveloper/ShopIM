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
            PriceChart.Series = Seriesx;
            PriceChart.AxisX.Add(xAxis);
            PriceChart.AxisY.Add(yAxis);
        }

        public void DrawPriceVsMonthPie(List<ProductStatisticInfo> productStatisticInfos)
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            List<double> PriceList = new List<double>();
            List<string> NameList = new List<string>();
            NameList.Add("Shihab");
            NameList.Add("Shihab2");
            NameList.Add("Shihab3");

            List<PieSeries> pieList = new List<PieSeries>();
            foreach(String name in NameList)
            {
                PieSeries pieSlice = new PieSeries();
                pieSlice.Title = name;
                pieSlice.Values = new ChartValues<double> { 10 };
                //PushOut = 15,
                pieSlice.DataLabels = true;
                pieSlice.LabelPoint = labelPoint;
                pieList.Add(pieSlice);
            }
            pieChart1.Series = new SeriesCollection(pieList);
            pieChart1.LegendLocation = LegendLocation.Bottom;
            
         /*   pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };*/

            //pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
 }



    

