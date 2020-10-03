using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myVMS.WebUI.Startup))]
namespace myVMS.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
