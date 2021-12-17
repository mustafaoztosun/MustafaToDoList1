using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MustafaToDoList1.Startup))]
namespace MustafaToDoList1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
