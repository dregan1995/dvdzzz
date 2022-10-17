using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dvdzzz.Startup))]
namespace dvdzzz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
