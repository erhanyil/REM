using Microsoft.Owin;
using Owin;
using REM.App_Start;
[assembly: OwinStartupAttribute(typeof(REM.Startup))]
namespace REM
{
    public partial class Startup : AuthConfig
    {
        public void Configuration(IAppBuilder app)
        {
            loginAuthentication();
        }
    }
}
