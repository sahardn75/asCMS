using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3layer_cms.Startup))]
namespace _3layer_cms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
