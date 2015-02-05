using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nubulous.Startup))]
namespace Nubulous
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
