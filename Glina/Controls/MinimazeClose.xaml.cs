using Autofac;
using Glina.ViewModels;
using System.Windows.Controls;

namespace Glina.Controls;

public partial class MinimazeClose : UserControl
{
    public MinimazeClose()
    {
        InitializeComponent();
        DataContext = App.Container.Resolve<MinimazeCloseViewModel>();
    }
}