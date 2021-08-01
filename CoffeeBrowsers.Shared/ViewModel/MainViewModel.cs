using CoffeeBrowsers.DataProvider;
using CoffeeBrowsers.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoffeeBrowsers.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Coffee> Coffees { get; } = new ObservableCollection<Coffee>();

        private Coffee _selectedCoffee;
        private readonly ICoffeeDataProvider _coffeeDataProvider;

        public MainViewModel(ICoffeeDataProvider coffeeDataProvider)
        {
            this._coffeeDataProvider = coffeeDataProvider;
        }



        public Coffee SelectedCoffee
        {
            get { return _selectedCoffee; }
            set 
            {
                if (_selectedCoffee != value)
                {
                    _selectedCoffee = value;
                    RaisePropertyChanged();
                }
            }
        }

    }
}
