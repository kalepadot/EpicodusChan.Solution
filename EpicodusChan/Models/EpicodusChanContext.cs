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
        public DbSet<Group> Groups { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Message>()
              .HasData(
                new Message { MessageId = 1, GroupId = 1, Title = "Cats Named Haru", UserName = "JDawg", Entry = "Jeremy has the coolest cat ever, who happens to be named Haru", Date = "04/20/2020"},
                
                new Message { MessageId = 2, GroupId = 1, Title = "Huginn & Muninn", UserName = "GMoney", Entry = "My name Jef and I really want 2 black cats named Huginn and Muninn", Date = "04/19/2020"},
                
                new Message { MessageId = 3, GroupId = 1, Title = "Freya", UserName = "GMoney", Entry = "I would love to have a dog named Freya, not sure what breed to get.", Date = "03/31/2020"},

                new Message { MessageId = 4, GroupId = 2, Title = "PC vs Mac", UserName = "DWizzle", Entry = "I want to know, once and for all which is better. Mac or PC? (Hint:It's mac)", Date = "04/7/2020"},

                new Message { MessageId = 5, GroupId = 3, Title = "Favorite Fruit?", UserName = "GMoney", Entry = "I'm taking a class on statistics and for a project I am taking a poll of peoples favorite fruits. Please comment below your answer!", Date = "04/01/2020"}
            );
        builder.Entity<Group>()
          .HasData(
            new Group { GroupId= 1, GroupName = "Talk About Your Pet",  Topic = "Pets"},
            new Group { GroupId= 2, GroupName = "Talking Tech",  Topic = "Tech"},
            new Group { GroupId= 3, GroupName = "Study Buddies",  Topic = "Education"}
          );

        }
    }
}