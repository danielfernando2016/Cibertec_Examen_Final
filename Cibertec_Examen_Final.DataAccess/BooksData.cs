using Cibertec_Examen_Final.Model;
using System.Linq;

namespace Cibertec_Examen_Final.DataAccess
{
    public class BooksData : BaseDataAccess<Books>
    {
        public Books GetBookId(int id)
        {
            using (var dbContext = new BooksDbContext())
            {
                return dbContext.Books.FirstOrDefault(x => x.title_id == id);
            }
        }
    }
}
