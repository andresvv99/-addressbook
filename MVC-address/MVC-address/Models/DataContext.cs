

namespace MVC_address.Models
{
    using System.Data.Entity;
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_address.Models.Book> Books { get; set; }
    }
}