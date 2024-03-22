using System.Windows.Controls;
using System.Windows.Input;
using Glina.ViewModels;
using Autofac;


namespace Glina.Views;

public partial class AuthorizationView : UserControl
{
    public AuthorizationView()
    {
        InitializeComponent();
        DataContext = App.Container.Resolve<AuthorizationViewModel>();
    }
}