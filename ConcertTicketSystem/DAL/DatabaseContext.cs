using ConcertTicketSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
namespace ConcertTicketSystem.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
