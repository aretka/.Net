using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Navigation.Store;
using Navigation.ViewModels;

namespace Navigation.Commands
{
    internal class NavigateToLithuania : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToLithuania(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new LithuaniaViewModel(_navigationStore);
        }
    }
}
