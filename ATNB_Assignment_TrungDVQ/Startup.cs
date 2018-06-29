using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATNB_Assignment_TrungDVQ.Startup))]
namespace ATNB_Assignment_TrungDVQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
