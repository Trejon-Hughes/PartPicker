using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartPicker.WebMVC.Startup))]
namespace PartPicker.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
