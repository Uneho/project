

namespace Glina.Models.Window.Service;

using System.Windows;

public class WindowService : IWindowService
{
    public void Minimize()
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            if (Application.Current.MainWindow != null)
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
        });
    }

    public void Close()
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            Application.Current.MainWindow?.Close();
        });
    }
}