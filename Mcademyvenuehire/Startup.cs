using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mcademyvenuehire.Startup))]
namespace Mcademyvenuehire
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
