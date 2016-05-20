using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunCrm.Web.Startup))]
namespace FunCrm.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
