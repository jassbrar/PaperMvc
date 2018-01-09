using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paper2.Startup))]
namespace Paper2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
