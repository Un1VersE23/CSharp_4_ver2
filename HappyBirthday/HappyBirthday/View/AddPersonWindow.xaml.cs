using System.Windows;
using HappyBirthday.ViewModel;

namespace HappyBirthday.View
{
    /// <inheritdoc />
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {

        public AddPersonWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }
        
    }
}
