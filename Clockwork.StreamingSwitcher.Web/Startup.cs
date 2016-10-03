using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Clockwork.StreamingSwitcher.Web.Startup))]

namespace Clockwork.StreamingSwitcher.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
