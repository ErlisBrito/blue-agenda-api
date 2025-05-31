
using Microsoft.EntityFrameworkCore;

namespace blue_agenda_api.Data.Contexts
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }
        //public DbSet<HashValidacao> HashValidacao { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new HashValidacaoMap());
        //}
    }
}
