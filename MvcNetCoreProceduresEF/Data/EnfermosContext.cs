using Microsoft.EntityFrameworkCore;
using MvcNetCoreProceduresEF.Models;

namespace MvcNetCoreProceduresEF.Data
{
    public class EnfermosContext : DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext> options)
            : base(options) { }

        public DbSet<Enfermo> Enfermos { get; set; }
    }
}
