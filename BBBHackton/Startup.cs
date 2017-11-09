using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBBHackton.Startup))]
namespace BBBHackton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
