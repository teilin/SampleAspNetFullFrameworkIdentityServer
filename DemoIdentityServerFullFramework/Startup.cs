using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoIdentityServerFullFramework.Startup))]
namespace DemoIdentityServerFullFramework
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
