using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(formulaire_dynamique.Startup))]
namespace formulaire_dynamique
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
