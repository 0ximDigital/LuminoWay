using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuminoWay.Startup))]
namespace LuminoWay
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
