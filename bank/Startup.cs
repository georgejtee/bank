using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bank.Startup))]
namespace bank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
