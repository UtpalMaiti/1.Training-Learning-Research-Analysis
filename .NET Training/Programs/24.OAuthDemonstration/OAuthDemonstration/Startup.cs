using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuthDemonstration.Startup))]
namespace OAuthDemonstration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
