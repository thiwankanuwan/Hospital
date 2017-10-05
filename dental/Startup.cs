using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dental.Startup))]
namespace dental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
