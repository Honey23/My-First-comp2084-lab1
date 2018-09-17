using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1_Honey.Startup))]
namespace Lab1_Honey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
