using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sincronias.Startup))]
namespace Sincronias
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
