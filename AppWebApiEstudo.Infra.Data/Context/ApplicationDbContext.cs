using AppWebApiEstudo.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace AppWebApiEstudo.Infra.Data.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
        public DbSet<Beneficiario> Beneficiarios {  get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Beneficiario>().ToTable("Beneficiario");
            
        }
    }
}
