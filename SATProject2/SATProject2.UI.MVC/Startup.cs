using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATProject2.UI.MVC.Startup))]
namespace SATProject2.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
