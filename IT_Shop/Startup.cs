using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Shop.Startup))]
namespace IT_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
