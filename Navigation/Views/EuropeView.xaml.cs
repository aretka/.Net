using Navigation.Dialogs;
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

namespace Navigation.Views
{
    /// <summary>
    /// Interaction logic for EuropeView.xaml
    /// </summary>
    public partial class EuropeView : UserControl
    {
        public EuropeView()
        {
            InitializeComponent();
        }

        private async void OpenModal(object sender, RoutedEventArgs e)
        {
            var CovidInfo = await CovidProcessor.LoadSunInformation();

           
            Button Button = sender as Button;
            var countryData = new CountryData(Convert.ToInt32(CovidInfo.cases), Convert.ToInt32(CovidInfo.tests), Convert.ToInt32(CovidInfo.deaths), Convert.ToInt32(CovidInfo.active), Button.Name);
            var window = new CountryInfoDialog(countryData);

            window.ShowDialog();
        }
    }
}
