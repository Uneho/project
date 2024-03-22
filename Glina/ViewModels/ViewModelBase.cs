using Glina.Models.Controllers.Error;
using Glina.Models.Controllers.Ui;
using Glina.Models.Window.Navigation;
using Glina.Models.Window.Service;



namespace Glina.ViewModels;


public class ViewModelBase : BindableBase
{
    protected IWindowService WindowService { get; set; }
    protected INavigation NavigationService { get; set; }
    public DelegateCommand<string> NavigateCommand { get; private set; }
    public DelegateCommand MinimizeCommand { get; private set; }
    public DelegateCommand CloseCommand { get; private set; }
    public DelegateCommand NextCommand { get; private set; }
    public DelegateCommand PreviousCommand { get; private set; }

    protected ViewModelBase(IWindowService windowService = null, INavigation navigationService = null)
    {
        WindowService = windowService;
        NavigationService = navigationService;

        if (WindowService != null)
        {
            MinimizeCommand = new DelegateCommand(() => WindowService.Minimize());
            CloseCommand = new DelegateCommand(() => WindowService.Close());
        }

        if (NavigationService != null)
        {
            NavigateCommand = new DelegateCommand<string>(path => NavigationService.Navigate(path));
        }
    }

    protected void InitializeNextPreviousCommands(Action nextAction, Action previousAction)
    {
        NextCommand = new DelegateCommand(nextAction);
        PreviousCommand = new DelegateCommand(previousAction);
    }
}