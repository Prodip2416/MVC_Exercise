using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessObjectModel.Startup))]
namespace BusinessObjectModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
