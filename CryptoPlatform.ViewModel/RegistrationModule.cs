using Autofac;
using CryptoPlatform.ViewModel.MainWindow;

namespace CryptoPlatform.ViewModel;

public class RegistrationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>().InstancePerDependency();
    }
}