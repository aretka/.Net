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
    internal class WorldViewModel : BaseViewModel
    {
        public ICommand NavigateToEuropeCommand { get; }
        public ICommand NavigateToLithuaniaCommand { get; }


        public WorldViewModel(NavigationStore navigationStore)
        {
            NavigateToEuropeCommand = new NavigateCommand<EuropeViewModel>(navigationStore, () => new EuropeViewModel(navigationStore));
            NavigateToLithuaniaCommand = new NavigateCommand<LithuaniaViewModel>(navigationStore, () => new LithuaniaViewModel(navigationStore));
        }
    }
}
