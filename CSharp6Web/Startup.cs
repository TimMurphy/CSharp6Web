using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharp6Web.Startup))]
namespace CSharp6Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
