using System.Web.Mvc;

namespace Cibertec_Examen_Final.Areas.Authores
{
    public class AuthoresAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Authores";
        
        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Authores_default",
                "Authores/{controller}/{action}/{id}",
                new { controller = "Authors", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}