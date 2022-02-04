using Microsoft.EntityFrameworkCore;
using UdemyEfCore.Data.Entities;


namespace UdemyEfCore.Data.Contexts
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=BURDUR; database=UdemyEfCore; integrated security=true;");
            optionsBuilder.UseSqlServer("server=AB01500-5000; database=UdemyEfCore; integrated security=true;");
        }

        //Tablo adlarını Fluent API ile bu şekilde isimlendirebiliyoruz, yani üretilen tablo adını bu şekilde
        // ezip değiştirebiliyoruz 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Product tablosu ile SaleHistory tablosu arasında Product 1 - SaleHistory n şeklinde 1'e çok ilişki kurma
            modelBuilder.Entity<Product>().HasMany(x=>x.saleHistory).WithOne(x=>x.product).HasForeignKey(x=>x.ProductId);


            //Product tablosu ile SaleHistory tablosu arasında Product 1 - SaleHistory n şeklinde 1'e çok ilişki kurma
            //tam tersi işlem
            //modelBuilder.Entity<SaleHistory>().HasOne(x => x.product).WithMany(x => x.saleHistory).HasForeignKey(x => x.ProductId);

            //Bire bir ilişki kuruyoruz. 
            modelBuilder.Entity<Product>().HasOne(x => x.ProductDetail).WithOne(x => x.Product).HasForeignKey<ProductDetail>(x => x.ProductId);


            //Çoka çok ilişki kurma
            modelBuilder.Entity<Product>().HasMany(x=>x.productCategories).WithOne(x=>x.Product).HasForeignKey(x=>x.ProductId);
            modelBuilder.Entity<Category>().HasMany(x => x.productCategories).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
            //Mükerrer kaydın önüne geçiyoruz. 
            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProductId });


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


            //Tph && Tpt
            modelBuilder.Entity<Employee>().ToTable("Empyoyees");
            modelBuilder.Entity<FulltimeEmployee>().ToTable("FulltimeEmployees");
            modelBuilder.Entity<ParttimeEmployee>().ToTable("ParttimeEmployees");



            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SaleHistory> SaleHistories{ get; set; }
        public DbSet<ProductDetail> productDetails { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ParttimeEmployee> parttimeEmployees{ get; set; }
        public DbSet<FulltimeEmployee> fulltimeEmployees { get; set; }

    }
}
