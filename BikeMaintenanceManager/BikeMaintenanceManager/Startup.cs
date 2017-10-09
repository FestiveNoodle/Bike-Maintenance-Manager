using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikeMaintenanceManager.Startup))]
namespace BikeMaintenanceManager
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
