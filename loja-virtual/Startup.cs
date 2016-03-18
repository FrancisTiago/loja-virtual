using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loja_virtual.Startup))]
namespace loja_virtual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
