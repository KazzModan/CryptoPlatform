using Autofac;
using CryptoPlatform.Domain.REST;
using CryptoPlatform.Infrastructure.REST;

namespace CryptoPlatform.Infrastructure;

public class RegistrationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<ApiRequestExecutor>().As<IApiRequestExecutor>().SingleInstance();
    }
}