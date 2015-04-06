using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CashMoney.Web.Startup))]
namespace CashMoney.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
