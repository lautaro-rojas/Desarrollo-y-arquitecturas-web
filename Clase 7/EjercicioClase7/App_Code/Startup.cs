using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioClase7.Startup))]
namespace EjercicioClase7
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
