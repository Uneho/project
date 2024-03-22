using Glina.Models.Window.Navigation;
using Glina.Models.Window.Service;



namespace Glina.ViewModels;


public class MinimazeCloseViewModel : ViewModelBase
{
    public MinimazeCloseViewModel(IWindowService windowService)
        : base(windowService)
    {
    }
}