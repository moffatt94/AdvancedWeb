using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(u1265196_MovieRentals.Startup))]
namespace u1265196_MovieRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
