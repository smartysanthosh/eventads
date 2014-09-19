using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventAds.Startup))]
namespace EventAds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //srinu
             ConfigureAuth(app);
        }
    }
}
