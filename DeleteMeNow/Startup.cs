using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeleteMeNow.Startup))]
namespace DeleteMeNow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
