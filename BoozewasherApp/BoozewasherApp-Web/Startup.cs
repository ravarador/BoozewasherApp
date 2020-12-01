using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoozewasherApp_Web.Startup))]
namespace BoozewasherApp_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
