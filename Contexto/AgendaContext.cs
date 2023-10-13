using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entidades;

namespace ModuloAPI.Contexto
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConventio>();
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
