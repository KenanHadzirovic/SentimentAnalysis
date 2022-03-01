using System.Data.Entity;

namespace SentimentAnalysis
{
    public class EFContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FailedConnection> FailedConnections { get; set; }

        public EFContext() : base("Server=localhost;Database=SentimentAnalysis;Trusted_Connection=True; User Id = Pinboard; Password = Pinboard;")
        {
        }
    }
}