using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG522Summative7555.Startup))]
namespace PRG522Summative7555
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
