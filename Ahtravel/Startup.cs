using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ahtravel.Startup))]
namespace Ahtravel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
