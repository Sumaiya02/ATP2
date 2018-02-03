using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(atp2.Startup))]
namespace atp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
