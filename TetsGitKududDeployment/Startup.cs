using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TetsGitKududDeployment.Startup))]
namespace TetsGitKududDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
