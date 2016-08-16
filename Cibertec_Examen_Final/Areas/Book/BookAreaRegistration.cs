using System.Web.Mvc;

namespace Cibertec_Examen_Final.Areas.Book
{
    public class BookAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Book";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Book_default",
                "Book/{controller}/{action}/{id}",
                new { controller = "Books", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}