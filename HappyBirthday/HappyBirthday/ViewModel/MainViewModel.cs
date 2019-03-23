

using System.Windows;
using System.Windows.Input;
using HappyBirthday.Model;
using HappyBirthday.Tools;
using HappyBirthday.Tools.Manager;

namespace HappyBirthday.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {

        private Visibility _filtersVisibility = Visibility.Collapsed;


      
        private ICommand _showFiltersCommand;


        public Visibility FiltersVisibility
        {
            get => _filtersVisibility;
            private set
            {
                _filtersVisibility = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowMenuCommand => _showFiltersCommand ?? (_showFiltersCommand = new RelayCommand<object>(ShowFiltersImplementation));

        private void ShowFiltersImplementation(object obj)
        {
            FiltersVisibility = _filtersVisibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void CloseImplementation(object obj)
        {
            StationManager.CloseApp();
        }
    }
}
