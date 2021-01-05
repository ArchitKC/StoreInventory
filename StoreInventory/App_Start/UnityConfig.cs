using StoreInventory.Services;
using StoreInventory.Services.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace StoreInventory
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductServices, ProductServices>();
            container.RegisterType<IUserDetailsServices, UserDetailsServices>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}