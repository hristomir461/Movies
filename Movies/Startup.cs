using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp1a.Startup))]
namespace WebApp1a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
