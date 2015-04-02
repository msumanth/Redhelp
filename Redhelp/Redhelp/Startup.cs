using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Redhelp.Startup))]
namespace Redhelp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
