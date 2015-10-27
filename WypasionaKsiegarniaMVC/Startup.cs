using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WypasionaKsiegarniaMVC.Startup))]
namespace WypasionaKsiegarniaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
