using System.Windows;

namespace WPF_MVVM_Custom
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new View.MainWindow
            {
                DataContext = new ViewModel.MainViewModel()
            };

            mw.Show();
        }
    }
}
