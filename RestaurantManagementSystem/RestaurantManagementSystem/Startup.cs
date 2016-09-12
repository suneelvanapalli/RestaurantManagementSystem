using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantManagementSystem.Startup))]
namespace RestaurantManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
