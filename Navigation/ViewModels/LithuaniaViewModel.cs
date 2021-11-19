using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Navigation.Commands;
using Navigation.Store;


namespace Navigation.ViewModels
{
    internal class LithuaniaViewModel : BaseViewModel
    {
        public ICommand NavigateToEuropeCommand { get; }
        public ICommand NavigateToWorldCommand { get; }

        public LithuaniaViewModel(NavigationStore navigationStore)
        {
            NavigateToEuropeCommand = new NavigateCommand<EuropeViewModel>(navigationStore, () => new EuropeViewModel(navigationStore));
            NavigateToWorldCommand = new NavigateCommand<WorldViewModel>(navigationStore, () => new WorldViewModel(navigationStore));
        }
    }
}
