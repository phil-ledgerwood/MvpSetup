using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvpSetup.Web.Startup))]
namespace MvpSetup.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
