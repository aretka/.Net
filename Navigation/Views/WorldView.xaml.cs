using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Navigation.API_stuff;
using LiveCharts;
using LiveCharts.Wpf;

namespace Navigation.Views
{
    /// <summary>
    /// Interaction logic for WorldView.xaml
    /// </summary>
    public partial class WorldView : UserControl
    {
        public SeriesCollection SeriesCollection1 { get; set; }
        public SeriesCollection SeriesCollection2 { get; set; }
        public SeriesCollection SeriesCollection3 { get; set; }
         public WorldView()
        {
            InitializeComponent();
            LoadWorldLineChartData();
            LoadWorldBottomCharts();
        }

        private async void LoadWorldLineChartData() {
            var result = await CovidProcessor.LoadWorldLineChartData();
            SeriesCollection1 = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Total cases",
                    Values =  new ChartValues<int>(result.totalCases),
                    PointGeometry = null
                    //Values = new ChartValues<int>{ result.totalCases[0], result.totalCases[1], result.totalCases[2] }              
                },
                new LineSeries
                {
                    Title = "Total deaths",
                    Values = new ChartValues<int>(result.totalDeaths),
                    PointGeometry = null
                    //Values = new ChartValues<int> { result.totalDeaths[1], result.totalDeaths[2], result.totalDeaths[3] }
                }
            };
            line_chart.Visibility = Visibility.Visible;
            pie_chart_x_labels.Labels = new[] { "" };
            line_chart.Series = SeriesCollection1;
        }

        private async void LoadWorldBottomCharts()
        {
            var pieChartData = await CovidProcessor.LoadWorldPieChartData();
            SeriesCollection2 = new SeriesCollection()
            {
                new PieSeries
                {
                    Title = "Active",
                    Values = new ChartValues<int> { pieChartData.active },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Critical",
                    Values = new ChartValues<int> { pieChartData.critical },
                    DataLabels = true
                },
            };

            SeriesCollection3 = new SeriesCollection()
            {
                new ColumnSeries
                {
                    Title = "Recovered",
                    Values = new ChartValues<int> { pieChartData.recovered }
                },
                new ColumnSeries
                {
                    Title = "Deaths",
                    Values = new ChartValues<int> { pieChartData.deaths }
                }
            };
            pie_chart.Visibility = Visibility.Visible;
            bar_chart.Visibility = Visibility.Visible;
            pie_chart.Series = SeriesCollection2;
            bar_chart.Series = SeriesCollection3;
        }
    }
}
