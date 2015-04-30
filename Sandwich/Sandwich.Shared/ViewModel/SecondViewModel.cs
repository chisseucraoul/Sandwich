using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Sandwich.Services.DataProvider;
using Sandwich.ViewModel;
using System.Threading.Tasks;
using System;
using Sandwich.DataModel;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace Sandwich.ViewModel
{
    public class SecondViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        public SecondViewModel()
        {

        }
        [PreferredConstructor]
        public SecondViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }

    }
}
