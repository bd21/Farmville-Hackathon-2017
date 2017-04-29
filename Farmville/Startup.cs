using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Farmville.Startup))]
namespace Farmville
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
