using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeonoraRexhepi_INKI643_Aplikacija.Startup))]
namespace LeonoraRexhepi_INKI643_Aplikacija
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
