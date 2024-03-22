using Autofac;
using System.Windows;
using Glina.Views;
using Glina.ViewModels;
using Glina.Models.Window.Navigation;
using Glina.Models.Window.Service;


namespace Glina;


public partial class App : Application
{
    public static IContainer Container { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var builder = new ContainerBuilder();

        // Регистрация сервисов
        builder.RegisterType<WindowService>().As<IWindowService>().InstancePerLifetimeScope();
        
        // Регистрация ViewModel
        builder.RegisterType<PrimaryViewModel>().AsSelf();
        builder.RegisterType<AuthorizationViewModel>().AsSelf();
        builder.RegisterType<RegistrationViewModel>().AsSelf();
        builder.RegisterType<MinimazeCloseViewModel>().AsSelf();
        
        // Регистрация навигации с использованием фабрики
        builder.Register<INavigation>(c => new Navigation(path =>
        {
            switch (path)
            {
                case "Registration":
                    return new RegistrationView();
                case "Authorization": 
                    return new AuthorizationView();
                default:
                    throw new NotImplementedException($"No view found for path: {path}");
            }
        })).SingleInstance();

        // Регистрация MainWindow -> без необходимости явно прописывать DataContext
        builder.RegisterType<MainWindow>().AsSelf().SingleInstance();

        Container = builder.Build();

        // Запуск главного окна 
        var mainWindow = Container.Resolve<MainWindow>();
        Current.MainWindow = mainWindow;
        mainWindow.Show();
    }
    //SingleInstance() указывает, что эти сервисы будут существовать как единственные экземпляры (singleton) на протяжении всего времени работы приложения.
}