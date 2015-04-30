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
using Windows.UI.Xaml;

namespace Sandwich.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Foods> _drinks = null;
        public ObservableCollection<Foods> Drinks { get { return _drinks; } set { _drinks = value; RaisePropertyChanged("Drinks"); } }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
                {
            ////    // Code runs in Blend --> create design time data.
                }
            else
            {
            ////    // Code runs "for real"
           // InitialiseAsync();
            }
        }

        private INavigationService _navigationService;

        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService) 
        { 
            _navigationService = navigationService;
                     
        }

        

        public async Task InitialiseAsync()
        {
            var service = new ProvideData();
            var lstDrinks = await service.getlstSandwichAsync();

            Drinks = new ObservableCollection<Foods>(lstDrinks);
            

        }
    }
}