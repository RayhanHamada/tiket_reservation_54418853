using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tiket_reservation.Startup))]
namespace tiket_reservation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
