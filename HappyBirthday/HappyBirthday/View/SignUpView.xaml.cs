
using System.Windows;
using System.Windows.Controls;
using HappyBirthday.ViewModel;


namespace HappyBirthday.View
{
    /// <summary>
    /// Interaction logic for SignUpView.xaml
    /// </summary>
    public partial class SignUpView : UserControl
    {
        public SignUpView()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel();
        }
    }
}
