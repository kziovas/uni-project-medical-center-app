using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VioPliroforikh.Startup))]
namespace VioPliroforikh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
