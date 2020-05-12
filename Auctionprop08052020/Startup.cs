using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auctionprop08052020.Startup))]
namespace Auctionprop08052020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
