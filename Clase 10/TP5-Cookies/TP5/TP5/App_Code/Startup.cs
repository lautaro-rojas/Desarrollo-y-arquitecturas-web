using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP5.Startup))]
namespace TP5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
