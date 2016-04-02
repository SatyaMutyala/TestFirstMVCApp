using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestFirstMVCApp.Startup))]
namespace TestFirstMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
