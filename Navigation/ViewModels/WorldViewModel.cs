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
        public ICommand NavigateToWorldCommand { get; }

        public WorldViewModel(NavigationStore navigationStore)
        {
            NavigateToWorldCommand = new NavigateCommand<WorldViewModel>(navigationStore, () => new WorldViewModel(navigationStore));
        }
    }
}
