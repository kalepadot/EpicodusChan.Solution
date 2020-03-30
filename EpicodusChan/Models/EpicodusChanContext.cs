using Microsoft.EntityFrameworkCore;

namespace EpicodusChan.Models
{
    public class EpicodusChanContext : DbContext
    {
        public EpicodusChanContext(DbContextOptions<EpicodusChanContext> options)
            : base(options)
        {
        }
        public DbSet<Message> Messages { get; set; }
    }
}