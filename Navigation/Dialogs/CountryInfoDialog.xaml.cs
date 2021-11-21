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
using System.Windows.Shapes;

namespace Navigation.Dialogs
{
    /// <summary>
    /// Interaction logic for CountryInfoDialog.xaml
    /// </summary>
    public partial class CountryInfoDialog : Window
    {
        public CountryInfoDialog(CountryData countryData)
        {
            InitializeComponent();
            WindowLoaded();
            Owner = App.Current.MainWindow;
            todaysCases.Text = countryData.todaysCases.ToString();
            totalCases.Text = countryData.totalCases.ToString();
            todaysDeaths.Text = countryData.todaysDeaths.ToString();
            totalDeaths.Text = countryData.totalDeaths.ToString();
        }

        private void WindowLoaded()
        {
            Application curApp = Application.Current;
            Window mainWindow = curApp.MainWindow;
            this.Left = mainWindow.Left + (mainWindow.Width - 300) / 2 ;
            this.Top = mainWindow.Top + (mainWindow.Height - 200) / 2 ;
        }

        private void okButton_Click(object sender, RoutedEventArgs e) =>
            DialogResult = true;

        private void cancelButton_Click(object sender, RoutedEventArgs e) =>
            DialogResult = false;
    }
}
