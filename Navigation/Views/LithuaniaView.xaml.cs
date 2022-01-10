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
using LiveCharts;
using LiveCharts.Wpf;

namespace Navigation.Views
{
    /// <summary>
    /// Interaction logic for LithuaniaView.xaml
    /// </summary>
    public partial class LithuaniaView : UserControl
    {
        public LithuaniaView()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection()
            {
                new PieSeries
                {
                    Title = "First",
                    Values = new ChartValues<double> { 124},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Second",
                    Values = new ChartValues<double> { 354},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Third",
                    Values = new ChartValues<double> { 35},
                    DataLabels = true
                }
            };
            CovidPieChart.Series = SeriesCollection;
        }
        public SeriesCollection SeriesCollection { get; set; }

    }
}
