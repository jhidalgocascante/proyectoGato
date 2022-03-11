using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webGato.Startup))]
namespace webGato
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
