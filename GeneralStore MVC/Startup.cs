using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeneralStore_MVC.Startup))]
namespace GeneralStore_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
