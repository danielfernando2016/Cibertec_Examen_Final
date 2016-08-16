using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Cibertec_Examen_Final.Models
{
    // Puede agregar datos del perfil del usuario agregando más propiedades a la clase BooksUser. Para más información, visite http://go.microsoft.com/fwlink/?LinkID=317594.
    public class BooksUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<BooksUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }
    
    public class BooksExamenDbContext : IdentityDbContext<BooksUser>
    {
        public BooksExamenDbContext()
            : base("IdentityConnectionString")
        {
        }

        public static BooksExamenDbContext Create()
        {
            return new BooksExamenDbContext();
        }
    }
   
}