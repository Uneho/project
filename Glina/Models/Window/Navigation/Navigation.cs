using System.Windows;
using System.Windows.Controls;
using Autofac;
using Glina.Views;


namespace Glina.Models.Window.Navigation;


public class Navigation : INavigation
{
    private readonly Func<string, UserControl> _viewCreator;

    public Navigation(Func<string, UserControl> viewCreator)
    {
        _viewCreator = viewCreator;
    }

    public void Navigate(string path)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            var view = _viewCreator(path);
            if (view != null)
            {
                var mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.Content = view;
            }
            else
            {
                MessageBox.Show($"Пути {path} нет.");
            }
        });
    }
}