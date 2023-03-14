using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011068944_NguyenQuocAnh.Startup))]
namespace _2011068944_NguyenQuocAnh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
