using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bigSchool_NguyenTranDau.Startup))]
namespace bigSchool_NguyenTranDau
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
