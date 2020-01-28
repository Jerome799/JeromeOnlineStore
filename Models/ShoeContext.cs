using System.Data.Entity;

namespace JeromeOnlineStore.Models
{
    public class ShoeContext : DbContext
    {
        public ShoeContext() : base("JeromeOnlineStore")
        { 
            
        }

        public DbSet<Shoe> Shoes { get; set; }
    }
}