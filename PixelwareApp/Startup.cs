using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PixelwareApp.Startup))]
namespace PixelwareApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
