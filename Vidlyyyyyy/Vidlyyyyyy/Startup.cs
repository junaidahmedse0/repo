using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlyyyyyy.Startup))]
namespace Vidlyyyyyy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
