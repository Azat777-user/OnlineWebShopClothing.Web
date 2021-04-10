using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineWebShopClothing.Startup))]
namespace OnlineWebShopClothing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
