using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_403_Project1.Startup))]
namespace _403_Project1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
