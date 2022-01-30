using Microsoft.EntityFrameworkCore;
using UdemyEfCore.Data.Entities;


namespace UdemyEfCore.Data.Contexts
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURDUR; database=UdemyEfCore; integrated security=true;");
        }

        //Tablo adlarını Fluent API ile bu şekilde isimlendirebiliyoruz, yani üretilen tablo adını bu şekilde
        // ezip değiştirebiliyoruz 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().ToTable(name: "Products", schema: "dbo");
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("Product_Name");
            //modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("Product_Id");
            //modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnName("Product_Price");
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValue("'Ürün bilgisi girilmemiş'");
            //modelBuilder.Entity<Product>().Property(x => x.CreateTime).HasDefaultValue("getdate()");


            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 3);
            //İlgili tabloda Name alanını verilen değer örneğin Bilgisayar ise, bu ismin bir daha kullanılmamasını
            //sağlar , mükerrer kayıtları önler
            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique(true);

            
            
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
