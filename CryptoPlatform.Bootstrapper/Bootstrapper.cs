using System.Windows;
using Autofac;
using CryptoPlatform.ViewModel.MainWindow;

namespace CryptoPlatform.Bootstrapper;

public class Bootstrapper
{
    private readonly IContainer _container;

    public Bootstrapper()
    {
        var containerBuilder = new ContainerBuilder();

        containerBuilder.RegisterModule<ViewModel.RegistrationModule>()
            .RegisterModule<Infrastructure.RegistrationModule>();

        _container = containerBuilder.Build();
    }
    public Window Run()
    {
        var mainWindowViewModel = _container.Resolve<IMainWindowViewModel>();

        var mainWindow = new MainWindow();

        mainWindow.Show();

        if (mainWindow is not Window window)
            throw new NotImplementedException();

        return mainWindow;
    }
    public void Dispose()
    {
        _container.Dispose();
    }
}