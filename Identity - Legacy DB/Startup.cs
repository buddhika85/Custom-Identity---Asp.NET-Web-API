using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Identity___Legacy_DB.Startup))]
namespace Identity___Legacy_DB
{
    
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}