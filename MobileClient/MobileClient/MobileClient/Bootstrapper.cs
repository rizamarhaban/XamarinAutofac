using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Microsoft.Practices.ServiceLocation;
using MobileClient.ViewModels;
using SomeExternalServices;

namespace MobileClient
{
    public sealed class Bootstrapper
    {
        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainPageViewModel>().AsSelf();
            builder.RegisterType<CustomerServices>().As<ICustomerServices>();

            IContainer container = builder.Build();

            AutofacServiceLocator asl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => asl);
        }
    }
}
