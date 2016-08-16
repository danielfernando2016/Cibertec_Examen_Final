using Cibertec_Examen_Final.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec_Examen_Final.DataAccess
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext() : base("name=BooksExamen")
        {
            //En este constructor llamaremos al metodo que rellena data
            //Database.SetInitializer(new WebDeveloperInitializer());
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Address>()
            //   .HasOptional(j => j.BusinessEntityAddress)
            //   .WithMany()
            //   .WillCascadeOnDelete(true);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
