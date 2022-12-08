using Microsoft.EntityFrameworkCore;
using MostreOCodigo.Domain.Models;

namespace MostreOCodigo.Data.Context
{
    public class SkynetzContext : DbContext
    {
        public SkynetzContext(DbContextOptions<SkynetzContext> options) : base(options) { }

        public DbSet<Valor> Valores { get; set; }
    }
}
