using _77Diamonds.DAL.DbModel;
using Microsoft.EntityFrameworkCore;

namespace _77Diamonds.DAL
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemDetailsView>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ColorMaster>? ColorMaster { get; set; }
        public DbSet<FabricMaster>? FabricMaster { get; set; }
        public DbSet<ItemDetail>? ItemDetail { get; set; }  
        public DbSet<ItemMaster>? ItemMaster { get; set; }
        public DbSet<ItemPicture>? ItemPicture { get; set; }
        public DbSet<ItemDetailsView>? ItemDetailsView { get; set; }

    }
}
