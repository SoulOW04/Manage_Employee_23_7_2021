using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Manage_Employee_23_7_2021.Startup))]
namespace Manage_Employee_23_7_2021
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
