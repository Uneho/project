using System.Windows.Controls;
using System.Windows.Input;
using Glina.ViewModels;
using Autofac;

namespace Glina.Views;

public partial class RegistrationView : UserControl
{
    public RegistrationView()
    {
        InitializeComponent();
        DataContext = App.Container.Resolve<RegistrationViewModel>();
    }
}