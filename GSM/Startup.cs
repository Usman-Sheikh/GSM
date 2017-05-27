using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GSM.Startup))]
namespace GSM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
