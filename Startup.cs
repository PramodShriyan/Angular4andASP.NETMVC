using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2MVC.Startup))]
namespace Angular2MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
