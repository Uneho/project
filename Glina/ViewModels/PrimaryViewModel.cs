using System.Collections.ObjectModel;
using System.Windows.Threading;
using Glina.Models;
using Glina.Models.Window.Navigation;
using Glina.Models.Window.Service;
using Prism.Commands;



namespace Glina.ViewModels;

public class PrimaryViewModel : ViewModelBase
{
    private DispatcherTimer timer;
    public ObservableCollection<CarouselItem> Items { get; } = new ObservableCollection<CarouselItem>();

    private int _selectedIndex;
    public int SelectedIndex
    {
        get => _selectedIndex;
        set => SetProperty(ref _selectedIndex, value, () => CurrentItem = Items[value]);
    }

    private CarouselItem _currentItem;
    public CarouselItem CurrentItem
    {
        get => _currentItem;
        set => SetProperty(ref _currentItem, value);
    }

    public PrimaryViewModel(INavigation navigationService) : base(navigationService: navigationService)
    {
        InitializeNextPreviousCommands(() => SelectedIndex = (SelectedIndex + 1) % Items.Count,
            () => SelectedIndex = (SelectedIndex - 1 + Items.Count) % Items.Count);

        timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(10) };
        timer.Tick += (sender, e) => NextCommand.Execute();
        timer.Start();

        // Упрощенное добавление элементов
        AddCarouselItem("pack://application:,,,/Assets/MainView/Group3.png", "Зарегистрироваться", "Registration");
        AddCarouselItem("pack://application:,,,/Assets/MainView/Group4.png", "Войти", "Authorization");
        AddCarouselItem("pack://application:,,,/Assets/MainView/Group5.png", "В разработке", null); // null, если нет команды

        SelectedIndex = 0; // Устанавливаем начальный выбранный элемент
        
        CurrentItem = Items.FirstOrDefault();
    }

    private void AddCarouselItem(string imagePath, string buttonContent, string navigationPath)
    {
        var item = new CarouselItem
        {
            ImagePath = imagePath,
            ButtonContent = buttonContent,
            NavigateCommand = navigationPath != null ? new DelegateCommand(() => NavigationService.Navigate(navigationPath)) : null
        };
        Items.Add(item);
    }
}