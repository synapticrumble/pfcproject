using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PFC_Project.Startup))]
namespace PFC_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
//configuring github sync

            ConfigureAuth(app);
        }
    }
}
