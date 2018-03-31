using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRPlayGround_MVC.Startup))]
namespace SignalRPlayGround_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
