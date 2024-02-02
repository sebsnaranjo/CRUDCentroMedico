using CentroMedico.BL.Data;
using Owin;

namespace CentroMedico.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(CentroMedicoContext.Create);
        }
    }
}
