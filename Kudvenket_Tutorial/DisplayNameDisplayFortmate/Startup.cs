using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DisplayNameDisplayFortmate.Startup))]
namespace DisplayNameDisplayFortmate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
