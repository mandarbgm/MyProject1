using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleApplication1.Startup))]
namespace SampleApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
