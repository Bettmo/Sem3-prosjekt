using Microsoft.EntityFrameworkCore;

namespace Nosted.DataAccess
{
    public class DataContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}