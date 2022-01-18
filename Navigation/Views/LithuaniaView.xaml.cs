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
using Navigation.API_stuff;

namespace Navigation.Views
{
    /// <summary>
    /// Interaction logic for LithuaniaView.xaml
    /// </summary>
    public partial class LithuaniaView : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public LithuaniaView()
        {
            InitializeComponent();
            LoadInfo();
        }
        public async void LoadInfo() {

            var lithuaniaData = await CovidProcessor.LoadLithuaniaData();
            SeriesCollection = new SeriesCollection()
            {
                new PieSeries
                {
                    Title = "Todays cases",
                    Values = new ChartValues<int> { lithuaniaData.todayCases},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Todays recovered",
                    Values = new ChartValues<int> { lithuaniaData.todayRecovered},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Todays deaths",
                    Values = new ChartValues<int> { lithuaniaData.todayDeaths},
                    DataLabels = true
                }
            };

            cases.Text = lithuaniaData.cases.ToString();
            deaths.Text = lithuaniaData.deaths.ToString();
            recovered.Text = lithuaniaData.recovered.ToString();
            active.Text = lithuaniaData.active.ToString();
            critical.Text = lithuaniaData.critical.ToString();
            tests.Text = lithuaniaData.tests.ToString();

            pie_chart.Series = SeriesCollection;
        }
    }
}
