using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpAppwithFSharpDatalayer.Startup))]
namespace CSharpAppwithFSharpDatalayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
