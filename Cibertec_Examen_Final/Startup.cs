using Cibertec_Examen_Final.DataAccess;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity.EntityFramework;

using Cibertec_Examen_Final.Models;

[assembly: OwinStartupAttribute(typeof(Cibertec_Examen_Final.Startup))]
namespace Cibertec_Examen_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUserAndRole();
        }

        internal void CreateUserAndRole()
        {
            using (var context = new BooksExamenDbContext())
            {

                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                var userManager = new UserManager<BooksUser>(new UserStore<BooksUser>(context));

                // In Startup iam creating first Admin Role and creating a default Admin User    
                if (!roleManager.RoleExists("Admin"))
                {

                    // first we create Admin rool   
                    var role = new IdentityRole();
                    role.Name = "Admin";
                    roleManager.Create(role);

                    //Here we create a Admin super user who will maintain the website                  

                    var user = new BooksUser
                    {
                        UserName = "danielfernando2010@gmail.com",
                        Email = "danielfernando2010@gmail.com"
                    };

                    string userPassword = "Examen2016";

                    var userCreation = userManager.Create(user, userPassword);

                    //Add default User to Role Admin   
                    if (userCreation.Succeeded)
                        userManager.AddToRole(user.Id, "Admin");


                }

                // creating Creating Manager role    
                if (!roleManager.RoleExists("Manager"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Manager"
                    };
                    roleManager.Create(role);

                }

                // creating Creating Employee role    
                if (!roleManager.RoleExists("Employee"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Employee"
                    };
                    roleManager.Create(role);

                }
            }
        }

    }
}
