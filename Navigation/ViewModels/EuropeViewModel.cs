using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Navigation.Store;
using Navigation.Commands;

namespace Navigation.ViewModels
{
    internal class EuropeViewModel : BaseViewModel
    {
        public ICommand NavigateToLithuaniaCommand { get; }

        public EuropeViewModel(NavigationStore navigationStore)
        {
            NavigateToLithuaniaCommand = new NavigateCommand<LithuaniaViewModel>(navigationStore, () => new LithuaniaViewModel(navigationStore));
        }
    }
}
