using Autofac;
using Glina.ViewModels;
using System.Windows.Controls;


namespace Glina.Views;

public partial class PrimaryView : UserControl
{
    public PrimaryView()
    {
        InitializeComponent();
        DataContext = App.Container.Resolve<PrimaryViewModel>();
    }
}