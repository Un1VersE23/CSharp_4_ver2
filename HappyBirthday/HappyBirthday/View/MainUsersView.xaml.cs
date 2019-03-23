
using System.ComponentModel;
using System.Windows;
using HappyBirthday.Tools.DataStorage;
using HappyBirthday.Tools.Manager;
using HappyBirthday.ViewModel;

namespace HappyBirthday.View
{
    /// <summary>
    /// Interaction logic for MainUsersView.xaml
    /// </summary>
    public partial class MainUsersView : Window
    {
        public MainUsersView()
        {
            InitializeApplication();
            InitializeComponent();
            DataContext = new MainViewModel();
           
        }

        private void InitializeApplication()
        {
            SerializedDataStorage u = new SerializedDataStorage();
            StationManager.Initialize(u);

        }

        private void UserListView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    base.OnClosing(e);
        //    StationManager.CloseApp();
        //}
    }
}
