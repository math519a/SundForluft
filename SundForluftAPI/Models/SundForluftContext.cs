using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace SundForluftAPI.Models
{
    public class SundForluftContext : DbContext
    {
        public SundForluftContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ItemModel> ItemModels { get; set; }
        
    }
}