using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AON_coding_test.Startup))]
namespace AON_coding_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
