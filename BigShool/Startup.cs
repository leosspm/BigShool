using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigShool.Startup))]
namespace BigShool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
