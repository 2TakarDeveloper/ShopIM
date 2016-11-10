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

namespace ShopIM.UI.Controller
{
    public partial class Chart : UserControl
    {
        public Chart(List<String> NameList, List<double> PriceList)
        {
            InitializeComponent();
            DrawPriceVsMonthChart(NameList, PriceList);
           // DrawPriceVsMonthPie();
        }
        public void DrawPriceVsMonthChart(List<String> NameList, List<Double> PriceList)
        {
            //Creating columns using price list
            ColumnSeries columns = new ColumnSeries();
            ChartValues<double> chartVal = new ChartValues<double>(PriceList);
            columns.Values = chartVal;
            columns.Title = "Montly Prices";

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

        public void DrawPriceVsMonthPie()
        {

            PieChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                   // LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                   // LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                  //  LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                   // LabelPoint = labelPoint
                }
            };

            PieChart.LegendLocation = LegendLocation.Bottom;
        }
    }


}
    

