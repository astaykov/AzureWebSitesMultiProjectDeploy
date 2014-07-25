using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebSitesMultiProjectDeploy.Startup))]
namespace AzureWebSitesMultiProjectDeploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
