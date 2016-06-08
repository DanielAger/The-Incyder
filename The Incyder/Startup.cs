using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_Incyder.Startup))]
namespace The_Incyder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
