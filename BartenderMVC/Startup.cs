using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BartenderMVC.Startup))]
namespace BartenderMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
