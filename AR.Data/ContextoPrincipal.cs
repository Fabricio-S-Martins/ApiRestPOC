using AR.Domain;
using Microsoft.EntityFrameworkCore;

namespace AR.Data
{
    class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
