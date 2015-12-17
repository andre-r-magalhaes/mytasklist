using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(br.com.mytasklist.Startup))]
namespace br.com.mytasklist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
