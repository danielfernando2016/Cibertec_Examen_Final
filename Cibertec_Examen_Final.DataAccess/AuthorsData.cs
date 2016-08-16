using Cibertec_Examen_Final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec_Examen_Final.DataAccess
{
    public class AuthorsData : BaseDataAccess<Authors>
    {

        public Authors GetAuthorId(int id)
        {
            using (var dbContext = new BooksDbContext())
            {
                return dbContext.Authors.FirstOrDefault(x => x.au_id == id);
            }
        }


    }
}
