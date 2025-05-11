using Microsoft.EntityFrameworkCore;
using Witherborn.Data.Models;

namespace Witherborn.Data
{
    public class WitherbornDbContext : DbContext
    {
        public WitherbornDbContext()
        {

        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Dungeon> Dungeons { get; set; } = null!;
        public virtual DbSet<Enemy> Enemies { get; set; } = null!;
        public virtual DbSet<Floor> Floors { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<PlayerDungeon> PlayersDungeons { get; set; } = null!;
        public virtual DbSet<PlayerItem> PlayersItems { get; set; } = null!;

        public WitherbornDbContext(DbContextOptions options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P67RBD6\\SQLEXPRESS;Database=Witherborn;Integrated Security=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
