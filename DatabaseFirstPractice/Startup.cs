using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseFirstPractice.Startup))]
namespace DatabaseFirstPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
