using Microsoft.EntityFrameworkCore;

namespace Authentication.Models
{
    public class UserContextModel : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public UserContextModel(DbContextOptions<UserContextModel> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}